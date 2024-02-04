namespace ObraSocial.Application.Service.Cadastro.Interface
{
    public interface IReadOnlyService<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();        
    }
}
