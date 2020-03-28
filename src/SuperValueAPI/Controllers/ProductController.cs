using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperValueAPI.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }


        [HttpGet]
        public IActionResult GetProduct(int i)
        {
            return Ok($"Product {i}");
        }
    }
}
