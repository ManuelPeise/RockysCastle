using Newtonsoft.Json;

namespace Logic.Weather.Models
{
    public class WeatherDataResponse
    {
        public CurrentWeatherDataSet Current { get; set; }
        public DailyWeatherDataSet Daily { get; set; }
        [JsonProperty("daily_units")]
        public WeatherDataUnits Units { get; set; }
    }

    public class CurrentWeatherDataSet
    {
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime TimeStamp { get; set; }
        [JsonProperty("temperature_2m", NullValueHandling = NullValueHandling.Ignore)]
        public double Temperature { get; set; }
        [JsonProperty("relative_humidity_2m", NullValueHandling = NullValueHandling.Ignore)]
        public double Humidity { get; set; }
        [JsonProperty("apparent_temperature", NullValueHandling = NullValueHandling.Ignore)]
        public double TempFeelsLike { get; set; }
        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        public double Rain { get; set; }
        [JsonProperty("showers", NullValueHandling = NullValueHandling.Ignore)]
        public double Showers { get; set; }
        [JsonProperty("snowfall", NullValueHandling = NullValueHandling.Ignore)]
        public double SnowFall { get; set; }
        [JsonProperty("weather_code", NullValueHandling = NullValueHandling.Ignore)]
        public int WeatherCode { get; set; }
        [JsonProperty("cloud_cover", NullValueHandling = NullValueHandling.Ignore)]
        public int Clouds { get; set; }
        [JsonProperty("pressure_msl", NullValueHandling = NullValueHandling.Ignore)]
        public double Pressure { get; set; }
        [JsonProperty("wind_speed_10m", NullValueHandling = NullValueHandling.Ignore)]
        public double WindSpeed { get; set; }
        [JsonProperty("wind_direction_10m", NullValueHandling = NullValueHandling.Ignore)]
        public double WindDirection { get; set; }
        [JsonProperty("wind_gusts_10m", NullValueHandling = NullValueHandling.Ignore)]
        public double WindGustSpeed { get; set; }

    }

    public class DailyWeatherDataSet
    {
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public List<DateTime> TimeStamps { get; set; }
        [JsonProperty("weather_code", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> WeatherCodes { get; set; }
        [JsonProperty("temperature_2m_max", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> MaxTemp { get; set; }
        [JsonProperty("temperature_2m_min", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> MinTemp { get; set; }
        [JsonProperty("apparent_temperature_max", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> TempFeelsMax { get; set; }
        [JsonProperty("apparent_temperature_min", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> TempFeelsMin { get; set; }
        [JsonProperty("sunrise", NullValueHandling = NullValueHandling.Ignore)]
        public List<DateTime> Sunrise { get; set; }
        [JsonProperty("sunset", NullValueHandling = NullValueHandling.Ignore)]
        public List<DateTime> Sunset { get; set; }
        [JsonProperty("sunshine_duration", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> SunShineDuration { get; set; }
        [JsonProperty("rain_sum", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> RainSum { get; set; }
        [JsonProperty("showers_sum", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> ShowersSum { get; set; }
        [JsonProperty("snowfall_sum", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> SnowSum { get; set; }
        [JsonProperty("wind_speed_10m_max", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> WindSpeed { get; set; }
        [JsonProperty("wind_gusts_10m_max", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> WindGusts { get; set; }
        [JsonProperty("wind_direction_10m_dominant", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> WindDirection { get; set; }
    }

    public class WeatherDataUnits
    {
        [JsonProperty("time")]
        public string TimeFormat { get; set; }
        [JsonProperty("weather_code")]
        public string WeatherCode { get; set; }
        [JsonProperty("temperature_2m_max")]
        public string Temp { get; set; }
        [JsonProperty("sunshine_duration")]
        public string Duration { get; set; }
        [JsonProperty("rain_sum")]
        public string Rain { get; set; }
        [JsonProperty("snowfall_sum")]
        public string Snow { get; set; }
        [JsonProperty("wind_speed_10m_max")]
        public string Speed { get; set; }
        [JsonProperty("wind_direction_10m_dominant")]
        public string Direction { get; set; }
    }
}

