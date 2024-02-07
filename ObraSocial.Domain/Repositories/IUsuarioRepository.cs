using ObraSocial.Domain.Entities;

namespace ObraSocial.Domain.Repositories
{
    public interface IUsuarioRepository : IReadOnlyRepository<Usuario>, IWriteOnlyRepository<Usuario>
    {
        Usuario? GetUsuarioByLoginAndPasswordAsync(string login, string passwordHash);
        bool GetByLoginAsync(string login);
    }
}
