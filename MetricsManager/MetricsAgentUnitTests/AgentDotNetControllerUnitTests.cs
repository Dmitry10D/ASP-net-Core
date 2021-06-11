﻿using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerUnitTests
{
    public class AgentDotNetControllerUnitTests
    {
        private AgentDotNetController controller;
        public AgentDotNetControllerUnitTests()
        {
            controller = new AgentDotNetController();
        }
        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.CollectMetrics(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}