using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System.Security.Cryptography.X509Certificates;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleService : BaseService, IFlightScheduleService
    {
        private readonly IFlightService _flightService;
        private readonly IAircraftService _aircraftService;
        private readonly ILayoutCloneService _layoutCloneService;
        private readonly ISectorService _sectorService;

        public FlightScheduleService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IFlightService flightService,
            IAircraftService aircraftService,
            ILayoutCloneService layoutCloneService,
            ISectorService sectorService) :
            base(unitOfWork, mapper)
        {
            _flightService = flightService;
            _aircraftService = aircraftService;
            _layoutCloneService = layoutCloneService;
            _sectorService = sectorService;
        }

        public async Task<FlightScheduleCreateStatusRM> CreateAsync(FlightScheduleCreateRM model)
        {
            var responseStatus = new FlightScheduleCreateStatusRM();
            var entity = _mapper.Map<FlightSchedule>(model);

            if (string.IsNullOrEmpty(entity.FlightNumber) && model.FlightId.HasValue)
                entity.FlightNumber = await _flightService.GetFlightNumber(model.FlightId.Value);

            if (string.IsNullOrEmpty(entity.OriginAirportCode))
            {
                var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);
                entity.MapOriginAirport(originAirport);
            }

            if (string.IsNullOrEmpty(entity.DestinationAirportCode))
            {
                var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.DestinationAirportId);
                entity.MapDestinationAirport(destinationAirport);
            }
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var flightScheduleSectors = model.FlightScheduleSectors;
                    entity.FlightScheduleSectors.Clear();
                    await _unitOfWork.Repository<FlightSchedule>().CreateAsync(entity);
                    await _unitOfWork.SaveChangesAsync();
                    responseStatus.Id = entity.Id;
                    responseStatus.StatusCode = ServiceResponseStatus.Success;
                    if (entity.Id != Guid.Empty)
                        if (!await CloneLayoutAsync(entity, flightScheduleSectors))
                        {
                            await transaction.RollbackAsync();
                            responseStatus.StatusCode = ServiceResponseStatus.Failed;
                        }

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }

            return responseStatus;
        }

        private async Task<bool> CloneLayoutAsync(FlightSchedule flightSchedule, IEnumerable<FlightScheduleSectorCreateRM>? flightScheduleSectors)
        {
            var aircraftConfigType = await _aircraftService.GetAircraftConfigType(flightSchedule.AircraftSubTypeId);

            if (aircraftConfigType == AircraftConfigType.P2C)
                return await _layoutCloneService.CloneLayoutAsync(flightSchedule, flightScheduleSectors);
            else if (aircraftConfigType == AircraftConfigType.Freighter)
                return await _layoutCloneService.CloneULDCargoLayoutAsync(flightSchedule, flightScheduleSectors);
            else
                return false;

        }

        public async Task<ServiceResponseStatus> UpdateAsync(FlightScheduleUpdateRM model)
        {
            var entity = _mapper.Map<FlightSchedule>(model);

            if (string.IsNullOrEmpty(entity.FlightNumber) && model.FlightId.HasValue)
                entity.FlightNumber = await _flightService.GetFlightNumber(model.FlightId.Value);

            if (string.IsNullOrEmpty(entity.AircraftRegNo) && model.AircraftId.HasValue)
                entity.AircraftRegNo = await _aircraftService.GetAircraftRegNo(model.AircraftId.Value);

            if (string.IsNullOrEmpty(entity.OriginAirportCode))
            {
                var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);
                entity.MapOriginAirport(originAirport);
            }

            if (string.IsNullOrEmpty(entity.DestinationAirportCode))
            {
                var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.DestinationAirportId);
                entity.MapDestinationAirport(destinationAirport);
            }

            _unitOfWork.Repository<FlightSchedule>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return ServiceResponseStatus.Success;
        }

        public async Task<FlightScheduleVM> GetAsync(FlightScheduleQM query)
        {

            var spec = new FlightScheduleSpecification(query);
            var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);

            return _mapper.Map<FlightSchedule, FlightScheduleVM>(flightSchedule);
        }

        public async Task<IReadOnlyList<FlightScheduleVM>> GetListAsync()
        {
            var list = await _unitOfWork.Repository<FlightSchedule>().GetListAsync();
            return _mapper.Map<IReadOnlyList<FlightScheduleVM>>(list);
        }

        public async Task<IReadOnlyList<FlightScheduleLinkVM>> GetListByMasterIdAsync(FlightScheduleLinkQM query)
        {
            var spec = new FlightScheduleSpecification(query);
            var list = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(spec);
            return _mapper.Map<IReadOnlyList<FlightScheduleLinkVM>>(list);

        }

        public async Task<FlightScheduleLinkVM> GetByIdAsync(FlightScheduleLinkQM query)
        {
            var spec = new FlightScheduleSpecification(query);
            var data = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<FlightSchedule,FlightScheduleLinkVM>(data);
        }

        public async Task<IReadOnlyList<AircraftDto>> GetAvailableAircrafts_ByFlightScheduleIdAsync(Guid flightScheduleId)
        {
            List<AircraftDto> list = new List<AircraftDto>();
            // Get Flight Schedule List by id
            var spec = new FlightScheduleSpecification(
                new CargoBookingSummaryDetailQM()
                {
                    Id = flightScheduleId,
                    IsIncludeAircraftType = true,
                    IsIncludeFlightScheduleSectors = true
                });

            var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);

            // Get Aircrafts according to Config Type and Sub Type
            var aircraftConfig = await _aircraftService.GetAircraftConfigType(flightSchedule.AircraftSubTypeId);

            var aircraftlist = await _unitOfWork.Repository<Aircraft>().GetListAsync();
            var filteredAircraftlist = aircraftlist.Where(x => x.ConfigurationType == aircraftConfig); // filtered by types - ex: Freighter type

            // Get times from Flight sector
            var orderedfSector = flightSchedule.FlightScheduleSectors.OrderBy(x => x.SequenceNo);
            var firstSector = orderedfSector.FirstOrDefault().Flight.FlightSectors.FirstOrDefault();
            var lastSector = orderedfSector.LastOrDefault().Flight.FlightSectors.LastOrDefault();
            TimeSpan depTime = firstSector.DepartureDateTime.Value;
            TimeSpan arrTime = lastSector.ArrivalDateTime.Value;
            double originBlockTimeMin = firstSector.OriginBlockTimeMin != null ? firstSector.OriginBlockTimeMin.Value : 0;
            double destinationBlockTimeMin = lastSector.DestinationBlockTimeMin != null ? lastSector.DestinationBlockTimeMin.Value : 0;

            // Get master schedule time from Aircraft Schedule according to times of Flight sector  (Only Extracly matched/ between).
            var specAircraftSc = new AircraftScheduleSpecification(flightSchedule.ScheduledDepartureDateTime.AddMinutes(-originBlockTimeMin), flightSchedule.ScheduledDepartureDateTime.Date.AddMinutes(destinationBlockTimeMin) + arrTime);
            var allMatchingAircratSchedule = await _unitOfWork.Repository<AircraftSchedule>().GetListWithSpecAsync(specAircraftSc);

            // logic
            foreach (var aircraftSchedule in allMatchingAircratSchedule)
            {
                var avaialbleAircraft = filteredAircraftlist.Where(x => x.Id == aircraftSchedule.AircraftId).FirstOrDefault();

                //var fsSpec = new FlightScheduleSpecification(aircraftSchedule.Id); // Get FlightSchedule from aircraft Schedule Id. 
                //IReadOnlyList<FlightSchedule> flightSchedule_AlreadyLinked = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(fsSpec);

                //if (flightSchedule_AlreadyLinked == null || flightSchedule_AlreadyLinked.Count == 0)
                //{
                if (!list.Any(x => x.Id == avaialbleAircraft.Id)) // check already exists to avoid duplicates values in the aircraft list. 
                    if (avaialbleAircraft != null)
                    {
                        var mappedAricraft = _mapper.Map<Aircraft, AircraftDto>(avaialbleAircraft);
                        mappedAricraft.AircraftScheduleId = aircraftSchedule.Id;
                        list.Add(mappedAricraft);
                    }
               // }
            }
            return list;
        }

        public async Task<IReadOnlyList<AircraftIdleReportVM>> GetAircraftsIdleReportAsyncOld(FlightScheduleReportQM query)
        {
            List<AircraftIdleReportVM> aircraftIdleReports = new List<AircraftIdleReportVM>();
            const int HOURS_OF_DAY = 24 * 60;
            try
            {
                if (query.Year != null && query.Month != null)
                    foreach (DateTime date in DateExtention.AllDatesInMonth(query.Year.Value, query.Month.Value))
                    {
                        var fsSepc = new FlightScheduleSpecification(query);
                        var list = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(fsSepc);
                        var groupsList = list.Where(x => x.AircraftId != null).GroupBy(c => c.AircraftRegNo).ToList();

                        foreach (var group in groupsList)
                        {
                            var fsList = group.Where(x => x.ScheduledDepartureDateTime.Date == date);

                            if (fsList.Any())
                                foreach (FlightSchedule fs in fsList)
                                {
                                    var firstSector = fs.FlightScheduleSectors.FirstOrDefault().Flight.FlightSectors.FirstOrDefault();
                                    TimeSpan tsDeparture = firstSector.DepartureDateTime.Value;
                                    var lastSector = fs.FlightScheduleSectors.FirstOrDefault().Flight.FlightSectors.LastOrDefault();
                                    TimeSpan tsArrival = lastSector.ArrivalDateTime.Value;

                                    TimeSpan utcDepTime = await GetMappedTimeAsync(tsDeparture, firstSector.SectorId);
                                    TimeSpan utcArrTime = await GetMappedTimeAsync(tsArrival, lastSector.SectorId, false);

                                    // Get UTC diff of flightSchedule. -> X
                                    double totalAllcatedTime = utcArrTime.TotalMinutes - utcDepTime.TotalMinutes;
                                    double totalBlockTime = firstSector.DestinationBlockTimeMin == null ? 0 : firstSector.DestinationBlockTimeMin.Value +
                                        lastSector.OriginBlockTimeMin == null ? 0 : lastSector.OriginBlockTimeMin.Value;

                                    double totalFlightTime = totalAllcatedTime + totalBlockTime;
                                    TimeSpan aircrafScheduleDiff = TimeSpan.Zero;
                                    double idleTimeMin = 0;
                                    if (fs.AircraftSchedule != null)
                                    {
                                        aircrafScheduleDiff = fs.AircraftSchedule.ScheduleStartDateTime.TimeOfDay - fs.AircraftSchedule.ScheduleEndDateTime.TimeOfDay;

                                        if (fs.AircraftSchedule.ScheduleStatus == ScheduleStatus.Schedule)
                                        {
                                            idleTimeMin = HOURS_OF_DAY - totalFlightTime;
                                        }
                                    }

                                    idleTimeMin = totalFlightTime - (aircrafScheduleDiff).TotalMinutes;

                                    if (fs.AircraftId != null)
                                        aircraftIdleReports.Add(new AircraftIdleReportVM()
                                        {
                                            Day = date.Day,
                                            Month = date.Month,
                                            NoOfHours = idleTimeMin / 60,
                                            AircraftRegNo = fs.AircraftRegNo,
                                            AircraftId = fs.AircraftId.Value
                                        });
                                }
                            else
                            {
                                aircraftIdleReports.Add(new AircraftIdleReportVM()
                                {
                                    Day = date.Day,
                                    Month = date.Month,
                                    NoOfHours = 0,
                                    AircraftRegNo = group.Key
                                });

                            }
                        }

                    }

            }
            catch (Exception ex)
            {

                throw;
            }
            return aircraftIdleReports.OrderBy(z=>z.Day).ToList();
        }

        public async Task<IReadOnlyList<AircraftIdleReportVM>> GetAircraftsIdleReportAsync(FlightScheduleReportQM query)
        {
            List<AircraftIdleReportVM> aircraftIdleReports = new List<AircraftIdleReportVM>();
            const int MINUTES_OF_DAY = 24 * 60;
            double idleTimeMin = MINUTES_OF_DAY;
            double reservedTime = 0;
            try
            {
                if (query.Year != null && query.Month != null)
                    foreach (DateTime date in DateExtention.AllDatesInMonth(query.Year.Value, query.Month.Value))
                    {
                        var fsSepc = new AircraftScheduleSpecification(query);
                        var list = await _unitOfWork.Repository<AircraftSchedule>().GetListWithSpecAsync(fsSepc);
                        var groupsList = list.Where(x => x.AircraftId != null).GroupBy(c => c.AircraftId).ToList();

                        foreach (var group in groupsList)
                        {
                            var asList = group.Where(x => x.ScheduleStartDateTime.Date == date);

                            if (asList.Any())
                            {
                                foreach (var aircraftSchedule in asList)
                                {
                                    idleTimeMin = 0; reservedTime = 0;
                                    if (aircraftSchedule.ScheduleStatus == ScheduleStatus.Schedule)
                                    {
                                        var flightSchedules = aircraftSchedule.FlightSchedules;
                                        foreach (var fs in flightSchedules)
                                        {
                                            var firstSector = fs.FlightScheduleSectors.FirstOrDefault().Flight.FlightSectors.FirstOrDefault();
                                            TimeSpan tsDeparture = firstSector.DepartureDateTime.Value;
                                            var lastSector = fs.FlightScheduleSectors.FirstOrDefault().Flight.FlightSectors.LastOrDefault();
                                            TimeSpan tsArrival = lastSector.ArrivalDateTime.Value;

                                            TimeSpan utcDepTime = await GetMappedTimeAsync(tsDeparture, firstSector.SectorId);
                                            TimeSpan utcArrTime = await GetMappedTimeAsync(tsArrival, lastSector.SectorId, false);

                                            // Get UTC diff of flightSchedule. -> X
                                            double totalAllcatedTime = utcArrTime.TotalMinutes - utcDepTime.TotalMinutes;
                                            double totalBlockTime = firstSector.DestinationBlockTimeMin == null ? 0 : firstSector.DestinationBlockTimeMin.Value +
                                                lastSector.OriginBlockTimeMin == null ? 0 : lastSector.OriginBlockTimeMin.Value;

                                            double totalFlightTime = totalAllcatedTime + totalBlockTime;
                                            TimeSpan aircrafScheduleDiff = TimeSpan.Zero;

                                            if (fs.AircraftSchedule != null)
                                            {
                                                if (fs.AircraftSchedule.ScheduleStatus == ScheduleStatus.Schedule)
                                                {
                                                    idleTimeMin += MINUTES_OF_DAY - totalFlightTime;
                                                    reservedTime += totalFlightTime;
                                                }
                                            }
                                        }
                                        
                                    }
                                    else
                                    {
                                        reservedTime += asList.Sum(x => x.ScheduleEndDateTime.TimeOfDay.TotalMinutes - x.ScheduleStartDateTime.TimeOfDay.TotalMinutes);
                                        idleTimeMin += MINUTES_OF_DAY - reservedTime;
                                    }
                                }
                                
                            }                                
                            else
                            {
                                idleTimeMin = MINUTES_OF_DAY;
                                reservedTime = 0;

                            }

                            aircraftIdleReports.Add(new AircraftIdleReportVM()
                            {
                                Day = date.Day,
                                Month = date.Month,
                                NoOfHours = (query.FlightScheduleReportType == FlightScheduleReportType.Idle? idleTimeMin: reservedTime) / 60,
                                AircraftId = group.Key.Value,
                                AircraftRegNo = await _aircraftService.GetAircraftRegNo(group.Key.Value)
                            });
                        }

                    }

            }
            catch (Exception ex)
            {

                throw;
            }
            return aircraftIdleReports.OrderBy(z=>z.Day).ToList();
        }

        private async Task<TimeSpan> GetMappedTimeAsync(TimeSpan? time, Guid sectorId, bool isOrigin = true, bool isSavedData = true)
        {
            TimeSpan offsetTime = new TimeSpan();
            var list = await _sectorService.GetSectorAirports(sectorId);

            if (isOrigin)
            {
                if (list[0] != null && !string.IsNullOrEmpty(list[0].CountryCode))
                    offsetTime = time.ToInternationalTimeSpan(list[0].CountryCodeISO3166, list[0].Lat, isSavedData);
            }
            else
            {
                if (list[1] != null && !string.IsNullOrEmpty(list[1].CountryCode))
                    offsetTime = time.ToInternationalTimeSpan(list[1].CountryCodeISO3166, list[1].Lat, isSavedData);
            }
            return offsetTime;
        }

        public async Task<Flight> MappedFlightSectorData(Flight? flight, bool isSavedData = true)
        {
            foreach (var fSector in flight.FlightSectors)
            {
                fSector.DepartureDateTime = await GetMappedTimeAsync(fSector.DepartureDateTime, fSector.SectorId, true, isSavedData);
                fSector.ArrivalDateTime = await GetMappedTimeAsync(fSector.ArrivalDateTime, fSector.SectorId, false, isSavedData);
            }
            return flight;
        }
    }
}