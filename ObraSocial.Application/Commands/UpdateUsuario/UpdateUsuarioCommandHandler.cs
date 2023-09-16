using AutoMapper;
using MediatR;
using ObraSocial.Application.Resources;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Application.Commands.UpdateUsuario
{
    public class UpdateUsuarioCommandHandler : IRequestHandler<UpdateUsuarioCommand, Unit>
    {
        private readonly IUnitOfWork<Usuario> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;

        public UpdateUsuarioCommandHandler(IUnitOfWork<Usuario> unitOfWork, 
                                           IMapper mapper, 
                                           IUsuarioRepository usuarioRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Unit> Handle(UpdateUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(request.Id);

            if (usuario == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundUsuario);

            _mapper.Map(request, usuario);

            await _unitOfWork.UpdateAsync(usuario);
            await _unitOfWork.SaveChangesAsync();

            return Unit.Value;
        }
    }
}