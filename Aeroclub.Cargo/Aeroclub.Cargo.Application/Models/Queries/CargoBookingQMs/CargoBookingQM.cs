using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs
{
    public class CargoBookingQM : BaseQM
    {
        public bool IsIncludeFlightDetail { get; set; }
        public bool IsIncludePackageDetail { get; set; }
        public bool IsIncludeAWBDetail { get; set; }
    }
}
