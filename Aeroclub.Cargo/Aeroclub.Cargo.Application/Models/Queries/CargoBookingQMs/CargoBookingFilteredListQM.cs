using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs
{
    public class CargoBookingFilteredListQM : BasePaginationQM
    {
        public string? BookingId { get; set; }

        public string? Destination { get; set; }

        public Guid? UserId { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

    }
}
