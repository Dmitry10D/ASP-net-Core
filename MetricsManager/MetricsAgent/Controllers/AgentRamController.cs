using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics")]
    [ApiController]
    public class AgentRamController : ControllerBase
    {
        private readonly ILogger<AgentRamController> _logger;

        public AgentRamController(ILogger<AgentRamController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в AgentRamController");
        }

        [HttpGet("ram/available/from/{fromTime}/to/{toTime}")]
        public IActionResult CollectMetrics([FromRoute] DateTimeOffset fromTime, [FromRoute] DateTimeOffset toTime)
        {
            _logger.LogInformation($"Entered time period from {fromTime} to {toTime}");
            return Ok();
        }

    }
}