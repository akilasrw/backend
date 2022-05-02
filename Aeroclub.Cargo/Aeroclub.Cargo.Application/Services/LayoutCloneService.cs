using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
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

        public async Task CloneLayoutAsync(FlightSchedule flightSchedule, IEnumerable<FlightScheduleSectorCreateRM>? FlightScheduleSectors)
        {
            if (FlightScheduleSectors != null)
            {
                var aircraftId = flightSchedule.AircraftId;
                if (aircraftId == null) return;

                // Get Aircraft
                var aircraft = await GetAircraftAsync(aircraftId.Value);
                if (aircraft == null) return;

                // Get AircraftLayout including all childs till Position
                var aircraftLayout = await GetAircraftLayoutAsync(aircraft.AircraftLayoutId);
                if (aircraftLayout == null) return;       

                // Get SeatLayout including all childs till Seat
                var seatLayout = await GetSeatLayoutAsync(aircraft.AircraftLayoutId);
                if (seatLayout == null) return;
                
                var newResetLayouts = await CloningLayoutAsync(aircraftLayout, seatLayout);

                foreach (var sector in FlightScheduleSectors)
                {
                    // Create Aircraft Layout
                    var createdAircraftLayout = await _unitOfWork.Repository<AircraftLayout>().CreateAsync(newResetLayouts.Item1);
                    // Save, if not success, go with this sequence | CargoPosition <-- Zone Area <-- Aircraft Cabin <-- Aircraft Deck <-- Aircraft Layout

                    var createdSeatLayout = await _unitOfWork.Repository<SeatLayout>().CreateAsync(newResetLayouts.Item2);
                    // Save, if not success, go with this sequence | Seat <-- SeatConfiguration <-- Seat Layout

                    // Create Load Plan                    
                    var createdLoadPlanStatus = await _loadPlanService.CreateAsync(
                        new Models.Dtos.LoadPlanDto()
                        {
                            AircraftLayoutId = createdAircraftLayout.Id,
                            SeatLayoutId = createdSeatLayout.Id,
                            LoadPlanStatus = Common.Enums.LoadPlanStatus.None
                        });

                    await _unitOfWork.SaveChangesAsync();

                    // Save Flight Schedule Sector
                    sector.FlightScheduleId = flightSchedule.Id;
                    sector.LoadPlanId = createdLoadPlanStatus.Id;
                    await _flightScheduleSectorService.CreateAsync(sector);
                }
            }
        }

        private async Task<Aircraft> GetAircraftAsync(Guid aircraftId)
        {
            return await _unitOfWork.Repository<Aircraft>().GetByIdAsync(aircraftId);
        }

        private async Task<AircraftLayout> GetAircraftLayoutAsync(Guid aircraftLayoutId)
        {
            var aircraftLayoutSpec = new AircraftLayoutSpecification(
                 new Models.Queries.AircraftLayoutQMs.AircraftLayoutQM() { Id = aircraftLayoutId, IncludeAircraftDeck = true });

            return await _unitOfWork.Repository<AircraftLayout>().GetEntityWithSpecAsync(aircraftLayoutSpec);
        }

        private Task<Tuple<AircraftLayout, SeatLayout>> CloningLayoutAsync(AircraftLayout aircraftLayout, SeatLayout seatLayout)
        {
            List<KeyValuePair<Guid, Guid>> zoneGuids = new List<KeyValuePair<Guid, Guid>>() { new KeyValuePair<Guid, Guid>() };

            foreach (var deck in aircraftLayout.AircraftDecks)
            {
                deck.Id = Guid.NewGuid();
                foreach (var cabin in deck.AircraftCabins)
                {
                    cabin.AircraftDeckId = deck.Id;
                    cabin.Id = Guid.NewGuid();
                    foreach (var zone in cabin.ZoneAreas)
                    {
                        var zoneId = zone.Id;
                        zone.AircraftCabinId = cabin.Id;
                        zone.Id = Guid.NewGuid();
                        zoneGuids.Add(new KeyValuePair<Guid, Guid>(zoneId, zone.Id));

                        foreach (var position in zone.CargoPositions)
                        {
                            position.ZoneAreaId = zone.Id;
                            position.Id = Guid.NewGuid();
                        }
                    }
                }
            }

            foreach (var conf in seatLayout.SeatConfigurations)
            {
                conf.Id = Guid.NewGuid();
                foreach (var seat in conf.Seats)
                {
                    seat.SeatConfigurationId = conf.Id;
                    seat.Id = Guid.NewGuid();
                    seat.ZoneAreaId = zoneGuids.FirstOrDefault(x => x.Key == seat.ZoneAreaId).Value;
                }
            }

            Tuple<AircraftLayout,SeatLayout> layouts = new Tuple<AircraftLayout, SeatLayout>(aircraftLayout, seatLayout);

            // Reset Ids, default values
            return Task.FromResult(layouts);
        }

        private async Task<SeatLayout> GetSeatLayoutAsync(Guid aircraftLayoutId)
        {
            var seatLayoutSpec = new SeatLayoutSpecification(
               new Models.Queries.SeatLayoutQMs.SeatLayoutQM() { Id = aircraftLayoutId, IncludeSeatConfiguration = true });

            return await _unitOfWork.Repository<SeatLayout>().GetEntityWithSpecAsync(seatLayoutSpec);
        } 

        private Task<IEnumerable<SeatConfiguration>> CloningSeatConfigurationAsync(SeatLayout seatLayout)
        {
            // Reset Ids, default values
            return Task.FromResult(seatLayout.SeatConfigurations
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
                }));
        }
    }
}
