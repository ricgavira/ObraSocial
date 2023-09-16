using AutoMapper;
using MediatR;
using ObraSocial.Application.Dtos;
using ObraSocial.Domain.Repositories;

namespace ObraSocial.Application.Queries.GetAllUsuarios
{
    public class GetAllUsuariosQueryHandler : IRequestHandler<GetAllUsuariosQuery, List<UsuarioDto>>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public GetAllUsuariosQueryHandler(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<List<UsuarioDto>> Handle(GetAllUsuariosQuery request, CancellationToken cancellationToken)
        {
            var usuarios = await _usuarioRepository.GetAllAsync();
            return _mapper.Map<List<UsuarioDto>>(usuarios);
        }
    }
}