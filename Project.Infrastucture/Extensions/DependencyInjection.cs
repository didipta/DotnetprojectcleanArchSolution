using Microsoft.Extensions.DependencyInjection;
using Project.Appliction.Interfaces;
using Project.Appliction.Services.Implementation;
using Project.Appliction.Services;
using Project.Infrastucture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastucture.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            // Register the generic repository
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

            // Register generic services
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            // Register product-specific services
            services.AddScoped<ProductServices>();

            return services;
        }
    }
}
