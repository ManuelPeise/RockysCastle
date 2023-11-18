using Data.Entities.Weather;
using Logic.Shared.Interfaces;
using Logic.Weather.Models;

namespace Logic.Weather.Interfaces
{
    public interface IOpenMeteoDailyWeatherRepository : IGenericRepository<DailyWeatherData>
    {
        Task ImportWeatherDailyData(WeatherLocation weatherLocation, int historyMonthCount, int forecastDays);
        Task<DailyWeather?> GetDailyWeather(WeatherLocation weatherLocation, DateTime date);
        Task<List<DailyWeather>?> GetAllDailyWeather(WeatherLocation weatherLocation, DateTime? from, DateTime? to);
    }
}
