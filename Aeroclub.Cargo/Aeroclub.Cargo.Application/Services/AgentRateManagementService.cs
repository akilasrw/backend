using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AgentRateManagementService : BaseService, IAgentRateManagementService
    {
        public AgentRateManagementService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AgentRateManagementRM dto)
        {
            var response = new ServiceResponseCreateStatus();

/*
            var entity = _mapper.Map<AgentRateManagement>(dto);

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

            if (aircraftLayoutMapping == null ||
                aircraftLayoutMapping.AircraftLayoutId == null)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }

            if (dto.ConfigurationType == AircraftConfigType.P2C &&
                (aircraftLayoutMapping.OverheadLayoutId == null ||
                aircraftLayoutMapping.SeatLayoutId == null))
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }

            entity.AircraftType = aircraftType.Type;
            entity.AircraftSubType = aircraftSubType.Type;


            await _unitOfWork.Repository<Aircraft>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            response.Id = entity.Id;
            response.StatusCode = ServiceResponseStatus.Success;*/
            return response;
        }
    }
}
