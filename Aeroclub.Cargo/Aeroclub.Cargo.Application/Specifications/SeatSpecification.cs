using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
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
    public class SeatSpecification: BaseSpecification<Seat>
    {
        public SeatSpecification(SeatQM query)
        : base(x => query.Id == Guid.Empty || x.Id == query.Id)
        {
            AddInclude(y => y.Include(z => z.SeatConfiguration).ThenInclude(c => c.SeatLayout));
        }

        public SeatSpecification(SeatListQM query)
        : base(x => true)
        {
            if (query.ZoneAreaId.HasValue)
            {
                AddInclude(y => y.Include(z => z.SeatConfiguration).ThenInclude(p => p.Seats));
                And(c => c.SeatConfiguration.Seats.Where(g => !g.IsOnSeatOccupied && g.ZoneAreaId == query.ZoneAreaId).Count() > 2);
                And(p => p.SeatConfiguration.SeatConfigurationType == query.SeatConfigurationType);
            }
            
        }
    }
}
