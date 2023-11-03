using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainerCargoPositionRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDCargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDCargoBookingManagerService
    {
        Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm);
        Task<BookingServiceResponseStatus> UpdateStatusAsync(CargoBookingUpdateRM rm);
        Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query);
        Task<ServiceResponseCreateStatus> AssginCargoToULDAsync(ULDContainerCargoPositionRM uLDContainerCargoPositions);
        Task<IReadOnlyList<ULDCargoBookingListVM>> GetULDBookingListAsync(CargoPositionULDContainerListQM query);
        Task<BookingServiceResponseStatus> StandByUpdateAsync(CargoBookingStandbyUpdateRM rm);
        Task<ServiceResponseCreateStatus> AddPalleteToFlightAsync(FlightScheduleSectorPalletCreateRM rm);
        Task<ServiceResponseStatus> SaveBookingAssigmentAsync(BookingAssignmentRM bookingAssignment);
        Task<IEnumerable<FlightScheduleSectorUldPositionVM>> GetFlightScheduleSectorWithULDPositionCountAsync(FlightScheduleSectorULDPositionCountQM query);
        Task<ServiceResponseStatus> CreateRemovePalleteListAsync(FlightScheduleSectorPalletCreateListRM request);
        Task<List<ULDFilteredListVM>> GetPalleteFromFlights(FlightSheduleSectorPalletGetList filter);

    }
}
