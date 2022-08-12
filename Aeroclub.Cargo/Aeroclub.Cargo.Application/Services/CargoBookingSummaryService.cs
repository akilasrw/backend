using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingSummaryService : BaseService, ICargoBookingSummaryService
    {
        private readonly IULDContainerCargoPositionService _ULDContainerCargoPositionService;

        public CargoBookingSummaryService(IUnitOfWork unitOfWork,
            IULDContainerCargoPositionService ULDContainerCargoPositionService,
            IMapper mapper)
            :base(unitOfWork,mapper)
        {
            _ULDContainerCargoPositionService = ULDContainerCargoPositionService;
        }

        public async Task<CargoBookingSummaryDetailVM> GetAsync(CargoBookingSummaryDetailQM query)
        {
            var spec = new FlightScheduleSpecification(query);

            var entity = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);

            var mappedEntity = _mapper.Map<CargoBookingSummaryDetailVM>(entity);
            if(entity.FlightScheduleSectors != null && entity.FlightScheduleSectors.Count>0)
            {
                var positionSummary = new CargoPositionSummaryVM();
                double totalAvailableWeight =0;
                double totalWeight =0;
                double totalAvailableVolume=0;
                double totalVolume=0;

                foreach (var sector in entity.FlightScheduleSectors)
                {
                    Tuple<double, double> aircraftWeight = await GetAircraftWeight(sector.Id);
                    Tuple<double, double> aircraftVolume = await GetAircraftVolume(sector.Id);

                    totalAvailableWeight += aircraftWeight.Item1;
                    totalWeight += aircraftWeight.Item2;

                    totalAvailableVolume += aircraftVolume.Item1;
                    totalVolume += aircraftVolume.Item2;
                }

                positionSummary.TotalBookedWeight = totalAvailableWeight;
                positionSummary.TotalWeight = totalWeight;
                positionSummary.WeightPercentage = Math.Round((decimal)positionSummary.TotalBookedWeight / (decimal)positionSummary.TotalWeight, 3);

                positionSummary.TotalBookedVolume = totalAvailableVolume;
                positionSummary.TotalVolume = totalVolume;
                positionSummary.VolumePercentage = Math.Round((decimal)positionSummary.TotalBookedVolume / (decimal)positionSummary.TotalVolume,3);

                mappedEntity.CargoPositionSummary = positionSummary;

                mappedEntity.CargoPositions = await GetAircraftPositionList(entity.FlightScheduleSectors.First().Id);

            }
            return mappedEntity;
        }

        public async Task<Pagination<CargoBookingSummaryVM>> GetFilteredListAsync(CargoBookingSummaryFilteredListQM query)
        {
            var spec = new FlightScheduleSpecification(query);
            var flightScheduleList = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(spec);

            var countSpec = new FlightScheduleSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<FlightSchedule>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<CargoBookingSummaryVM>>(flightScheduleList);

            return new Pagination<CargoBookingSummaryVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }



        private async Task<Tuple<double, double>> GetAircraftWeight(Guid flightScheduleSectorId) // Checking only Main Deck
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

            var bookedWeight = position.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight;

            var weight = position.ZoneArea.AircraftCabin.AircraftDeck.MaxWeight;

            return new Tuple<double, double>(bookedWeight, weight);
        }

        private async Task<Tuple<double, double>> GetAircraftVolume(Guid flightScheduleSectorId)
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

            double bookedVolume = 0;
            double volume = 0;

            foreach (var position in positions)
            {
                bookedVolume += position.CurrentVolume;
                volume += position.MaxVolume;
            }

            return new Tuple<double, double>(bookedVolume, volume);
        }


        private async Task<List<CargoPositionDetailVM>> GetAircraftPositionList(Guid flightScheduleSectorId)
        {
            List<CargoPositionDetailVM> list = new List<CargoPositionDetailVM>();
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

            foreach (var position in positions)
            {
                var cargoPosition = new CargoPositionDetailVM();

                var positionContainers = await _ULDContainerCargoPositionService.GetListAsync(new ULDCOntainerCargoPositionQM()
                {
                    IsIncludeULDContainer = true,
                    CargoPositionId = position.Id
                });

                if (positionContainers != null && positionContainers.Count > 0)
                {
                    var firstContainer = positionContainers.First();
                    if (firstContainer.ULDContainer.ULD != null)
                    {
                        cargoPosition.IsPalletAssigned = true;
                       
                        cargoPosition.ULDNumber = firstContainer.ULDContainer.ULD.SerialNumber;
                    }
                }

                   
                cargoPosition.MaxWeight = position.MaxWeight;
                cargoPosition.Weight = position.CurrentWeight;
                cargoPosition.MaxVolume = position.MaxVolume;
                cargoPosition.Volume = position.CurrentVolume;
                list.Add(cargoPosition);
            }

            return list;
        }

    }
}
