using MediatR;
using ObraSocial.Domain.Enums;

namespace ObraSocial.Application.Commands.UpdateUsuario
{
    public class UpdateUsuarioCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}