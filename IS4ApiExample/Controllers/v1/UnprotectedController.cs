using Microsoft.AspNetCore.Mvc;

namespace IS4ApiExample.Controllers.v1
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UnprotectedController : ControllerBase
    {
        // GET /api/isonline
        [HttpGet("isonline")]
        public ActionResult<bool> Get()
        {
            return true;
        }
    }
}
