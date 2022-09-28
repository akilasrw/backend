using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAgentRateManagementService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(AgentRateManagementListRM dto);

    }
}
