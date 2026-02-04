namespace Sahara.Api
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 144 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
