using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AircraftScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.MasterScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AircraftScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftScheduleVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.MasterScheduleVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Interfaces;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Models;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class MasterScheduleService : BaseService, IMasterScheduleService
    {
        IDateGeneratorService _dateGeneratorService;

        public MasterScheduleService(IUnitOfWork unitOfWork,IMapper mapper, IDateGeneratorService dateGeneratorService) :base(unitOfWork,mapper)
        {
            _dateGeneratorService = dateGeneratorService;
        }

        public async Task<IReadOnlyList<AircraftScheduleVM>> GetAircraftScheduleAsync(MasterScheduleListQM query)
        {
            List<AircraftSchedule> scheduleList = new List<AircraftSchedule>();
            var bookingDays = _dateGeneratorService.GetDates(new DateGeneratorRM() { DaysOfWeek = "1,2,3,4,5,6,7", ScheduleStartDate = query.ScheduleStartDate, ScheduleEndDate = query.ScheduleEndDate });

            foreach (var bookingDay in bookingDays)
            {
                var spec = new AircraftScheduleSpecification(new AircraftScheduleListQM() { IsIncludeAircraft = true,ScheduleStartDate= bookingDay });
                var list = await _unitOfWork.Repository<AircraftSchedule>().GetListWithSpecAsync(spec);
                scheduleList.AddRange(list);
            }          
            return _mapper.Map<IReadOnlyList<AircraftScheduleVM>>(scheduleList);
        }

        public async Task<MasterScheduleVM> GetAsync(MasterScheduleDetailQM query)
        {
            var spec = new MasterScheduleSpecification(query);
            var entity = await _unitOfWork.Repository<MasterSchedule>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<MasterSchedule, MasterScheduleVM>(entity);
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(MasterScheduleRM dto)
        {
            var response = new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success};

            using (var transaction = _unitOfWork.BeginTransaction())
            {

                var masterScheduleEntity = _mapper.Map<MasterSchedule>(dto);
                var masterScheduleResponse = await _unitOfWork.Repository<MasterSchedule>().CreateAsync(masterScheduleEntity);
                await _unitOfWork.SaveChangesAsync();

                if (masterScheduleResponse == null)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.Failed;
                    response.Message = "Master schedule creation fails.";
                    return response;
                }

                var previousSchedules = await _unitOfWork.Repository<AircraftSchedule>().GetListWithSpecAsync(new AircraftScheduleSpecification(new AircraftScheduleQM { IsScheduleCompleted = false, AircraftId = dto.AircraftId }));

                if (dto.CalendarType == CalendarType.Daily)
                {

                    response = await CreateAircraftSchedule(dto.ScheduleStartDate, dto, masterScheduleResponse,previousSchedules);

                    if (response.StatusCode != ServiceResponseStatus.Success)
                    {
                        transaction.Rollback();
                        return response;
                    }
                }else{
                    var bookingDays = _dateGeneratorService.GetDates(new DateGeneratorRM() { DaysOfWeek = dto.DaysOfWeek, ScheduleStartDate = dto.ScheduleStartDate, ScheduleEndDate = dto.ScheduleEndDate });

                    if (bookingDays == null || bookingDays.Count < 1)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                        response.Message = "Booking days validation error.";
                        return response;
                    }

                    foreach (var day in bookingDays)
                    {

                        response =  await CreateAircraftSchedule(day,dto,masterScheduleResponse,previousSchedules);

                        if (response.StatusCode != ServiceResponseStatus.Success )
                        {
                            transaction.Rollback();
                            return response;
                        }
                    }

                }
                transaction.Commit();
            }

            return response;
        }

        private async Task<ServiceResponseCreateStatus> CreateAircraftSchedule(DateTime day, MasterScheduleRM dto, MasterSchedule masterScheduleResponse, IReadOnlyList<AircraftSchedule> previousSchedules)
        {
            var response = new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success };

            var aircraftSchedule = new AircraftScheduleRM();
            aircraftSchedule.AircraftId = dto.AircraftId;
            aircraftSchedule.MasterScheduleId = masterScheduleResponse.Id;
            aircraftSchedule.ScheduleStartDateTime = day.Date.Add(masterScheduleResponse.ScheduleStartTime);

            var scheduleStartDateTimeInMili = aircraftSchedule.ScheduleStartDateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            scheduleStartDateTimeInMili += dto.NumberOfHours * 60 * 60 * 1000;
            var scheduleEndDateTime = (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(scheduleStartDateTimeInMili).ToLocalTime();
            aircraftSchedule.ScheduleEndDateTime = scheduleEndDateTime;

            if(previousSchedules != null && previousSchedules.Count>0)
            {
                foreach(var schedule in previousSchedules)
                {
                    if (schedule.ScheduleStartDateTime < aircraftSchedule.ScheduleEndDateTime && aircraftSchedule.ScheduleStartDateTime < schedule.ScheduleEndDateTime)
                    {
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                        response.Message = "Already scheduled this time slot.(" + schedule.ScheduleStartDateTime + " - "+ schedule.ScheduleEndDateTime+".";
                        return response;
                    }
                }
            }

            var aircraftScheduleEntity = _mapper.Map<AircraftSchedule>(aircraftSchedule);
            var aircraftScheduleResponse = await _unitOfWork.Repository<AircraftSchedule>().CreateAsync(aircraftScheduleEntity);
            await _unitOfWork.SaveChangesAsync();

            if (aircraftScheduleResponse == null)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                response.Message = "Aircraft schedule creation fails.";
            }
            return response;
        }


    }
}
