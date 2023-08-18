using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    private readonly IAccountService _accountService;
    private readonly IReservationService _reservationService;

    public PaymentController(IPaymentService paymentService,
        IAccountService accountService,
        IReservationService reservationService)
    {
        _paymentService = paymentService;
        _accountService = accountService;
        _reservationService = reservationService;
    }

    [HttpGet]
    public async Task<IActionResult> CheckCustomerProfile(int accountId)
    {
        try
        {
            if (accountId <= 0)
            {
                return BadRequest("Invalid Account Id");
            }

            var response = await _paymentService.CheckUserProfile(accountId);

            if(response == null)
            {
                return NotFound("Account doesn't have customer profile created");
            }

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update()
    {
        try
        {
            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    [Route("addCustomer")]
    public async Task<IActionResult> CreateCustomer([FromBody] CustomerRequest request, CancellationToken ct)
    {
        try
        {
            if(await _accountService.GetById(request.AccountId) == null)
            {
                return BadRequest("Account with provided Id doesn't exist");
            }

            var response = await _paymentService.AddCustomer(request, ct);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    [Route("addPayment")]
    public async Task<IActionResult> CreatePayment([FromBody] PaymentRequest request, CancellationToken ct)
    {
        try
        {
            if(await _reservationService.GetById(request.ReservationId) == null)
            {
                return BadRequest("Reservation with provided id doesn't exist");
            }

            var response = await _paymentService.AddPayment(request, ct);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

