using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Aeroclub.Cargo.Core.Entities.Core;
using Aeroclub.Cargo.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Data.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CargoContext _context;
        public GenericRepository(CargoContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(Guid id, bool asNoTracking = true)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (asNoTracking)
                _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public async Task<IReadOnlyList<T>> GetListAsync(bool asNoTracking = true)
        {
            var query = _context.Set<T>().AsQueryable();
            if (asNoTracking)
                query.AsNoTracking();
            return await query.ToListAsync();
        }

        public async Task<T> GetEntityWithSpecAsync(ISpecification<T> spec, bool asNoTracking = true)
        {
            return await ApplySpecification(spec, asNoTracking).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetListWithSpecAsync(ISpecification<T> spec, bool asNoTracking = true)
        {
            return await ApplySpecification(spec, asNoTracking).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec, bool asNoTracking = true)
        {
            var query = _context.Set<T>().AsQueryable();

            if (asNoTracking)
                query = query.AsNoTracking();

            return SpecificationEvaluator<T>.GetQuery(query, spec);
        }

        public async Task<T> CreateAsync(T entity)
        {
            var entityResult = await _context.Set<T>().AddAsync(entity);
            return entityResult.Entity;
        }

        public async Task CreateRangeAsync(IEnumerable<T> entity)
        {
            await _context.Set<T>().AddRangeAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<bool> AnyAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).AnyAsync();
        }

        public void Detach(T entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
        }

        public async Task<bool> AllAsync(ISpecification<T> spec, Expression<Func<T, bool>> criteria)
        {
            return await ApplySpecification(spec).AllAsync(criteria);
        }

        public async Task<double> SumAsync(ISpecification<T> spec, Expression<Func<T, double>> selector)
        {
            return await ApplySpecification(spec).SumAsync(selector);
        }

        public IQueryable<T> GetQuery(ISpecification<T> spec, bool asNoTracking = true)
        {
            var query = _context.Set<T>().AsQueryable();

            if (asNoTracking)
                query = query.AsNoTracking();

            return SpecificationEvaluator<T>.GetQuery(query, spec);
        }
        
        public IQueryable<T> GetQuery()
        {
            return _context.Set<T>().AsQueryable();
        }

    }
}