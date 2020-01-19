using System;
using System.Collections.Generic;
using System.Text;

namespace CuriousMe.Domain.Weather
{
    public interface IWeatherForecastService
    {
        WeatherForecast[] GetForecast();
    }
}
