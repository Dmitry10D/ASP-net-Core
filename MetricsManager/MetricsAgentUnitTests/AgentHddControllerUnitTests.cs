using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Microsoft.Extensions.Logging;

namespace MetricsManagerUnitTests
{
    public class AgentHddControllerUnitTests
    {
        private AgentHddController controller;
        private readonly ILogger<AgentHddController> logger;
        public AgentHddControllerUnitTests(ILogger<AgentHddController> logger)
        {
            controller = new AgentHddController(logger);
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