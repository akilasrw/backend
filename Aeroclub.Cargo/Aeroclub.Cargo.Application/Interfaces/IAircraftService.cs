using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAircraftService
    {
        Task<string> GetAircraftRegNo(Guid id);
        Task<IReadOnlyList<AircraftTypeVM>> GetAircraftTypesAsync(AircraftTypeQM query);
    }
}