using Aeroclub.Cargo.Application.Enums;
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

        public async Task<ServiceResponseStatus> UpdateULDIdAsync(ULDContainerUpdateRM dto)
        {
            var entity = await _unitOfWork.Repository<ULDContainer>().GetByIdAsync(dto.Id,false);
            entity.ULDId = dto.ULDId;
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<ULDContainer>().Detach(entity);
            return ServiceResponseStatus.Success;
        }

        public async Task<ULDContainerDto> GetAsync(ULDContainerQM query)
        {
            var res = await _unitOfWork.Repository<ULDContainer>().GetByIdAsync(query.Id);
            return _mapper.Map<ULDContainer, ULDContainerDto>(res);
        }
    }
}
