using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcPlusWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Hi")]
        public IActionResult Hi()
        {
            return Ok("Hello");
        }

        [HttpGet("Data")]
        public IActionResult Data()
        {
            return NotFound("User data Not Found");
        }
    }
}
