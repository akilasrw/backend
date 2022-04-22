using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
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
    public class SeatService : BaseService, ISeatService
    {
        public SeatService(IUnitOfWork unitOfWork, IMapper mapper) 
            : base(unitOfWork, mapper)
        {
        }

        public async Task<ServiceResponseStatus> UpdateAsync(SeatDto seatDto)
        {
            var seat = _mapper.Map<Seat>(seatDto);          
            _unitOfWork.Repository<Seat>().Update(seat);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<Seat>().Detach(seat);
            return ServiceResponseStatus.Success;
            
        }

        public async Task<SeatDto> GetAsync(SeatQM query)
        {
            var spec = new SeatSpecification(query);
            var sector = await _unitOfWork.Repository<Seat>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<SeatDto>(sector);
        }
    }
}
