namespace ObraSocial.Infra.Data.UnitOfWork
{
    public interface IUnitOfWork<T>
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task<int> SaveChangesAsync();
    }
}