using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Domain.Repositories
{
    public interface IUsuarioRepository : IWriteOnlyRepository<Usuario>, IReadOnlyRepository<Usuario>
    {
        Task<Usuario?> GetUsuarioByLoginAndPasswordAsync(string login, string passwordHash);
        Task<bool> GetByLoginAsync(string login);
    }
}
