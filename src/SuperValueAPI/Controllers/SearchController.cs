using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperValueAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    { 
        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult SearchByLocation(GeoLocationQueryModel location)
        {
            return Ok(new List<LocationShopResult>());
        }

        public IActionResult SearchByProduct(ProductQueryModel location)
        {
            return Ok(new List<LocationShopResult>());
        }
    }
}
