﻿using Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class CargoBookingLookupSpecification : BaseSpecification<CargoBooking>
    {

        public CargoBookingLookupSpecification(CargoBookingLookupQM query):
            base(x=>((string.IsNullOrEmpty(query.ReferenceNumber) ||
            x.BookingNumber == query.ReferenceNumber || 
            x.PackageItems.Any(y => y.PackageRefNumber == query.ReferenceNumber))
            ))
        {

            if (query.IsIncludeFlightDetail)
                AddInclude(x => x.Include(y => y.FlightScheduleSector));

            if (query.IsIncludePackageDetail)
                AddInclude(x => x.Include(y => y.PackageItems).ThenInclude(y => y.AWBInformation));

        }

    }
}
