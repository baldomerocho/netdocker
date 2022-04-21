using TokenApp3.Data;
using Microsoft.EntityFrameworkCore;

namespace TokenApp3
{
    public class WeatherForecast
    {
        public WeatherForecast(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GuardadorContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexionDB")));
        }
    }
}