using Data.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Weather
{
    public class CurrentWeatherData: IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double TempFeelsLike { get; set; }
        public double Rain { get; set; }
        public double Showers { get; set; }
        public double SnowFall { get; set; }
        public int WeatherCode { get; set; }
        public int Clouds { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindDirection { get; set; }
        public double WindGustSpeed { get; set; }
        [ForeignKey("Id")]
        public Guid LocationId { get; set; }
        public WeatherLocation Location { get; set; } = new WeatherLocation();
    }
}
