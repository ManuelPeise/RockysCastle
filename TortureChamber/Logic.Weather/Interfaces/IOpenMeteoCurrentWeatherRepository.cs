using Data.Entities.Weather;
using Logic.Shared.Interfaces;

namespace Logic.Weather.Interfaces
{
    public interface IOpenMeteoCurrentWeatherRepository: IGenericRepository<CurrentWeatherData>
    {
        Task ImportCurrentWeatherData(WeatherLocation weatherLocation, int forecastDays);
    }
}
