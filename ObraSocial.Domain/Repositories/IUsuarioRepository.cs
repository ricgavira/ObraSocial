using ObraSocial.Domain.Entities;

namespace ObraSocial.Domain.Repositories
{
    public interface IUsuarioRepository : IReadOnlyRepository<Usuario>, IWriteOnlyRepository<Usuario>
    {
        Task<Usuario?> GetUsuarioByLoginAndPasswordAsync(string login, string passwordHash);
        Task<bool> GetByLoginAsync(string login);
    }
}
