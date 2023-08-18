using eGym.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class RecommendationController : ControllerBase
{
    private readonly IRecommendationService _recommendationService;

    public RecommendationController(IRecommendationService recommendationService)
    {
        _recommendationService = recommendationService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(int accountId)
    {
        try
        {
            var response = await _recommendationService.Get(accountId);

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

