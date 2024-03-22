using Aeroclub.Cargo.Application.Models.Queries.ShipmentQM;
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
    public class ShipmentSpecification : BaseSpecification<Shipment>
    {
        public ShipmentSpecification(ShipmentQM query)
            :base(x=> (query.userId == Guid.Empty || query.userId == x.CargoBooking.CreatedBy) && (query.flightScheduleID == Guid.Empty || x.flightScheduleID == query.flightScheduleID) && x.bookingID == query.bookingID) 
        {

            AddInclude(x => x.Include(y => y.CargoBooking).ThenInclude(y => y.AWBInformation));
            AddInclude(x => x.Include(y => y.FlightSchedule));
            AddInclude(x => x.Include(y => y.PackageItem));
            AddInclude(x => x.Include(y => y.PackageItems));
        }
    }
}
