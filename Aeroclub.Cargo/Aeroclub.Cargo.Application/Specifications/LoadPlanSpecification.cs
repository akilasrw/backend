using Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class LoadPlanSpecification : BaseSpecification<LoadPlan>
    {
        public LoadPlanSpecification(LoadPlanQM query)
            : base(p => (query.Id == Guid.Empty || p.Id == query.Id))
        {
            
        }
    }
}
