using System;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class CargoPositionSpecification : BaseSpecification<CargoPosition>
    {
        public CargoPositionSpecification(CargoPositionListQM query)
            : base (x=> 
                (query.AircraftLayoutId == Guid.Empty || x.ZoneArea.AircraftCabin.AircraftDeck.AircraftLayoutId == query.AircraftLayoutId)
            )
        {
            if(query.AircraftLayoutId != Guid.Empty)
                AddInclude(y=> y.Include(x=> x.ZoneArea.AircraftCabin.AircraftDeck));
            
            if(query.IncludeSeat)
                AddInclude(y=> y.Include(x=> x.Seat));
            
            if (query.IncludeOverhead)
                AddInclude(y => y.Include(x => x.OverheadCompartment));
        }       

        public CargoPositionSpecification(CargoPositionQM query)
            : base (x=> 
                (query.Id == Guid.Empty || x.Id == query.Id)
            )
        {
            if(query.Id != Guid.Empty)
                AddInclude(y=> y.Include(x=> x.ZoneArea.AircraftCabin.AircraftDeck));
            
        }
    }
}