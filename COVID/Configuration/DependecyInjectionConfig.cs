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
            services.AddScoped<ITB_COVID_01, TB_COVID_01Repository>();
            return services;
        }
    }
}
