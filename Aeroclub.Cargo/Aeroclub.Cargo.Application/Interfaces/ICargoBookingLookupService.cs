using Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoBookingLookupService
    {
        Task<CargoBookingLookupVM?> GetAsync(CargoBookingLookupQM query);

        Task<IReadOnlyList<DeliveryAudit>> GetDeliveryAudit();
    }
}
