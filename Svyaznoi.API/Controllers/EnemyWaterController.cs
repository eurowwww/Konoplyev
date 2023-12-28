using Microsoft.AspNetCore.Mvc;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnemyWaterController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Dangerous", "Be careful","Good"
    };

        private readonly ILogger<EnemyWaterController> _logger;

        public EnemyWaterController(ILogger<EnemyWaterController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEnemyWater")]
        
            public IEnumerable<EnemyWater> Get()
            {
                return Enumerable.Range(1, 5).Select(index => {
                    int opp = Random.Shared.Next(1, 10);
                    string summary = "";
                    if (opp <= 2)
                    {
                        summary = Summaries[2];
                    }
                    else if (opp > 2 && opp < 7)
                    {
                        summary = Summaries[1];
                    }
                    else
                    {
                        summary = Summaries[2];
                    }
                    return new EnemyWater
                    {
                        Date = DateTime.Now.AddDays(index),
                        Number = opp,
                        Summary = summary
                    };
                })
                .ToArray();
            }
        }
}