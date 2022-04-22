using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id, bool asNoTracking = true);
        Task<IReadOnlyList<T>> GetListAsync(bool asNoTracking = true);
        Task<T> GetEntityWithSpecAsync(ISpecification<T> spec, bool asNoTracking = true);
        Task<IReadOnlyList<T>> GetListWithSpecAsync(ISpecification<T> spec, bool asNoTracking = true);
        Task<int> CountAsync(ISpecification<T> spec);
        Task<T> CreateAsync(T entity);
        Task CreateRangeAsync(IEnumerable<T> entity);
        void Update(T entity);
        void Delete(T entity);
        Task<bool> AnyAsync(ISpecification<T> spec);
        void Detach(T entity);
        Task<bool> AllAsync(ISpecification<T> spec, Expression<Func<T, bool>> criteria);
        Task<double> SumAsync(ISpecification<T> spec, Expression<Func<T, double>> selector);
        IQueryable<T> GetQuery(ISpecification<T> spec, bool asNoTracking = true);
        IQueryable<T> GetQuery();
    }
}