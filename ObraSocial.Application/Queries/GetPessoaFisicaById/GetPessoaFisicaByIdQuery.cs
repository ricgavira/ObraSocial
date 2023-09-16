using MediatR;
using ObraSocial.Application.Dtos.Cadastro;

namespace ObraSocial.Application.Queries.GetPessoaFisicaById
{
    public class GetPessoaFisicaByIdQuery : IRequest<PessoaFisicaDto>
    {
        public GetPessoaFisicaByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
