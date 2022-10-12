using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.AircraftScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs;
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

        public async Task<ServiceResponseCreateStatus> CreateAsync(MasterScheduleRM dto)
        {
            var response = new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success};

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                var bookingDays = _dateGeneratorService.GetDates(new DateGeneratorRM() { DaysOfWeek = dto.DaysOfWeek, ScheduleStartDate = dto.ScheduleStartDateTime, ScheduleEndDate = dto.ScheduleEndDateTime });

                if (bookingDays == null || bookingDays.Count <1)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.ValidationError;
                    response.Message = "Booking days validation error.";
                    return response;
                }

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


                foreach (var day in bookingDays)
                {
                    var aircraftSchedule = new AircraftScheduleRM();
                   // aircraftSchedule.ScheduleStartDateTime = 

                    var aircraftScheduleEntity = _mapper.Map<AircraftSchedule>(aircraftSchedule);
                    var aircraftScheduleResponse = await _unitOfWork.Repository<AircraftSchedule>().CreateAsync(aircraftScheduleEntity);
                    await _unitOfWork.SaveChangesAsync();

                    if (aircraftScheduleResponse== null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        response.Message = "Aircraft schedule creation fails.";
                        return response;
                    }
                }




                transaction.Commit();
            }

            return response;
        }
    }
}
