using Aeroclub.Cargo.Application.Models.Queries.AircraftScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftScheduleSpecification : BaseSpecification<AircraftSchedule>
    {
        public AircraftScheduleSpecification(AircraftScheduleQM query)
            : base(x => x.AircraftId == query.AircraftId && x.IsCompleted == query.IsScheduleCompleted && !x.IsDeleted)
        {
                
        }

        public AircraftScheduleSpecification(AircraftScheduleListQM query)
            : base(x=> x.ScheduleStartDateTime.Date == query.ScheduleStartDate.Date || (query.ScheduleStartDate.Date > x.ScheduleStartDateTime.Date && query.ScheduleStartDate.Date <= x.ScheduleEndDateTime.Date))
        {
            if(query.IsIncludeAircraft)
                AddInclude(x => x.Include(y => y.Aircraft));

        }
    }
}
