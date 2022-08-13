using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDService :BaseService, IULDService
    {
        private readonly IULDMetaDataService _uLDMetaDataService;

        public ULDService(IMapper mapper, IUnitOfWork unitOfWork, IULDMetaDataService uLDMetaDataService):
            base(unitOfWork,mapper)
        {
            _uLDMetaDataService = uLDMetaDataService;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(ULDDto ULDDto)
        {
            var uld = _mapper.Map<ULD>(ULDDto);
            // TODO: Future, we can remove this If this commented part is not required and both tables are saved accordingly.
            //if (uld == null) return ServiceResponseStatus.Failed;
            //var response = await _uLDMetaDataService.CreateAsync(ULDDto.ULDMetaData);

            //if (response.StatusCode == ServiceResponseStatus.Success)
            //{
             //   uld.ULDMetaDataId = response.Id;

            var entity = await _unitOfWork.Repository<ULD>().CreateAsync(uld);
            await _unitOfWork.SaveChangesAsync();
            var response = new ServiceResponseCreateStatus() { Id = entity.Id, StatusCode = ServiceResponseStatus.Success };

            return response;
            //}
            //return ServiceResponseStatus.Failed;
        }

        public Task<ULDDto> GetAsync(ULDQM query)
        {
            throw new NotImplementedException();
        }
    }
}
