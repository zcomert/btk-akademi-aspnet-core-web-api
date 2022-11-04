using Microsoft.AspNetCore.Mvc;

namespace firstApplication.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Greeting()
        {
            string message = "Hello Web API";
            return Ok(new
            {
                message = message,
                statusCode = 200
            });
        }
    }
}
