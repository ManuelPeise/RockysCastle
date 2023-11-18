using Data.Entities.Weather;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Weather.Models
{
    public class CurrentWeather
    {
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
        public Location Location { get; set; } = new Location();
    }
}
