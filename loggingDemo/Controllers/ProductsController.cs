using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loggingDemo.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            _logger.LogInformation($"GetAllProducts has been called." +
                $" {DateTime.UtcNow}");
            return NoContent(); // 204 
        }
    }
}
