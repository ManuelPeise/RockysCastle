using Data.Entities.Interfaces;
using Data.Entities.Weather;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Measurement
{
    public class MeasurementAdress : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public int HouseNumber { get; set; }
        [MinLength(5), MaxLength(5)]
        public int PostalCode { get; set; }
        public string City { get; set; } = string.Empty;

        [ForeignKey("Id")]
        public Guid LocationId { get; set; }
        public WeatherLocation Location { get; set; } = new WeatherLocation();
    }
}
