using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class CargoBooking : AuditableEntity
    {
        public string BookingNumber { get; set; } = null!; // Auto Generated No - Format - Singleton
        public BookingStatus BookingStatus { get; set; }
        public AWBStatus AWBStatus { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.UtcNow;
        public Guid? FlightScheduleSectorId { get; set; }

        public virtual AWBInformation AWBInformation { get; set; }
        public virtual FlightScheduleSector FlightScheduleSector { get; set; }
        public virtual Airport OriginAirport { get; set; }
        public virtual Airport DestinationAirport { get; set; }
        public virtual ICollection<PackageItem> PackageItems { get; set; }
    }
}