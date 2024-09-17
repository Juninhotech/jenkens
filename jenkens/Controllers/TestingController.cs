using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jenkens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {


        [HttpPost("testing")]

        public IActionResult Test()
        {
            return Ok("Just testing");
        }


        [HttpGet]
        public IActionResult Test2()
        {
            return Ok("hello");
        }
    }
}
