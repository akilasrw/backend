using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
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
    public class ULDContainerService : BaseService,IULDContainerService
    {

        public ULDContainerService(IMapper mapper, IUnitOfWork unitOfWork)
            : base(unitOfWork, mapper)
        {
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerDto ULDContainerDto)
        {
            var res = new ServiceResponseCreateStatus();
            var model = _mapper.Map<ULDContainer>(ULDContainerDto);
            
            var result = await _unitOfWork.Repository<ULDContainer>().CreateAsync(model);
            res.Id = result.Id;
            res.StatusCode = ServiceResponseStatus.Success;
            return res;
        }

        public Task<ULDContainerDto> GetAsync(ULDContainerQM query)
        {
            throw new NotImplementedException();
        }
    }
}
