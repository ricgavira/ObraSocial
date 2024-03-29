﻿using ObraSocial.Domain.Entities;
using ObraSocial.Domain.Repositories;

namespace ObraSocial.Infra.Data.UnitOfWork
{
    public interface IUnitOfWork<T> : IWriteOnlyRepository<T>, IReadOnlyRepository<T> where T : BaseEntity<T>
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task<int> SaveChangesAsync();
        ICollection<T> FindAllByWhere(Func<T, bool> where);
        T? FindByWhere(Func<T, bool> where);
    }
}