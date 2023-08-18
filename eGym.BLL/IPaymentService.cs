using eGym.BLL.Models.Requests;
using Stripe;

namespace eGym.BLL;

public interface IPaymentService
{
    public Task<Domain.Customer> CheckUserProfile(int accountId);
    Task<Customer> AddCustomer(CustomerRequest customer, CancellationToken ct);
    Task<Charge> AddPayment(PaymentRequest payment, CancellationToken ct);
}

