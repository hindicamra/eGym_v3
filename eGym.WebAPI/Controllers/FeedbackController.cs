using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class FeedbackController : ControllerBase
{
    private readonly IFeedbackService _feedbackService;

    public FeedbackController(IFeedbackService feedbackService)
    {
        _feedbackService = feedbackService;
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

            var response = await _feedbackService.GetById(id);

            if(response == null)
            {
                return NotFound("Feedback with provided id doesn't exist");
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
            var response = await _feedbackService.GetAll();
            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("getByUser")]
    public async Task<IActionResult> GetByUser(int userId)
    {
        try
        {
            if(userId < 0)
            {
                return BadRequest("inavlid user id");
            }

            var response = await _feedbackService.GetByUser(userId);

            if(response == null)
            {
                return NotFound("User doesn't have any feedback currently");
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
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _feedbackService.GetById(id);

            if(response == null)
            {
                return NotFound("Feedback with provided id doesn't exist");
            }

            await _feedbackService.Delete(id);

            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateFeedbackRequest request, int id)
    {
        try
        {
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _feedbackService.GetById(id);

            if (response == null)
            {
                return NotFound("Feedback with provided id doesn't exist");
            }

            await _feedbackService.Update(request, response);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateFeedbackRequest request)
    {
        try
        {
            await _feedbackService.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

