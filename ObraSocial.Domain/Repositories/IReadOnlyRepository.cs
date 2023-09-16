namespace ObraSocial.Domain.Repositories
{
    public interface IReadOnlyRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}
