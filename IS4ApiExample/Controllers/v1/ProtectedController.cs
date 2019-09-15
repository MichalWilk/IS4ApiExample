using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IS4ApiExample.Controllers.v1
{
    [Route("v1/[controller]")]
    [Authorize]
    [ApiController]
    public class ProtectedController : ControllerBase
    {
        // GET /license
        [HttpGet("isvalidated")]
        public ActionResult<bool> GetIsValidated()
        {
            return true;
        }
    }
}
