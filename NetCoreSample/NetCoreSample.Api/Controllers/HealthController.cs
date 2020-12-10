using Microsoft.AspNetCore.Mvc;

namespace NetCoreSample.Api.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        #region ctor

        public HealthController()
        {
        }

        #endregion

        [HttpGet, Route("health")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}