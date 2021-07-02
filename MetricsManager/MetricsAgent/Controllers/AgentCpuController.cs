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
    public class AgentCpuController : ControllerBase
    {
        private readonly ILogger<AgentCpuController> _logger;

        public AgentCpuController(ILogger<AgentCpuController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в AgentCpuController");
        }

        [HttpGet("cpu/from/{fromTime}/to/{toTime}")]
        public IActionResult CollectMetrics([FromRoute] DateTimeOffset fromTime, [FromRoute] DateTimeOffset toTime)
        {
            _logger.LogInformation($"Entered time period from {fromTime} to {toTime}");
            return Ok();
        }
        
    }
}
