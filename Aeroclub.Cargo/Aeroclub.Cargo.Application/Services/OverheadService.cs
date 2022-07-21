using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.OverheadCompartmentQMs;
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

        public async Task<OverheadCompartmentDto> GetAsync(OverheadCompartmentQM query)
        {

            var spec = new OverheadCompartmentSpecification(query);
            var overheadCompartment = await _unitOfWork.Repository<OverheadCompartment>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<OverheadCompartmentDto>(overheadCompartment);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(OverheadCompartmentDto overheadCompartmentDto)
        {
            var overheadCompartment = _mapper.Map<OverheadCompartment>(overheadCompartmentDto);
            _unitOfWork.Repository<OverheadCompartment>().Update(overheadCompartment);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<OverheadCompartment>().Detach(overheadCompartment);
            return ServiceResponseStatus.Success;
        }
    }
}
