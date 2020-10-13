using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi2.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/api/downstream")]
    public class DownstreamController : ControllerBase
    {

        private readonly ILogger<DownstreamController> _logger;

        public DownstreamController(ILogger<DownstreamController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>
            {
                "hello",
                "world"
            };
        }
    }
}
