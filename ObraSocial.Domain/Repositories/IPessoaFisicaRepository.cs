using ObraSocial.Domain.Entities;

namespace ObraSocial.Domain.Repositories
{
    public interface IPessoaFisicaRepository : IWriteOnlyRepository<PessoaFisica>, IReadOnlyRepository<PessoaFisica>
    {
        Task<IEnumerable<PessoaFisica>> GetByCPFAsync(string CPF);
        Task<IEnumerable<PessoaFisica>> GetByRangeIdadeAsync(int initial, int final);
    }
}
