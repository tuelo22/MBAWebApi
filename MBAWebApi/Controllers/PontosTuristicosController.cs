using Microsoft.AspNetCore.Mvc;

namespace MBAWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontosTuristicosController : ControllerBase
    {
        private readonly ILogger<PontosTuristicosController> _logger;

        public PontosTuristicosController(ILogger<PontosTuristicosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<String> Get()
        {
            try
            {
                return PontosTuristicosService.Listar();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Information, ex, "Falha ao realizar request.");

                throw;
            }
        }
    }
}
