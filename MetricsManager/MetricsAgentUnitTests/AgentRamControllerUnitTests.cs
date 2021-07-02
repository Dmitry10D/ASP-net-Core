using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Microsoft.Extensions.Logging;

namespace MetricsManagerUnitTests
{
    public class AgentRamControllerUnitTests
    {
        private AgentRamController controller;
        private readonly ILogger<AgentRamController> logger;
        public AgentRamControllerUnitTests(ILogger<AgentRamController> logger)
        {
            controller = new AgentRamController(logger);
        }
        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var fromTime = DateTimeOffset.FromUnixTimeMilliseconds(0);
            var toTime = DateTimeOffset.FromUnixTimeMilliseconds(100000);

            var result = controller.CollectMetrics(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}