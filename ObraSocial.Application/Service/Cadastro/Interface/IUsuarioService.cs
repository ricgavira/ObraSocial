using ObraSocial.Application.Dtos.Cadastro;

namespace ObraSocial.Application.Service.Cadastro.Interface
{
    public interface IUsuarioService : IReadOnlyService<UsuarioDto>, IWriteOnlyService<UsuarioDto>
    {
        UsuarioLoginDto LoginUser(LoginDto loginDto);
    }
}