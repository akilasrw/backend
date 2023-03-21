using Aeroclub.Cargo.Application.Models.Queries.SeatLayoutQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class SeatLayoutSpecification : BaseSpecification<SeatLayout>
    {
        public SeatLayoutSpecification(SeatLayoutQM query)
            : base(p => (query.Id == Guid.Empty || p.Id == query.Id))
        {
            if (query.IncludeSeatConfiguration)
                AddInclude(x => x.Include(y => y.SeatConfigurations).ThenInclude(a => a.Seats));
        }
    }
}
