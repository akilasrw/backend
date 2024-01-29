using Aeroclub.Cargo.Application.Models.Queries.ShipmentQM;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
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
            :base(x=> x.flightScheduleID == query.flightScheduleID && x.bookingID == query.bookingID) 
        { }
    }
}
