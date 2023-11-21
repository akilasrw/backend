using System.Collections.Generic;
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.OverheadCompartmentQMs;
using Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs;
using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingFlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class BookingManagerService : BaseService, IBookingManagerService
    {
        private readonly ICargoBookingFlightScheduleSectorService _cargoBookingFlightScheduleSectorService;
        private readonly ICargoBookingService _cargoBookingService;
        private readonly IULDContainerService _uLDContainerService;
        private readonly IPackageItemService _packageItemService;
        private readonly ICargoPositionService _cargoPositionService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly ISeatService _seatService;
        private readonly ISeatConfigurationService _seatConfigurationService;
        private readonly IOverheadService _overheadService;
        private readonly IULDContainerCargoPositionService _uLDContainerCargoPositionService;
        private readonly IAWBService _AWBService;
        private readonly IConfiguration _configuration;



        public BookingManagerService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ICargoBookingService cargoBookingService,
            IULDContainerService uLDContainerService,
            IPackageItemService packageItemService,
            ICargoPositionService cargoPositionService,
            IFlightScheduleSectorService flightScheduleSectorService,
            ISeatService seatService,
            ISeatConfigurationService seatConfigurationService,
            IOverheadService overheadService,
            IULDContainerCargoPositionService uLDContainerCargoPositionService,
            IAWBService aWBService,
            ICargoBookingFlightScheduleSectorService cargoBookingFlightScheduleSectorService,
            IConfiguration configuration)
            : base(unitOfWork, mapper)
        {
            _cargoBookingFlightScheduleSectorService = cargoBookingFlightScheduleSectorService;
            _cargoBookingService = cargoBookingService;
            _uLDContainerService = uLDContainerService;
            _packageItemService = packageItemService;
            _cargoPositionService = cargoPositionService;
            _flightScheduleSectorService = flightScheduleSectorService;
            _seatService = seatService;
            _seatConfigurationService = seatConfigurationService;
            _overheadService = overheadService;
            _uLDContainerCargoPositionService = uLDContainerCargoPositionService;
            _AWBService = aWBService;
            _configuration = configuration;
        }

        public async Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm) // for P2C - passanger
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    if (rm.FlightScheduleSectorIds == null)
                    {
                        return BookingServiceResponseStatus.ValidationError;
                    }

                    var packages = rm.PackageItems.ToList();
                    rm.PackageItems.Clear();
                    
                    foreach(var flightScheduleSectorId in rm.FlightScheduleSectorIds)
                    {
                        // Get Flight Schedule Sector Data
                        var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = flightScheduleSectorId, IncludeLoadPlan = true });
                        
                        // Check available Positions
                        if (!flightSector.FlightScheduleSectorCargoPositions.Any(x => x.AvailableSpaceCount > 0))
                        {
                            return BookingServiceResponseStatus.ValidationError;
                        }
                    }

                   
                    
                    // Save Cargo Booking Details
                    var cargoBooking = await _cargoBookingService.CreateAsync(rm);
                    if (cargoBooking == null)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.Failed;
                    }

                    foreach (var flightSectorId in rm.FlightScheduleSectorIds)
                    {
                        var createdBookingFlightSector = await _cargoBookingFlightScheduleSectorService.BookingFlightScheduleSectorCreate(new CargoBookingFlightScheduleSectorRM() { CargoBookingId = cargoBooking.Id, FlightScheduleSectorId = flightSectorId });
                        if (createdBookingFlightSector.StatusCode == ServiceResponseStatus.Failed)
                        {
                            transaction.Rollback();
                            return BookingServiceResponseStatus.Failed;
                        }
                    }

                    //Save AWB Details
                    if (rm.AWBDetail != null)
                    {
                        rm.AWBDetail.CargoBookingId = cargoBooking.Id;
                        var awbResponse = await _AWBService.CreateAsync(rm.AWBDetail);

                        if (awbResponse.StatusCode == ServiceResponseStatus.Failed)
                        {
                            transaction.Rollback();
                            return BookingServiceResponseStatus.Failed;
                        }
                    }

                    // Get Available/ Matching Cargo Positions.
                    foreach (var package in packages)
                    {
                        //Package weight calculation
                        var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                        if (package.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != package.WeightUnitId.ToString())
                        {
                            package.Weight = package.Weight.GramToKilogramConversion();
                        }

                        // Save Package Items
                        package.CargoBookingId = cargoBooking.Id;
                        var createdPackage = await _packageItemService.CreateAsync(package);

                        if (createdPackage.StatusCode == ServiceResponseStatus.Failed)
                        {
                            transaction.Rollback();
                            return BookingServiceResponseStatus.Failed;
                        }

                        foreach(var flightScheduleSectorId in rm.FlightScheduleSectorIds)
                        {

                            // Get Flight Schedule Sector Data
                            var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = flightScheduleSectorId, IncludeLoadPlan = true });

                            if (flightSector == null || flightSector.LoadPlanId == null)
                            {
                                transaction.Rollback();
                                return BookingServiceResponseStatus.Failed;
                            }

                            List<Tuple<CargoPosition, Guid?>> matchedCargoPositions;
                            if (package.PackageContainerType == PackageContainerType.OnThreeSeats)
                                matchedCargoPositions = await _cargoPositionService.GetMatchingThreeSeatCargoPositionAsync(package, flightSector.AircraftLayoutId.Value, SeatConfigurationType.ThreeSeats);
                            else
                                matchedCargoPositions = await _cargoPositionService.GetMatchingCargoPositionAsync(package, flightSector.AircraftLayoutId.Value, (CargoPositionType)package.PackageContainerType); // Return Tuple.

                            if (matchedCargoPositions == null || matchedCargoPositions.Count == 0)
                            {
                                transaction.Rollback();
                                return BookingServiceResponseStatus.NoSpace;
                            }


                            // Save Box or ULD Container Details
                            var createdULDContainer = await _uLDContainerService.CreateAsync(new ULDContainerDto()
                            {
                                LoadPlanId = flightSector.LoadPlanId.Value,
                                ULDContainerType = matchedCargoPositions.First().Item1.CargoPositionType == CargoPositionType.OnFloor ? ULDContainerType.ULD : ULDContainerType.Box,
                                ULDId = matchedCargoPositions.First().Item1.CargoPositionType == CargoPositionType.OnFloor ? matchedCargoPositions.First().Item2 : null, // From Neelanga's API
                                Height = package.Height,
                                Length = package.Length,
                                Width = package.Width,
                            });

                            if (createdULDContainer == null || createdULDContainer.Id == Guid.Empty)
                            {
                                transaction.Rollback();
                                return BookingServiceResponseStatus.Failed;
                            }

                            var createdPackageULDContainer = await _packageItemService.PackageULDContainerCreate(new PackageULDContainerRM() { PackageItemId = createdPackage.Id, ULDContainerId = createdULDContainer.Id });

                            if (createdPackageULDContainer.StatusCode == ServiceResponseStatus.Failed)
                            {
                                transaction.Rollback();
                                return BookingServiceResponseStatus.Failed;
                            }


                            // Save ULD - No need - Lelanga will handle this.

                            foreach (var matchedCargoPosition in matchedCargoPositions)
                            {
                                // Update ULDContainer Cargo Position
                                await _uLDContainerCargoPositionService.CreateAsync(new ULDContainerCargoPositionDto()
                                {
                                    CargoPositionId = matchedCargoPosition.Item1.Id,
                                    ULDContainerId = createdULDContainer.Id
                                });

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

                                        // Check all 3 seats are occupied and if it is true, SeatConfiguration should update as occupied.
                                        var config = await GetSeatConfigurationAsync(seat.SeatConfigurationId);
                                        if (config.Seats.Where(x => !x.IsOnSeatOccupied).Count() == 0)
                                        {
                                            config.IsOnSeatOccupied = true;

                                            if (package.PackageContainerType == PackageContainerType.OnThreeSeats)
                                                config.IsFullRowOccupied = true;

                                            await UpdateSeatConfigurationAsync(config);
                                        }

                                        if (config.Seats.Where(x => !x.IsUnderSeatOccupied).Count() == 0)
                                        {
                                            config.IsUnderSeatOccupied = true;
                                            await UpdateSeatConfigurationAsync(config);
                                        }
                                    }
                                }

                                // Update overhead Position.
                                else if (matchedCargoPosition.Item1.OverheadCompartmentId != null && matchedCargoPosition.Item1.OverheadCompartmentId != Guid.Empty)
                                {
                                    bool overheadUpdated = false;
                                    var overhead = await _overheadService.GetAsync(new OverheadCompartmentQM() { Id = matchedCargoPosition.Item1.OverheadCompartmentId.Value });
                                    if (matchedCargoPosition.Item1.CargoPositionType == CargoPositionType.Overhead)
                                    {
                                        overheadUpdated = true;
                                        overhead.IsOccupied = true;
                                    }

                                    if (overheadUpdated)
                                    {
                                        await _overheadService.UpdateAsync(overhead);
                                        // when all 3 position are occupied, OverheadCompartment should update as occupied.
                                    }
                                }

                                // Update Current Weights. in 3 seats, it should devide for 3 parts
                                await UpdateCurrentWeightAsyncs(matchedCargoPosition.Item1.Id, package.PackageContainerType == PackageContainerType.OnThreeSeats ? package.Weight / 3 : package.Weight);


                            }

                        }                  

                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

            return BookingServiceResponseStatus.Success;
        }

        async Task UpdateCurrentWeightAsyncs(Guid positionId, double weight)
        {
            var position = await _unitOfWork.Repository<CargoPosition>().GetEntityWithSpecAsync(new CargoPositionSpecification(new CargoPositionQM() { Id = positionId }));
            position.CurrentWeight += weight;
            position.ZoneArea.CurrentWeight += weight;
            position.ZoneArea.AircraftCabin.CurrentWeight += weight;
            position.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight += weight;
            _unitOfWork.Repository<CargoPosition>().Update(position);
            _unitOfWork.Repository<ZoneArea>().Update(position.ZoneArea);
            _unitOfWork.Repository<AircraftCabin>().Update(position.ZoneArea.AircraftCabin);
            _unitOfWork.Repository<AircraftDeck>().Update(position.ZoneArea.AircraftCabin.AircraftDeck);

            await _unitOfWork.SaveChangesAsync();

            _unitOfWork.Repository<CargoPosition>().Detach(position);
            _unitOfWork.Repository<ZoneArea>().Detach(position.ZoneArea);
            _unitOfWork.Repository<AircraftCabin>().Detach(position.ZoneArea.AircraftCabin);
            _unitOfWork.Repository<AircraftDeck>().Detach(position.ZoneArea.AircraftCabin.AircraftDeck);
            
        }

        async Task<bool> ValidateAsync(List<PackageItemCreateRM> PackageItems, IList<FlightScheduleSectorCargoPosition> FlightScheduleSectorCargoPositions)
        {

            return true;
        }

        public async Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query)
        {
            return await _cargoBookingService.GetAsync(query);
        }
        
        public async Task<CargoBookingDetailVM> GetDetailAsync(CargoBookingQM query)
        {
            return await _cargoBookingService.GetDetailAsync(query);
        }

        public async Task<Pagination<CargoBookingVM>> GetBookingFilteredListAsync(CargoBookingFilteredListQM query)
        {
            return await _cargoBookingService.GetFilteredListAsync(query);
        }

        public async Task<IReadOnlyList<CargoBookingULDVM>> GetFreighterBookingListAsync(FlightScheduleSectorBookingListQM query)
        {
            return await _cargoBookingService.GetFreighterBookingListAsync(query);
        }

            public async Task<IReadOnlyList<CargoBookingListVM>> GetBookingListAsync(FlightScheduleSectorBookingListQM query)
        {
            return await _cargoBookingService.GetListAsync(query);
        }

        public async Task<CargoBookingSummaryDetailVM> GetBookingSummaryAsync(BookingSummaryQuery query)
        {
            var position = await _flightScheduleSectorService.GetCargoPositionSummaryAsync(
                new FlightScheduleSectorSearchQuery() { FlightScheduleId = query.FlightScheduleId });

            return new CargoBookingSummaryDetailVM()
            {
                CargoPositionSummary = position
            };
        }

        public async Task<IEnumerable<SeatDto>> GetSeatBookingSummaryLayoutAsync(FlightScheduleSectorSearchQuery query)
        {
            return await _flightScheduleSectorService.GetCargoPositionLayoutAsync(query);
        }

        private async Task<bool> UpdateSeatConfigurationAsync(SeatConfigurationDto seatConfigurationDto)
        {
            foreach (var seat in seatConfigurationDto.Seats.ToList())
            {
                seat.IsOnSeatOccupied = true;
                await _seatService.UpdateAsync(seat);
            }
            await _seatConfigurationService.UpdateAsync(seatConfigurationDto);
            return true;
        }

        private async Task<SeatConfigurationDto> GetSeatConfigurationAsync(Guid seatConfigId)
        {
           return  await _seatConfigurationService.GetAsync(new SeatConfigurationQM()
            {
                Id = seatConfigId,
                IncludeSeats = true,
                SeatConfigurationType = SeatConfigurationType.ThreeSeats
           });
        }

        public async Task<BookingServiceResponseStatus> UpdateAsync(CargoBookingUpdateRM rm)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {

                // Update Cargo Booking Details
                var response = await _cargoBookingService.UpdateAsync(rm);
                if (response.StatusCode == ServiceResponseStatus.Failed)
                {
                    transaction.Rollback();
                    return BookingServiceResponseStatus.Failed;
                }

                transaction.Commit();
            }

            return BookingServiceResponseStatus.Success;
        }

        public async Task<ServiceResponseStatus> UpdateStandByStatusAsync(CargoBookingStatusUpdateListRM rm)
        {
            return await _cargoBookingService.UpdateStandByStatusAsync(rm);
        }

        public async Task<ServiceResponseStatus> UpdateDeleteListAsync(IEnumerable<CargoBookingUpdateRM> list)
        {
            return await _cargoBookingService.UpdateDeleteListAsync(list);
        }

        public BookingStatus BookingNextStatus(BookingStatus bookingStatus)
        {
            switch(bookingStatus)
            {
                case BookingStatus.None: return BookingStatus.Booked;
                case BookingStatus.Booked: return BookingStatus.Accepted;
                //case BookingStatus.Accepted: return BookingStatus.Dispatched;
            }
            return BookingStatus.None;
        }
        public VerifyStatus BookingVerifyNextStatus(BookingStatus bookingStatus, bool isCancel = false, bool isRecieved = false, bool isDispatch = false)
        {
            if (bookingStatus == BookingStatus.Booked)
            {
                if (isCancel) return VerifyStatus.Deleted;
                if (isRecieved) return VerifyStatus.Dispatched;
                return VerifyStatus.CargoNotDispatched;

            }
            else if (bookingStatus == BookingStatus.Accepted)
            {
                if (isDispatch) return VerifyStatus.Dispatched;
                if (isCancel) return VerifyStatus.Deleted;
                return VerifyStatus.OffLoad;
            }
            return VerifyStatus.None;
        }

        public PackageItemStatus PackageNextStatus(PackageItemStatus packageItemStatus)
        {
            switch(packageItemStatus)
            {
                case PackageItemStatus.None: return PackageItemStatus.Booked;
                case PackageItemStatus.Booked: return PackageItemStatus.Accepted;
                case PackageItemStatus.Accepted: return PackageItemStatus.Dispatched;
            }
            return PackageItemStatus.None;
        }

        public async Task<IReadOnlyList<CargoBookingStandByCargoVM>> GetStandByCargoListAsync(FlightScheduleSectorBookingListQM query)
        {
            return await _cargoBookingService.GetStandByCargoListAsync(query);
        }
        
        public async Task<IReadOnlyList<CargoBookingListVM>> GetVerifyBookingListAsync(FlightScheduleSectorVerifyBookingListQM query)
        {
            return await _cargoBookingService.GetVerifyBookingListAsync(query);
        }

        public async Task<CargoBookingMobileVM> GetMobileBookingAsync(FlightScheduleSectorMobileQM query)
        {
            return await _cargoBookingService.GetMobileBookingAsync(query);
        }

        public Task<IReadOnlyList<CargoBookingListVM>> GetAssignedCargoList(AssignedCargoQM query)
        {
            return _cargoBookingService.GetOnlyAssignedListAsync(query);
        }
    }
}
