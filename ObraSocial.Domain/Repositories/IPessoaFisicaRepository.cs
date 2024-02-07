using ObraSocial.Domain.Entities;

namespace ObraSocial.Domain.Repositories
{
    public interface IPessoaFisicaRepository: IReadOnlyRepository<PessoaFisica>, IWriteOnlyRepository<PessoaFisica>
    {
        IEnumerable<PessoaFisica> GetByCPFAsync(string CPF);
        bool ExistByCPFAsync(string CPF);
        IEnumerable<PessoaFisica> GetByRangeIdadeAsync(int initial, int final);
    }
}
