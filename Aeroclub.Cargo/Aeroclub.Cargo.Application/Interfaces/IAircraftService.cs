using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AircraftRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAircraftService
    {
        Task<string> GetAircraftRegNo(Guid id);
        Task<AircraftConfigType> GetAircraftConfigType(Guid id);
        Task<IReadOnlyList<AircraftTypeVM>> GetAircraftTypesAsync(AircraftTypeQM query);
        Task<AircraftVM> GetAsync(AircraftQM query);
        Task <ServiceResponseCreateStatus> CreateAsync(AircaftCreateRM dto);
        Task<ServiceResponseStatus> UpdateAsync(AircaftUpdateRM dto);
        Task<Pagination<AircraftVM>> GetFilteredListAsync(AircraftListQM query);

    }
}