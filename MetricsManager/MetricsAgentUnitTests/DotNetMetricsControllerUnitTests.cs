using System;
using Xunit;
using Moq;
using MetricsAgent;
using MetricsAgent.DAL;
using MetricsAgent.Controllers;

namespace MetricsAgentUnitTests
{
    public class DotNetMetricsControllerUnitTests
    {
        private DotNetMetricsController controller;
        private Mock<IDotNetMetricsRepository> mock;
        public DotNetMetricsControllerUnitTests()
        {
            mock = new Mock<IDotNetMetricsRepository>();
            controller = new DotNetMetricsController(mock.Object);
        }
        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            mock.Setup(repository =>
            repository.Create(It.IsAny<DotNetMetric>())).Verifiable();
            
            var result = controller.Create(new
            MetricsAgent.Requests.DotNetMetricCreateRequest
            {
                Time = DateTimeOffset.FromUnixTimeSeconds(1),
                Value = 50
            });
            
           mock.Verify(repository => repository.Create(It.IsAny<DotNetMetric>()),
           Times.AtMostOnce());
        }
    }
}
