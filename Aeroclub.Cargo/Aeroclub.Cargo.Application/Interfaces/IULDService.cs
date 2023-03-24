using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDService
    {
        Task<ServiceResponseCreateStatus> CreateULDAsync(ULDDto ULDDto);
        Task<ServiceResponseCreateStatus> CreateAsync(ULDCreateRM ULDDto);
        Task<Pagination<ULDFilteredListVM>> GetFilteredListAsync(ULDListQM query);
        Task<ULDDto> GetAsync(ULDQM query);
    }
}
