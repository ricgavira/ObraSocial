using MediatR;
using ObraSocial.Application.Resources;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Application.Commands.DeleteUsuario
{
    public class DeleteUsuarioCommandHandler : IRequestHandler<DeleteUsuarioCommand, Unit>
    {
        private readonly IUnitOfWork<Usuario> _unitOfWork;
        private readonly IUsuarioRepository _usuarioRepository;

        public DeleteUsuarioCommandHandler(IUnitOfWork<Usuario> unitOfWork, 
                                           IUsuarioRepository usuarioRepository)
        {
            _unitOfWork = unitOfWork;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Unit> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(request.Id);

            if (usuario == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundUsuario);

            await _unitOfWork.DeleteAsync(usuario);
            await _unitOfWork.SaveChangesAsync();

            return Unit.Value;
        }
    }
}