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
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SeatConfigurationVM;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Errors.Model;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoPositionService : BaseService, ICargoPositionService
    {
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly ISeatConfigurationService _seatConfigurationService;
        private readonly IConfiguration _configuration;

        public CargoPositionService(IUnitOfWork unitOfWork, 
            IMapper mapper, 
            IFlightScheduleSectorService flightScheduleSectorService,
            ISeatConfigurationService seatConfigurationService,
            IConfiguration configuration
            ) : base(unitOfWork, mapper)
        {
            _flightScheduleSectorService = flightScheduleSectorService;
            _seatConfigurationService = seatConfigurationService;
            _configuration = configuration;
        }



        public async Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingCargoPositionAsync(PackageItemCreateRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType)
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
                 (cargoPositionType == CargoPositionType.Overhead && !x.OverheadCompartment.IsOccupied)) && // Checking overhead available.
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


        public async Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingThreeSeatCargoPositionAsync(PackageItemCreateRM packageItem, Guid aircraftLayoutId, SeatConfigurationType seatConfigurationType)
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

            if (!flightSector.FlightScheduleSectorCargoPositions.Any(x => x.CargoPositionType == CargoPositionType.OnSeat && x.AvailableSpaceCount >2))
            {
                return response;
            }

            var seatConfigurationSpec = new SeatConfigurationSpecification(new SeatConfigurationListQM
            { SeatLayoutId = flightSector.SeatLayoutId.Value, IncludeSeats = true, SeatConfigurationType = SeatConfigurationType.ThreeSeats });

            var seatConfigurationList = await _unitOfWork.Repository<SeatConfiguration>().GetListWithSpecAsync(seatConfigurationSpec);

            if(seatConfigurationList != null)
            {
                foreach (var config in seatConfigurationList)
                {
                    if (config.Seats.Where(x => !x.IsOnSeatOccupied).Count() > 2)
                    {
                        availableSeatCount += 1;
                    }
                }
            }

            response.SeatCount = availableSeatCount;

            return response;
        }


        public async Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm)
        {

            var response = new ValidateResponse() { IsValid=true};

            foreach(var flightScheduleSectorId in rm.FlightScheduleSectorIds)
            {
                var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = flightScheduleSectorId, IncludeLoadPlan = true });

                if (!flightSector.FlightScheduleSectorCargoPositions.Any(x => x.AvailableSpaceCount > 0))
                {
                    return new ValidateResponse()
                    {
                        IsValid = false,
                        ValidationMessage = "No available space for this."
                    };
                }

                if (rm.PackageItem.PackageContainerType != PackageContainerType.OnThreeSeats)
                {
                    var cargoPositions = (CargoPositionType)rm.PackageItem.PackageContainerType;

                    if (cargoPositions != CargoPositionType.OnFloor && cargoPositions != CargoPositionType.None)
                    {
                        var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
                        { AircraftLayoutId = flightSector.AircraftLayoutId.Value, IncludeSeat = true, IncludeOverhead = true });

                        var cargoPositionList = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

                        var position = cargoPositionList.First(x => x.CargoPositionType == cargoPositions);

                        var weightValidationResponse = GetWeightValidationResponse(rm.PackageItem.Weight, position.MaxWeight, position.ZoneArea, rm.PackageItem.WeightUnitId);
                        if (weightValidationResponse.IsValid)
                        {
                            response = weightValidationResponse;
                        }
                        else
                        {
                            return weightValidationResponse;
                        }
                    }
                }
                else
                {
                    SeatConfiguration? config = null;

                    var seatConfigurationSpec = new SeatConfigurationSpecification(new SeatConfigurationListQM
                    { SeatLayoutId = flightSector.SeatLayoutId.Value, IncludeSeats = true, IncludeZones = true, SeatConfigurationType = SeatConfigurationType.ThreeSeats });

                    var seatConfigurationList = await _unitOfWork.Repository<SeatConfiguration>().GetListWithSpecAsync(seatConfigurationSpec);

                    if (seatConfigurationList != null)
                    {
                        foreach (var seatConfig in seatConfigurationList)
                        {
                            if (seatConfig.Seats.Where(x => !x.IsOnSeatOccupied).Count() > 2)
                            {
                                config = seatConfig;
                                break;
                            }
                        }
                    }

                    if (config != null && config.Seats != null)
                    { 
                        var weightValidationResponse = GetWeightValidationResponse(rm.PackageItem.Weight, config.MaxWeight, config.Seats.First().ZoneArea, rm.PackageItem.WeightUnitId);
                        if (weightValidationResponse.IsValid)
                        {
                            response = weightValidationResponse;
                        }
                        else
                        {
                            return weightValidationResponse;
                        }
                    }
                    else
                    {
                        return new ValidateResponse()
                        {
                            IsValid = false,
                            ValidationMessage = "No available space for this."
                        };
                    }
                }
            }

            return response;
        }

        private ValidateResponse GetWeightValidationResponse(double packageWeight, double maxWeight, ZoneArea zoneArea,Guid weightUnitId)
        {

            var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
            if (weightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != weightUnitId.ToString())
            {
                packageWeight = packageWeight.GramToKilogramConversion();
            }


            var isMaxWeightValid = true;
            string messagePrefix = "";

            if (packageWeight > maxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Position";

            }
            else if (zoneArea.CurrentWeight + packageWeight > zoneArea.MaxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Zone area";
            }
            else if (zoneArea.AircraftCabin.CurrentWeight + packageWeight > zoneArea.AircraftCabin.MaxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Aircraft cabin";

            }
            else if (zoneArea.AircraftCabin.AircraftDeck.CurrentWeight + packageWeight > zoneArea.AircraftCabin.AircraftDeck.MaxWeight)
            {
                isMaxWeightValid = false;
                messagePrefix = "Aircraft deck";
            }

            if (!isMaxWeightValid)
            {
                return new ValidateResponse()
                {
                    IsValid = false,
                    ValidationMessage = String.Format("{0} max weight({1}Kg) exceed.", messagePrefix, maxWeight)
                };

            }
            else
            {
                return  new ValidateResponse() { IsValid = true };
            }

        }

        public async Task<List<CargoPositionVM>> GetSummeryCargoPositionAsync(Guid aircraftLayoutId)
        {
            List<CargoPositionVM> list = new List<CargoPositionVM>();
            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = aircraftLayoutId, IncludeSeat = true, IncludeOverhead = true });

            var cargoPositionList =  await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);
            foreach (var cargoPosition in cargoPositionList)
            {
                var cargoVM = new CargoPositionVM
                {
                    Id = cargoPosition.Id,
                    Name = cargoPosition.Name,
                    Height = cargoPosition.Height,
                    MaxWeight = cargoPosition.MaxWeight,
                    MaxVolume = cargoPosition.MaxVolume,
                    CurrentWeight = cargoPosition.CurrentWeight,
                    Length = cargoPosition.Length,
                    Breadth = cargoPosition.Breadth,
                    Priority = cargoPosition.Priority,
                    FlightLeg = cargoPosition.FlightLeg,
                    CurrentVolume = cargoPosition.CurrentVolume,
                    ZoneAreaId = cargoPosition.ZoneAreaId,
                };

                list.Add(cargoVM);
            }

            return list;
        }

        public async Task UpdateCargoPositionPropertiesAsync(Guid cargoPositionId, double newHeight, double newMaxWeight, double newMaxVolume)
        {
           
            var cargoPosition = await _unitOfWork.Repository<CargoPosition>().GetByIdAsync(cargoPositionId);

            if (cargoPosition == null)
            { 
                throw new NotFoundException("CargoPosition not found");
            }

          
            cargoPosition.Height = newHeight;
            cargoPosition.MaxWeight = newMaxWeight;
            cargoPosition.MaxVolume = newMaxVolume;


            _unitOfWork.Repository<CargoPosition>().Update(cargoPosition);

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        
            
        }

    }
}