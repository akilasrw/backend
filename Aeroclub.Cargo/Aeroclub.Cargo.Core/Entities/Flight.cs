using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Flight : AuditableEntity
    {
        public string FlightNumber { get; set; } = null!;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;

        public virtual Airport DestinationAirport { get; set; }
        public virtual Airport OriginAirport { get; set; }

        public virtual ICollection<FlightSector>? FlightSectors { get; set; } = null;
    }
}