using Data.Entities.Weather;
using Logic.Shared.Interfaces;
using Logic.Weather.Models;

namespace Logic.Weather.Interfaces
{
    public interface IOpenMeteoCurrentWeatherRepository: IGenericRepository<CurrentWeatherData>
    {
        Task ImportCurrentWeatherData(WeatherLocation weatherLocation, int forecastDays);

        Task<CurrentWeather?> GetCurrentWeather(WeatherLocation weatherLocation, DateTime date);
    }
}
