using Data.Entities.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Weather.Helpers
{
    internal static class WeatherRequestHelper
    {
        internal static List<KeyValuePair<string, object>> GetCurrentWeatherRequestParameters(WeatherLocation locationData, int forecastDays)
        {
            var currentDataParameters = new List<string>
            {
               "temperature_2m", "relative_humidity_2m", "apparent_temperature",
                "rain", "showers", "snowfall", "weather_code", "cloud_cover",
                "pressure_msl", "wind_speed_10m", "wind_direction_10m", "wind_gusts_10m"
            };

            return new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("latitude", locationData.Latitude),
                new KeyValuePair<string, object>("longitude", locationData.Longitude),
                new KeyValuePair<string, object>("current", string.Join(",", currentDataParameters)),
                new KeyValuePair<string, object>("forecast_days", forecastDays),
            };
        }

        internal static List<KeyValuePair<string, object>> GetDailyWeatherParameters(WeatherLocation locationData, DateTime from, DateTime to)
        {
            var dailyDataParameters = new List<string>
            {
               "weather_code", "temperature_2m_max", "temperature_2m_min",
               "apparent_temperature_max", "apparent_temperature_min",
               "sunrise", "sunset", "sunshine_duration", "rain_sum",
               "showers_sum", "snowfall_sum", "wind_speed_10m_max",
                "wind_gusts_10m_max", "wind_direction_10m_dominant"
            };


            return new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("latitude", locationData.Latitude),
                new KeyValuePair<string, object>("longitude", locationData.Longitude),
                new KeyValuePair<string, object>("daily", string.Join(",", dailyDataParameters)),
                new KeyValuePair<string, object>("start_date", from.ToString("yyyy-MM-dd")),
                new KeyValuePair<string, object>("end_date", to.ToString("yyyy-MM-dd"))
            };
        }
    }
}
