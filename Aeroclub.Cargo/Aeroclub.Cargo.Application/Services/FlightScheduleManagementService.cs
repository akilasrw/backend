using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Interfaces;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Models;
using static Grpc.Core.Metadata;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleManagementService : BaseService, IFlightScheduleManagementService
    {
        private readonly IFlightScheduleService _flightScheduleService;
        private readonly IDateGeneratorService _dateGeneratorService;
        private readonly IFlightService _flightService;
        private readonly ISectorService _sectorService;
        private readonly ILayoutCloneService _layoutCloneService;

        public FlightScheduleManagementService(
            IUnitOfWork unitOfWork,
            IFlightService flightService,
            ISectorService sectorService,
            IDateGeneratorService dateGeneratorService,
            ILayoutCloneService layoutCloneService,
            IMapper mapper, IFlightScheduleService flightScheduleService) :
            base(unitOfWork, mapper)
        {
            _flightScheduleService = flightScheduleService;
            _flightService = flightService;
            _sectorService = sectorService;
            _dateGeneratorService = dateGeneratorService;
            _layoutCloneService= layoutCloneService;
        }


        public async Task<bool> CheckSchedule(FlightScheduleManagementRM dto)
        {
            var specs = new FlightScheduleManagementSpecification(dto.ScheduleStartDate, dto.ScheduleEndDate, dto.FlightId);
            var existingSchedule = await _unitOfWork.Repository<FlightScheduleManagement>().GetEntityWithSpecAsync(specs);

            if(existingSchedule != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleManagementRM dto)
        {
            var res = new ServiceResponseCreateStatus();
            var flightScheduleManagementEntity = _mapper.Map<FlightScheduleManagement>(dto);
            flightScheduleManagementEntity.IsFlightScheduleGenerated = true;
            var flightScheduleManagementResponse = await _unitOfWork.Repository<FlightScheduleManagement>().CreateAsync(flightScheduleManagementEntity);
            await _unitOfWork.SaveChangesAsync();

            if (flightScheduleManagementResponse == null)
            {
                res.StatusCode = ServiceResponseStatus.Failed;
            }
            else
            {
                var flightScheduleResponse = await CreateFlightSchedule(dto, flightScheduleManagementResponse.Id);
                if(flightScheduleResponse.StatusCode == ServiceResponseStatus.Failed || flightScheduleResponse.StatusCode == ServiceResponseStatus.ValidationError)
                {
                    await DeleteAsync(flightScheduleManagementResponse.Id);
                }

                res= flightScheduleResponse;
            }

            return res;
        }


        public async Task<ServiceResponseCreateStatus> UpdateAsync(FlightScheduleManagementUpdateRM dto)
        {
            var existingScheduleDeleteResponse = await DeleteFlightSchedule(dto.FlightScheduleIds);

            if (existingScheduleDeleteResponse.StatusCode == ServiceResponseStatus.Failed || existingScheduleDeleteResponse.StatusCode == ServiceResponseStatus.ValidationError)
            {
                return existingScheduleDeleteResponse;
            }

            dto.IsFlightScheduleGenerated = true;
            var flightScheduleManagementEntity = _mapper.Map<FlightScheduleManagement>(dto);

            _unitOfWork.Repository<FlightScheduleManagement>().Update(flightScheduleManagementEntity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<FlightScheduleManagement>().Detach(flightScheduleManagementEntity);

            var flightScheduleManagementDto = _mapper.Map<FlightScheduleManagementRM>(dto);

            var flightScheduleResponse = await CreateFlightSchedule(flightScheduleManagementDto, flightScheduleManagementEntity.Id);
            if (flightScheduleResponse.StatusCode == ServiceResponseStatus.Failed || flightScheduleResponse.StatusCode == ServiceResponseStatus.ValidationError)
            {
                await DeleteAsync(flightScheduleManagementEntity.Id);
            }
            return flightScheduleResponse;
        }

       
        public async Task<FlightScheduleManagementVM> GetAsync(FlightScheduleManagementDetailQM query)
        {
            var spec = new FlightScheduleManagementSpecification(query);
            var entity = await _unitOfWork.Repository<FlightScheduleManagement>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<FlightScheduleManagement, FlightScheduleManagementVM>(entity);
        }

        public async Task<Pagination<FlightScheduleManagementVM>> GetFilteredListAsync(FlightScheduleManagementFilteredListQM query)
        {
            var spec = new FlightScheduleManagementSpecification(query);
            var flightScheduleManagementList = await _unitOfWork.Repository<FlightScheduleManagement>().GetListWithSpecAsync(spec);

            var countSpec = new FlightScheduleManagementSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<FlightScheduleManagement>().CountAsync(countSpec);

            //foreach (var mgt in flightScheduleManagementList)
            //{
            //    mgt.Flight = await _flightService.MappedFlightSectorData(mgt.Flight, false);
            //}
            var dtoList = _mapper.Map<IReadOnlyList<FlightScheduleManagementVM>>(flightScheduleManagementList);
            return new Pagination<FlightScheduleManagementVM>(query.PageIndex, query.PageSize, totalCount, dtoList);

        }


        private async Task<ServiceResponseCreateStatus> CreateFlightSchedule(FlightScheduleManagementRM dto, Guid id)
        {

            var flightDetail = await _flightService.GetDetailAsync(new FlightDetailQM() { Id = dto.FlightId, IsIncludeFlightSectors = true });

            if (flightDetail == null)
                return new ServiceResponseCreateStatus() { StatusCode =ServiceResponseStatus.ValidationError};

            if (flightDetail.FlightSectors.Count < 1)
                return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };

            var bookingDays = _dateGeneratorService.GetDates(new DateGeneratorRM(){ DaysOfWeek = dto.DaysOfWeek, ScheduleStartDate = dto.ScheduleStartDate,ScheduleEndDate = dto.ScheduleEndDate});

            if (bookingDays.Count > 0)
            {

                var scheduledList = await _flightScheduleService.GetListAsync();

                if (scheduledList != null && scheduledList.Count > 0)
                {
                    foreach (var day in bookingDays)
                    {
                        var matchingSchedule = scheduledList.FirstOrDefault(z => z.ScheduledDepartureDateTime.Date == day.Date && z.FlightId == dto.FlightId && z.AircraftSubTypeId == dto.AircraftSubTypeId);
                        if (matchingSchedule != null)
                            return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError, Message = "This aircraft and flight are already assigned for " + day.Date.ToShortDateString() + "." };
                    }
                }

                foreach (var day in bookingDays)
                {
                    var firstSector = flightDetail.FlightSectors.First(r => r.Sequence == 1);
                    var list = await _sectorService.GetSectorAirports(firstSector.SectorId);

                    var flightSchedule = new FlightScheduleCreateRM();
                    var flightScheduleSectors = new List<FlightScheduleSectorCreateRM>();
                    flightSchedule.FlightId = flightDetail.Id;
                    flightSchedule.FlightNumber = flightDetail.FlightNumber;
                    flightSchedule.ScheduledDepartureDateTime =
                                                firstSector.DepartureDateTime == DateTime.MinValue ?
                                                day :
                                                day.Date.Add(firstSector.DepartureDateTime.TimeOfDay);
                    flightSchedule.ActualDepartureDateTime = DateTime.MinValue;
                    flightSchedule.FlightScheduleStatus = FlightScheduleStatus.None;
                    flightSchedule.OriginAirportId = flightDetail.OriginAirportId;
                    flightSchedule.DestinationAirportId = flightDetail.DestinationAirportId;
                    flightSchedule.AircraftSubTypeId = dto.AircraftSubTypeId;
                    flightSchedule.FlightScheduleManagementId = id;

                    foreach (var sector in flightDetail.FlightSectors)
                    {
                        list = await _sectorService.GetSectorAirports(sector.SectorId);
                        var utcDepartureDateTime = sector.DepartureDateTime == DateTime.MinValue ? day
                            : day.Date.Add(sector.DepartureDateTime.TimeOfDay);

                        flightScheduleSectors.Add(new FlightScheduleSectorCreateRM()
                        {
                            FlightId = flightDetail.Id,
                            SectorId = sector.SectorId,
                            SequenceNo = sector.Sequence,
                            FlightNumber = flightDetail.FlightNumber,
                            AircraftSubTypeId = dto.AircraftSubTypeId,
                            FlightScheduleStatus = FlightScheduleStatus.None,
                            OriginAirportId = sector.Sector.OriginAirportId,
                            DestinationAirportId = sector.Sector.DestinationAirportId,
                            OriginAirportCode = sector.Sector.OriginAirportCode,
                            DestinationAirportCode = sector.Sector.DestinationAirportCode,
                            OriginAirportName = sector.Sector.OriginAirportName,
                            DestinationAirportName = sector.Sector.DestinationAirportName,
                            ScheduledDepartureDateTime = utcDepartureDateTime,
                            ActualDepartureDateTime = DateTime.MinValue,
                        });
                    }
                    flightSchedule.FlightScheduleSectors = flightScheduleSectors;

                    var flightScheduleResponse = await _flightScheduleService.CreateAsync(flightSchedule);

                    if (flightScheduleResponse.StatusCode == ServiceResponseStatus.Failed) return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Failed };
                    if (flightScheduleResponse.StatusCode == ServiceResponseStatus.ValidationError) return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };

                }
            }
            else
                return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };

            return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success };
        }

        private async Task<ServiceResponseCreateStatus> DeleteFlightSchedule(List<Guid> flightScheduleIds)
        {
            if(flightScheduleIds.Count() <1) return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                foreach (var scheduleId in flightScheduleIds)
                {
                    var spec = new FlightScheduleSpecification(new FlightScheduleQM() { Id = scheduleId, IncludeFlightScheduleSectors = true });
                    var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);
                    if (flightSchedule == null || flightSchedule.FlightScheduleSectors == null || flightSchedule.FlightScheduleSectors.Count() < 1) {
                        transaction.Rollback();
                        return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };
                    }

                    var deleteClonedLayoutResponse = await _layoutCloneService.DeleteClonedCargoLayoutAsync(flightSchedule);
                    if (!deleteClonedLayoutResponse) {
                        transaction.Rollback();
                        return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Failed }; 
                    }

                    var flightScheduleDeleteResponse = await _flightScheduleService.DeleteAsync(scheduleId);
                    if (!flightScheduleDeleteResponse) {
                        transaction.Rollback();
                        return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Failed }; 
                    }
                }
                transaction.Commit();
            }
            return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success };
        }


        public async Task GetUnAssignedAircraftAsync(Guid flightScheduleManagementId)
        {
            // Get relevent flight schedule mgt
            var spec = new FlightScheduleManagementSpecification(new FlightScheduleManagementDetailQM() { Id = flightScheduleManagementId });
            var flightScheduleManagement = await _unitOfWork.Repository<FlightScheduleManagement>().GetEntityWithSpecAsync(spec);

            // take all assgined aircrafts
            var spec2 = new FlightScheduleManagementSpecification(flightScheduleManagement.AircraftSubTypeId);
            var fsmgtList = await _unitOfWork.Repository<FlightScheduleManagement>().GetListWithSpecAsync(spec2);

            // filter assgined aircrafts according to time slots
            var assignedAircraftList = fsmgtList.Where(x => x.FlightSchedules.Any(y => y.AircraftId != null)).ToList();
            List<Guid> aircraftIdList = new List<Guid>();
            foreach (var a in assignedAircraftList)
            {
                foreach (var s in a.FlightSchedules)
                {
                    if (s.AircraftId != null && !aircraftIdList.Any(x => x == s.AircraftId.Value))
                        aircraftIdList.Add(s.AircraftId.Value);
                }
            }

            // take all unassgined aircrafts
            var Aircraftlist = await _unitOfWork.Repository<Aircraft>().GetListAsync();
            Aircraftlist.Where(x => x.AircraftSubType == fsmgtList.First().AircraftSubType.Type).ToList();

            // filter available aircrafts
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {
            var entity = await _unitOfWork.Repository<FlightScheduleManagement>().GetEntityWithSpecAsync(new FlightScheduleManagementSpecification(new FlightScheduleManagementDetailQM { Id = Id}));
            _unitOfWork.Repository<FlightScheduleManagement>().Delete(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<FlightScheduleManagement>().Detach(entity);
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }

    }
}
