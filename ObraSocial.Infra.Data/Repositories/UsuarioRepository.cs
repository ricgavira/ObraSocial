using Microsoft.EntityFrameworkCore;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.Context;
using ObraSocial.Infra.Data.UnitOfWork;

namespace ObraSocial.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly IUnitOfWork<Usuario> _unitOfWork;

        public UsuarioRepository(AppDbContext appDbContext, IUnitOfWork<Usuario> unitOfWork)
        {
            _appDbContext = appDbContext;
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

        public async Task<Usuario?> GetUsuarioByLoginAndPasswordAsync(string login, string passwordHash)
        {
            return await _appDbContext.Usuarios
                                      .SingleOrDefaultAsync(x => x.Login == login && 
                                                                 x.Password == passwordHash);
        }

        public async Task<bool> GetByLoginAsync(string login)
        {
            var result = await _appDbContext.Usuarios
                                            .Where(x => x.Login == login)
                                            .AnyAsync();

            return result;
        }
    }
}