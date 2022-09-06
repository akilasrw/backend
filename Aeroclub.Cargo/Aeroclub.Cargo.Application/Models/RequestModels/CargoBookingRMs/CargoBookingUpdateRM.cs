using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs
{
    public class CargoBookingUpdateRM : BaseRM
    {
        public BookingStatus BookingStatus { get; set; }

    }
}
