using Data.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace Data.Entities.Weather
{
    public class WeatherLocation: IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Country { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
    }
}
