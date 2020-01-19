using CuriousMe.Domain.Weather;
using System;
using System.Linq;

namespace CuriousMe.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public WeatherForecast[] GetForecast()
        {
            string[] Summaries = new[] {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
