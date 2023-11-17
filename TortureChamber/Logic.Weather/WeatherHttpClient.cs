using Logic.Shared;
using Logic.Weather.Interfaces;

namespace Logic.Weather
{
    public class WeatherHttpClient : HttpClientBase, IWeatherHttpClient
    {
        private const string _baseUrl = "https://api.open-meteo.com/v1/";

        public WeatherHttpClient() : base(_baseUrl)
        {

        }
    }
}
