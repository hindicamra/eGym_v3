using eGym.BLL;
using eGym.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private readonly IReportService _reportService;

    public ReportController(IReportService reportService)
    {
        _reportService = reportService;
    }

    [Route("finance")]
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetFinancialReport(string token)
    {
        try
        {
            if(token == "RSIIeGym")
            {
                var file = await _reportService.GetFinanceReport2();

                return Ok(file);
            }

            return Unauthorized();  
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [Route("employees")]
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetEmployeesReport(string token)
    {
        try
        {
            if (token == "RSIIeGym")
            {
                var file = await _reportService.GetEmployeeReport();

                return File(file, "application/pdf");
            }

            return Unauthorized();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [Route("users")]
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetUsersReport(string token)
    {
        try
        {
            if (token == "RSIIeGym")
            {
                var file = await _reportService.GetUserReport();

                return File(file, "application/pdf");
            }

            return Unauthorized();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [Route("token")]
    [HttpGet]
    public async Task<IActionResult> GetToken()
    {
        try
        {
            return Ok(new Token { Key = "RSIIeGym" });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

