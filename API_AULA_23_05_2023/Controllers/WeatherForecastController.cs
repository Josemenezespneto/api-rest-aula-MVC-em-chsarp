using API_AULA_23_05_2023.Data;
using API_AULA_23_05_2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_AULA_23_05_2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private ContextoBD contextoBD;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ContextoBD contextoBD)
        {
            _logger = logger;
            this.contextoBD = contextoBD;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost(Name = "Teste")]
        public string Post(Professor p)
        {
            string retorno = "";
            //realizar um teste para cadastrar um professor no banco
            //Professor p = new Professor() { Cpf = "123", Nome = "Melo", Titulacao = "Mestre"};
            this.contextoBD.Professores.Add(p);
            this.contextoBD.SaveChanges();
            retorno = "Professor cadastrado com sucesso";
            return retorno;
        }
    }
}