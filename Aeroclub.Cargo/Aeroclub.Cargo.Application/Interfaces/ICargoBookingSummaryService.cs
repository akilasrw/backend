
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoBookingSummaryService
    {
        Task<Pagination<CargoBookingSummaryVM>> GetFilteredListAsync(CargoBookingSummaryFilteredListQM query);
        Task<CargoBookingSummaryDetailVM> GetAsync(CargoBookingSummaryDetailQM query);
        Task<List<CargoPositionDetailVM>> GetAircraftPositionList(Guid flightScheduleSectorId);
    }
}
