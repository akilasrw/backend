using Aeroclub.Cargo.Application.Models.Queries.OverheadCompartmentQMs;
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
    public class OverheadCompartmentSpecification: BaseSpecification<OverheadCompartment>
    {
        public OverheadCompartmentSpecification(OverheadCompartmentQM query)
            :base(x => query.Id == Guid.Empty || x.Id == query.Id)
        {
            AddInclude(y => y.Include(z => z.OverheadCompartmentConfigurations).ThenInclude(c => c.OverheadLayout));
        }
    }
}
