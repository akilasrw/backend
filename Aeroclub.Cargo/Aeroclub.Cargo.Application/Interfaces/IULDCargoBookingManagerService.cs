using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDCargoBookingVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDCargoBookingManagerService
    {
        Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm);
        Task<BookingServiceResponseStatus> UpdateAsync(CargoBookingUpdateRM rm);
        Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query);
        Task<ServiceResponseCreateStatus> AssginCargoToULDAsync(ULDContainerCargoPositionDto uLDContainerCargoPosition);
        Task<IReadOnlyList<ULDCargoBookingListVM>> GetULDBookingListAsync(CargoPositionULDContainerListQM query);

    }
}
