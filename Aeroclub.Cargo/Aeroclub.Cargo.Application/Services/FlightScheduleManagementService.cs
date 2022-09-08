using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleManagementService : BaseService, IFlightScheduleManagementService
    {
        public FlightScheduleManagementService(
            IUnitOfWork unitOfWork,
            IMapper mapper) :
            base(unitOfWork, mapper)
        {

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
            IList<string?> bookingDays = new List<string?>();

            if (!String.IsNullOrEmpty(dto.DaysOfWeek))
            {
                foreach (var s in dto.DaysOfWeek.Split(','))
                {
                    int num;
                    if (int.TryParse(s, out num))
                        daysOfWeek.Add(num);
                }
            }

            if (daysOfWeek.Count > 0)
            {
                foreach (var day in daysOfWeek)
                {
                    bookingDays.Add(dto.ScheduleStartDate.GetWeekdayInRange(dto.ScheduleEndDate,day.GetDayOfWeek()).ToString());
                }
            }

            if(bookingDays.Count > 0)
            {

            }
           

            return ServiceResponseStatus.Success;

        }


    }
}
