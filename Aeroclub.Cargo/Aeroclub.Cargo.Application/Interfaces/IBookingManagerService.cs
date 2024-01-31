using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.GetShipmentsRM;
using Aeroclub.Cargo.Application.Models.ViewModels.BookingShipmentSummeryVM;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IBookingManagerService
    {
        Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm);
        Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query);
        Task<CargoBookingDetailVM> GetDetailAsync(CargoBookingQM query);
        Task<Pagination<CargoBookingVM>> GetBookingFilteredListAsync(CargoBookingFilteredListQM query);
        Task<CargoBookingSummaryDetailVM> GetBookingSummaryAsync(BookingSummaryQuery query);
        Task<IEnumerable<SeatDto>> GetSeatBookingSummaryLayoutAsync(FlightScheduleSectorSearchQuery query);
        Task<BookingServiceResponseStatus> UpdateAsync(CargoBookingUpdateRM rm);
        Task<IReadOnlyList<CargoBookingListVM>> GetBookingListAsync(FlightScheduleSectorBookingListQM query);
        Task<IReadOnlyList<CargoBookingListVM>> GetAssignedCargoList(AssignedCargoQM query);
        Task<IReadOnlyList<CargoBookingULDVM>> GetFreighterBookingListAsync(FlightScheduleSectorBookingListQM query);
        BookingStatus BookingNextStatus(BookingStatus bookingStatus);
        PackageItemStatus PackageNextStatus(PackageItemStatus packageItemStatus);
        Task<ServiceResponseStatus> UpdateDeleteListAsync(IEnumerable<CargoBookingUpdateRM> list);
        Task<ServiceResponseStatus> UpdateStandByStatusAsync(CargoBookingStatusUpdateListRM rm);
        Task<IReadOnlyList<CargoBookingStandByCargoVM>> GetStandByCargoListAsync(FlightScheduleSectorBookingListQM query);
        Task<IReadOnlyList<CargoBookingListVM>> GetVerifyBookingListAsync(FlightScheduleSectorVerifyBookingListQM query);
        Task<CargoBookingMobileVM> GetMobileBookingAsync(FlightScheduleSectorMobileQM query);
        Task<IReadOnlyList<BookingShipmentSummeryVM>> GetShipmentByAWB(GetShipmentsRM query);

    }
}
