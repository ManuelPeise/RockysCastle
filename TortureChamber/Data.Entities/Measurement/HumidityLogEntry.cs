using Data.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Measurement
{
    public class HumidityLogEntry : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public int Humidity { get; set; }
        public bool Ventilated { get; set; }
        public int? VentilatedHumidity { get; set; }
        [ForeignKey("Id")]
        public Guid RoomId { get; set; }
        public Room Room { get; set; } = new Room();

        [ForeignKey("Id")]
        public Guid WeatherDataId { get; set; }
        public Room WeatherData { get; set; } = new Room();

    }
}
