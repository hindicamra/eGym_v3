using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;
    private readonly IEmployeeService _employeeService;
    private readonly IAccountService _accountService;

    public ReservationController(IReservationService reservationService, IAccountService accountService, IEmployeeService employeeService)
    {
        _reservationService = reservationService;
        _employeeService = employeeService;
        _accountService = accountService;
    }

    [HttpGet]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            if(id < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _reservationService.GetById(id);

            if(response == null)
            {
                return NotFound("There is no reservation with provided id");
            }

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("GetByUser")]
    public async Task<IActionResult> GetByUser(int userId)
    {
        try
        {
            if (userId < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _reservationService.GetByUser(userId);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("GetNewestByUser")]
    public async Task<IActionResult> GetNewestByUser(int userId, DateTime date)
    {
        try
        {
            if (userId < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _reservationService.GetNewestByUser(userId, date);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("GetByEmployee")]
    public async Task<IActionResult> GetByEmployee(int employeeId, DateTime date)
    {
        try
        {
            if (employeeId < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _reservationService.GetByEmployee(employeeId, date);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("GetPendingReservation")]
    public async Task<IActionResult> GetPendingReservation(int employeeId, DateTime date)
    {
        try
        {
            if (employeeId < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _reservationService.GetPendingReservations(employeeId, date);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("GetPaidReservation")]
    public async Task<IActionResult> GetPaidReservation(int employeeId, DateTime date)
    {
        try
        {
            if (employeeId < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _reservationService.GetPaidReservations(employeeId, date);

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
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            var reservation = await _reservationService.GetById(id);
            if(reservation == null)
            {
                return BadRequest("Reservation with provided id doensn't exist");
            }

            await _reservationService.Delete(id);

            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateReservationRequest request, int reservationId)
    {
        try
        {
            var reservation = await _reservationService.GetById(reservationId);
            if (reservation == null)
            {
                return BadRequest("Reservation with provided id doensn't exist");
            }

            await _reservationService.Update(request, reservation);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    [Route("confirm")]
    public async Task<IActionResult> ConfirmReservation(int reservationId)
    {
        try
        {
            var reservation = await _reservationService.GetById(reservationId);
            if (reservation == null)
            {
                return BadRequest("Reservation with provided id doensn't exist");
            }

            reservation.Status = BLL.Models.Enums.ReservationStatus.Confirmed;

            await _reservationService.UpdateStatus(reservation);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    [Route("decline")]
    public async Task<IActionResult> DeclineReservation(int reservationId)
    {
        try
        {
            var reservation = await _reservationService.GetById(reservationId);
            if (reservation == null)
            {
                return BadRequest("Reservation with provided id doensn't exist");
            }

            reservation.Status = BLL.Models.Enums.ReservationStatus.Declined;

            await _reservationService.UpdateStatus(reservation);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateReservationRequest request)
    {
        try
        {
            var account = await _accountService.GetById(request.AccountId);
            if(account == null)
            {
                return BadRequest("Account with provided id doesn't exist");
            }

            var employee = await _employeeService.GetById(request.EmployeeId);
            if (employee == null)
            {
                return BadRequest("Employee with provided id doesn't exist");
            }

            await _reservationService.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

