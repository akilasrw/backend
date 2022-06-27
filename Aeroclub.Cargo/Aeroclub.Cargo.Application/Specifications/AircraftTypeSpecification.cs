using Microsoft.EntityFrameworkCore;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftTypeSpecification : BaseSpecification<AircraftType>
    {
        public AircraftTypeSpecification(AircraftTypeQM query)
           : base()
        {
            if (query.IsIncludeSubType)
                AddInclude(x => x.Include(y => y.AircraftSubTypes));
        }
    }
}
