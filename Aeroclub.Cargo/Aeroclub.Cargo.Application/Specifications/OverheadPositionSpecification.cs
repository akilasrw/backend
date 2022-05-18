using Aeroclub.Cargo.Application.Models.Queries.OverheadPositionQMs;
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
    public class OverheadPositionSpecification: BaseSpecification<OverheadPosition>
    {
        public OverheadPositionSpecification(OverheadPositionQM query)
            :base(x => query.Id == Guid.Empty || x.Id == query.Id)
        {
            AddInclude(y => y.Include(z => z.OverheadCompartment).ThenInclude(c => c.OverheadLayout));
        }
    }
}
