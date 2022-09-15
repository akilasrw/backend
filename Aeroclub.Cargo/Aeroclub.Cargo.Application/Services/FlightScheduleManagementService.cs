using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
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
            var response = new ServiceResponseCreateStatus();

            var createdFlightScheduleStatus = await CreateFlightSchedule(dto);

            if (createdFlightScheduleStatus == ServiceResponseStatus.Success)
            {
                var flightScheduleManagementEntity = _mapper.Map<FlightScheduleManagement>(dto);
                var flightScheduleManagementResponse = await _unitOfWork.Repository<FlightScheduleManagement>().CreateAsync(flightScheduleManagementEntity);
                await _unitOfWork.SaveChangesAsync();

                if (flightScheduleManagementResponse == null)
                {
                    response.StatusCode = ServiceResponseStatus.Failed;
                }
            }
            else
            {
                response.StatusCode = createdFlightScheduleStatus;
            }
            return response;
        }

        public async Task<FlightScheduleManagementVM> GetAsync(FlightScheduleManagementDetailQM query)
        {
            var spec = new FlightScheduleManagementSpecification(query);
            var entity = await _unitOfWork.Repository<FlightScheduleManagement>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<FlightScheduleManagement, FlightScheduleManagementVM>(entity);
        }

        public async Task<Pagination<FlightScheduleManagementVM>> GetFilteredListAsync(FlightScheduleManagementFilteredListQM query)
        {
            query.IncludeAircraft = true;
            var spec = new FlightScheduleManagementSpecification(query);
            var flightScheduleManagementList = await _unitOfWork.Repository<FlightScheduleManagement>().GetListWithSpecAsync(spec);

            var countSpec = new FlightScheduleManagementSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<FlightScheduleManagement>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<FlightScheduleManagementVM>>(flightScheduleManagementList);
            return new Pagination<FlightScheduleManagementVM>(query.PageIndex, query.PageSize, totalCount, dtoList);

        }

        private async Task<ServiceResponseStatus> CreateFlightSchedule(FlightScheduleManagementRM dto)
        {
            var flightDetail = await _flightService.GetDetailAsync(new FlightDetailQM() { Id = dto.FlightId, IsIncludeFlightSectors = true });
            var aircraftDetail = await _unitOfWork.Repository<Aircraft>().GetByIdAsync(dto.AircraftId);
            IList<int> daysOfWeek = new List<int>();
            List<DateTime> bookingDays = new List<DateTime>();

            if (flightDetail == null)
                return ServiceResponseStatus.ValidationError;

            if (flightDetail.FlightSectors.Count < 1)
                return ServiceResponseStatus.ValidationError;

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
                return ServiceResponseStatus.ValidationError;


            if (daysOfWeek.Count > 0)
            {
                foreach (var day in daysOfWeek)
                {
                    bookingDays.AddRange(dto.ScheduleStartDate.GetWeekdayInRange(dto.ScheduleEndDate, day.GetDayOfWeek()));
                }
            }
            else
                return ServiceResponseStatus.ValidationError;

            if (bookingDays.Count > 0)
            {
                foreach (var day in bookingDays)
                {
                    var flightSchedule = new FlightScheduleCreateRM();
                    var flightScheduleSectors = new List<FlightScheduleSectorCreateRM>();
                    flightSchedule.FlightId = flightDetail.Id;
                    flightSchedule.FlightNumber = flightDetail.FlightNumber;
                    flightSchedule.ScheduledDepartureDateTime =
                                                flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime == DateTime.MinValue ?
                                                day :
                                                day.Add(flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime.TimeOfDay);
                    flightSchedule.ActualDepartureDateTime =
                                                flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime == DateTime.MinValue ?
                                                day :
                                                day.Add(flightDetail.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime.TimeOfDay);
                    flightSchedule.FlightScheduleStatus = FlightScheduleStatus.None;
                    flightSchedule.OriginAirportId = flightDetail.OriginAirportId;
                    flightSchedule.DestinationAirportId = flightDetail.DestinationAirportId;
                    flightSchedule.AircraftId = aircraftDetail.Id;
                    flightSchedule.AircraftRegNo = aircraftDetail.RegNo;

                    foreach (var sector in flightDetail.FlightSectors)
                    {
                        flightScheduleSectors.Add(new FlightScheduleSectorCreateRM()
                        {
                            FlightId = flightDetail.Id,
                            SectorId = sector.SectorId,
                            SequenceNo = sector.Sequence,
                            FlightNumber = flightDetail.FlightNumber,
                            AircraftId = aircraftDetail.Id,
                            FlightScheduleStatus = FlightScheduleStatus.None,
                            OriginAirportId = sector.Sector.OriginAirportId,
                            DestinationAirportId = sector.Sector.DestinationAirportId,
                            OriginAirportCode = sector.Sector.OriginAirportCode,
                            DestinationAirportCode = sector.Sector.DestinationAirportCode,
                            OriginAirportName = sector.Sector.OriginAirportName,
                            DestinationAirportName = sector.Sector.DestinationAirportName,
                            ScheduledDepartureDateTime = sector.DepartureDateTime == DateTime.MinValue ? day : day.Add(sector.DepartureDateTime.TimeOfDay),
                            ActualDepartureDateTime = sector.DepartureDateTime == DateTime.MinValue ? day : day.Add(sector.DepartureDateTime.TimeOfDay),
                        });
                    }
                    flightSchedule.FlightScheduleSectors = flightScheduleSectors;

                    var flightScheduleResponse = await _flightScheduleService.CreateAsync(flightSchedule);

                    if (flightScheduleResponse.StatusCode == ServiceResponseStatus.Failed) return ServiceResponseStatus.Failed;
                    if (flightScheduleResponse.StatusCode == ServiceResponseStatus.ValidationError) return ServiceResponseStatus.ValidationError;

                }
            }
            else
                return ServiceResponseStatus.ValidationError;

            return ServiceResponseStatus.Success;
        }

    }
}
