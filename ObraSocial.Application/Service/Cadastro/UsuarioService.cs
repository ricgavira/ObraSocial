using AutoMapper;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Application.Resources;
using ObraSocial.Application.Service.Cadastro.Interface;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Domain.Services;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Application.Service.Cadastro
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork<Usuario> _unitOfWork;
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public UsuarioService(IUnitOfWork<Usuario> unitOfWork, 
                              IUsuarioRepository repository, 
                              IMapper mapper, 
                              IAuthService authService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
            _authService = authService;
        }

        public async Task<UsuarioDto?> CreateAsync(UsuarioDto usuarioDto)
        {
            bool usuarioExiste = await _repository.GetByLoginAsync(usuarioDto.Login);

            if (usuarioExiste)
                return null;

            usuarioDto.Password = _authService.ComputedSha256Hash(usuarioDto.Password);

            var usuario = _mapper.Map<Usuario>(usuarioDto);

            await _unitOfWork.BeginTransactionAsync();
            var retorno = await _repository.CreateAsync(usuario);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();

            return _mapper.Map<UsuarioDto>(retorno);
        }

        public async Task DeleteAsync(int id)
        {
            var usuario = await _repository.GetByIdAsync(id);

            if (usuario == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundUsuario);

            await _repository.DeleteAsync(usuario);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var usuarios = await _repository.GetAllAsync();
            return _mapper.Map<List<UsuarioDto>>(usuarios);
        }

        public async Task<UsuarioDto> GetByIdAsync(int id)
        {
            var usuario = await _repository.GetByIdAsync(id);
            return _mapper.Map<UsuarioDto>(usuario);
        }

        public async Task<UsuarioLoginDto> LoginUser(LoginDto loginDto)
        {
            var passwordHash = _authService.ComputedSha256Hash(loginDto.Password);
            var usuario = await _repository.GetUsuarioByLoginAndPasswordAsync(loginDto.Login, passwordHash);

            if (usuario == null)
                return new UsuarioLoginDto(loginDto.Login, ValidationMessages.InvalidLogin);

            var token = _authService.GenerateJwtToken(usuario.Login, usuario.Role.ToString());

            return new UsuarioLoginDto(usuario.Login, token);
        }

        public async Task UpdateAsync(UsuarioDto usuarioDto)
        {
            var usuario = await _repository.GetByIdAsync(usuarioDto.Id);

            if (usuario == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundUsuario);

            _mapper.Map(usuarioDto, usuario);

            await _repository.UpdateAsync(usuario);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}