using Aeroclub.Cargo.Application.Models.Queries.AircraftLayoutQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftLayoutSpecification: BaseSpecification<AircraftLayout>
    {
        public AircraftLayoutSpecification(AircraftLayoutQM query)
            :base(p=> (query.Id == Guid.Empty || p.Id == query.Id))
        {
            if (query.IncludeAircraftDeck)
                AddInclude(x => x.Include(y => y.AircraftDecks).ThenInclude(a => a.AircraftCabins).ThenInclude(b => b.ZoneAreas).ThenInclude(c => c.CargoPositions));
        }
    }
}
