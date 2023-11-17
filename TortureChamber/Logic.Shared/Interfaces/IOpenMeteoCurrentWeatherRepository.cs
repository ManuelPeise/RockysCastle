using Data.Entities.Measurement;
using Data.Entities.Weather;

namespace Logic.Shared.Interfaces
{
    public interface IOpenMeteoCurrentWeatherRepository: IGenericRepository<CurrentWeatherData>
    {
    }
}
