using Microsoft.EntityFrameworkCore;

namespace Data.Database
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}