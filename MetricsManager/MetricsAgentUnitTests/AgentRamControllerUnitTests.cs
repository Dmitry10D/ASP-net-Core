using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerUnitTests
{
    public class AgentRamControllerUnitTests
    {
        private AgentRamController controller;
        public AgentRamControllerUnitTests()
        {
            controller = new AgentRamController();
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