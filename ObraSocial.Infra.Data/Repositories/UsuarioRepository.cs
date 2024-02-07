using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IUnitOfWork<Usuario> _unitOfWork;

        public UsuarioRepository(IUnitOfWork<Usuario> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Usuario> AddAsync(Usuario usuario)
        {
            await _unitOfWork.BeginTransactionAsync();
            var retorno = await _unitOfWork.AddAsync(usuario);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();

            return retorno;
        }

        public async Task DeleteAsync(Usuario usuario)
        {
            await _unitOfWork.BeginTransactionAsync();
            await _unitOfWork.DeleteAsync(usuario);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            await _unitOfWork.BeginTransactionAsync();
            await _unitOfWork.UpdateAsync(usuario);
            await _unitOfWork.SaveChangesAsync();
            await _unitOfWork.CommitTransactionAsync();
        }

        public async Task<ICollection<Usuario>> GetAllAsync()
        {
            return await _unitOfWork.GetAllAsync();
        }

        public async Task<Usuario?> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetByIdAsync(id);
        }

        public Usuario? GetUsuarioByLoginAndPasswordAsync(string login, string passwordHash)
        {
            return _unitOfWork.FindByWhere(x => x.Login == login && 
                                                      x.Password == passwordHash);
        }

        public bool GetByLoginAsync(string login)
        {
            var result = _unitOfWork.FindByWhere(x => x.Login == login);

            return result != null;
        }
    }
}