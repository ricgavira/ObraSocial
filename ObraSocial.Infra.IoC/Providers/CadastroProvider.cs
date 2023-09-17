using Microsoft.Extensions.DependencyInjection;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.Repositories;

namespace ObraSocial.Infra.IoC.Providers
{
    public static class CadastroProvider
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IPessoaFisicaRepository, PessoaFisicaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}