using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;

namespace WebApi1.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/invoke")]
    public class InvokeController : ControllerBase
    {

        private readonly ILogger<InvokeController> _logger;
        private IDownstreamWebApi _downstreamWebApi;

        public InvokeController(ILogger<InvokeController> logger, 
            IDownstreamWebApi downstreamWebApi)
        {
            _logger = logger;
            _downstreamWebApi = downstreamWebApi;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation("Trying to call a downstream Api");
            var value = await _downstreamWebApi.CallWebApiForUserAsync(
                "WebApi2",
                options =>
                {
                    options.HttpMethod = HttpMethod.Get;
                    options.RelativePath = "api/downstream";
                });

            return Ok(value);
        }
    }
}
