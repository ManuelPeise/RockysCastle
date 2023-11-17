using Data.Entities.Weather;
using Logic.Shared.Interfaces;

namespace Logic.Weather.Interfaces
{
    public interface IWeatherLocationRepository: IGenericRepository<WeatherLocation>
    {
        Task<WeatherLocation?> QueryGeoLocationDataAsync(string city);
        Task<WeatherLocation?> GetGeoLocationDataAsync(string city);
    }
}
