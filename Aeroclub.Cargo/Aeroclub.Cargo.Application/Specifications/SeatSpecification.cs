using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
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
        :base(x=> query.Id == Guid.Empty || x.Id == query.Id)
        {

        }
    }
}
