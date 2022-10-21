using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberStackRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBNumberStackVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAWBNumberStackService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(AWBNumberStackCreateRM dto);
        Task<ServiceResponseCreateStatus> UpdateAsync(AWBNumberStackUpdateRM dto);
        Task<AWBNumberStackVM> GetAsync(AWBNumberStackQM query);
        Task<bool> DeleteAsync(Guid Id);
    }
}
