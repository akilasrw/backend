using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDByFlightScheduleRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDService
    {
        Task<ServiceResponseCreateStatus> CreateULDAsync(ULDDto ULDDto);
        Task<ServiceResponseCreateStatus> CreateAsync(ULDCreateRM ULDDto);
        Task<ServiceResponseStatus> UpdateAsync(ULDUpdateRM ULDDto);
        Task<Pagination<ULDFilteredListVM>> GetFilteredListAsync(ULDListQM query);
        Task<List<ULD>> GetULDByFlightSchedule(ULDByFlightScheduleRM rm);
        Task<ULDDto> GetAsync(ULDQM query);
    }
}
