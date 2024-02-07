using ObraSocial.Domain.Entities;

namespace ObraSocial.Domain.Repositories
{
    public interface IReadOnlyRepository<T> where T : BaseEntity<T>
    {
        Task<T?> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}