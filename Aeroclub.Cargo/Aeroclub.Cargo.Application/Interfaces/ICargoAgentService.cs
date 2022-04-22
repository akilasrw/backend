using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoAgentService
    {
        Task<CargoAgentCreateStatusRM> CreateAsync(CargoAgentCreateRM model);

        Task<ServiceResponseStatus> UpdateAsync(CargoAgentUpdateRM model);

        Task<CargoAgentVM> GetAsync(CargoAgentQM Id);

        Task<bool> DeleteAsync(Guid Id);
    }
}
