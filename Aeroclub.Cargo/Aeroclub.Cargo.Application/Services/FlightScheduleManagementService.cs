using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
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
        public FlightScheduleManagementService(
            IUnitOfWork unitOfWork,
            IMapper mapper,IFlightScheduleService flightScheduleService) :
            base(unitOfWork, mapper)
        {
            _flightScheduleService = flightScheduleService;

        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleManagementRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var flightScheduleManagementEntity = _mapper.Map<FlightScheduleManagement>(dto);
                    var flightScheduleManagementResponse = await _unitOfWork.Repository<FlightScheduleManagement>().CreateAsync(flightScheduleManagementEntity);
                    await _unitOfWork.SaveChangesAsync();

                    if (flightScheduleManagementResponse == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                    }

                    var createdFlightStatus = await CreateFlightSchedule(dto);

                    if(createdFlightStatus == ServiceResponseStatus.Failed)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                    }

                    if (createdFlightStatus == ServiceResponseStatus.ValidationError)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
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
            var flightDetail = await _unitOfWork.Repository<Flight>().GetByIdAsync(dto.FlightId);
            var aircraftDetail = await _unitOfWork.Repository<Aircraft>().GetByIdAsync(dto.AircraftId);
            IList<int> daysOfWeek = new List<int>();
            List<DateTime> bookingDays = new List<DateTime>();

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
                foreach(var day in bookingDays)
                {
                    var flightSchedule = new FlightScheduleCreateRM();
                    flightSchedule.FlightId = flightDetail.Id;
                    flightSchedule.FlightNumber = flightDetail.FlightNumber;
                    flightSchedule.ScheduledDepartureDateTime = day; // time need to add
                    flightSchedule.ActualDepartureDateTime = day; // time need to add
                    flightSchedule.FlightScheduleStatus = FlightScheduleStatus.None;
                    flightSchedule.OriginAirportId = flightDetail.OriginAirportId;
                    flightSchedule.DestinationAirportId = flightDetail.DestinationAirportId;
                    flightSchedule.AircraftId = aircraftDetail.Id;
                    flightSchedule.AircraftRegNo = aircraftDetail.RegNo;

                    //flightScheduleSectors need to add



                    var flightScheduleResponse = await _flightScheduleService.CreateAsync(flightSchedule);
                    if (flightScheduleResponse.StatusCode == ServiceResponseStatus.Failed)
                    {
                        return ServiceResponseStatus.Failed;
                    }
                }
            }
            else
                return ServiceResponseStatus.ValidationError;

            return ServiceResponseStatus.Success;
        }


    }
}
