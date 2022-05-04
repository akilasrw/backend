using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<LoadPlanDto> GetAsync(LoadPlanQM query)
        {
            throw new NotImplementedException();
        }
    }
}
