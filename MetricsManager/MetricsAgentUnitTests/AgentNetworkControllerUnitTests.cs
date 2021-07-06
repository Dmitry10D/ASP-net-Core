using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Microsoft.Extensions.Logging;

namespace MetricsManagerUnitTests
{
    public class AgentNetworkControllerUnitTests
    {
        private AgentNetworkController controller;
        private readonly ILogger<AgentNetworkController> logger;
        public AgentNetworkControllerUnitTests(ILogger<AgentNetworkController> logger)
        {
            controller = new AgentNetworkController(logger);
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