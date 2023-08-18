using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Employee")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            if(id < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _employeeService.GetById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Employee,User")]
    [Route("getAll")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var response = await _employeeService.GetAll();

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Employee,User")]
    [Route("activity")]
    public async Task<IActionResult> GetEmployeeActivity(int employeeId)
    {
        try
        {
            var response = await _employeeService.GetEmployeeActivity(employeeId);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Employee")]
    [Route("search")]
    public async Task<IActionResult> Search(string text)
    {
        try
        {
            var response = await _employeeService.Search(text);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpDelete]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            //Check if account exist
            var employee = await _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _employeeService.Delete(id);

            return NoContent();
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    [Authorize(Roles = "Admin,Employee")]
    public async Task<IActionResult> Update([FromBody] UpdateAccountRequest request, int id)
    {
        try
        {
            var employee = await _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _employeeService.Update(request, employee);

            return Ok();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create([FromBody] CreateEmployeeRequest request)
    {
        try
        {
            await _employeeService.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    [Route("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login(string username, string password)
    {
        try
        {
            var response = await _employeeService.Login(username, password);

            if (response == null)
            {
                return BadRequest("Invalid username or password");
            }

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

