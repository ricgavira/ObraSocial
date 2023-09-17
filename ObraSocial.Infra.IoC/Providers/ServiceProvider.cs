using Microsoft.Extensions.DependencyInjection;
using ObraSocial.Application.Service.Cadastro;
using ObraSocial.Application.Service.Cadastro.Interface;
using ObraSocial.Domain.Services;
using ObraSocial.Infra.Data.AuthService;

namespace ObraSocial.Infra.IoC.Providers
{
    public static class ServiceProvider
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IPessoaFisicaService, PessoaFisicaService>();
            services.AddScoped <IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
