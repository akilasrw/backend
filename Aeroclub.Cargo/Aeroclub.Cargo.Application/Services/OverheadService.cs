using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.OverheadPositionQMs;
using Aeroclub.Cargo.Application.Specifications;
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
    public class OverheadService:BaseService, IOverheadService
    {
        public OverheadService(IUnitOfWork unitOfWork, IMapper mapper)
            :base(unitOfWork, mapper)
        {

        }

        public async Task<OverheadPositionDto> GetAsync(OverheadPositionQM query)
        {

            var spec = new OverheadPositionSpecification(query);
            var overheadPosition = await _unitOfWork.Repository<OverheadPosition>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<OverheadPositionDto>(overheadPosition);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(OverheadPositionDto overheadPositionDto)
        {
            var overheadPosition = _mapper.Map<OverheadPosition>(overheadPositionDto);
            _unitOfWork.Repository<OverheadPosition>().Update(overheadPosition);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<OverheadPosition>().Detach(overheadPosition);
            return ServiceResponseStatus.Success;
        }
    }
}
