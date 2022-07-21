using Microsoft.Extensions.DependencyInjection;
using RocWay.Transversal.Common;
using RocWay.Infrastructure.Data.EFCore;
using RocWay.Infrastructure.Repository;
using RocWay.Application.Interface;
using RocWay.Application.Main;
using RocWay.Domain.Interface;
using RocWay.Domain.Core;
using RocWay.Infrastructure.Interface;
using RocWay.Transversal.Loggin;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace RocWay.Transversal.Modules
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddSingleton<IConfiguration>(configuration);
            //services.AddSingleton<IConnectionFactory, RocWayContextFactory>();
            services.AddDbContext<RocWayContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("RocWayDB")));
            services.AddScoped<ICustomerApplication, CustomerApplication>();
            services.AddScoped<ICustomerDomain, CustomerDomain>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            return services;
        }
    }
}
