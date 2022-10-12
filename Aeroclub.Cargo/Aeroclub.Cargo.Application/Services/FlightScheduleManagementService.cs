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
using Aeroclub.Cargo.Infrastructure.DateGenerator.Interfaces;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Models;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleManagementService : BaseService, IFlightScheduleManagementService
    {
        private readonly IFlightScheduleService _flightScheduleService;
        private readonly IDateGeneratorService _dateGeneratorService;
        private readonly IFlightService _flightService;
        private readonly ISectorService _sectorService;

        public FlightScheduleManagementService(
            IUnitOfWork unitOfWork,
            IFlightService flightService,
            ISectorService sectorService,
            IDateGeneratorService dateGeneratorService,
            IMapper mapper, IFlightScheduleService flightScheduleService) :
            base(unitOfWork, mapper)
        {
            _flightScheduleService = flightScheduleService;
            _flightService = flightService;
            _sectorService = sectorService;
            _dateGeneratorService = dateGeneratorService;
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
            await _unitOfWork.Repository<FlightScheduleManagement>().GetEntityWithSpecAsync(spec2);

            // filter assgined aircrafts according to time slots

            // take all unassgined aircrafts


            // filter available aircrafts
        }
    }
}
