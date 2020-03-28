using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperValueAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentIntegratonWebHookController : ControllerBase
    {
        private readonly ILogger<PaymentIntegratonWebHookController> _logger;

        public PaymentIntegratonWebHookController(ILogger<PaymentIntegratonWebHookController> logger)
        {
            _logger = logger;
        }

     
    }
}
