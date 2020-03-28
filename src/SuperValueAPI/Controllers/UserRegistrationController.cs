
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperValueAPI.Controllers
{  
    public class UserRegistrationController : ControllerBase
    {
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


        [HttpGet]
        public IActionResult GetUser() 
        {
            return Ok();
        }
    }
}
