using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    { 

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("ok");
        }
    }
}
