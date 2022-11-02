using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerCargoPositionVMs;
using Aeroclub.Cargo.Application.Specifications;
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
            await _unitOfWork.SaveChangesAsync();

            res.Id = result.Id;
            res.StatusCode = ServiceResponseStatus.Success;

            return res;
        }

        public async Task<IReadOnlyList<ULDContainerCargoPositionVM>> GetListAsync(ULDCOntainerCargoPositionQM query)
        {

            var spec = new ULDContainerCargoPositionSpecification(query);
            var entityList = await _unitOfWork.Repository<ULDContainerCargoPosition>().GetListWithSpecAsync(spec);

            var dtoList = _mapper.Map<IReadOnlyList<ULDContainerCargoPositionVM>>(entityList);

            return dtoList;
        }

    }
}
