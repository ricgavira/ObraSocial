namespace ObraSocial.Application.Service.Cadastro.Interface
{
    public interface IWriteOnlyService<T>
    {
        Task<T?> CreateAsync(T entityDto);
        Task UpdateAsync(T entityDto);
        Task DeleteAsync(int id);

    }
}
