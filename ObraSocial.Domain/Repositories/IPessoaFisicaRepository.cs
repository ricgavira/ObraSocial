using ObraSocial.Domain.Entities;

namespace ObraSocial.Domain.Repositories
{
    public interface IPessoaFisicaRepository: IReadOnlyRepository<PessoaFisica>, IWriteOnlyRepository<PessoaFisica>
    {
        Task<IEnumerable<PessoaFisica>> GetByCPFAsync(string CPF);
        Task<bool> ExistByCPFAsync(string CPF);
        Task<IEnumerable<PessoaFisica>> GetByRangeIdadeAsync(int initial, int final);
    }
}
