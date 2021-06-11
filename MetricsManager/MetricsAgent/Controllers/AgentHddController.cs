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
    public class AgentHddController : ControllerBase
    {
        [HttpGet("hdd/left")]
        public IActionResult CollectMetrics()
        {
            return Ok();
        }

    }
}