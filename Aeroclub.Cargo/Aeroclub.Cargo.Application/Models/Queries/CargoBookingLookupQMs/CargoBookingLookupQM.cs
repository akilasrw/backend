
namespace Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs
{
    public class CargoBookingLookupQM 
    {
        public Guid UserId { get; set; }
        public string? ReferenceNumber { get; set; }
        public bool IsIncludeFlightDetail { get; set; }
        public bool IsIncludeAWBDetail { get; set; }
        public bool IsIncludePackageDetail { get; set; }
        public long? AWBNumber { get; set; }
    }
}
