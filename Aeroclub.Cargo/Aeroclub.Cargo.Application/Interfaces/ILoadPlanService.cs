using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.LoadPlanVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ILoadPlanService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(LoadPlanDto loadPlanDto);
        Task<LoadPlanVM> GetAsync(LoadPlanQM query);
        Task<ServiceResponseStatus> DeleteAsync(Guid Id);
    }
}
