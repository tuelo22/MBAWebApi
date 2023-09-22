using MBAWebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MBAWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PontosTuristicosController : ControllerBase
    {
        private readonly ILogger<PontosTuristicosController> _logger;

        public PontosTuristicosController(ILogger<PontosTuristicosController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPontosTuristicos")]
        public IEnumerable<String> Get()
        {
            _logger.Log(LogLevel.Information, "Acesso ao endpoint PontosTuristicos GET");

            return PontosTuristicosService.Listar();
        }
    }
}
