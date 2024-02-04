using ObraSocial.Application.Dtos.Cadastro;

namespace ObraSocial.Application.Service.Cadastro.Interface
{
    public interface IPessoaFisicaService : IReadOnlyService<PessoaFisicaDto>, IWriteOnlyService<PessoaFisicaDto>
    {
        Task<IEnumerable<PessoaFisicaSimpleDto>> GetAllSimpleAsync();
    }
}