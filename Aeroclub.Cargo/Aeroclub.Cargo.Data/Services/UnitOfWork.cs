using System;
using System.Collections;
using System.Threading.Tasks;
using Aeroclub.Cargo.Core.Entities.Core;
using Aeroclub.Cargo.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace Aeroclub.Cargo.Data.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CargoContext _context;
        private Hashtable _repositories;

        public UnitOfWork(CargoContext context)
        {
            _context = context;
        }
        
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return  _context.Database.BeginTransaction();
        }
        
        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            _repositories ??= new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<TEntity>)_repositories[type];
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}