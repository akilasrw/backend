using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoBookingService
    {
        Task<Pagination<CargoBookingVM>> GetFilteredListAsync(CargoBookingFilteredListQM query);
        Task<CargoBookingDetailVM> GetAsync(CargoBookingDetailQM query);
        Task<ServiceResponseCreateStatus> CreateAsync(CargoBookingRM dto);
        Task<ServiceResponseStatus> UpdateAWBStatus(Guid bookingId);
        Task<ServiceResponseCreateStatus> UpdateAsync(CargoBookingUpdateRM rm);

    }
}