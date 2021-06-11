using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics")]
    [ApiController]
    public class AgentNetworkController : ControllerBase
    {
        [HttpGet("network/from/{fromTime}/to/{toTime}")]
        public IActionResult CollectMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

    }
}
