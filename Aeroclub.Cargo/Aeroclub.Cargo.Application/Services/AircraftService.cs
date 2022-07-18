using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.Queries.AircrftLayoutMappingQM;
using Aeroclub.Cargo.Application.Models.RequestModels.AircraftRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AircraftService :BaseService, IAircraftService
    {
       
        public AircraftService(IUnitOfWork unitOfWork, IMapper mapper):
            base(unitOfWork,mapper)
        {
           
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AircaftCreateRM dto)
        {

            var response = new ServiceResponseCreateStatus();

            var aircraftList = await _unitOfWork.Repository<Aircraft>().GetListWithSpecAsync(new AircraftSpecification(new AircraftValidationQM() { RegNo = dto.RegNo}));

            if(aircraftList != null && aircraftList?.Count > 0)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                return response;
            }

            var entity = _mapper.Map<Aircraft>(dto);

            var aircraftType = await _unitOfWork.Repository<AircraftType>().GetByIdAsync(dto.AircraftTypeId);
            var aircraftSubType = await _unitOfWork.Repository<AircraftSubType>().GetByIdAsync(dto.AircraftSubTypeId);
            var aircraftLayoutMapping = await _unitOfWork.Repository<AircraftLayoutMapping>().GetEntityWithSpecAsync(new AircraftLayoutMappingSpecification(new AircraftLayoutMappingQM()
            {
                AircraftSubTypeId = dto.AircraftSubTypeId,
                AircraftTypeId = dto.AircraftTypeId,
            }));


            if (aircraftType == null)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }

            if (aircraftSubType == null)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }

            if(aircraftLayoutMapping == null ||
                aircraftLayoutMapping.AircraftLayoutId == null)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }

            if(dto.ConfigurationType == AircraftConfigType.P2C && 
                aircraftLayoutMapping.OverheadLayoutId == null ||
                aircraftLayoutMapping.SeatLayoutId == null)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }

            entity.AircraftType = aircraftType.Type;
            entity.AircraftSubType = aircraftSubType.Type;

            entity.AircraftLayoutId = (Guid)(aircraftLayoutMapping.AircraftLayoutId);
            entity.OverheadLayoutId = (dto.ConfigurationType == AircraftConfigType.P2C)?aircraftLayoutMapping.OverheadLayoutId:null;
            entity.SeatLayoutId = (dto.ConfigurationType == AircraftConfigType.P2C)?aircraftLayoutMapping.SeatLayoutId:null;
                         

            await _unitOfWork.Repository<Aircraft>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            response.Id = entity.Id;
            response.StatusCode = ServiceResponseStatus.Success;
            return response;

        }

        public async Task<string> GetAircraftRegNo(Guid id)
        {
            var flight = await _unitOfWork.Repository<Aircraft>().GetByIdAsync(id);
            return flight.RegNo;
        }

        public async Task<IReadOnlyList<AircraftTypeVM>> GetAircraftTypesAsync(AircraftTypeQM query)
        {
            query.IsIncludeSubType = true;
            var spec = new AircraftTypeSpecification(query);
            var aircraftTypes = await _unitOfWork.Repository<AircraftType>().GetListWithSpecAsync(spec);

            return _mapper.Map<IReadOnlyList<AircraftTypeVM>>(aircraftTypes);
        }

        public async Task<AircraftVM> GetAsync(AircraftQM query)
        {
            var spec = new AircraftSpecification(query);
            var aircraft = await _unitOfWork.Repository<Aircraft>().GetEntityWithSpecAsync(spec);
            var aircraftVM = _mapper.Map<Aircraft, AircraftVM>(aircraft);
            return aircraftVM;
        }

        public async Task<Pagination<AircraftVM>> GetFilteredListAsync(AircraftListQM query)
        {
            var spec = new AircraftSpecification(query);
            var aircraftList = await _unitOfWork.Repository<Aircraft>().GetListWithSpecAsync(spec);

            var countSpec = new AircraftSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<Aircraft>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<AircraftVM>>(aircraftList);

            return new Pagination<AircraftVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(AircaftUpdateRM dto)
        {
            var existingAircraft = await _unitOfWork.Repository<Aircraft>().GetEntityWithSpecAsync(new AircraftSpecification(new AircraftValidationQM() { RegNo = dto.RegNo }));

            if (existingAircraft != null && existingAircraft.Id != dto.Id)
            {
                return ServiceResponseStatus.ValidationError;
            }

            var entity = _mapper.Map<Aircraft>(dto);

            var aircraftType = await _unitOfWork.Repository<AircraftType>().GetByIdAsync(dto.AircraftTypeId);
            var aircraftSubType = await _unitOfWork.Repository<AircraftSubType>().GetByIdAsync(dto.AircraftSubTypeId);
            var aircraftLayoutMapping = await _unitOfWork.Repository<AircraftLayoutMapping>().GetEntityWithSpecAsync(new AircraftLayoutMappingSpecification(new AircraftLayoutMappingQM()
            {
                AircraftSubTypeId = dto.AircraftSubTypeId,
                AircraftTypeId = dto.AircraftTypeId,
            }));

            if (aircraftType == null)
            {
                return ServiceResponseStatus.Failed;
            }

            if (aircraftSubType == null)
            {
                return ServiceResponseStatus.Failed;
            }

            if (aircraftLayoutMapping == null ||
                aircraftLayoutMapping.AircraftLayoutId == null ||
                aircraftLayoutMapping.OverheadLayoutId == null ||
                aircraftLayoutMapping.SeatLayoutId == null)
            {
                return ServiceResponseStatus.Failed;
            }

            entity.AircraftType = aircraftType.Type;
            entity.AircraftSubType = aircraftSubType.Type;

            entity.AircraftLayoutId = (Guid)(aircraftLayoutMapping.AircraftLayoutId);
            entity.OverheadLayoutId = (Guid)(aircraftLayoutMapping.OverheadLayoutId);
            entity.SeatLayoutId = (Guid)(aircraftLayoutMapping.SeatLayoutId);


            _unitOfWork.Repository<Aircraft>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<Aircraft>().Detach(entity);
            return ServiceResponseStatus.Success;
        }

       
    }
}