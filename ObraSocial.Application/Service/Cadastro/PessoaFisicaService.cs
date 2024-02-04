using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using ObraSocial.Application.Dtos.Cadastro;
using ObraSocial.Application.Resources;
using ObraSocial.Application.Service.Cadastro.Interface;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Helpers;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Application.Service.Cadastro
{
    public class PessoaFisicaService : IPessoaFisicaService
    {
        private readonly IUnitOfWork<PessoaFisica> _unitOfWork;
        private readonly IPessoaFisicaRepository _repository;
        private readonly IMapper _mapper;

        public PessoaFisicaService(IPessoaFisicaRepository repository, 
                                   IMapper mapper, 
                                   IUnitOfWork<PessoaFisica> unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<PessoaFisicaDto?> CreateAsync(PessoaFisicaDto pessoaFisicaDto)
        {
            Boolean pessoaFisicaExiste = await _repository.ExistByCPFAsync(StringHelper.OnlyNumber(pessoaFisicaDto?.CPF ?? ""));

            if (pessoaFisicaExiste)
                return null;

            var pessoaFisica = _mapper.Map<PessoaFisica>(pessoaFisicaDto);

            await _unitOfWork.BeginTransactionAsync();
            var retorno = await _repository.CreateAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();

            return _mapper.Map<PessoaFisicaDto>(retorno);
        }

        public async Task DeleteAsync(int id)
        {
            var pessoaFisica = await _repository.GetByIdAsync(id);

            if (pessoaFisica == null)
                throw new KeyNotFoundException(ValidationMessages.NotFoundPessoaFisica);

            await _repository.DeleteAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
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
            await _unitOfWork.BeginTransactionAsync();
            await _repository.UpdateAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();
        }
    }
}