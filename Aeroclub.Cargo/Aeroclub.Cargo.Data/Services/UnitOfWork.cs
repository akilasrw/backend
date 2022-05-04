using System;
using System.Collections;
using Aeroclub.Cargo.Core.Entities.Core;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.UserResolver.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;


namespace Aeroclub.Cargo.Data.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IUserResolverService _userResolverService;
        private readonly CargoContext _context;
        private Hashtable _repositories;

        public UnitOfWork(CargoContext context, IUserResolverService userResolverService)
        {
            _context = context;
            _userResolverService = userResolverService;
        }
        
        public async Task<int> SaveChangesAsync()
        {
            var userid = _userResolverService.GetUserId();

            return await _context.SaveAuditableChangesAsync(userid);
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