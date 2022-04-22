using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoPositionService : BaseService, ICargoPositionService
    {
        public CargoPositionService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Tuple<CargoPosition, Guid?>> GetMatchingCargoPosition(PackageItemRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType)
        {
            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
                {AircraftLayoutId = aircraftLayoutId, IncludeSeat = true});

            var cargoPositionList =
                await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            // Checking Main Deck available positions
            var matchingCargoPosition = cargoPositionList.ToList().FirstOrDefault(x => 
                x.ZoneArea.AircraftZone.AircraftDeck.AircraftDeckType == AircraftDeckType.MainDeck && // Checking only Main Deck
                x.CargoPositionType == cargoPositionType && // Check position Type based on the package size
                ((cargoPositionType == CargoPositionType.OnSeat && !x.Seat.IsOnSeatOccupied) || // Checking On seat available if the  type is on seat
                 (cargoPositionType == CargoPositionType.UnderSeat && !x.Seat.IsUnderSeatOccupied)) && // Checking Under seat available if the  type is under seat
                (x.MaxWeight > (x.CurrentWeight + packageItem.Weight) && // Checking weight of cargo position
                    (x.ZoneArea.MaxWeight > (x.ZoneArea.CurrentWeight + packageItem.Weight)) &&
                    (x.ZoneArea.AircraftZone.MaxWeight > (x.ZoneArea.AircraftZone.CurrentWeight + packageItem.Weight)) &&
                    (x.ZoneArea.AircraftZone.AircraftDeck.MaxWeight > (x.ZoneArea.AircraftZone.AircraftDeck.CurrentWeight + packageItem.Weight)))
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

            return new Tuple<CargoPosition, Guid?>(matchingCargoPosition, uldId);

        }

        
    }
}