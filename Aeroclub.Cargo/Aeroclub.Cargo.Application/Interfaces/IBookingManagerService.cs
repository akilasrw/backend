using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IBookingManagerService
    {
        Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm);
        Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query);
        Task<Pagination<CargoBookingVM>> GetBookingFilteredListAsync(CargoBookingFilteredListQM query);
        Task<CargoBookingSummaryDetailVM> GetBookingSummaryAsync(BookingSummaryQuery query);
        Task<IEnumerable<SeatDto>> GetSeatBookingSummaryLayoutAsync(FlightScheduleSectorSearchQuery query);
        Task<BookingServiceResponseStatus> UpdateAsync(CargoBookingUpdateRM rm);
        Task<IReadOnlyList<CargoBookingListVM>> GetBookingListAsync(FlightScheduleSectorBookingListQM query);

    }
}
