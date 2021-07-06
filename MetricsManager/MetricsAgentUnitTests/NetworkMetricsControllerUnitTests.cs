using System;
using Xunit;
using Moq;
using MetricsAgent;
using MetricsAgent.DAL;
using MetricsAgent.Controllers;

namespace MetricsAgentUnitTests
{
    public class NetworkMetricsControllerUnitTests
    {
        private NetworkMetricsController controller;
        private Mock<INetworkMetricsRepository> mock;
        public NetworkMetricsControllerUnitTests()
        {
            mock = new Mock<INetworkMetricsRepository>();
            controller = new NetworkMetricsController(mock.Object);
        }
        [Fact]
        public void Create_ShouldCall_Create_From_Repository()
        {
            // устанавливаем параметр заглушки
            // в заглушке прописываем что в репозиторий прилетит CpuMetric объект
            mock.Setup(repository =>
            repository.Create(It.IsAny<NetworkMetric>())).Verifiable();
            // выполняем действие на контроллере
            var result = controller.Create(new
            MetricsAgent.Requests.NetworkMetricCreateRequest
            {
                Time = DateTimeOffset.FromUnixTimeSeconds(1),
                Value = 50
            });
            // проверяем заглушку на то, что пока работал контроллер
            // действительно вызвался метод Create репозитория с нужным типом объекта в параметре
           mock.Verify(repository => repository.Create(It.IsAny<NetworkMetric>()),
           Times.AtMostOnce());
        }
    }
}
