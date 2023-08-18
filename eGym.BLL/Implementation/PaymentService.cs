using AutoMapper;
using eGym.BLL.Exceptions;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;
using Microsoft.AspNetCore.Identity;
using Stripe;

namespace eGym.BLL.Implementation;

public class PaymentService : IPaymentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ChargeService _chargeService;
    private readonly CustomerService _customerService;
    private readonly TokenService _tokenService;

    public PaymentService(IUnitOfWork unitOfWork, IMapper mapper,
            ChargeService chargeService,
            CustomerService customerService,
            TokenService tokenService)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _chargeService = chargeService;
        _customerService = customerService;
        _tokenService = tokenService;
    }

    public async Task<Stripe.Customer> AddCustomer(CustomerRequest customer, CancellationToken ct)
    {
        //Check does account already has customer profile
        var alreadyCreated = await _unitOfWork.Customers.GetWhere(x => x.AccountId.Equals(customer.AccountId));
        if (alreadyCreated.Any() || alreadyCreated == null)
        {
            throw new CustomerException("Account has already created customer profile");
        }

        TokenCreateOptions tokenOptions = new TokenCreateOptions
        {
            Card = new TokenCardOptions
            {
                Name = customer.Name,
                Number = customer.CreditCard.CardNumber,
                ExpYear = customer.CreditCard.ExpirationYear,
                ExpMonth = customer.CreditCard.ExpirationMonth,
                Cvc = customer.CreditCard.CVC
            }
        };

        Token stripeToken = await _tokenService.CreateAsync(tokenOptions, null, ct);

        CustomerCreateOptions customerOptions = new CustomerCreateOptions
        {
            Name = customer.Name,
            Email = customer.Email,
            Source = stripeToken.Id
        };

        var response = await _customerService.CreateAsync(customerOptions, null, ct);

        await _unitOfWork.Cards.Insert(_mapper.Map<Domain.Card>(customer.CreditCard));

        var createdCard = await _unitOfWork.Cards.GetWhere(x => x.CardNumber.Equals(customer.CreditCard.CardNumber));

        var domainCustomer = _mapper.Map<Domain.Customer>(customer);
        domainCustomer.StripeCustomerId = response.Id;
        domainCustomer.CardId = createdCard.FirstOrDefault().CardId;

        await _unitOfWork.Customers.Insert(domainCustomer);

        return response;
    }

    public async Task<Charge> AddPayment(PaymentRequest payment, CancellationToken ct)
    {
        var reservation = await _unitOfWork.Reservations.GetById(payment.ReservationId);

        //Check is reservation already paid
        if (reservation.Status == 3)
        {
            throw new ReservationException("Reservation has been already paid");
        }

        //Check is reservation already confirmed
        if (reservation.Status != 2)
        {
            throw new ReservationException("Reservation is not confirmed yet");
        }

        ChargeCreateOptions paymentOptions = new ChargeCreateOptions
        {
            Customer = payment.CustomerId,
            ReceiptEmail = payment.ReceiptEmail,
            Description = payment.Description,
            Currency = payment.Currency,
            Amount = payment.Amount
        };

        var response = await _chargeService.CreateAsync(paymentOptions, null, ct);

        var customer = await _unitOfWork.Customers.GetWhere(x => x.StripeCustomerId.Equals(payment.CustomerId));

        var internalPayment = new Payment()
        {
            Description = payment.Description,
            ReceiptEmail = payment.ReceiptEmail,
            CCV = payment.CCV,
            Currency = payment.Currency,
            Amount = payment.Amount,
            CustomerId = customer.FirstOrDefault().CustomerId,
            ReservationId = payment.ReservationId
        };

        await _unitOfWork.Payments.Insert(internalPayment);

        reservation.Status = 3;

        await _unitOfWork.Reservations.Update(reservation);

        return response;
    }

    public async Task<Domain.Customer> CheckUserProfile(int accountId)
    {
        var response = await _unitOfWork.Customers.GetWhere(x => x.AccountId.Equals(accountId));

        return response.ToList().FirstOrDefault();
    }
}

