using Data.Database;
using Data.Entities.Weather;
using Logic.Shared;
using Logic.Weather.Extensions;
using Logic.Weather.Interfaces;
using Logic.Weather.Models;

namespace Logic.Weather
{
    public class WeatherLocationRepository: GenericRepository<WeatherLocation>, IWeatherLocationRepository
    {
        private readonly IWeatherLocationHttpClient _locationHttpClient;
        public WeatherLocationRepository(AppDataContext context, IWeatherLocationHttpClient locationHttpClient) : base(context)
        {
            _locationHttpClient = locationHttpClient;
        }

        public async Task<WeatherLocation?> QueryGeoLocationDataAsync(string city)
        {
            Guid id = Guid.NewGuid();

            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("name", city),
                new KeyValuePair<string, object>("count", 1),
                new KeyValuePair<string, object>("language", "de"),
                new KeyValuePair<string, object>("format", "json")
            };

            var response = await _locationHttpClient.GetAsync<GeoLocations>("", parameters);

            if (await IsNewGeoLocation(city))
            {
                id = await Insert(response.Results[0].ToEntity());
            }

            return await GetById(id);
        }

        public async Task<WeatherLocation?> GetGeoLocationDataAsync(string city)
        {
            var all = await GetAll();

            return all.FirstOrDefault(x => x.Name.ToLower().Equals(city.ToLower()));
        }

        private async Task<bool> IsNewGeoLocation(string name)
        {
            var all = await GetAll();

            return !all.Where(x => x.Name.ToLower().Equals(name.ToLower())).Any();
          
        }
    }
}
