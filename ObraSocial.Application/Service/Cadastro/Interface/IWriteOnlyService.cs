namespace ObraSocial.Application.Service.Cadastro.Interface
{
    public interface IWriteOnlyService<T>
    {
        Task<T?> AddAsync(T entityDto);
        Task UpdateAsync(T entityDto);
        Task DeleteAsync(int id);

    }
}
