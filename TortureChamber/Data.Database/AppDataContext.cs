using Data.Entities.Measurement;
using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options) : base(options) { }

        public DbSet<HumidityLogEntry> HumidityLogTable { get; set; }
        public DbSet<Room> RoomTable { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}