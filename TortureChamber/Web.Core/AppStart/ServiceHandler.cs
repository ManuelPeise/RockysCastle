using Data.Database;
using Logic.Shared;
using Logic.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Web.Core.AppStart
{
    public static class ServiceHandler
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDataContext>(options =>
            {
                options.UseMySQL(builder.Configuration.GetConnectionString("AppDataContext"));
            });

            builder.Services.AddScoped<IHumidityProtocolRepository, HumidityProtocolRepository>();

            // Add services to the container.
            builder.Services.AddRazorPages();
        }
    }
}
