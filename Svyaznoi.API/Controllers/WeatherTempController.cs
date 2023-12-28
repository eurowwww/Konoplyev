using Microsoft.AspNetCore.Mvc;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherTempController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Cold", "Warm","Hot"
    };

        private readonly ILogger<WeatherTempController> _logger;

        public WeatherTempController(ILogger<WeatherTempController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherTemp")]
        public IEnumerable<WeatherTemp> Get()
        {
            return Enumerable.Range(1, 5).Select(index => {
                int temperature = Random.Shared.Next(-25, 45);
                string summary = "";
                if (temperature <5)
                {
                    summary = Summaries[0];
                }
                else if (temperature >= 5 && temperature <15)
                {
                    summary = Summaries[1];
                }
                else
                {
                    summary = Summaries[2];
                }
                return new WeatherTemp
                {
                    Date = DateTime.Now.AddDays(index),
                    WTemperatureC = temperature,
                    Summary = summary
                };
            })
            .ToArray();
        }
    }
}