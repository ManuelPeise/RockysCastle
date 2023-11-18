using Data.Database;
using Logic.Measurement;
using Logic.Measurement.Interfaces;
using Logic.Weather;
using Logic.Weather.Interfaces;
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
            builder.Services.AddScoped<IMeasurementAdressRepository, MeasurementAdressRepository>();

            // weather services
            builder.Services.AddScoped<IOpenMeteoCurrentWeatherRepository, OpenMeteoCurrentWeatherRepository>();
            builder.Services.AddScoped<IOpenMeteoDailyWeatherRepository, OpenMeteoDailyWeatherRepository>();
            builder.Services.AddScoped<IWeatherLocationRepository, WeatherLocationRepository>();

            builder.Services.AddScoped<IWeatherService, WeatherService>();
            // Add services to the container.
            builder.Services.AddRazorPages();
        }
    }
}
