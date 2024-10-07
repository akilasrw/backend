using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;
using NodaTime;

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
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id) && x.FlightSchedule.IsDeleted == false)
        {
            if(query.IncludeULDContaines)
                AddInclude(y=> y.Include(x=> x.LoadPlan.ULDContaines).ThenInclude(y=>y.ULDContainerCargoPositions).ThenInclude(z=>z.CargoPosition));
            
            if(query.IncludeAircraftSubType)
                AddInclude(y=> y.Include(x=> x.AircraftSubType));

            if (query.IncludeFlightScheduleSectorPallets)
                AddInclude(y => y.Include(c => c.FlightScheduleSectorPallets));

            if(query.IncludeLoadPlan)
                AddInclude(y=> y.Include(x=> x.LoadPlan).ThenInclude(t=>t.AircraftLayout.AircraftDecks).ThenInclude(z=>z.AircraftCabins).ThenInclude(c=>c.ZoneAreas).ThenInclude(p=>p.CargoPositions));
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

        public FlightScheduleSectorSpecification(FlightScheduleSectorULDPositionCountQM query)
            : base(x=> ((query.ScheduledDepartureStartDateTime == DateTime.MinValue &&
                  query.ScheduledDepartureEndDateTime == DateTime.MinValue)
                 || (query.ScheduledDepartureStartDateTime.Date <= x.ScheduledDepartureDateTime.Date) &&
                 (query.ScheduledDepartureEndDateTime >= x.ScheduledDepartureDateTime.Date)) && x.IsDeleted == false)
        {
            AddInclude(y => y.Include(x => x.LoadPlan));
            AddInclude(y => y.Include(x => x.LoadPlan.ULDContaines).ThenInclude(y => y.ULDContainerCargoPositions).ThenInclude(z => z.CargoPosition));
            AddInclude(y => y.Include(x => x.LoadPlan).ThenInclude(t => t.AircraftLayout.AircraftDecks).ThenInclude(z => z.AircraftCabins).ThenInclude(c => c.ZoneAreas).ThenInclude(p => p.CargoPositions));
            AddInclude(y => y.Include(x => x.AircraftSubType).ThenInclude((z)=> z.AircraftType));
            AddInclude(y => y.Include(x => x.Aircraft));
            AddInclude(y => y.Include(c => c.FlightScheduleSectorPallets).ThenInclude(i=> i.ULD));
        }
    }
}