using Data.Entities.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Entities.Weather
{
    public class DailyWeatherData : IEntity
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int WeatherCode { get; set; }
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        public double TempFeelsMax { get; set; }
        public double TempFeelsMin { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public double SunShineDuration { get; set; }
        public double RainSum { get; set; }
        public double ShowersSum { get; set; }
        public double SnowSum { get; set; }
        public double WindSpeed { get; set; }
        public double WindGusts { get; set; }
        public int WindDirection { get; set; }
        [ForeignKey("Id")]
        public Guid LocationId { get; set; }
        public WeatherLocation Location { get; set; }
    }
}
