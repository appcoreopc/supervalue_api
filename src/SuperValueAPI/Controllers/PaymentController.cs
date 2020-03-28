
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperValueAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
     
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult GetPaymentSecret(PaymentIntentModel model)
        {
            return Ok();
        }
    }
}
