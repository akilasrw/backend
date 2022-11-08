using Aeroclub.Cargo.Application.Models.Queries.AircraftScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftScheduleSpecification : BaseSpecification<AircraftSchedule>
    {
        public AircraftScheduleSpecification(AircraftScheduleQM query)
            : base(x => x.AircraftId == query.AircraftId && x.IsCompleted == query.IsScheduleCompleted && !x.IsDeleted)
        {
                
        }
    }
}
