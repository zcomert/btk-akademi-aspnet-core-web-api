using Microsoft.AspNetCore.Mvc;

namespace loggingDemo.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            _logger.LogWarning($"GetAllOrders has been called at " +
                $"{DateTime.UtcNow}");
            return Ok(); // 200
        }
    }
}
