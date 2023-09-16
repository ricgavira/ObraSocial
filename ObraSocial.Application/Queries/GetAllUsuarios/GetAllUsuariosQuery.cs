using MediatR;
using ObraSocial.Application.Dtos.Cadastro;

namespace ObraSocial.Application.Queries.GetAllUsuarios
{
    public class GetAllUsuariosQuery : IRequest<List<UsuarioDto>>
    {
    }
}
