using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperValueAPI.Controllers
{
    public class PaymentIntegratonWebHookController : ControllerBase
    {
        private readonly ILogger<PaymentIntegratonWebHookController> _logger;

        public PaymentIntegratonWebHookController(ILogger<PaymentIntegratonWebHookController> logger)
        {
            _logger = logger;
        }
    }
}
