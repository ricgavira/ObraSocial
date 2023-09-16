using Microsoft.Extensions.DependencyInjection;
using ObraSocial.Application.Commands.CreatePessoaFisica;
using ObraSocial.Domain.Services;
using ObraSocial.Infra.Data.AuthService;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Infra.IoC.Providers
{
    public static class ConfigProvider
    {
        public static IServiceCollection AddConfig(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            services.AddMediatR();

            return services;
        }

        public static IServiceCollection AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreatePessoaFisicaCommand).Assembly));

            return services;
        }
    }
}