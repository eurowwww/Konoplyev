using Microsoft.AspNetCore.Mvc;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WaterTempController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing",  "Cool", "Warm"
    };

        private readonly ILogger<WaterTempController> _logger;

        public WaterTempController(ILogger<WaterTempController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWaterTemp")]
        public IEnumerable<WaterTemp> Get()
        {
            return Enumerable.Range(1, 5).Select(index => {
                int temperature = Random.Shared.Next(0, 35);
                string summary = "";
                if (temperature < 20)
                {
                    summary = Summaries[0];
                }
                else if (temperature >= 20 && temperature < 27)
                {
                    summary = Summaries[1];
                }
                else
                {
                    summary = Summaries[2];
                }
                return new WaterTemp
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = temperature,
                    Summary = summary
                };
            })
            .ToArray();
        }
    }
}