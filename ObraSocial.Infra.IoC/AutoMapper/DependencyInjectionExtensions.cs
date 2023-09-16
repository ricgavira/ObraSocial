using Microsoft.Extensions.DependencyInjection;
using ObraSocial.Application.Mapping;

namespace ObraSocial.Infra.IoC.AutoMapper
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfiles));

            return services;
        }
    }
}
