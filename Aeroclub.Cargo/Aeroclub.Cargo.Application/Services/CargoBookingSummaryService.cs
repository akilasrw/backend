using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingSummaryService : BaseService, ICargoBookingSummaryService
    {
        private readonly IULDContainerCargoPositionService _ULDContainerCargoPositionService;
        private readonly IULDService _uLDService;
        private readonly IBookingManagerService _bookingManagerService;

        public CargoBookingSummaryService(IUnitOfWork unitOfWork,
            IULDContainerCargoPositionService ULDContainerCargoPositionService,
            IULDService uLDService,
            IBookingManagerService bookingManagerService,
            IMapper mapper)
            :base(unitOfWork,mapper)
        {
            _ULDContainerCargoPositionService = ULDContainerCargoPositionService;
            _uLDService = uLDService;
            _bookingManagerService = bookingManagerService;
        }

        public async Task<CargoBookingSummaryDetailVM> GetAsync(CargoBookingSummaryDetailQM query)
        {
            CargoBookingSummaryDetailVM? mappedEntity = null;
            var spec = new FlightScheduleSpecification(query);
            var entity = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);
            if (entity != null)
            {
                mappedEntity = _mapper.Map<CargoBookingSummaryDetailVM>(entity);
                if (entity.FlightScheduleSectors != null && entity.FlightScheduleSectors.Count > 0)
                {
                    var positionSummary = new CargoPositionSummaryVM();
                    double totalAvailableWeight = 0;
                    double totalWeight = 0;
                    double totalAvailableVolume = 0;
                    double totalVolume = 0;

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
                    positionSummary.VolumePercentage = Math.Round((decimal)positionSummary.TotalBookedVolume / (decimal)positionSummary.TotalVolume, 3);

                    mappedEntity.CargoPositionSummary = positionSummary;

                    mappedEntity.CargoPositions = await GetAircraftPositionList(entity.FlightScheduleSectors.First().Id);
                    
                    mappedEntity.BookingSummaryDetailFigures = await GetBookingCountWeightAndVolume(entity);

                }
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

            foreach (var d in dtoList)
            {
                var sum = await GetAsync(new CargoBookingSummaryDetailQM() { Id = d.Id, IsIncludeFlightScheduleSectors = true });
                d.TotalBookedVolume = sum.BookingSummaryDetailFigures.TotalBookedVolume;
                d.TotalBookedWeight = sum.BookingSummaryDetailFigures.TotalBookedWeight;
            }

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
                var uld = await _uLDService.GetAsync(new ULDQM() { PositionId = position.Id });

                if (uld != null && uld.ULDMetaData != null)
                {
                    cargoPosition.IsPalletAssigned = true;
                    cargoPosition.ULDNumber = uld.SerialNumber;
                    cargoPosition.Dimention = string.Format("{0} x {1} x {2}", uld.ULDMetaData.Length, uld.ULDMetaData.Width, uld.ULDMetaData.Height);
                }
                int val;
                cargoPosition.Id = position.Id;
                cargoPosition.MaxWeight = position.MaxWeight;
                cargoPosition.Weight = position.CurrentWeight;
                cargoPosition.MaxVolume = position.MaxVolume;
                cargoPosition.Volume = position.CurrentVolume;
                cargoPosition.Position = int.TryParse(position.Name, out val) ? int.Parse(position.Name) : 0;
                list.Add(cargoPosition);
            }

            return list.OrderBy(x => x.Position).ToList();
        }

        private async Task<BookingSummaryDetailFiguresVM> GetBookingCountWeightAndVolume(FlightSchedule flightSchedule)
        {
            BookingSummaryDetailFiguresVM summaryFigures = new BookingSummaryDetailFiguresVM();            

            foreach (var f in flightSchedule.FlightScheduleSectors)
            {
                foreach (var s in f.CargoBookingFlightScheduleSectors)
                {
                    summaryFigures.BookingCount++;
                    var spec = new CargoBookingSpecification(new CargoBookingQM() { IsIncludePackageDetail = true, Id = s.CargoBookingId});
                    var booking = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);
                    summaryFigures.BookingRecievedCount += booking.BookingStatus == BookingStatus.Accepted ? 1 : 0;

                    summaryFigures.TotalBookedWeight += booking.PackageItems.Sum(x => x.Weight);
                    summaryFigures.TotalRecievedBookedWeight += booking.PackageItems.Where(c=>c.PackageItemStatus== PackageItemStatus.Accepted).Sum(x => x.Weight);

                    summaryFigures.TotalBookedVolume += booking.PackageItems.Sum(x => (x.Width * x.Height * x.Length));
                    summaryFigures.TotalRecievedBookedVolume += booking.PackageItems.Where(c=>c.PackageItemStatus== PackageItemStatus.Accepted).Sum(x => (x.Width * x.Height * x.Length));
                }
            }

            return summaryFigures;
        }
    }
}
