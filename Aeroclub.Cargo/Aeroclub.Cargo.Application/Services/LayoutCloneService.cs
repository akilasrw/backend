using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class LayoutCloneService : BaseService, ILayoutCloneService
    {
        private readonly IAircraftService _aircraftService;
        private readonly ILoadPlanService _loadPlanService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;

        public LayoutCloneService(
            IAircraftService aircraftService,
            ILoadPlanService loadPlanService,
            IFlightScheduleSectorService flightScheduleSectorService,
            IUnitOfWork unitOfWork, 
            IMapper mapper) 
            : base(unitOfWork, mapper)
        {
            _aircraftService = aircraftService;
            _loadPlanService = loadPlanService;
            _flightScheduleSectorService = flightScheduleSectorService;
        }

        public async Task CloneLayoutAsync(FlightSchedule flightSchedule)
        {
            var aircraftId = flightSchedule.AircraftId;
            if (aircraftId == null) return;
            
            // Get Aircraft
            var aircraft = await _unitOfWork.Repository<Aircraft>().GetByIdAsync(aircraftId.Value);
            if (aircraft == null) return;

            // Get AircraftLayout including all childs till Position
            // Reset Ids
            var aircraftLayoutSpec = new AircraftLayoutSpecification(
                new Models.Queries.AircraftLayoutQMs.AircraftLayoutQM() { Id = aircraft.AircraftLayoutId, IncludeAircraftDeck = true });

            var aircraftLayout = await _unitOfWork.Repository<AircraftLayout>().GetEntityWithSpecAsync(aircraftLayoutSpec);

            if (aircraftLayout == null) return;

            var newAircraftDecks = aircraftLayout.AircraftDecks
                .Select(a => new AircraftDeck()
                {
                    CurrentWeight = 0,
                    AircraftDeckType = a.AircraftDeckType,
                    MaxWeight = a.MaxWeight,
                    AircraftCabins = (ICollection<AircraftCabin>)a.AircraftCabins
                    .Select(b => new AircraftCabin()
                    {
                        MaxWeight = b.MaxWeight,
                        CurrentWeight = 0,
                        Name = b.Name,
                        ZoneAreas = (ICollection<ZoneArea>)b.ZoneAreas
                                .Select(c => new ZoneArea()
                                {
                                    CurrentWeight = 0,
                                    Name = c.Name,
                                    MaxWeight = c.MaxWeight,
                                    CargoPositions = (ICollection<CargoPosition>)c.CargoPositions
                                    .Select(e => new CargoPosition()
                                    {
                                        MaxWeight = e.MaxWeight,
                                        Name = e.Name,
                                        CargoPositionType = e.CargoPositionType,
                                        CurrentWeight = 0,
                                    })
                                })
                    })
                });

            aircraftLayout.Id = Guid.NewGuid();
            aircraftLayout.AircraftDecks = (ICollection<AircraftDeck>)newAircraftDecks;
            var createdAircraftLayout = await _unitOfWork.Repository<AircraftLayout>().CreateAsync(aircraftLayout);
            // Save, if not success, go with this sequence | CargoPosition <-- Zone Area <-- Aircraft Cabin <-- Aircraft Deck <-- Aircraft Layout

            // Get SeatLayout including all childs till Seat
            // Reset Ids
            var seatLayoutSpec = new SeatLayoutSpecification(
                new Models.Queries.SeatLayoutQMs.SeatLayoutQM() { Id = aircraft.AircraftLayoutId, IncludeSeatConfiguration = true });

            var seatLayout = await _unitOfWork.Repository<SeatLayout>().GetEntityWithSpecAsync(seatLayoutSpec);

            if (seatLayout == null) return;
            var newSeatConfigurations = seatLayout.SeatConfigurations
                .Select(d =>
                new SeatConfiguration()
                {
                    IsOnSeatOccupied = false,
                    IsUnderSeatOccupied = false,
                    RowNumber = d.RowNumber,
                    ColumnNumber = d.ColumnNumber,
                    SeatConfigurationType = d.SeatConfigurationType,
                    Seats = (ICollection<Seat>)d.Seats
                    .Select(a => new Seat()
                    {
                        RowNumber = a.RowNumber,
                        ColumnNumber = a.ColumnNumber,
                        IsOnSeatOccupied = false,
                        IsUnderSeatOccupied = false,
                        SeatNumber = a.SeatNumber,
                        // ZoneAreaId = a.ZoneAreaId, // TODO: Need to add this.
                    }),
                });
            seatLayout.Id = Guid.NewGuid();
            seatLayout.SeatConfigurations = (ICollection<SeatConfiguration>)newSeatConfigurations;
            var createdSeatLayout = await _unitOfWork.Repository<SeatLayout>().CreateAsync(seatLayout);
            // Save, if not success, go with this sequence | Seat <-- SeatConfiguration <-- Seat Layout

            // Create Load Plan
            var createdLoadPlan = await _loadPlanService.CreateAsync(
                new Models.Dtos.LoadPlanDto()
                {
                    AircraftLayoutId = createdAircraftLayout.Id,
                    SeatLayoutId = createdSeatLayout.Id,
                    LoadPlanStatus = Common.Enums.LoadPlanStatus.None
                });
            await _unitOfWork.SaveChangesAsync();

            // Create Flight Schedule Sector when calling to create flight schedule.
        }
    }
}
