using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AgentRateManagementVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAgentRateManagementService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(AgentRateManagementListRM dto);
        Task<Pagination<AgentRateManagementVM>> GetFilteredListAsync(AgentRateManagementListQM query);
        Task<AgentRateManagementVM> GetAsync(AgentRateManagementQM query);

    }
}
