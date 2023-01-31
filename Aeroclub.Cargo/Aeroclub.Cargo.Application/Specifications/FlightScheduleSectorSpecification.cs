﻿using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
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

        public FlightScheduleSectorSpecification(FlightScheduleSectorQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {
            if(query.IncludeULDContaines)
                AddInclude(y=> y.Include(x=> x.LoadPlan.ULDContaines).ThenInclude(y=>y.ULDContainerCargoPositions).ThenInclude(z=>z.CargoPosition));
            
            if(query.IncludeAircraftSubType)
                AddInclude(y=> y.Include(x=> x.AircraftSubType));

            if(query.IncludeLoadPlan)
                AddInclude(y=> y.Include(x=> x.LoadPlan));
        }

        public FlightScheduleSectorSpecification(FlightScheduleSectorSearchQuery query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id) && 
            (query.FlightScheduleId == Guid.Empty || x.FlightScheduleId == query.FlightScheduleId))
        {
            AddInclude(x => x.Include(y => y.AircraftSubType));
            AddInclude(y => y.Include(x => x.LoadPlan.ULDContaines).ThenInclude(y => y.ULDContainerCargoPositions).ThenInclude(z => z.CargoPosition));
            AddInclude(y => y.Include(x => x.LoadPlan.AircraftLayout.AircraftDecks));
        }

        public FlightScheduleSectorSpecification(FlightScheduleSectorSearchQM query)
            : base(x =>  x.FlightNumber.ToLower() == query.FlightNumber.ToLower() && query.FlightDate.Date == x.ScheduledDepartureDateTime.Date && x.AircraftId == query.AircraftId)
        {
            AddInclude(y => y.Include(x => x.LoadPlan));
        }

        public FlightScheduleSectorSpecification(FlightScheduleSectorBookingListQM query)
           : base(x => ((string.IsNullOrEmpty(query.FlightNumber) || x.FlightNumber.Contains(query.FlightNumber)) &&
           (query.FlightDate == DateTime.MinValue || x.ScheduledDepartureDateTime.Date == query.FlightDate.Date)) && (!x.IsDeleted))
        {
            AddInclude(x => x.Include(y => y.CargoBookings).ThenInclude(x=>x.PackageItems).ThenInclude(a=>a.ULDContainer).ThenInclude(b=>b.ULDContainerCargoPositions));
            AddInclude(x => x.Include(y => y.CargoBookings).ThenInclude(x=>x.AWBInformation));

        }
    }
}