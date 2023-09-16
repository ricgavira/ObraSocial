using MediatR;
using ObraSocial.Application.Dtos;
using ObraSocial.Domain.Repositories;
using ObraSocial.Domain.Services;

namespace ObraSocial.Application.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, UsuarioLoginDto?>
    {
        private readonly IAuthService _authService;
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginUserCommandHandler(IAuthService authService, 
                                       IUsuarioRepository usuarioRepository)
        {
            _authService = authService;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioLoginDto?> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputedSha256Hash(request.Password);

            var usuario = await _usuarioRepository.GetUsuarioByLoginAndPasswordAsync(request.Login, passwordHash);

            if (usuario == null)
                return null;

            var token = _authService.GenerateJwtToken(usuario.Login, usuario.Role.ToString());

            return new UsuarioLoginDto(usuario.Login, token);
        }
    }
}