using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AgentRateManagementVMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;

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
        Task<IReadOnlyList<SubRateCategory>> GetOtherSubRates(OtherRateTypes id);
        Task<IReadOnlyList<ChildRateCategory>> GetChildRates(Guid subTypeID);
        Task<IReadOnlyList<AgentOtherRates>> FilterOtherRates(Guid childTypeID);
        Task<AgentOtherRates> CreateOtherRates(AgentOtherRatesRM model);


    }
}
