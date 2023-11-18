using Data.Database;
using Data.Entities.Weather;
using Logic.Shared;
using Logic.Weather.Interfaces;
using Logic.Weather.Helpers;
using Logic.Weather.Models;
using Logic.Weather.Extensions;

namespace Logic.Weather
{
    public class OpenMeteoCurrentWeatherRepository : GenericRepository<CurrentWeatherData>, IOpenMeteoCurrentWeatherRepository
    {
        private readonly IWeatherHttpClient _weatherHttpClient;

        public OpenMeteoCurrentWeatherRepository(AppDataContext context, IWeatherHttpClient weatherHttpClient) : base(context)
        {

            _weatherHttpClient = weatherHttpClient;
        }

        public async Task ImportCurrentWeatherData(WeatherLocation weatherLocation, int forecastDays)
        {
            var importDate = DateTime.UtcNow;

            var requestParameters = WeatherRequestHelper.GetCurrentWeatherRequestParameters(
                weatherLocation, forecastDays);

            var response = await _weatherHttpClient.GetAsync<WeatherDataResponse>("forecast", requestParameters);

            var entity = response.Current.ToEntity(weatherLocation.Id);

            await Insert(entity);
        }

        public async Task<CurrentWeather?> GetCurrentWeather(WeatherLocation weatherLocation, DateTime date)
        {
            var entities = await GetAll();

            return entities
                .Where(x =>
                    x.Location.Id == weatherLocation.Id
                    && x.TimeStamp.Date == date.Date)
                .FirstOrDefault()?.ToModel();


        }
    }
}
