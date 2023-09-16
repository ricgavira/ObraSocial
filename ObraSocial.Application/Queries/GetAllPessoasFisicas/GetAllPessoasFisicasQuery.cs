using MediatR;
using ObraSocial.Application.Dtos;

namespace ObraSocial.Application.Queries.GetAllPessoasFisicas
{
    public class GetAllPessoasFisicasQuery : IRequest<List<PessoaFisicaDto>>
    {
    }
}