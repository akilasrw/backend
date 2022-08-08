﻿using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainer;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

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

        public async Task<ServiceResponseStatus> UpdateAsync(ULDContainerUpdateRM dto)
        {
            var entity = _mapper.Map<ULDContainer>(dto);
           _unitOfWork.Repository<ULDContainer>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<ULDContainer>().Detach(entity);
            return ServiceResponseStatus.Success;
        }

        public Task<ULDContainerDto> GetAsync(ULDContainerQM query)
        {
            throw new NotImplementedException();
        }
    }
}
