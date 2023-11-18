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

        internal static CurrentWeatherData ToEntity(this CurrentWeatherDataSet model, Guid locationId)
        {
            return new CurrentWeatherData
            {
                TimeStamp = model.TimeStamp,
                Temperature = model.Temperature,
                TempFeelsLike = model.TempFeelsLike,
                Humidity = model.Humidity,
                Pressure = model.Pressure,
                Rain = model.Rain,
                Showers = model.Showers,
                SnowFall = model.SnowFall,
                WeatherCode = model.WeatherCode,
                Clouds = model.Clouds,
                LocationId = locationId,
                WindDirection = model.WindDirection,
                WindGustSpeed = model.WindGustSpeed,
                WindSpeed = model.WindSpeed,
            };
        }

        internal static List<DailyWeatherData> ToEntityList(this DailyWeatherDataSet model, WeatherLocation weatherLocation)
        {
            var dailyWeatherDataCollection = new List<DailyWeatherData>();

            for (int index = 0; index < model.TimeStamps.Count; index++)
            {
                dailyWeatherDataCollection.Add(new DailyWeatherData
                {
                    TimeStamp = model.TimeStamps[index],
                    MinTemp = model.MinTemp[index],
                    MaxTemp = model.MaxTemp[index],
                    TempFeelsMin = model.TempFeelsMin[index],
                    TempFeelsMax = model.TempFeelsMax[index],
                    RainSum = model.RainSum[index],
                    ShowersSum = model.ShowersSum[index],
                    SnowSum = model.SnowSum[index],
                    Sunrise = model.Sunrise[index],
                    Sunset = model.Sunset[index],
                    WeatherCode = model.WeatherCodes[index],
                    SunShineDuration = model.SunShineDuration[index],
                    WindDirection = model.WindDirection[index],
                    WindGusts = model.WindGusts[index],
                    WindSpeed = model.WindSpeed[index],
                    LocationId = weatherLocation.Id,
                    Location = weatherLocation,
                });
            }

            return dailyWeatherDataCollection;
        }

        internal static CurrentWeather ToModel(this CurrentWeatherData model)
        {
            return new CurrentWeather
            {
                Id = model.Id,
                Clouds = model.Clouds,
                Humidity = model.Humidity,
                Pressure = model.Pressure,
                Rain = model.Rain,
                Showers = model.Showers,
                SnowFall = model.SnowFall,
                Temperature = model.Temperature,
                TempFeelsLike = model.TempFeelsLike,
                TimeStamp = model.TimeStamp,
                WeatherCode = model.WeatherCode,
                WindDirection = model.WindDirection,
                WindGustSpeed = model.WindGustSpeed,
                WindSpeed = model.WindSpeed,
                Location = model.Location.ToModel()
            };
        }

        internal static DailyWeather ToModel(this DailyWeatherData model)
        {
            return new DailyWeather
            {
                Id = model.Id,
                TimeStamp = model.TimeStamp,
                ImportDate = model.ImportDate,
                LastUpdate = model.LastUpdate,
                TempFeelsMax = model.TempFeelsMax,
                TempFeelsMin = model.TempFeelsMin,
                MaxTemp = model.MaxTemp,
                MinTemp = model.MinTemp,
                Sunrise = model.Sunrise,
                Sunset = model.Sunset,
                ShowersSum = model.ShowersSum,
                RainSum = model.RainSum,
                SnowSum = model.SnowSum,
                SunShineDuration = model.SunShineDuration,
                WeatherCode = model.WeatherCode,
                WindDirection = model.WindDirection,
                WindGusts = model.WindGusts,
                WindSpeed = model.WindSpeed,
                Location = model.Location.ToModel()
            };
        }

        internal static Location ToModel(this WeatherLocation model)
        {
            return new Location
            {
                Id = model.Id,
                Name = model.Name,
                Country = model.Country,
                CountryCode = model.CountryCode,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                TimeZone = model.TimeZone,
            };
        }
    }
}
