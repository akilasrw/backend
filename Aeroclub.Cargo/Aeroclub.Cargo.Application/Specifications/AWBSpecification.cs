﻿using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AWBSpecification: BaseSpecification<AWBInformation>
    {
        public AWBSpecification(AirWayBillQM query)
            : base(x => (query.Id == Guid.Empty || x.Id == query.Id))
        {

        }

        public AWBSpecification(AWBTrackingQM query)
            : base(x => (x.AwbTrackingNumber == query.AwbTrackingNum))  
        {
            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y=> y.PackageItems));
        }
    }
}
