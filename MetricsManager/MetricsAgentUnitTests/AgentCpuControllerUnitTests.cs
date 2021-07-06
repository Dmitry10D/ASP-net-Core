using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Microsoft.Extensions.Logging;

namespace MetricsManagerUnitTests
{
    public class AgentCpuControllerUnitTests
    {
        private AgentCpuController controller;
        private readonly ILogger<AgentCpuController> _logger;
        public AgentCpuControllerUnitTests(ILogger<AgentCpuController> logger)
        {
            controller = new AgentCpuController(logger);
            _logger = logger;
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
