using Microsoft.EntityFrameworkCore;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.Context;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Infra.Data.Repositories
{
    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IUnitOfWork<PessoaFisica> _unitOfWork;

        public PessoaFisicaRepository(AppDbContext appDbContext, IUnitOfWork<PessoaFisica> unitOfWork)
        {
            _appDbContext = appDbContext;
            _unitOfWork = unitOfWork;
        }

        public async Task<PessoaFisica> AddAsync(PessoaFisica pessoaFisica)
        {
            await _unitOfWork.BeginTransactionAsync();
            var retorno = await _unitOfWork.AddAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();

            return retorno;
        }

        public async Task DeleteAsync(PessoaFisica pessoaFisica)
        {
            await _unitOfWork.BeginTransactionAsync();
            await _unitOfWork.DeleteAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();
        }

        public async Task UpdateAsync(PessoaFisica pessoaFisica)
        {
            await _unitOfWork.BeginTransactionAsync();
            await _unitOfWork.UpdateAsync(pessoaFisica);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();
        }

        public async Task<PessoaFisica?> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetByIdAsync(id);
        }

        public async Task<ICollection<PessoaFisica>> GetAllAsync()
        {
            return await _unitOfWork.GetAllAsync();
        }

        public async Task<bool> ExistByCPFAsync(string CPF)
        {
            return await _appDbContext.PessoasFisicas
                                      .Where(x => x.Cpf == CPF)
                                      .AnyAsync();
        }

        public async Task<IEnumerable<PessoaFisica>> GetByCPFAsync(string CPF)
        {
            return await _appDbContext.PessoasFisicas
                                      .Where(x => x.Cpf == CPF)
                                      .ToListAsync();
        }

        public async Task<IEnumerable<PessoaFisica>> GetByRangeIdadeAsync(int initial, int final)
        {
            return await _appDbContext.PessoasFisicas
                                      .Where(x => x.Idade >= initial && x.Idade <= final)
                                      .ToListAsync();
        }
    }
}