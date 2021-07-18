using COVID.Context;
using COVID.Interface;
using COVID.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Configuration
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<COVIDContext>();
            
            services.AddScoped<IVW02_COVID_ONLINE, VW02_COVID_ONLINERepository>();
            services.AddScoped<IVW01_COVID_UF, VW01_COVID_UFRepository>();

            return services;
        }
    }
}
