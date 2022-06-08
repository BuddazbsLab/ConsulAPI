using ConsulAPI.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ConsulAPI.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    [ApiController]
    public class ConsulReturnSettings : BaseController
    {

        /// <summary>
        /// Gets the appsettings.json
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET /Consul appsettings
        /// </remarks>
        /// <returns>Returns appsettings.json</returns>
        /// <response code="200">Success</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public override ContentResult Get()
        {
            ConsulAppsettings consulAppsettings = new();
            var res = consulAppsettings.GetSettings();

            return Content(res.ToString(), "application/json");
        }
    }
}
