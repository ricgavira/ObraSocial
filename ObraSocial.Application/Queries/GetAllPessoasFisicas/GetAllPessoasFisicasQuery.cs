using MediatR;
using ObraSocial.Application.Dtos.Cadastro;

namespace ObraSocial.Application.Queries.GetAllPessoasFisicas
{
    public class GetAllPessoasFisicasQuery : IRequest<List<PessoaFisicaDto>>
    {
    }
}