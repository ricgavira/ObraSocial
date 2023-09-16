using Microsoft.EntityFrameworkCore.Storage;
using ObraSocial.Infra.Data.Context;

namespace ObraSocial.Infra.Data.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T>
    {
        private readonly AppDbContext _appDbContext;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(
                AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _appDbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("A transação não foi iniciada.");
            }

            try
            {
                await _transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await _transaction.RollbackAsync();
                throw ex;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            await _appDbContext.AddAsync(entity);
            return entity;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _appDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) 
        { 
            if (disposing)
            {
                _appDbContext.Dispose();
            }
        }

        public Task DeleteAsync(T entity)
        {
            _appDbContext.Remove(entity);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(T entity)
        {
            _appDbContext.Update(entity);
            return Task.CompletedTask;
        }
    }
}