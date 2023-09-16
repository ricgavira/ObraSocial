namespace ObraSocial.Domain.Repositories
{
    public interface IWriteOnlyRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
