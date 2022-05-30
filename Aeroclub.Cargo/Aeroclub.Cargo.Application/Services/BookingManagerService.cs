﻿using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.OverheadPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.SeatConfigurationQMs;
using Aeroclub.Cargo.Application.Models.Queries.SeatQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
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
        private readonly ISeatConfigurationService _seatConfigurationService;
        private readonly IOverheadService _overheadService;

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
            IOverheadService overheadService)
            : base(unitOfWork, mapper)
        {
            _cargoBookingService = cargoBookingService;
            _uLDContainerService = uLDContainerService;
            _packageItemService = packageItemService;
            _cargoPositionService = cargoPositionService;
            _flightScheduleSectorService = flightScheduleSectorService;
            _seatService = seatService;
            _seatConfigurationService = seatConfigurationService;
            _overheadService = overheadService;
        }

        public async Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm)
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

                    // Check available Positions
                    if (!flightSector.FlightScheduleSectorCargoPositions.Any(x=>x.AvailableSpaceCount > 0))
                    {
                        return BookingServiceResponseStatus.ValidationError;
                    }

                    // Save Cargo Booking Details
                    var response = await _cargoBookingService.CreateAsync(rm);
                    if (response == null)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.Failed;
                    }

                    // Get Available/ Matching Cargo Positions.
                    foreach (var package in packages)
                    {
                        // TODO: Local Binding it default PackageContainerType
                        // if(item.PackageContainerType == PackageContainerType.None)
                        //    continue; 
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

                        // Save ULD - No need - Lelanga will handle this.
                        bool isFirstPosition = false;
                        foreach (var matchedCargoPosition in matchedCargoPositions)
                        {
                            if (!isFirstPosition)
                            {
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
                                isFirstPosition = true;
                            } // TODO: Only saved one position Id,  Need to handle this.

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
                            else if (matchedCargoPosition.Item1.OverheadPositionId != null && matchedCargoPosition.Item1.OverheadPositionId != Guid.Empty)
                            {
                                bool overheadUpdated = false;
                                var overhead = await _overheadService.GetAsync(new OverheadPositionQM() { Id = matchedCargoPosition.Item1.OverheadPositionId.Value });
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
                            await UpdateCurrentWeightAsyncs(matchedCargoPosition.Item1.Id, package.PackageContainerType == PackageContainerType.OnThreeSeats? package.Weight/3: package.Weight);
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
            
            _unitOfWork.Repository<CargoPosition>().Detach(position);
            _unitOfWork.Repository<ZoneArea>().Detach(position.ZoneArea);
            _unitOfWork.Repository<AircraftCabin>().Detach(position.ZoneArea.AircraftCabin);
            _unitOfWork.Repository<AircraftDeck>().Detach(position.ZoneArea.AircraftCabin.AircraftDeck);
            await _unitOfWork.SaveChangesAsync();
        }

        async Task<bool> ValidateAsync(List<PackageItemRM> PackageItems, IList<FlightScheduleSectorCargoPosition> FlightScheduleSectorCargoPositions)
        {

            return true;
        }

        public async Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query)
        {
            return await _cargoBookingService.GetAsync(query);
        }

        public async Task<Pagination<CargoBookingVM>> GetBookingFilteredListAsync(CargoBookingFilteredListQM query)
        {
            return await _cargoBookingService.GetFilteredListAsync(query);
        }

        private async Task<bool> UpdateSeatConfigurationAsync(SeatConfigurationDto seatConfigurationDto)
        {
            seatConfigurationDto.IsOnSeatOccupied = true;
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
    }
}
