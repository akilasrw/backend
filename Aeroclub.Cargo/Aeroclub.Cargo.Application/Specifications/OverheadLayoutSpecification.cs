using Aeroclub.Cargo.Application.Models.Queries.OverheadLayoutQMs;
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
    public class OverheadLayoutSpecification : BaseSpecification<OverheadLayout>
    {
        public OverheadLayoutSpecification(OverheadLayoutQM query)
            : base(p => (query.Id == Guid.Empty || p.Id == query.Id))
        {
            if (query.IncludeOverheadCompartment)
                AddInclude(x => x.Include(y => y.OverheadCompartments).ThenInclude(a => a.OverheadPositions));
        }
    }
}
