using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoAgentService
    {
        Task<CargoAgentCreateStatusRM> CreateAsync(CargoAgentCreateRM model);
        Task<ServiceResponseStatus> UpdateAsync(CargoAgentUpdateRM model);

        Task<ServiceResponseStatus> UpdateProfile(AgentProfileUpdateRM model, Guid id);

        Task<AppUser> GetProfile(Guid id);
        Task<CargoAgentVM> GetAsync(CargoAgentQM Id);
        Task<bool> DeleteAsync(Guid Id);
        Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync();
        Task<Pagination<CargoAgentVM>> GetFilteredListAsync(CargoAgentListQM query);
        Task<bool> StatusUpdateAsync(CargoAgentStatusUpdateRM rm);
        Task<IReadOnlyList<CargoAgentVM>> GetListAsync();

    }
}
