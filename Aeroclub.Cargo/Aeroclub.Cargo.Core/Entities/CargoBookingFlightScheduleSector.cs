using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class CargoBookingFlightScheduleSector : BaseEntity
    {
        public Guid CargoBookingId { get; set; }
        public Guid FlightScheduleSectorId { get; set;}

        public virtual CargoBooking CargoBooking { get; set; }
        public virtual FlightScheduleSector FlightScheduleSector { get; set; }

    }
}
