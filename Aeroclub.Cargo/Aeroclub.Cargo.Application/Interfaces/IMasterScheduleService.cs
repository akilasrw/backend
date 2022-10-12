using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IMasterScheduleService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(MasterScheduleRM dto);

    }
}
