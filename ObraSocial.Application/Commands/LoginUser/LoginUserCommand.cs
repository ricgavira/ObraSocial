using MediatR;
using ObraSocial.Application.Dtos;

namespace ObraSocial.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<UsuarioLoginDto>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}