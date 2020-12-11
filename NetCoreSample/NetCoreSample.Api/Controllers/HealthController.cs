using Microsoft.AspNetCore.Mvc;
using NetCoreSample.Framework.Abstract;
using NetCoreSample.ServiceModel;

namespace NetCoreSample.Api.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        #region ctor

        private readonly ISettings settings;

        public HealthController(ISettings settings)
        {
            this.settings = settings;
        }

        #endregion

        [HttpGet, Route(ApiUrls.Health)]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet, Route(ApiUrls.Version)]
        public IActionResult Version()
        {
            return Ok(settings.ApplicationVersion);
        }
    }
}