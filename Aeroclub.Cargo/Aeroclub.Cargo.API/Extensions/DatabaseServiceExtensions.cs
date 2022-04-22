using Aeroclub.Cargo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aeroclub.Cargo.API.Extensions
{
    public static class DatabaseServiceExtensions
    {
        public static IServiceCollection AddDBContextServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CargoContext>(option =>
                option.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
