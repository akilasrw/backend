using System;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class FlightScheduleSpecification : BaseSpecification<FlightSchedule>
    {
        public FlightScheduleSpecification(FlightScheduleListQM query)
        : base(x=> 
            (query.FlightDate == DateTime.MinValue || x.ScheduledDepartureDateTime.Date == query.FlightDate.Date) &&
            (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
            (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId)
        )
        {
            
        }

        public FlightScheduleSpecification(FlightScheduleQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {

        }
    }
}