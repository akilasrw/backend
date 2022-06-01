using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDContainerCargoPositionService : BaseService, IULDContainerCargoPositionService
    {


        public ULDContainerCargoPositionService(IMapper mapper, IUnitOfWork unitOfWork)
             : base(unitOfWork, mapper)
        {
                
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerCargoPositionDto ULDContainerCargoPositionDto)
        {
            var res = new ServiceResponseCreateStatus();

            var model = _mapper.Map<ULDContainerCargoPosition>(ULDContainerCargoPositionDto);

            var result = await _unitOfWork.Repository<ULDContainerCargoPosition>().CreateAsync(model);

            res.Id = result.Id;
            res.StatusCode = ServiceResponseStatus.Success;

            return res;
        }
    }
}
