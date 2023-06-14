using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.LoadPlanVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class LoadPlanService : BaseService, ILoadPlanService
    {

        public LoadPlanService(IMapper mapper, IUnitOfWork unitOfWork)
            : base(unitOfWork, mapper)
        {
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(LoadPlanDto loadPlanDto)
        {
                var res = new ServiceResponseCreateStatus();
                var loadPlan = _mapper.Map<LoadPlan>(loadPlanDto);

                var result = await _unitOfWork.Repository<LoadPlan>().CreateAsync(loadPlan);
                await _unitOfWork.SaveChangesAsync();
                res.Id = result.Id;
                res.StatusCode = ServiceResponseStatus.Success;
                return res;
        }

        public async Task<ServiceResponseStatus> DeleteAsync(Guid Id)
        {
            var loadPlan = await _unitOfWork.Repository<LoadPlan>().GetByIdAsync(Id);
            _unitOfWork.Repository<LoadPlan>().Delete(loadPlan);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<LoadPlan>().Detach(loadPlan);

            return ServiceResponseStatus.Success;
        }

        public async Task<LoadPlanVM> GetAsync(LoadPlanQM query)
        {
            var spec = new LoadPlanSpecification(query);
            var loadPlan = await _unitOfWork.Repository<LoadPlan>().GetEntityWithSpecAsync(spec);
            var loadPlanVm = _mapper.Map<LoadPlan, LoadPlanVM>(loadPlan);
            return loadPlanVm;
        }
    }
}
