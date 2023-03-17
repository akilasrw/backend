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
        Task<Pagination<AgentRateManagementVM>> GetFilteredAgentRateListAsync(AgentRateManagementRateListQM query);
        Task<AgentRateManagementVM> GetAsync(AgentRateManagementQM query);
        Task<ServiceResponseCreateStatus> UpdateAsync(AgentRateManagementUpdateRM dto);
        Task<ServiceResponseCreateStatus> UpdateActiveStatusAsync(AgentRateStatusUpdateRM dto);
        Task<ServiceResponseCreateStatus> DeleteAsync(Guid Id);


    }
}
