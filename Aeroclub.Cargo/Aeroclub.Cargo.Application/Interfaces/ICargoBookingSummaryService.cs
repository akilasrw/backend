
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoBookingSummaryService
    {
        Task<Pagination<CargoBookingSummaryVM>> GetFilteredListAsync(CargoBookingSummaryFilteredListQM query);

    }
}
