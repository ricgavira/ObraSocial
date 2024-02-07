using ObraSocial.Domain.Entities;

namespace ObraSocial.Domain.Repositories
{
    public interface IWriteOnlyRepository<T> where T : BaseEntity<T>
    {
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
