using Data.Entities.Weather;
using Logic.Weather.Models;

namespace Logic.Weather.Extensions
{
    internal static class WeatherExtensions
    {
        internal static WeatherLocation ToEntity(this GeoLocationData model)
        {
            return new WeatherLocation
            {
                Name = model.Name,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Country = model.Country,
                CountryCode = model.CountryCode,
                TimeZone = model.TimeZone,
            };
        }
    }
}
