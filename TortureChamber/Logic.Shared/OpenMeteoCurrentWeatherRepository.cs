using Data.Database;
using Data.Entities.Weather;
using Logic.Shared.Interfaces;


namespace Logic.Shared
{
    public class OpenMeteoCurrentWeatherRepository : GenericRepository<CurrentWeatherData>, IOpenMeteoCurrentWeatherRepository
    {
        public OpenMeteoCurrentWeatherRepository(AppDataContext context): base(context)
        {
            
        }
    }
}
