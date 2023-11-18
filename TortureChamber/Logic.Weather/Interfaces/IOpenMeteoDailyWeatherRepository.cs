using Data.Entities.Weather;
using Logic.Shared.Interfaces;

namespace Logic.Weather.Interfaces
{
    public interface IOpenMeteoDailyWeatherRepository : IGenericRepository<DailyWeatherData>
    {
        Task ImportWeatherDailyData(WeatherLocation weatherLocation, int historyMonthCount, int forecastDays);
    }
}
