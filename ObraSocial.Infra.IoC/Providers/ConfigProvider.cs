using Microsoft.Extensions.DependencyInjection;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Infra.IoC.Providers
{
    public static class ConfigProvider
    {
        public static IServiceCollection AddConfig(this IServiceCollection services)
        {            
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            return services;
        }
    }
}