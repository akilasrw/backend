using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs
{
    public class CargoBookingUpdateRM : BaseRM
    {
        public BookingStatus BookingStatus { get; set; }

    }

    public class CargoBookingStatusUpdateRM: BaseRM 
    {
        public StandByStatus? StandByStatus { get; set; }
        public VerifyStatus? VerifyStatus { get; set; }
    }

    public class CargoBookingStatusUpdateListRM
    {
        public StandByStatus? StandByStatus { get; set; }
        public IEnumerable<CargoBookingStatusUpdateRM> CargoBookingStatusUpdateList { get; set; }
    }

    public class CargoBookingStandbyUpdateRM
    {
        public DateTime FlightDate { get; set; }
        public string FlightNumber { get; set; }
        public Guid BookingId { get; set; }
    }
}
