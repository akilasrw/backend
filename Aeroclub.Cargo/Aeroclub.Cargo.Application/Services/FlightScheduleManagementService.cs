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
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleManagementService : BaseService, IFlightScheduleManagementService
    {
        private readonly IFlightScheduleService _flightScheduleService;
        private readonly IFlightService _flightService;
        public FlightScheduleManagementService(
            IUnitOfWork unitOfWork,
            IFlightService flightService,
            IMapper mapper, IFlightScheduleService flightScheduleService) :
            base(unitOfWork, mapper)
        {
            _flightScheduleService = flightScheduleService;
            _flightService = flightService;

        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleManagementRM dto)
        {

            var createdFlightSchedule = await CreateFlightSchedule(dto);

            if (createdFlightSchedule.StatusCode == ServiceResponseStatus.Success)
            {
                var flightScheduleManagementEntity = _mapper.Map<FlightScheduleManagement>(dto);
                flightScheduleManagementEntity.IsFlightScheduleGenerated = true;
                var flightScheduleManagementResponse = await _unitOfWork.Repository<FlightScheduleManagement>().CreateAsync(flightScheduleManagementEntity);
                await _unitOfWork.SaveChangesAsync();

                if (flightScheduleManagementResponse == null)
                {
                    createdFlightSchedule.StatusCode = ServiceResponseStatus.Failed;
                }
            }
           
            return createdFlightSchedule;
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

            var dtoList = _mapper.Map<IReadOnlyList<FlightScheduleManagementVM>>(flightScheduleManagementList);
            return new Pagination<FlightScheduleManagementVM>(query.PageIndex, query.PageSize, totalCount, dtoList);

        }

        private async Task<ServiceResponseCreateStatus> CreateFlightSchedule(FlightScheduleManagementRM dto)
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
                    var flightSchedule = new FlightScheduleCreateRM();
                    var flightScheduleSectors = new List<FlightScheduleSectorCreateRM>();
                    flightSchedule.FlightId = flightDetail.Id;
                    flightSchedule.FlightNumber = flightDetail.FlightNumber;
                    flightSchedule.ScheduledDepartureDateTime =
                                                flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime == DateTime.MinValue ?
                                                day :
                                                day.Date.Add(flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime.TimeOfDay);
                    flightSchedule.ActualDepartureDateTime =
                                                flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime == DateTime.MinValue ?
                                                day :
                                                day.Date.Add(flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime.TimeOfDay);
                    flightSchedule.FlightScheduleStatus = FlightScheduleStatus.None;
                    flightSchedule.OriginAirportId = flightDetail.OriginAirportId;
                    flightSchedule.DestinationAirportId = flightDetail.DestinationAirportId;
                    flightSchedule.AircraftSubTypeId = dto.AircraftSubTypeId;

                    foreach (var sector in flightDetail.FlightSectors)
                    {
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
                            ScheduledDepartureDateTime = sector.DepartureDateTime == DateTime.MinValue ? day : day.Date.Add(sector.DepartureDateTime.TimeOfDay),
                            ActualDepartureDateTime = sector.DepartureDateTime == DateTime.MinValue ? day : day.Date.Add(sector.DepartureDateTime.TimeOfDay),
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
    }
}
