using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs;
using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SeatConfigurationVM;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoPositionService : BaseService, ICargoPositionService
    {
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly ISeatConfigurationService _seatConfigurationService;

        public CargoPositionService(IUnitOfWork unitOfWork, 
            IMapper mapper, 
            IFlightScheduleSectorService flightScheduleSectorService,
            ISeatConfigurationService seatConfigurationService
            ) : base(unitOfWork, mapper)
        {
            _flightScheduleSectorService = flightScheduleSectorService;
            _seatConfigurationService = seatConfigurationService;
        }

        public async Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingCargoPositionAsync(PackageItemRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType)
        {
            List<Tuple<CargoPosition, Guid?>> matchingCargoPositions = new List<Tuple<CargoPosition, Guid?>>();
            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
                { AircraftLayoutId = aircraftLayoutId, IncludeSeat = true, IncludeOverhead = true});

            var cargoPositionList =
                await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            // Checking Main Deck available positions
            var matchingCargoPosition = cargoPositionList.ToList().FirstOrDefault(x => 
                x.ZoneArea.AircraftCabin.AircraftDeck.AircraftDeckType == AircraftDeckType.MainDeck && // Checking only Main Deck
                x.CargoPositionType == cargoPositionType && // Check position Type based on the package size
                ((cargoPositionType == CargoPositionType.OnSeat && !x.Seat.IsOnSeatOccupied) || // Checking On seat available if the  type is on seat
                 (cargoPositionType == CargoPositionType.UnderSeat && !x.Seat.IsUnderSeatOccupied) || // Checking Under seat available if the  type is under seat
                 (cargoPositionType == CargoPositionType.Overhead && !x.OverheadPosition.IsOccupied)) && // Checking overhead available.
                (x.MaxWeight >= (x.CurrentWeight + packageItem.Weight) && // Checking weight of cargo position
                    (x.ZoneArea.MaxWeight >= (x.ZoneArea.CurrentWeight + packageItem.Weight)) &&
                    (x.ZoneArea.AircraftCabin.MaxWeight >= (x.ZoneArea.AircraftCabin.CurrentWeight + packageItem.Weight)) &&
                    (x.ZoneArea.AircraftCabin.AircraftDeck.MaxWeight >= (x.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight + packageItem.Weight)))
                ); // Checking weight of Zone
            Guid? uldId = null;
            // Main Deck positions full. then checking belly for available positions
            if (matchingCargoPosition == null)
            {
                // TODO: if null, Call Nelanga's API to get Belly space

                //matchingCargoPosition = cargoPositionList.ToList().FirstOrDefault(x =>
                //    x.ZoneArea.AircraftZone.AircraftDeck.AircraftDeckType == AircraftDeckType.Belly &&
                //    (x.MaxWeight < (x.CurrentWeight + packageItem.Weight) &&
                //     (x.ZoneArea.MaxWeight < (x.ZoneArea.CurrentWeight + packageItem.Weight)) &&
                //     (x.ZoneArea.AircraftZone.MaxWeight <
                //      (x.ZoneArea.AircraftZone.CurrentWeight + packageItem.Weight)) &&
                //     (x.ZoneArea.AircraftZone.AircraftDeck.MaxWeight <
                //      (x.ZoneArea.AircraftZone.AircraftDeck.CurrentWeight + packageItem.Weight)))
                //);

                //if (matchingCargoPosition == null)
                //{
                //    return null;
                //}               
            }

            matchingCargoPositions.Add(new Tuple<CargoPosition, Guid?>(matchingCargoPosition, uldId));
            return matchingCargoPositions;

        }


        public async Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingThreeSeatCargoPositionAsync(PackageItemRM packageItem, Guid aircraftLayoutId, SeatConfigurationType seatConfigurationType)
        {
            List<Tuple<CargoPosition, Guid?>> matchingCargoPositions = new List<Tuple<CargoPosition, Guid?>>();
           
            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = aircraftLayoutId, IncludeSeat = true });

            var cargoPositionList = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var seatSec = new SeatConfigurationSpecification(new SeatConfigurationQM() { IncludeZones = true, SeatConfigurationType = seatConfigurationType });
            var availableConfigurationList =
                await _unitOfWork.Repository<SeatConfiguration>().GetListWithSpecAsync(seatSec);

            var avaialbleSeatConfig = availableConfigurationList.FirstOrDefault(x => (x.Seats.Where(g => !g.IsOnSeatOccupied).Count() > 2) &&
            x.Seats.Any(y=>y.ZoneArea.AircraftCabin.AircraftDeck.AircraftLayoutId == aircraftLayoutId));

            Guid? uldId = null;
            int positiionCount = 0;

            foreach (var seat in avaialbleSeatConfig.Seats.ToList())
            {
                var matchingCargoPosition = cargoPositionList.FirstOrDefault(x =>
                x.ZoneArea.AircraftCabin.AircraftDeck.AircraftDeckType == AircraftDeckType.MainDeck &&
                x.SeatId == seat.Id && x.CargoPositionType == CargoPositionType.OnSeat &&
                (x.MaxWeight >= (x.CurrentWeight + packageItem.Weight) &&
                    (x.ZoneArea.MaxWeight >= (x.ZoneArea.CurrentWeight + packageItem.Weight)) &&
                    (x.ZoneArea.AircraftCabin.MaxWeight >= (x.ZoneArea.AircraftCabin.CurrentWeight + packageItem.Weight)) &&
                    (x.ZoneArea.AircraftCabin.AircraftDeck.MaxWeight >= (x.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight + packageItem.Weight))));

                if (matchingCargoPosition != null) 
                {
                    ++positiionCount;
                    matchingCargoPositions.Add(new Tuple<CargoPosition, Guid?>(matchingCargoPosition, uldId));
                }

                if (positiionCount >= 3)
                    break;
            }

            if (matchingCargoPositions.Count == 0)
            {         
            }

            return matchingCargoPositions;

        }


        public async Task<SeatAvailabilityVM> GetAvailableThreeSeatAsync(FlightScheduleSectorQM qm)
        {
            var availableSeatCount = 0;
            var response = new SeatAvailabilityVM() { SeatCount = availableSeatCount };

            var flightSector = await _flightScheduleSectorService.GetAsync(qm);

            if (!flightSector.FlightScheduleSectorCargoPositions.Any(x => x.AvailableSpaceCount > 0))
            {
                return response;
            }

            var cargoPositionSpec = new CargoPositionSpecification(new CargoSeatPositionListQM
            { AircraftLayoutId = flightSector.AircraftLayoutId.Value, IncludeSeat = true, CargoPositionType = CargoPositionType.OnSeat });

            var cargoPositionList = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            foreach (var cargoPosition in cargoPositionList)
            {
                var seatConfiguration = await _seatConfigurationService.GetAsync(new SeatConfigurationQM() { Id = cargoPosition.Seat.SeatConfigurationId,IncludeSeats=true});
                if (seatConfiguration != null  && seatConfiguration.SeatConfigurationType == SeatConfigurationType.ThreeSeats && seatConfiguration.Seats.Where(x => !x.IsOnSeatOccupied).Count() > 2)
                {
                    availableSeatCount += 1;
                }
            }

            response.SeatCount = availableSeatCount;

            return response;
        }


        public async Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm)
        {

            var response = new ValidateResponse() { IsValid=true};

            var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = rm.FlightScheduleSectorId, IncludeLoadPlan = true });

            if (!flightSector.FlightScheduleSectorCargoPositions.Any(x => x.AvailableSpaceCount > 0))
            {
                
                return new ValidateResponse()
                {
                    IsValid = false,
                    ValidationMessage = "No available space for this."
                };
            }

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
             { AircraftLayoutId = flightSector.AircraftLayoutId.Value, IncludeSeat = true, IncludeOverhead = true });

             var cargoPositionList = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var isMaxWaightValid = true;
            string messagePrefix = "";
            double maxWaight = 0;

            if (rm.PackageItem.PackageContainerType != PackageContainerType.OnThreeSeats)
            {
                var cargoPositions = (CargoPositionType)rm.PackageItem.PackageContainerType;

                if (cargoPositions != CargoPositionType.OnFloor && cargoPositions != CargoPositionType.None)
                {
                    var position = cargoPositionList.First(x => x.CargoPositionType == cargoPositions);

                    maxWaight = position.MaxWeight;

                    if (rm.PackageItem.Weight > maxWaight)
                    {
                        isMaxWaightValid = false;
                        messagePrefix = "Position";

                    }
                    else if (position.ZoneArea.CurrentWeight + rm.PackageItem.Weight > position.ZoneArea.MaxWeight)
                    {
                        isMaxWaightValid = false;
                        messagePrefix = "Zone area";
                    }
                    else if (position.ZoneArea.AircraftCabin.CurrentWeight + rm.PackageItem.Weight > position.ZoneArea.AircraftCabin.MaxWeight)
                    {
                        isMaxWaightValid = false;
                        messagePrefix = "Aircraft cabin";

                    }
                    else if (position.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight + rm.PackageItem.Weight > position.ZoneArea.AircraftCabin.AircraftDeck.MaxWeight)
                    {
                        isMaxWaightValid = false;
                        messagePrefix = "Aircraft deck";
                    }
                }
            }
            else
            {
                // TODO: Three sheet validation - Yohan
            }

            if (!isMaxWaightValid)
            {
                return new ValidateResponse()
                {
                    IsValid = false,
                    ValidationMessage = String.Format("{0} max waight({1}Kg) exceed.", messagePrefix, maxWaight)
                };

            }

            return response;
        }
    }
}