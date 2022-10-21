using Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AWBNumberStackSpecification : BaseSpecification<AWBNumberStack>
    {
        public AWBNumberStackSpecification(AWBNumberStackQM query)
           : base(x => x.Id == query.Id)
        {
            if (query.IsAgentInclude)
            {
                AddInclude(x => x.Include(y => y.CargoAgent));
            }

        }
    }
}
