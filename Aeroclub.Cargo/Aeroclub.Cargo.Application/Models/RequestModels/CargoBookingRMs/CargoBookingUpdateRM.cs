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
    }

    public class CargoBookingStatusUpdateListRM
    {
        public StandByStatus? StandByStatus { get; set; }
        public IEnumerable<CargoBookingStatusUpdateRM> CargoBookingStatusUpdateList { get; set; }
    }
}
