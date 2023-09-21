using MBAWebApi.Controllers;
using Xunit.Abstractions;

namespace MBAWebApi.Test
{
    public class WeatherForecastControllerTest
    {
        private readonly XunitLogger<WeatherForecastController> _logger;

        public WeatherForecastControllerTest(ITestOutputHelper output)
        {
            _logger = new XunitLogger<WeatherForecastController>(output);
        }
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new WeatherForecastController(_logger);

            var result = controller.Get();

            Assert.True(result.Any());
        }
    }
}