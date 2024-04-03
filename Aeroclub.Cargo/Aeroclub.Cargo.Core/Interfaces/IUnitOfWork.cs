using System;
using System.Threading.Tasks;
using Aeroclub.Cargo.Core.Entities.Core;
using Microsoft.EntityFrameworkCore.Storage;

namespace Aeroclub.Cargo.Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> SaveChangesAsync();
        Task<int> SaveCronChangesAsync();
        IDbContextTransaction BeginTransaction();
    }
}