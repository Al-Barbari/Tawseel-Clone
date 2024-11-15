using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tawseel.CrossCutting.Mappings;

namespace Tawseel.CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCrossCutting(this IServiceCollection services)
        {
            AddMappings(services);

            return services;
        }
        public static void AddMappings( IServiceCollection services)
        {
            // Add AutoMapper configuration
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<QueryMappingProfile>();
                cfg.AddProfile<CommandMappingProfile>();
            });            
        }
    }
}
