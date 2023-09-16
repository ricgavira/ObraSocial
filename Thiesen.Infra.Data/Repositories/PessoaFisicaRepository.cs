using Microsoft.EntityFrameworkCore;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.Context;

namespace ObraSocial.Infra.Data.Repositories
{
    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        private readonly AppDbContext _appDbContext;

        public PessoaFisicaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<PessoaFisica> AddAsync(PessoaFisica pessoaFisica)
        {
            await _appDbContext.PessoasFisicas.AddAsync(pessoaFisica);
            return pessoaFisica;
        }

        public Task DeleteAsync(PessoaFisica pessoaFisica)
        {
            _appDbContext.Remove(pessoaFisica);
            return Task.CompletedTask;
        }

        public async Task<ICollection<PessoaFisica>> GetAllAsync()
        {
            return await _appDbContext.PessoasFisicas
                                      .ToListAsync();
        }

        public async Task<IEnumerable<PessoaFisica>> GetByCPFAsync(string CPF)
        {
            return await _appDbContext.PessoasFisicas
                                      .Where(x => x.Cpf == CPF)
                                      .ToListAsync();
        }

        public async Task<PessoaFisica?> GetByIdAsync(int id)
        {
            return await _appDbContext.PessoasFisicas.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<PessoaFisica>> GetByRangeIdadeAsync(int initial, int final)
        {
            return await _appDbContext.PessoasFisicas
                                      .Where(x => x.Idade >= initial && x.Idade <= final)
                                      .ToListAsync();
        }

        public Task UpdateAsync(PessoaFisica pessoaFisica)
        {
            _appDbContext.PessoasFisicas.Update(pessoaFisica);
            return Task.CompletedTask;
        }
    }
}