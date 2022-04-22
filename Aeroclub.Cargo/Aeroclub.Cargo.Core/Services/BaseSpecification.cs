using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Aeroclub.Cargo.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using Aeroclub.Cargo.Core.Extensions;

namespace Aeroclub.Cargo.Core.Services
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        
        public Expression<Func<T, bool>>? Criteria { get; private set; }
        
        public List<Func<IQueryable<T>, IIncludableQueryable<T, object>>> Includes { get; } =
            new List<Func<IQueryable<T>, IIncludableQueryable<T, object>>>();

        public Expression<Func<T, object>>? OrderBy { get; private set; }

        public Expression<Func<T, object>>? OrderByDescending { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        public Expression<Func<T, object>>? GroupBy { get; private set; }
        

        protected void AddInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }

        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }

        protected void ApplyGroupBy(Expression<Func<T, object>> groupByExpression)
        {
            GroupBy = groupByExpression;
        }

        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
        
        protected void And(Expression<Func<T, bool>> expression)
        {
            Criteria = Criteria?.And(expression);
        }

        protected void Or(Expression<Func<T, bool>> expression)
        {
            Criteria = Criteria?.Or(expression);
        }
    }
}