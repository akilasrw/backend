using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDCargoBookingManagerService
    {
        Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm);
        Task<BookingServiceResponseStatus> UpdateAsync(CargoBookingUpdateRM rm);
        Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query);
    }
}
