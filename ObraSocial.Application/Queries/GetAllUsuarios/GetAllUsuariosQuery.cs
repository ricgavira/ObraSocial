using MediatR;
using ObraSocial.Application.Dtos;

namespace ObraSocial.Application.Queries.GetAllUsuarios
{
    public class GetAllUsuariosQuery : IRequest<List<UsuarioDto>>
    {
    }
}
