using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleService :BaseService, IFlightScheduleService
    {
        private readonly IFlightService _flightService;
        private readonly IAircraftService _aircraftService;
        private readonly ILayoutCloneService _layoutCloneService;

        public FlightScheduleService(
            IUnitOfWork unitOfWork, 
            IMapper mapper,
            IFlightService flightService,
            IAircraftService aircraftService,
            ILayoutCloneService layoutCloneService) :
            base(unitOfWork,mapper)
        {
            _flightService = flightService;
            _aircraftService = aircraftService;
            _layoutCloneService = layoutCloneService;
        }

        public async Task<FlightScheduleCreateStatusRM> CreateAsync(FlightScheduleCreateRM model)
        {
            var responseStatus = new FlightScheduleCreateStatusRM();
            var entity = _mapper.Map<FlightSchedule>(model);
            
            if (string.IsNullOrEmpty(entity.FlightNumber) && model.FlightId.HasValue)
                entity.FlightNumber = await _flightService.GetFlightNumber(model.FlightId.Value);
            
            if (string.IsNullOrEmpty(entity.AircraftRegNo) && model.AircraftId.HasValue)
                entity.AircraftRegNo = await _aircraftService.GetAircraftRegNo(model.AircraftId.Value);

            if (string.IsNullOrEmpty(entity.OriginAirportCode))
            {
                var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);
                entity.MapOriginAirport(originAirport);
            }

            if (string.IsNullOrEmpty(entity.DestinationAirportCode))
            {
                var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.DestinationAirportId);
                entity.MapDestinationAirport(destinationAirport);
            }
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var flightScheduleSectors = model.FlightScheduleSectors;
                    entity.FlightScheduleSectors.Clear();
                    await _unitOfWork.Repository<FlightSchedule>().CreateAsync(entity);
                    await _unitOfWork.SaveChangesAsync();
                    responseStatus.Id = entity.Id;
                    responseStatus.StatusCode = ServiceResponseStatus.Success;
                    if (entity.Id != Guid.Empty)
                        if (!await CloneLayoutAsync(entity, flightScheduleSectors))
                        {
                            await transaction.RollbackAsync();
                            responseStatus.StatusCode = ServiceResponseStatus.Failed;
                        }

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }
                
            return responseStatus;
        }

        private async Task<bool> CloneLayoutAsync(FlightSchedule flightSchedule, IEnumerable<FlightScheduleSectorCreateRM>? flightScheduleSectors)
        {
           return await _layoutCloneService.CloneLayoutAsync(flightSchedule, flightScheduleSectors);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(FlightScheduleUpdateRM model)
        {
            var entity = _mapper.Map<FlightSchedule>(model);

            if(string.IsNullOrEmpty(entity.FlightNumber) && model.FlightId.HasValue)
                entity.FlightNumber = await _flightService.GetFlightNumber(model.FlightId.Value);
            
            if (string.IsNullOrEmpty(entity.AircraftRegNo) && model.AircraftId.HasValue)
                entity.AircraftRegNo = await _aircraftService.GetAircraftRegNo(model.AircraftId.Value);

            if (string.IsNullOrEmpty(entity.OriginAirportCode))
            {
                var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);
                entity.MapOriginAirport(originAirport);
            }

            if (string.IsNullOrEmpty(entity.DestinationAirportCode))
            {
                var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.DestinationAirportId);
                entity.MapDestinationAirport(destinationAirport);
            }
            
            _unitOfWork.Repository<FlightSchedule>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return ServiceResponseStatus.Success;
        }

        public async Task<FlightScheduleVM> GetAsync(FlightScheduleQM query)
        {

            var spec = new FlightScheduleSpecification(query);
            var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);

            return _mapper.Map<FlightSchedule, FlightScheduleVM>(flightSchedule);
        }
    }
}