using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DietController : ControllerBase
{
    private readonly IDietService _dietService;
    private readonly IAccountService _accountService;

    public DietController(IDietService dietService, IAccountService accountService)
    {
        _dietService = dietService;
        _accountService = accountService;
    }

    [HttpGet]
    [Authorize(Roles = "Employee,User")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            if(id < 0)
            {
                return BadRequest("Invalid id");
            }

            var result = await _dietService.GetById(id);

            if(result == null)
            {
                return NotFound("Diet with provided id doesn't exist");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("getByUserId")]
    [Authorize(Roles = "Employee,User")]
    public async Task<IActionResult> GetByUserId(int userId)
    {
        try
        {
            if (userId < 0)
            {
                return BadRequest("Invalid id");
            }

            var result = await _dietService.GetByUser(userId);

            if (result == null)
            {
                return NotFound("Diets for provided user doesn't exist");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpDelete]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            await _dietService.Delete(id);

            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Update([FromBody] UpdateDietRequest request, int Id)
    {
        try
        {
            var diet = await _dietService.GetById(Id);

            if (diet == null)
            {
                return BadRequest("Diet with provided id doesn't exist");
            }

            await _dietService.Update(request, diet);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Create([FromBody] CreateDietRequest request)
    {
        try
        {
            var account = await _accountService.GetById(request.AccountId);

            if (account == null)
            {
                return BadRequest("Account with provided id doesn't exist");
            }

            await _dietService.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

