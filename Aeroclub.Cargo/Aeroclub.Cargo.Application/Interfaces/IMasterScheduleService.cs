using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.MasterScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftScheduleVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.MasterScheduleVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IMasterScheduleService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(MasterScheduleCreateRM dto);
        Task<ServiceResponseCreateStatus> UpdateAsync(MasterScheduleUpdateRM dto);
        Task<MasterScheduleVM> GetAsync(MasterScheduleDetailQM query);
        Task<IReadOnlyList<AircraftScheduleVM>> GetAircraftScheduleAsync(MasterScheduleListQM query);

    }
}
