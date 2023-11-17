using Data.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace Data.Entities.Measurement
{
    public class Room: IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
