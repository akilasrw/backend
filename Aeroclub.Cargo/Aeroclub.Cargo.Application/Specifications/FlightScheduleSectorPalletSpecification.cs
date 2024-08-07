using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorPalletQMs;
using Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs;
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
    public class FlightScheduleSectorPalletSpecification : BaseSpecification<FlightScheduleSectorPallet>
    {
        public FlightScheduleSectorPalletSpecification(FlightScheduleSectorPalletQuery query)
            : base(p => (query.FlightScheduleSectorId == Guid.Empty || p.FlightScheduleSectorId == query.FlightScheduleSectorId) &&
            (query.ULDId == Guid.Empty || p.ULDId == query.ULDId))
        {
            if (query.IncludeUld)
                AddInclude(x => x.Include(y => y.ULD).ThenInclude(i=> i.ULDMetaData));

            if (query.IncludeFlightSchedule)
                AddInclude(x => x.Include(y => y.FlightScheduleSector));
        }

        public FlightScheduleSectorPalletSpecification(Guid fId, Guid uldId)
            :base(p => (p.FlightScheduleSectorId == fId && p.ULDId == uldId)) {
        
        
        }


        public FlightScheduleSectorPalletSpecification(Guid uldId)
          : base(p => (p.ULDId == uldId && p.IsDeleted == false))
        {


        }

        public FlightScheduleSectorPalletSpecification(string uld)
          : base(p => (p.ULD.SerialNumber == uld && p.IsDeleted == false))
        {


        }
    }
}
