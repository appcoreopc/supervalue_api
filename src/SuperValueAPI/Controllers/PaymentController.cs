
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stripe;

namespace SuperValueAPI.Controllers
{
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult CreatePaymentIntent(PaymentIntentModel model)
        {
            StripeConfiguration.ApiKey = "sk_test_tqZS5yHD23f53cd3IUJXgF5Y";
            var options = new PaymentIntentCreateOptions
            {
                Amount = model.Amount,
                Currency = model.Currency,
                Customer = model.CustomerId,
            };

            var service = new PaymentIntentService();
            var paymentIntent = service.Create(options);

            return Ok(paymentIntent.ClientSecret);
        }
    }
}
