using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperValueAPI.ActionFilter;

namespace SuperValueAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ApiKeyAuthorization]
        public IActionResult GetOrderHistory(UserOrderQueryModel model) => Ok();


        //[HttpGet]
        //public IActionResult GetCurrentOrder(UserOrderQueryModel mode) => Ok();
    }
}
