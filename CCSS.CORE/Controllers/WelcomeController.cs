using Microsoft.AspNetCore.Mvc;

namespace CCSS.CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, " Welcome - Service version 1.0.1 - " + System.DateTime.Now);
        }
    }
}