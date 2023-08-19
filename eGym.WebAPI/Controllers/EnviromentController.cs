using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eGym.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnviromentController : ControllerBase
    {
        private readonly IHostEnvironment _hostEnvironment;
        public EnviromentController(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        // GET: api/<EnviromentController>
        [HttpGet]
        public IActionResult Get()
        {
            string environment = _hostEnvironment.EnvironmentName;
            return Content($"ASPNETCORE_ENVIRONMENT: {environment}");
        }
    }
}
