using Logic.Shared;
using Logic.Weather.Interfaces;

namespace Logic.Weather
{
    public class WeatherLocationHttpClient : HttpClientBase, IWeatherLocationHttpClient
    {
        private const string _baseUrl = "https://geocoding-api.open-meteo.com/v1/search";

        public WeatherLocationHttpClient() : base(_baseUrl)
        {

        }
    }
}
