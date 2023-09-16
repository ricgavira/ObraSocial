using MediatR;
using ObraSocial.Application.Dtos.Cadastro;

namespace ObraSocial.Application.Queries.GetUsuarioById
{
    public class GetUsuarioByIdQuery : IRequest<UsuarioDto>
    {
        public GetUsuarioByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}