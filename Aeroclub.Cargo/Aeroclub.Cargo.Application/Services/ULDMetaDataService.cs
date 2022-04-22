using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDMetaDataQMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDMetaDataService :BaseService, IULDMetaDataService
    {

        public ULDMetaDataService(IMapper mapper, IUnitOfWork unitOfWork):
            base(unitOfWork,mapper)
        {
          
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(ULDMetaDataDto dto)
        {
            var uldMetadata = _mapper.Map<ULDMetaData>(dto);
            var uldMeta = await _unitOfWork.Repository<ULDMetaData>().CreateAsync(uldMetadata);
            await _unitOfWork.SaveChangesAsync();
            var response = new ServiceResponseCreateStatus() { Id = uldMeta.Id, StatusCode = ServiceResponseStatus.Success };
            return response;
        }

        public async Task<ULDMetaDataDto> GetAsync(ULDMetaDataQM query)
        {
            var spec = new ULDMetaDataSpecification(query);
            var cargoAgent = await _unitOfWork.Repository<ULDMetaData>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<ULDMetaData, ULDMetaDataDto>(cargoAgent);
        }
    }
}
