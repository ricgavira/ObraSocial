using Microsoft.EntityFrameworkCore;
using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;
using ObraSocial.Infra.Data.Context;

namespace ObraSocial.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Usuario> AddAsync(Usuario usuario)
        {
            await _appDbContext.Usuarios.AddAsync(usuario);
            return usuario;
        }

        public Task DeleteAsync(Usuario usuario)
        {
            _appDbContext.Remove(usuario);
            return Task.CompletedTask;
        }

        public async Task<ICollection<Usuario>> GetAllAsync()
        {
            return await _appDbContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario?> GetByIdAsync(int id)
        {
            return await _appDbContext.Usuarios
                                      .SingleOrDefaultAsync(x => x.Id == id);

        }

        public async Task<Usuario?> GetUsuarioByLoginAndPasswordAsync(string login, string passwordHash)
        {
            return await _appDbContext.Usuarios
                                      .SingleOrDefaultAsync(x => x.Login == login && 
                                                                 x.Password == passwordHash);
        }

        public Task UpdateAsync(Usuario usuario)
        {
            _appDbContext.Update(usuario);
            return Task.CompletedTask;
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