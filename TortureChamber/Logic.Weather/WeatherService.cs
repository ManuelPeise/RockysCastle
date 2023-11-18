using Logic.Weather.Interfaces;

namespace Logic.Weather
{
    public class WeatherService : IWeatherService
    {
        private IOpenMeteoCurrentWeatherRepository _currenrWeatherRepository;
        private IOpenMeteoDailyWeatherRepository _dailyWeatherRepository;
        private IWeatherLocationRepository _weatherLocationRepository;

        public WeatherService(
            IOpenMeteoCurrentWeatherRepository currenrWeatherRepository,
            IOpenMeteoDailyWeatherRepository dailyWeatherRepository,
            IWeatherLocationRepository weatherLocationRepository)
        {
            _currenrWeatherRepository = currenrWeatherRepository;
            _dailyWeatherRepository = dailyWeatherRepository;
            _weatherLocationRepository = weatherLocationRepository;
        }
    }
}
