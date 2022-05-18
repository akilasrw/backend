using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs;
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
    public class SeatConfigurationService :BaseService, ISeatConfigurationService
    {
        public SeatConfigurationService(IUnitOfWork unitOfWork, IMapper mapper)
            :base(unitOfWork,mapper)
        {

        }

        public async Task<SeatConfigurationDto> GetAsync(SeatConfigurationQM query)
        {
            var seatConfig = await _unitOfWork.Repository<SeatConfiguration>()
                .GetEntityWithSpecAsync(new SeatConfigurationSpecification(query));
            return _mapper.Map<SeatConfigurationDto>(seatConfig);   
        }

        public async Task<ServiceResponseStatus> UpdateAsync(SeatConfigurationDto seatConfigurationDto)
        {
            var seat = _mapper.Map<SeatConfiguration>(seatConfigurationDto);
            _unitOfWork.Repository<SeatConfiguration>().Update(seat);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<SeatConfiguration>().Detach(seat);
            return ServiceResponseStatus.Success;

        }
    }
}
