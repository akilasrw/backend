﻿using Aeroclub.Cargo.Application.Enums;
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
                var spec = new AircraftScheduleSpecification(new AircraftScheduleListQM() { IsIncludeAircraft = query.IsIncludeAircraft, IsIncludeFlightSchedules = query.IsIncludeFlightSchedules,ScheduleStartDate= bookingDay });
                var list = await _unitOfWork.Repository<AircraftSchedule>().GetListWithSpecAsync(spec);
                scheduleList.AddRange(list);
            }
            var disList = scheduleList.DistinctBy(x => x.Id).ToList();
            var filterdList = GetFlightScheduleDetails(disList);

            return _mapper.Map<IReadOnlyList<AircraftScheduleVM>>(filterdList);
        }

        private List<AircraftScheduleVM> GetFlightScheduleDetails(List<AircraftSchedule> list )
        {
            List < AircraftScheduleVM > scheduleList = new List<AircraftScheduleVM>();
            foreach (var schedule in list)
            {
                if(schedule.MasterSchedule.ScheduleStatus == ScheduleStatus.Schedule && 
                    schedule.FlightSchedules != null && schedule.FlightSchedules.Count>0)
                {
                    List<AircraftScheduleFlightVM> flightList = new List<AircraftScheduleFlightVM>();
                    foreach (var flightSchedule in schedule.FlightSchedules)
                    {
                        flightSchedule.FlightScheduleSectors.OrderBy(x => x.SequenceNo);
                        var flight = new AircraftScheduleFlightVM();
                        flight.Id = flightSchedule.Id;
                        flight.OriginAirportId = flightSchedule.OriginAirportId;
                        flight.DestinationAirportId = flightSchedule.DestinationAirportId;
                        flight.OriginAirportName = flightSchedule.OriginAirportName;
                        flight.DestinationAirportName = flightSchedule.DestinationAirportName;
                        flight.OriginAirportCode = flightSchedule.OriginAirportCode;
                        flight.DestinationAirportCode = flightSchedule.DestinationAirportCode;


                        foreach (var flightSchedulesector in flightSchedule.FlightScheduleSectors)
                        {
                            var flightSector = flightSchedulesector.Sector.FlightSectors?.OrderBy(x => x.Sequence).First();
                            if(flightSector != null && flightSchedulesector.SequenceNo == 1)
                            {
                     
                                    var departureDate = flightSchedulesector.ActualDepartureDateTime.Date;
                                    var departureDateTime = departureDate + flightSector.DepartureDateTime;
                                    var actualDepartureDateTime = departureDateTime?.AddMinutes(-(double)flightSector.OriginBlockTimeMin);
                                    flight.FlightScheduleStartDateTime = (DateTime)actualDepartureDateTime;
                            }

                            var arrivalDateTime = flight.FlightScheduleStartDateTime;

                            if (flightSector != null)
                            {
                                arrivalDateTime.AddMinutes((double)flightSector.OriginBlockTimeMin);
                                var sectorTimeGap = flightSector.DepartureDateTime.Value.Subtract((TimeSpan)flightSector.ArrivalDateTime);
                                var sectorHours = sectorTimeGap.TotalHours;
                                arrivalDateTime.AddHours(sectorHours);
                                arrivalDateTime.AddMinutes((double)flightSector.DestinationBlockTimeMin);
                            }

                            flight.FlightScheduleEndDateTime = arrivalDateTime;
                        }

                        flightList.Add(flight);
                    }

                    var mapedSchedule = _mapper.Map<AircraftSchedule, AircraftScheduleVM>(schedule);
                    mapedSchedule.AircraftScheduleFlights = flightList;
                    scheduleList.Add(mapedSchedule);
                }
                else
                {
                    scheduleList.Add(_mapper.Map<AircraftSchedule, AircraftScheduleVM>(schedule));
                }

            }

            return scheduleList;

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
