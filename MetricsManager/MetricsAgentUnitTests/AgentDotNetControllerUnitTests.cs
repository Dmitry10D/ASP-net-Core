using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Microsoft.Extensions.Logging;

namespace MetricsManagerUnitTests
{
    public class AgentDotNetControllerUnitTests
    {
        private AgentDotNetController controller;
        private readonly ILogger<AgentDotNetController> logger;

        public AgentDotNetControllerUnitTests(ILogger<AgentDotNetController> logger)
        {
            controller = new AgentDotNetController(logger);
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