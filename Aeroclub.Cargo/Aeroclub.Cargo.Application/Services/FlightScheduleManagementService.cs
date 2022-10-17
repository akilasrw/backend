using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Aeroclub.Cargo.Application.Extensions;
using System.Runtime.CompilerServices;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleManagementService : BaseService, IFlightScheduleManagementService
    {
        private readonly IFlightScheduleService _flightScheduleService;
        private readonly IFlightService _flightService;
        private readonly ISectorService _sectorService;

        public FlightScheduleManagementService(
            IUnitOfWork unitOfWork,
            IFlightService flightService,
            ISectorService sectorService,
            IMapper mapper, IFlightScheduleService flightScheduleService) :
            base(unitOfWork, mapper)
        {
            _flightScheduleService = flightScheduleService;
            _flightService = flightService;
            _sectorService = sectorService;
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
                return await CreateFlightSchedule(dto, flightScheduleManagementResponse.Id);
            }

            return res;
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

            foreach (var mgt in flightScheduleManagementList)
            {
                mgt.Flight = await _flightService.MappedFlightSectorData(mgt.Flight, false);
            }
            var dtoList = _mapper.Map<IReadOnlyList<FlightScheduleManagementVM>>(flightScheduleManagementList);
            return new Pagination<FlightScheduleManagementVM>(query.PageIndex, query.PageSize, totalCount, dtoList);

        }

        private async Task<ServiceResponseCreateStatus> CreateFlightSchedule(FlightScheduleManagementRM dto, Guid id)
        {

            var flightDetail = await _flightService.GetDetailAsync(new FlightDetailQM() { Id = dto.FlightId, IsIncludeFlightSectors = true });
            IList<int> daysOfWeek = new List<int>();
            List<DateTime> bookingDays = new List<DateTime>();

            if (flightDetail == null)
                return new ServiceResponseCreateStatus() { StatusCode =ServiceResponseStatus.ValidationError};

            if (flightDetail.FlightSectors.Count < 1)
                return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };

            if (!String.IsNullOrEmpty(dto.DaysOfWeek))
            {
                foreach (var s in dto.DaysOfWeek.Split(','))
                {
                    int num;
                    if (int.TryParse(s, out num))
                        daysOfWeek.Add(num);
                }
            }
            else
                return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };


            if (daysOfWeek.Count > 0)
            {
                foreach (var day in daysOfWeek)
                {
                    bookingDays.AddRange(dto.ScheduleStartDate.GetWeekdayInRange(dto.ScheduleEndDate, day.GetDayOfWeek()));
                }
            }
            else
                return new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.ValidationError };



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
                                                day.Date.Add(firstSector.DepartureDateTime.TimeOfDay.ToInternationalTimeSpan(list[0].CountryCodeISO3166, list[0].Lat));
                    flightSchedule.ActualDepartureDateTime = flightSchedule.ScheduledDepartureDateTime;
                    flightSchedule.FlightScheduleStatus = FlightScheduleStatus.None;
                    flightSchedule.OriginAirportId = flightDetail.OriginAirportId;
                    flightSchedule.DestinationAirportId = flightDetail.DestinationAirportId;
                    flightSchedule.AircraftSubTypeId = dto.AircraftSubTypeId;
                    flightSchedule.FlightScheduleManagementId = id;

                    foreach (var sector in flightDetail.FlightSectors)
                    {
                        list = await _sectorService.GetSectorAirports(sector.SectorId);
                        var utcDepartureDateTime = sector.DepartureDateTime == DateTime.MinValue ? day
                            : day.Date.Add(sector.DepartureDateTime.TimeOfDay.ToInternationalTimeSpan(list[0].CountryCodeISO3166, list[0].Lat));

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
                            ActualDepartureDateTime = utcDepartureDateTime,
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
    }
}
