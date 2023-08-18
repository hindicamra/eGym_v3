using eGym.BLL;
using eGym.BLL.Implementation;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        try
        {
            if (id <= 0)
            {
                return BadRequest("Invalid Id");
            }

            var response = await _accountService.GetById(id);
            if (response == null)
            {
                return NotFound("Account with provided Id doesn't exist");
            }

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var response = await _accountService.GetAll();

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Employee,User")]
    [Route("search")]
    public async Task<IActionResult> Search(string text)
    {
        try
        {
            var response = await _accountService.Search(text);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpDelete]
    [Authorize(Roles = "Employee,Admin")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            if(id <= 0)
            {
                return BadRequest("Invalid Id");
            }

            //Check if account exist
            var account = await _accountService.GetById(id);
            if (account == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _accountService.Delete(id);

            return NoContent();
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAccountRequest request, int id)
    {
        try
        {
            var account = await _accountService.GetById(id);
            if(account == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _accountService.Update(request, account);

            return Ok();
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Create([FromBody] CreateAccountRequest request)
    {
        try
        {
            await _accountService.Create(request);

            return Accepted();
        }
        catch(Exception ex)
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
            var response = await _accountService.Login(username, password);

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

