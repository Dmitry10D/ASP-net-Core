using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerUnitTests
{
    public class AgentHddControllerUnitTests
    {
        private AgentHddController controller;
        public AgentHddControllerUnitTests()
        {
            controller = new AgentHddController();
        }
        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.CollectMetrics();

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}