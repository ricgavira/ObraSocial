using AutoMapper;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Application.Resources;
using ObraSocial.Application.Service.Cadastro.Interface;
using ObraSocial.Application.Helpers;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;

namespace ObraSocial.Application.Service.Cadastro
{
    public class PessoaFisicaService : IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository _repository;
        private readonly IMapper _mapper;

        public PessoaFisicaService(IPessoaFisicaRepository repository, 
                                   IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PessoaFisicaDto?> AddAsync(PessoaFisicaDto pessoaFisicaDto)
        {
            bool pessoaFisicaExiste = _repository.ExistByCPFAsync(StringHelper.OnlyNumber(pessoaFisicaDto?.CPF ?? ""));

            if (pessoaFisicaExiste)
                return null;

            var pessoaFisica = _mapper.Map<PessoaFisica>(pessoaFisicaDto);

            var retorno = await _repository.AddAsync(pessoaFisica);

            return _mapper.Map<PessoaFisicaDto>(retorno);
        }

        public async Task DeleteAsync(int id)
        {
            var pessoaFisica = await _repository.GetByIdAsync(id);

            if (pessoaFisica == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundPessoaFisica);

            await _repository.DeleteAsync(pessoaFisica);           
        }

        public async Task<IEnumerable<PessoaFisicaDto>> GetAllAsync()
        {
            var pessoasFisicas = await _repository.GetAllAsync();

            return _mapper.Map<List<PessoaFisicaDto>>(pessoasFisicas);
        }

        public async Task<IEnumerable<PessoaFisicaSimpleDto>> GetAllSimpleAsync()
        {
            var pessoasFisicas = await _repository.GetAllAsync();

            return _mapper.Map<List<PessoaFisicaSimpleDto>>(pessoasFisicas);
        }

        public async Task<PessoaFisicaDto> GetByIdAsync(int id)
        {
            var pessoaFisica = await _repository.GetByIdAsync(id);

            return _mapper.Map<PessoaFisicaDto>(pessoaFisica);
        }

        public async Task UpdateAsync(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = await _repository.GetByIdAsync(pessoaFisicaDto.Id);

            if (pessoaFisica == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundPessoaFisica);

            _mapper.Map(pessoaFisicaDto, pessoaFisica);
            await _repository.UpdateAsync(pessoaFisica);
        }
    }
}