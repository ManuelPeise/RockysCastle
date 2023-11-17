using Data.Entities.Interfaces;

namespace Data.Entities.Weather
{
    public class WeatherData: IEntity
    {
        public Guid Id { get; set; }
    }
}
