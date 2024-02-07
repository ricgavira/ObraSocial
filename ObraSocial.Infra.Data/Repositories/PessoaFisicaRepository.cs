using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Infra.Data.Repositories
{
    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        private readonly IUnitOfWork<PessoaFisica> _unitOfWork;

        public PessoaFisicaRepository(IUnitOfWork<PessoaFisica> unitOfWork)
        {
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

        public bool ExistByCPFAsync(string CPF)
        {
            var pf = GetByCPFAsync(CPF);
            return pf != null && pf.Any();
        }

        public IEnumerable<PessoaFisica> GetByCPFAsync(string CPF)
        {
            return _unitOfWork.FindAllByWhere(p => p.Cpf == CPF);
        }

        public IEnumerable<PessoaFisica> GetByRangeIdadeAsync(int initial, int final)
        {
            return _unitOfWork.FindAllByWhere(x => x.Idade >= initial && x.Idade <= final);
        }
    }
}