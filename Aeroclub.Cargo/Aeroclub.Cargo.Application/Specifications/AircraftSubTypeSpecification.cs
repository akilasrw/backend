using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftSubTypeSpecification : BaseSpecification<AircraftSubType>
    {
        public AircraftSubTypeSpecification(AircraftSubTypeQM query)
           : base(x => query.aircraftSubType == x.Type)
        {
          
        }
    }
}
