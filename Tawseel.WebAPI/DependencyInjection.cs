using Microsoft.EntityFrameworkCore;
using Tawseel.Infrastructure.Data;

namespace Tawseel.WebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WriteDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("WriteDb"))
            );
            services.AddDbContext<ReadDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("ReadDb"))
            );
            return services;
        }
    }
}
