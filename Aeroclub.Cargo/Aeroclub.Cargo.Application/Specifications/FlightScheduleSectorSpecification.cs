using System;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class FlightScheduleSectorSpecification : BaseSpecification<FlightScheduleSector>
    {
        public FlightScheduleSectorSpecification(FlightScheduleSectorListQM query)
            : base(x =>
                (query.ScheduledDepartureDateTime == DateTime.MinValue ||
                 x.ScheduledDepartureDateTime.Date == query.ScheduledDepartureDateTime.Date) &&
                (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
                (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
                ((query.ScheduledDepartureStartDateTime == DateTime.MinValue &&
                  query.ScheduledDepartureEndDateTime == DateTime.MinValue)
                 || (query.ScheduledDepartureStartDateTime.Date <= x.ScheduledDepartureDateTime.Date) &&
                 (query.ScheduledDepartureEndDateTime >= x.ScheduledDepartureDateTime.Date)) &&
                (!query.OriginAirportOnly || x.OriginAirportId == query.OriginAirportId)
            )
        {
        }

        public FlightScheduleSectorSpecification(FlightScheduleSectorFilteredListQM query, bool isCount = false)
            : base(x =>
                (query.ScheduledDepartureDateTime == DateTime.MinValue ||
                 x.ScheduledDepartureDateTime.Date == query.ScheduledDepartureDateTime.Date) &&
                (query.OriginAirportId == Guid.Empty || x.OriginAirportId == query.OriginAirportId) &&
                (query.DestinationAirportId == Guid.Empty || x.DestinationAirportId == query.DestinationAirportId) &&
                ((query.ScheduledDepartureStartDateTime == DateTime.MinValue &&
                  query.ScheduledDepartureEndDateTime == DateTime.MinValue)
                 || (query.ScheduledDepartureStartDateTime.Date <= x.ScheduledDepartureDateTime.Date) &&
                 (query.ScheduledDepartureEndDateTime >= x.ScheduledDepartureDateTime.Date)) &&
                (!query.OriginAirportOnly || x.OriginAirportId == query.OriginAirportId) &&
                (!query.DestinationAirportOnly || x.DestinationAirportId == query.DestinationAirportId)
            )
        {
            if (!isCount)
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
        }

        public FlightScheduleSectorSpecification(FlightScheduleSectorQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {
            if(query.IncludeULDContaines)
                AddInclude(y=> y.Include(x=> x.LoadPlan.ULDContaines).ThenInclude(y=>y.ULDContainerCargoPositions).ThenInclude(z=>z.CargoPosition));
            
            if(query.IncludeAircraft)
                AddInclude(y=> y.Include(x=> x.Aircraft));

            if(query.IncludeLoadPlan)
                AddInclude(y=> y.Include(x=> x.LoadPlan));
        }
    }
}