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

        public MasterScheduleService(IUnitOfWork unitOfWork, IMapper mapper, IDateGeneratorService dateGeneratorService) : base(unitOfWork, mapper)
        {
            _dateGeneratorService = dateGeneratorService;
        }


        public async Task<IReadOnlyList<AircraftScheduleVM>> GetAircraftScheduleAsync(MasterScheduleListQM query)
        {
            List<AircraftSchedule> scheduleList = new List<AircraftSchedule>();
            var bookingDays = _dateGeneratorService.GetDates(new DateGeneratorRM() { DaysOfWeek = "1,2,3,4,5,6,7", ScheduleStartDate = query.ScheduleStartDate, ScheduleEndDate = query.ScheduleEndDate });

            foreach (var bookingDay in bookingDays)
            {
                var spec = new AircraftScheduleSpecification(new AircraftScheduleListQM() { IsIncludeAircraft = query.IsIncludeAircraft, IsIncludeFlightSchedules = query.IsIncludeFlightSchedules, ScheduleStartDate = bookingDay });
                var list = await _unitOfWork.Repository<AircraftSchedule>().GetListWithSpecAsync(spec);
                scheduleList.AddRange(list);
            }
            var disList = scheduleList.DistinctBy(x => x.Id).ToList();
            var filterdList = GetFlightScheduleDetails(disList);

            return _mapper.Map<IReadOnlyList<AircraftScheduleVM>>(filterdList);
        }
        

        private List<AircraftScheduleVM> GetFlightScheduleDetails(List<AircraftSchedule> list)
        {
            List<AircraftScheduleVM> scheduleList = new List<AircraftScheduleVM>();
            foreach (var schedule in list)
            {
                if (schedule.ScheduleStatus == ScheduleStatus.Schedule &&
                    schedule.FlightSchedules != null && schedule.FlightSchedules.Count > 0)
                {
                    List<AircraftScheduleFlightVM> flightList = new List<AircraftScheduleFlightVM>();
                    foreach (var flightSchedule in schedule.FlightSchedules)
                    {
                        flightSchedule.FlightScheduleSectors.OrderBy(x => x.SequenceNo);
                        var flight = new AircraftScheduleFlightVM();
                        flight.Id = flightSchedule.Id;
                        flight.FlightNumber = flightSchedule.FlightNumber;
                        flight.OriginAirportId = flightSchedule.OriginAirportId;
                        flight.DestinationAirportId = flightSchedule.DestinationAirportId;
                        flight.OriginAirportName = flightSchedule.OriginAirportName;
                        flight.DestinationAirportName = flightSchedule.DestinationAirportName;
                        flight.OriginAirportCode = flightSchedule.OriginAirportCode;
                        flight.DestinationAirportCode = flightSchedule.DestinationAirportCode;

                        var orderedFlightScheduleSectors = flightSchedule.FlightScheduleSectors.OrderBy(x => x.SequenceNo).ToList();

                        var firsrFlightScheduleSector = orderedFlightScheduleSectors.First();
                        if(firsrFlightScheduleSector != null)
                        {
                            var flightSector = firsrFlightScheduleSector.Sector.FlightSectors?.Where(x => x.FlightId == firsrFlightScheduleSector.FlightId && x.SectorId == firsrFlightScheduleSector.SectorId).FirstOrDefault();
                            if (flightSector != null)
                            {
                                var departureDate = firsrFlightScheduleSector.ActualDepartureDateTime.Date;
                                var departureDateTime = departureDate + flightSector.DepartureDateTime;
                                var actualDepartureDateTime = (flightSector.OriginBlockTimeMin != null) ? departureDateTime?.AddMinutes(-(double)flightSector.OriginBlockTimeMin) : departureDateTime;
                                flight.FlightScheduleStartDateTime = (DateTime)actualDepartureDateTime;
                            }
                        }


                        var lastFlightScheduleSector = orderedFlightScheduleSectors.Last();
                        if (lastFlightScheduleSector != null)
                        {
                            var flightSector = lastFlightScheduleSector.Sector.FlightSectors?.Where(x => x.FlightId == lastFlightScheduleSector.FlightId && x.SectorId == lastFlightScheduleSector.SectorId).FirstOrDefault();
                            if (flightSector != null)
                            {
                                var arrivalDate = lastFlightScheduleSector.ActualDepartureDateTime.Date;
                                var arrivalDateTime = arrivalDate + flightSector.ArrivalDateTime;
                               // arrivalDateTime = (flightSector.OriginBlockTimeMin != null) ? arrivalDateTime.AddMinutes((double)flightSector.OriginBlockTimeMin) : arrivalDateTime;
                               // var sectorTimeGap = flightSector.ArrivalDateTime.Value.Subtract((TimeSpan)flightSector.DepartureDateTime);
                               // var sectorMinutes = sectorTimeGap.TotalMinutes;
                              ///  arrivalDateTime = arrivalDateTime?.AddMinutes(sectorMinutes);
                                arrivalDateTime = (flightSector.DestinationBlockTimeMin != null) ? arrivalDateTime?.AddMinutes((double)flightSector.DestinationBlockTimeMin) : arrivalDateTime;

                                flight.FlightScheduleEndDateTime = (DateTime)arrivalDateTime;



                              
                            }
                        }


/*

                        foreach (var flightSchedulesector in orderedFlightScheduleSectors)
                        {
                            var flightSector = flightSchedulesector.Sector.FlightSectors?.Where(x => x.FlightId == flightSchedulesector.FlightId && x.SectorId == flightSchedulesector.SectorId).FirstOrDefault();

                            if (flightSector != null)
                            {
                                if (flightSchedulesector.SequenceNo == 1)
                                {

                                    var departureDate = flightSchedulesector.ActualDepartureDateTime.Date;
                                    var departureDateTime = departureDate + flightSector.DepartureDateTime;
                                    var actualDepartureDateTime = (flightSector.OriginBlockTimeMin != null) ? departureDateTime?.AddMinutes(-(double)flightSector.OriginBlockTimeMin) : departureDateTime;
                                    flight.FlightScheduleStartDateTime = (DateTime)actualDepartureDateTime;
                                }


                                var arrivalDateTime = flight.FlightScheduleStartDateTime;
                                arrivalDateTime = (flightSector.OriginBlockTimeMin != null) ? arrivalDateTime.AddMinutes((double)flightSector.OriginBlockTimeMin) : arrivalDateTime;
                                var sectorTimeGap = flightSector.ArrivalDateTime.Value.Subtract((TimeSpan)flightSector.DepartureDateTime);
                                var sectorMinutes = sectorTimeGap.TotalMinutes;
                                arrivalDateTime = arrivalDateTime.AddMinutes(sectorMinutes);
                                arrivalDateTime = (flightSector.DestinationBlockTimeMin != null) ? arrivalDateTime.AddMinutes((double)flightSector.DestinationBlockTimeMin) : arrivalDateTime;

                                flight.FlightScheduleEndDateTime = arrivalDateTime;
                            }
                        }*/


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

        public async Task<AircraftScheduleVM> GetAircraftScheduleAsync(Guid id)
        {
            var entity = await _unitOfWork.Repository<AircraftSchedule>().GetByIdAsync(id);
            return _mapper.Map<AircraftSchedule, AircraftScheduleVM>(entity);
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(MasterScheduleCreateRM dto)
        {
            var response = new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success };

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

                    response = await CreateAircraftSchedule(dto.ScheduleStartDate, dto, masterScheduleResponse, previousSchedules);

                    if (response.StatusCode != ServiceResponseStatus.Success)
                    {
                        transaction.Rollback();
                        return response;
                    }
                }
                else
                {
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

                        response = await CreateAircraftSchedule(day, dto, masterScheduleResponse, previousSchedules);

                        if (response.StatusCode != ServiceResponseStatus.Success)
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

        private async Task<ServiceResponseCreateStatus> CreateAircraftSchedule(DateTime day, MasterScheduleCreateRM dto, MasterSchedule masterScheduleResponse, IReadOnlyList<AircraftSchedule> previousSchedules)
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
            aircraftSchedule.ScheduleStatus = dto.ScheduleStatus;

            if (previousSchedules != null && previousSchedules.Count > 0)
            {
                foreach (var schedule in previousSchedules)
                {
                    if (schedule.ScheduleStartDateTime < aircraftSchedule.ScheduleEndDateTime && aircraftSchedule.ScheduleStartDateTime < schedule.ScheduleEndDateTime)
                    {
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                        response.Message = "Already scheduled this time slot.(" + schedule.ScheduleStartDateTime + " - " + schedule.ScheduleEndDateTime + ".";
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

        public async Task<bool> DeleteAsync(Guid Id)
        {
            var aircraftSchedule = await _unitOfWork.Repository<AircraftSchedule>().GetByIdAsync(Id);
            var masterSchedule = await _unitOfWork.Repository<MasterSchedule>().GetByIdAsync(aircraftSchedule.MasterScheduleId,false);

            if (masterSchedule != null && masterSchedule.CalendarType == CalendarType.Daily)
            {
                masterSchedule.IsDeleted= true;
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<MasterSchedule>().Detach(masterSchedule);
            }

            _unitOfWork.Repository<AircraftSchedule>().Delete(aircraftSchedule);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AircraftSchedule>().Detach(aircraftSchedule);
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }


        public async Task<ServiceResponseCreateStatus> UpdateAsync(MasterScheduleUpdateRM dto)
        {
            var response = new ServiceResponseCreateStatus();
            response.Id = dto.Id;

            var existingSchedule = await _unitOfWork.Repository<AircraftSchedule>().GetByIdAsync(dto.Id);

            if (existingSchedule == null)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                response.Message = "Schedule not found.";
                return response;
            }

            if (existingSchedule.FlightSchedules != null && existingSchedule.FlightSchedules.Count > 0)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                response.Message = "Unable to update. Flights already assigned.";
                return response;
            }

            var entity = _mapper.Map<AircraftSchedule>(dto);
            entity.MasterScheduleId = existingSchedule.MasterScheduleId;
            _unitOfWork.Repository<AircraftSchedule>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AircraftSchedule>().Detach(entity);
            response.StatusCode= ServiceResponseStatus.Success;
            return response;
        }
    }
}
