using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleService : BaseService, IFlightScheduleService
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
            base(unitOfWork, mapper)
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
            var aircraftConfigType = await _aircraftService.GetAircraftConfigType(flightSchedule.AircraftSubTypeId);

            if (aircraftConfigType == AircraftConfigType.P2C)
                return await _layoutCloneService.CloneLayoutAsync(flightSchedule, flightScheduleSectors);
            else if (aircraftConfigType == AircraftConfigType.Freighter)
                return await _layoutCloneService.CloneULDCargoLayoutAsync(flightSchedule, flightScheduleSectors);
            else
                return false;

        }

        public async Task<ServiceResponseStatus> UpdateAsync(FlightScheduleUpdateRM model)
        {
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

        public async Task<IReadOnlyList<FlightScheduleVM>> GetListAsync()
        {
            var list = await _unitOfWork.Repository<FlightSchedule>().GetListAsync();
            return _mapper.Map<IReadOnlyList<FlightScheduleVM>>(list);
        }

        public async Task<IReadOnlyList<FlightScheduleLinkVM>> GetListByMasterIdAsync(FlightScheduleLinkQM query)
        {
            var spec = new FlightScheduleSpecification(query);
            var list = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(spec);
            return _mapper.Map<IReadOnlyList<FlightScheduleLinkVM>>(list);

        }

        public async Task<IReadOnlyList<AircraftDto>> GetAvailableAircrafts_ByFlightScheduleIdAsync(Guid flightScheduleId)
        {
            List<AircraftDto> list = new List<AircraftDto>();
            // Get Flight Schedule List by id
            var spec = new FlightScheduleSpecification(
                new CargoBookingSummaryDetailQM()
                {
                    Id = flightScheduleId,
                    IsIncludeAircraftType = true,
                    IsIncludeFlightScheduleSectors = true
                });

            var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);

            // Get Aircrafts according to Config Type and Sub Type
            var aircraftConfig = await _aircraftService.GetAircraftConfigType(flightSchedule.AircraftSubTypeId);

            var aircraftlist = await _unitOfWork.Repository<Aircraft>().GetListAsync();
            var filteredAircraftlist = aircraftlist.Where(x => x.ConfigurationType == aircraftConfig);

            // Get times from Flight sector
            var orderedfSector = flightSchedule.FlightScheduleSectors.OrderBy(x => x.SequenceNo);
            TimeSpan depTime = orderedfSector.FirstOrDefault().Flight.FlightSectors.FirstOrDefault().DepartureDateTime.Value;
            TimeSpan arrTime = orderedfSector.LastOrDefault().Flight.FlightSectors.LastOrDefault().ArrivalDateTime.Value;

            // Get master schedule time from Aircraft Schedule according to times of Flight sector  (Only Extracly matched/ between).
            var specAircraftSc = new AircraftScheduleSpecification(flightSchedule.ScheduledDepartureDateTime, flightSchedule.ScheduledDepartureDateTime.Date + arrTime);
            var allMatchingAircratSchedule = await _unitOfWork.Repository<AircraftSchedule>().GetListWithSpecAsync(specAircraftSc);

            // logic
            foreach (var aircraftSchedule in allMatchingAircratSchedule)
            {
                var avaialbleAircraft = filteredAircraftlist.Where(x => x.Id == aircraftSchedule.AircraftId).FirstOrDefault();
                if (!list.Any(x => x.Id == avaialbleAircraft.Id))
                    if (avaialbleAircraft != null)
                    {
                        var mappedAricraft = _mapper.Map<Aircraft, AircraftDto>(avaialbleAircraft);
                        mappedAricraft.AircraftScheduleId = aircraftSchedule.Id;
                        list.Add(mappedAricraft);
                    }
                        
            }
            return list;
        }
    }
}