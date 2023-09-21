using MBAWebApi.Controllers;
using Xunit.Abstractions;

namespace MBAWebApi.Test
{
    public class PontosTuristicosControllerTest
    {
        private readonly XunitLogger<PontosTuristicosController> _logger;

        public PontosTuristicosControllerTest(ITestOutputHelper output)
        {
            _logger = new XunitLogger<PontosTuristicosController>(output);
        }
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new PontosTuristicosController(_logger);

            var result = controller.Get();

            Assert.True(result.Any());
        }
    }
}