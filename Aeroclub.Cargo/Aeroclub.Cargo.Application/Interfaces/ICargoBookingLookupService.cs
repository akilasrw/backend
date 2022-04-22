using Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoBookingLookupService
    {
        Task<CargoBookingLookupVM> GetAsync(CargoBookingLookupQM query);
    }
}
