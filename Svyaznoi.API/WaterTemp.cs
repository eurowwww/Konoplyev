namespace Svyaznoi.API
{
    public class WaterTemp
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    public class EnemyWater
    {
        public DateTime Date { get; set; }

        public int Number { get; set; }

        public string? Summary { get; set; }
    }
    public class WeatherTemp
    {
        public DateTime Date { get; set; }

        public int WTemperatureC { get; set; }

        public int WTemperatureF => 32 + (int)(WTemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}