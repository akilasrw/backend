using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDCargoBookingService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(CargoBookingRM dto);
        Task<CargoBookingDetailVM> GetAsync(CargoBookingDetailQM query);
        Task<ServiceResponseCreateStatus> UpdateStatusAsync(CargoBookingUpdateRM dto);

    }
}
