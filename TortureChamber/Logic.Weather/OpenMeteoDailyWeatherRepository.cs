using Data.Database;
using Data.Entities.Weather;
using Logic.Shared;
using Logic.Weather.Extensions;
using Logic.Weather.Helpers;
using Logic.Weather.Interfaces;
using Logic.Weather.Models;

namespace Logic.Weather
{
    public class OpenMeteoDailyWeatherRepository: GenericRepository<DailyWeatherData>, IOpenMeteoDailyWeatherRepository
    {
        private readonly IWeatherHttpClient _weatherHttpClient;

        public OpenMeteoDailyWeatherRepository(AppDataContext context, IWeatherHttpClient weatherHttpClient) : base(context)
        {
            _weatherHttpClient = weatherHttpClient;
        }

        public async Task ImportWeatherDailyData(WeatherLocation weatherLocation, int historyMonthCount, int forecastDays)
        {
            var importDate = DateTime.UtcNow;

            var requestParameters = WeatherRequestHelper.GetDailyWeatherParameters(
                weatherLocation, importDate.AddMonths(-historyMonthCount), importDate.AddDays(forecastDays));

            var response = await _weatherHttpClient.GetAsync<WeatherDataResponse>("forecast", requestParameters);

            var entityCollection = response.Daily.ToEntityList(weatherLocation);

            await AddHistoricalAsync(entityCollection, importDate);

            await AddAsync(entityCollection, importDate);
        }

        private async Task AddHistoricalAsync(List<DailyWeatherData> entities, DateTime importDate)
        {
            // get historical entities
            var entitiesToInsert = entities.Where(x => x.TimeStamp.Date < importDate.Date).ToList();

            await InsertRange(entitiesToInsert);
        }

        // TODO check this
        private async Task AddAsync(List<DailyWeatherData> entities, DateTime importDate)
        {
            // get entities of current day 
            var entitiesToInsert = entities.Where(x => x.TimeStamp.Date > importDate.AddDays(-1).Date).ToList();

            await InsertRange(entitiesToInsert);
        }
    }
}
