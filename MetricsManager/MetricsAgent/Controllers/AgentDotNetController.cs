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
    public class AgentDotNetController : ControllerBase
    {
        [HttpGet("dotnet/errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult CollectMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

    }
}