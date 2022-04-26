using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System.Transactions;

namespace Aeroclub.Cargo.Application.Services
{
    public class BookingManagerService : BaseService, IBookingManagerService
    {
        private readonly ICargoBookingService _cargoBookingService;
        private readonly IULDContainerService _uLDContainerService;
        private readonly IPackageItemService _packageItemService;
        private readonly ICargoPositionService _cargoPositionService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly ISeatService _seatService;

        public BookingManagerService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ICargoBookingService cargoBookingService,
            IULDContainerService uLDContainerService,
            IPackageItemService packageItemService,
            ICargoPositionService cargoPositionService,
            IFlightScheduleSectorService flightScheduleSectorService,
            ISeatService seatService)
            : base(unitOfWork, mapper)
        {
            _cargoBookingService = cargoBookingService;
            _uLDContainerService = uLDContainerService;
            _packageItemService = packageItemService;
            _cargoPositionService = cargoPositionService;
            _flightScheduleSectorService = flightScheduleSectorService;
            _seatService = seatService;
        }

        public async Task<ServiceResponseStatus> CreateAsync(CargoBookingRM rm)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var packages = rm.PackageItems.ToList();
                    rm.PackageItems.Clear();
                    
                    // Get Flight Schedule Sector Data
                    var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = rm.FlightScheduleSectorId.Value, IncludeLoadPlan = true });
                    rm.OriginAirportId = flightSector.OriginAirportId;
                    rm.DestinationAirportId = flightSector.DestinationAirportId;

                    if (!flightSector.FlightScheduleSectorCargoPositions.Any(x=>x.AvailableSpaceCount > 0))
                    {
                        return ServiceResponseStatus.ValidationError;
                    }

                    // Save Cargo Booking Details
                    var response = await _cargoBookingService.CreateAsync(rm);
                    if (response == null)
                    {
                        transaction.Rollback();
                        return ServiceResponseStatus.Failed;
                    }                        

                    // Get Available/ Matching Cargo Positions.
                    foreach (var package in packages)
                    {
                        // TODO: Local Binding it default PackageContainerType
                        // if(item.PackageContainerType == PackageContainerType.None)
                        //    continue; 
                        
                        var matchedCargoPosition = await _cargoPositionService.GetMatchingCargoPosition(package, flightSector.AircraftLayoutId.Value, (CargoPositionType)package.PackageContainerType); // Return Tuple.

                        // Save ULD - No need - Lelanga will handle this.

                        // Save Box or ULD Container Details
                        var uldContainer = await _uLDContainerService.CreateAsync(new ULDContainerDto()
                        {
                            CargoPositionId = matchedCargoPosition.Item1.Id,
                            LoadPlanId = flightSector.LoadPlanId.Value,
                            ULDContainerType = matchedCargoPosition.Item1.CargoPositionType == CargoPositionType.OnFloor ? ULDContainerType.ULD : ULDContainerType.Box,
                            ULDId = matchedCargoPosition.Item1.CargoPositionType == CargoPositionType.OnFloor ? matchedCargoPosition.Item2 : null, // From Neelanga's API
                            Height = package.Height,
                            Length = package.Length,
                            Width = package.Width,
                        });

                        // Save Package Items
                        package.CargoBookingId = response.Id;
                        package.ULDContainerId = uldContainer.Id;
                        await _packageItemService.CreateAsync(package);

                        // Update Seat/ Position.
                        if (matchedCargoPosition.Item1.SeatId != null && matchedCargoPosition.Item1.SeatId != Guid.Empty)
                        {
                            bool seatUpdated = false;
                            var seat = await _seatService.GetAsync(new SeatQM() { Id = matchedCargoPosition.Item1.SeatId.Value });
                            if (matchedCargoPosition.Item1.CargoPositionType == CargoPositionType.OnSeat)
                            {
                                seatUpdated = true;
                                seat.IsOnSeatOccupied = true;
                            }
                            else if (matchedCargoPosition.Item1.CargoPositionType == CargoPositionType.UnderSeat)
                            {
                                seatUpdated = true;
                                seat.IsUnderSeatOccupied = true;
                            }

                            if (seatUpdated)
                            {
                                await _seatService.UpdateAsync(seat);
                            }
                        }

                        // TO DO: Update Current Weights.
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

            return ServiceResponseStatus.Success;
        }

        public async Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query)
        {
            return await _cargoBookingService.GetAsync(query);
        }

        public async Task<Pagination<CargoBookingVM>> GetBookingFilteredListAsync(CargoBookingFilteredListQM query)
        {
            return await _cargoBookingService.GetFilteredListAsync(query);
        }
    }
}
