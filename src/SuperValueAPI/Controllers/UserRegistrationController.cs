
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperValueAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserRegistrationController> _logger;

        public UserRegistrationController(ILogger<UserRegistrationController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult RegisterUser(UserRegistrationModel user) 
        {
            return Ok();
        }
    }
}
