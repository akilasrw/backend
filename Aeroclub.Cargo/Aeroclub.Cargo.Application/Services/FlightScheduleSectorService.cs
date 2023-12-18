using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AircrftLayoutMappingQM;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleSectorService : BaseService, IFlightScheduleSectorService
    {
        private readonly IConfiguration _configuration;
        private readonly IAirportService _airportService;

        public FlightScheduleSectorService(IUnitOfWork unitOfWork, 
            IMapper mapper, 
            IConfiguration configuration,
            IAirportService airportService)
            : base(unitOfWork, mapper)
        {
            _configuration = configuration;
            _airportService = airportService;
        }

        public async Task<IReadOnlyList<T>> GetListAsync<T>(FlightScheduleSectorListQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var flightScheduleSectorList =
                await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);

            return _mapper.Map<IReadOnlyList<T>>(flightScheduleSectorList);
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleSectorCreateRM dto)
        {
            var response = new ServiceResponseCreateStatus();
            var flightsector = _mapper.Map<FlightScheduleSector>(dto);
            await _unitOfWork.Repository<FlightScheduleSector>().CreateAsync(flightsector);
            await _unitOfWork.SaveChangesAsync();
            response.Id = flightsector.Id;
            response.StatusCode = Enums.ServiceResponseStatus.Success;
            return response;
        }

        public async Task<FlightScheduleSectorVM> GetAsync(FlightScheduleSectorQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var flightSSector = await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);
            var flightSSVm = _mapper.Map<FlightScheduleSector, FlightScheduleSectorVM>(flightSSector);
            flightSSVm.FlightScheduleSectorCargoPositions = await GetAircraftAvailableSpace(query.Id);
            return flightSSVm;
        }

        public async Task<double> GetAircraftAvailableWeight(Guid flightScheduleSectorId) // Checking only Main Deck
        {
            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorQM
            {
                Id = flightScheduleSectorId,
                IncludeLoadPlan = true,
            });

            var flightScheduleSector =
                await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            {
                AircraftLayoutId = flightScheduleSector.LoadPlan.AircraftLayoutId
            });

            var position = await _unitOfWork.Repository<CargoPosition>().GetEntityWithSpecAsync(cargoPositionSpec);

            var availableWeight = position.ZoneArea.AircraftCabin.AircraftDeck.MaxWeight - position.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight;
            return availableWeight;
        }

        public async Task<double> GetAircraftAvailableVolume(Guid flightScheduleSectorId)
        {
            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorQM
            {
                Id = flightScheduleSectorId,
                IncludeLoadPlan = true,
            });

            var flightScheduleSector =
                await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            {
                AircraftLayoutId = flightScheduleSector.LoadPlan.AircraftLayoutId
            });

            var positions = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            double availableVolume = 0;

            foreach (var position in positions)
            {
                var remainingVolume = position.MaxVolume - position.CurrentVolume;
                availableVolume += remainingVolume;
            }

            return availableVolume;
        }

        public async Task<List<FlightScheduleSectorCargoPosition>> GetFreighterAircraftAvailableSpace(Guid flightScheduleSectorId)
        {
            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorQM
            {
                Id = flightScheduleSectorId,
                IncludeULDContaines = true,
                IncludeAircraftSubType = true,
            });

            var flightScheduleSector = await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            {
                AircraftLayoutId = flightScheduleSector.LoadPlan.AircraftLayoutId
            });

            var cargoPositions = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var groupedCargoPositions = cargoPositions.GroupBy(item => item.CargoPositionType,
                  (key, group) => new { CargoPositionType = key, Items = group.ToList() })
              .ToList();

            var flightScheduleSectorCargoPositionsList = new List<FlightScheduleSectorCargoPosition>();

            foreach (var flightScheduleSectorCargoPosition in from groupedCargoPosition in groupedCargoPositions
                                                              let totalCount = groupedCargoPosition.Items.Count
                                                              let cargoPositionType = groupedCargoPosition.CargoPositionType
                                                             
                                                              let occupiedCount = groupedCargoPosition.Items.Count(x => 
                                                              (x.CurrentWeight >= x.MaxWeight) ||(x.CurrentVolume >= x.MaxVolume) 
                                                              )
                       
                                                              select new FlightScheduleSectorCargoPosition
                                                              {
                                                                  CargoPositionType = groupedCargoPosition.CargoPositionType,
                                                                  AvailableSpaceCount = totalCount - occupiedCount
                                                              })
            {
                flightScheduleSectorCargoPositionsList.Add(flightScheduleSectorCargoPosition);
            }

            return flightScheduleSectorCargoPositionsList;
        }

        public async Task<List<FlightScheduleSectorCargoPosition>> GetAircraftAvailableSpace(Guid flightScheduleSectorId)
        {
            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorQM
            {
                Id = flightScheduleSectorId,
                IncludeULDContaines = true,
                IncludeAircraftSubType = true,
            });

            var flightScheduleSector =
                await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);
            // await _unitOfWork.Repository<FlightScheduleSector>().GetByIdAsync(flightScheduleSectorId);

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            {
                AircraftLayoutId = flightScheduleSector.LoadPlan.AircraftLayoutId
            });

            var cargoPositions = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var groupedCargoPositions = cargoPositions.GroupBy(item => item.CargoPositionType,
                    (key, group) => new { CargoPositionType = key, Items = group.ToList() })
                .ToList();

            var flightScheduleSectorCargoPositionsList = new List<FlightScheduleSectorCargoPosition>();

            foreach (var flightScheduleSectorCargoPosition in from groupedCargoPosition in groupedCargoPositions
                                                              let totalCount = groupedCargoPosition.Items.Count
                                                              let cargoPositionType = groupedCargoPosition.CargoPositionType
                                                              //let packedULDContainersCount = flightScheduleSector.LoadPlan.ULDContaines.Count(x =>
                                                              //    x.ULDContainerCargoPositions.Any(y => y.CargoPosition.CargoPositionType == groupedCargoPosition.CargoPositionType))
                                                              let packedULDContainersCount = flightScheduleSector.LoadPlan.ULDContaines.Select(x => new
                                                              {
                                                                  Count = x.ULDContainerCargoPositions.Count(y =>
                                                                       y.CargoPosition.CargoPositionType == groupedCargoPosition.CargoPositionType)
                                                              }).Sum(z=>z.Count)
                                                              select new FlightScheduleSectorCargoPosition
                                                              {
                                                                  CargoPositionType = groupedCargoPosition.CargoPositionType,
                                                                  AvailableSpaceCount = totalCount - packedULDContainersCount
                                                              })
            {
                flightScheduleSectorCargoPositionsList.Add(flightScheduleSectorCargoPosition);
            }

            return flightScheduleSectorCargoPositionsList;
        }

        public async Task<CargoPositionSummaryVM> GetCargoPositionSummaryAsync(FlightScheduleSectorSearchQuery query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var entity = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);
            var flightSector = entity.FirstOrDefault();
            if (flightSector == null)
                return new CargoPositionSummaryVM();

            // Get Aircrat Layout Mapping
            var aircraftLayoutMappingDetail = await GetAircraftLayoutMappingAsync(flightSector.AircraftSubTypeId);
            if (aircraftLayoutMappingDetail == null) return new CargoPositionSummaryVM();
            if (aircraftLayoutMappingDetail.AircraftLayoutId == null) return new CargoPositionSummaryVM();
                       
            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = (Guid)aircraftLayoutMappingDetail.AircraftLayoutId, IncludeSeat = true, IncludeOverhead = true });

            var cargoPositionList =
                await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            CargoPositionSummaryVM positionSummary = new CargoPositionSummaryVM();

            var groupedCargoPositions = cargoPositionList.GroupBy(item => item.CargoPositionType,
                    (key, group) => new { CargoPositionType = key, Items = group.ToList() })
                .ToList();

            var flightScheduleSectorCargoPositionsList = new List<FlightScheduleSectorCargoPositionSummery>();

            foreach (var flightScheduleSectorCargoPosition in from groupedCargoPosition in groupedCargoPositions
                                                              let totalCount = groupedCargoPosition.Items.Count
                                                              let cargoPositionType = groupedCargoPosition.CargoPositionType
                                                              let packedULDContainersCount = flightSector.LoadPlan.ULDContaines.Select(x => new
                                                              {
                                                                  Count = x.ULDContainerCargoPositions.Count(y =>
                                                                      y.CargoPosition.CargoPositionType == groupedCargoPosition.CargoPositionType)
                                                              }).Sum(z => z.Count)

                                                              select new FlightScheduleSectorCargoPositionSummery
                                                              {
                                                                  CargoPositionType = groupedCargoPosition.CargoPositionType,
                                                                  AvailableSpaceCount = packedULDContainersCount,
                                                                  Total = totalCount,
                                                              })
            {
                flightScheduleSectorCargoPositionsList.Add(flightScheduleSectorCargoPosition);
            }

            var position = flightScheduleSectorCargoPositionsList.Where(y => y.CargoPositionType == CargoPositionType.OnSeat).FirstOrDefault();
            positionSummary.TotalOccupiedOnSeats = position.AvailableSpaceCount;
            positionSummary.TotalOnSeats = position.Total;
            positionSummary.OnSeatsPercentage = (decimal)positionSummary.TotalOccupiedOnSeats / (decimal)positionSummary.TotalOnSeats;

            position = flightScheduleSectorCargoPositionsList.Where(y => y.CargoPositionType == CargoPositionType.UnderSeat).FirstOrDefault();
            positionSummary.TotalOccupiedUnderSeats = position.AvailableSpaceCount;
            positionSummary.TotalUnderSeats = position.Total;
            positionSummary.UnderSeatsPercentage = (decimal)positionSummary.TotalOccupiedUnderSeats / positionSummary.TotalUnderSeats;

            position = flightScheduleSectorCargoPositionsList.Where(y => y.CargoPositionType == CargoPositionType.Overhead).FirstOrDefault();
            positionSummary.TotalOccupiedOverheads = position.AvailableSpaceCount;
            positionSummary.TotalOverheads = position.Total;
            positionSummary.OverheadPercentage = (decimal)positionSummary.TotalOccupiedOverheads / positionSummary.TotalOverheads;

            positionSummary.TotalWeight = flightSector.LoadPlan.AircraftLayout.AircraftDecks.First().MaxWeight;
            positionSummary.TotalBookedWeight = flightSector.LoadPlan.AircraftLayout.AircraftDecks.First().CurrentWeight;
            positionSummary.WeightPercentage = (decimal)positionSummary.TotalBookedWeight / (decimal)positionSummary.TotalWeight;

            return positionSummary;
        }

        public async Task<IEnumerable<SeatDto>> GetCargoPositionLayoutAsync(FlightScheduleSectorSearchQuery query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var entity = await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);
            var flightSector = entity;
            //if (flightSector == null)
            //    return new CargoPositionSummaryVM();

            // Get Aircrat Layout Mapping
            var aircraftLayoutMappingDetail = await GetAircraftLayoutMappingAsync(entity.AircraftSubTypeId);

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = (Guid)aircraftLayoutMappingDetail.AircraftLayoutId, IncludeSeat = true, IncludeOverhead = true });

            var cargoPositionList =
                await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var seats = cargoPositionList.Where(x => x.CargoPositionType == query.CargoPositionType).Select(y =>y.Seat);
            return _mapper.Map<IEnumerable<Seat>, IEnumerable<SeatDto>>(seats);
        }

        public async Task<IEnumerable<FlightScheduleSectorUldPositionVM>> GetFlightScheduleSectorWithULDPositionCountAsync(FlightScheduleSectorULDPositionCountQM query)
        {
            List<FlightScheduleSectorUldPositionVM> list = new List<FlightScheduleSectorUldPositionVM>();

            var spec = new FlightScheduleSectorSpecification(query);
            var flightScheduleSectors = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);

            foreach (var flightScheduleSector in flightScheduleSectors)
            {
                if (query.ExcludeFinalizedSchedules && flightScheduleSector?.LoadPlan?.LoadPlanStatus == LoadPlanStatus.Finalized)
                {
                    continue;
                }
                var fs = _mapper.Map<FlightScheduleSectorUldPositionVM>(flightScheduleSector);
                var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
                {
                    AircraftLayoutId = flightScheduleSector.LoadPlan.AircraftLayoutId
                });
                fs.AircraftLayoutId = flightScheduleSector.LoadPlan.AircraftLayoutId;
                var cargoPositions = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);
                fs.ULDPositionCount = cargoPositions.Count;
                fs.ULDCount = flightScheduleSector.LoadPlan == null || flightScheduleSector.LoadPlan.ULDContaines == null ? 0 : flightScheduleSector.LoadPlan.ULDContaines.Where(x => x.ULD != null).Count();
                fs.CutoffTime = flightScheduleSector.CutoffTimeMin == null ? flightScheduleSector.ScheduledDepartureDateTime
                    : flightScheduleSector.ScheduledDepartureDateTime.AddHours(-flightScheduleSector.CutoffTimeMin.Value);
                list.Add(fs);

            }

            return list;
        }

        private async Task<AircraftLayoutMapping> GetAircraftLayoutMappingAsync(Guid subTypeId)
        {
            var spec = new AircraftLayoutMappingSpecification(new AircraftLayoutMappingQM() { AircraftSubTypeId = subTypeId });
            return await _unitOfWork.Repository<AircraftLayoutMapping>().GetEntityWithSpecAsync(spec);
        }

        //private async Task<DateTime> GetMappedTimeAsync(DateTime date, Guid airportId)
        //{
        //    TimeSpan offsetTime = new TimeSpan();
        //    var res = await _airportService.GetAsync(new AirportQM() { Id = airportId, IsCountryInclude = true});

        //    if (res != null && !string.IsNullOrEmpty(res.CountryCode))
        //        offsetTime = date.TimeOfDay.ToInternationalTimeSpan(res.CountryCodeISO3166, res.Lat, false);

        //    return date + offsetTime;
        //}

        public async Task<ServiceResponseStatus> DeleteAsync(Guid Id)
        {
            var flightsector = await _unitOfWork.Repository<FlightScheduleSector>().GetByIdAsync(Id);
            _unitOfWork.Repository<FlightScheduleSector>().Delete(flightsector);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<FlightScheduleSector>().Detach(flightsector);

            return ServiceResponseStatus.Success;
        }
    }
}