using Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class SeatConfigurationSpecification: BaseSpecification<SeatConfiguration>
    {
        public SeatConfigurationSpecification(SeatConfigurationQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id) &&
                (query.SeatConfigurationType == SeatConfigurationType.None || x.SeatConfigurationType == query.SeatConfigurationType))
        {
            if (query.IncludeSeats)
                AddInclude(z => z.Include(c => c.Seats)); 
            
            if (query.IncludeZones)
                AddInclude(z => z.Include(c => c.Seats).ThenInclude(d=>d.ZoneArea).ThenInclude(e => e.AircraftCabin).ThenInclude(f => f.AircraftDeck).ThenInclude(g => g.AircraftLayout));
        }

        public SeatConfigurationSpecification(SeatConfigurationListQM query)
           : base(x =>  x.SeatLayoutId == query.SeatLayoutId && x.SeatConfigurationType == query.SeatConfigurationType)
        {
            if (query.IncludeSeats)
                AddInclude(z => z.Include(c => c.Seats));

            if (query.IncludeZones)
                AddInclude(z => z.Include(c => c.Seats).ThenInclude(d => d.ZoneArea).ThenInclude(e => e.AircraftCabin).ThenInclude(f => f.AircraftDeck).ThenInclude(g => g.AircraftLayout));
        }
    }
}
