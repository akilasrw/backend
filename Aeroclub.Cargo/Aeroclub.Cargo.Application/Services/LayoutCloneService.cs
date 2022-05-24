﻿using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.OverheadLayoutQMs;
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

        public async Task<bool> CloneLayoutAsync(FlightSchedule flightSchedule, IEnumerable<FlightScheduleSectorCreateRM>? FlightScheduleSectors)
        {
            if (FlightScheduleSectors != null)
            {
                var aircraftId = flightSchedule.AircraftId;
                if (aircraftId == null) return false;

                // Get Aircraft
                var aircraft = await GetAircraftAsync(aircraftId.Value);
                if (aircraft == null) return false;

                // Get AircraftLayout including all childs till Position
                var aircraftLayout = await GetAircraftLayoutAsync(aircraft.AircraftLayoutId);
                if (aircraftLayout == null) return false;       

                // Get SeatLayout including all childs till Seat
                var seatLayout = await GetSeatLayoutAsync(aircraft.SeatLayoutId);
                if (seatLayout == null) return false;

                // Get OverheadLayout including all childs till overheadPosition
                var overheadLayout = await GetOverheadLayoutAsync(aircraft.OverheadLayoutId);
                if (overheadLayout == null) return false;

                foreach (var sector in FlightScheduleSectors)
                {
                    var newResetLayouts = await ResetLayoutAsync(aircraftLayout, seatLayout, overheadLayout);
                    // Create Aircraft Layout
                    var createdAircraftLayout = await _unitOfWork.Repository<AircraftLayout>().CreateAsync(newResetLayouts.Item1);
                    await _unitOfWork.SaveChangesAsync();
                    // Save, if not success, go with this sequence | CargoPosition <-- Zone Area <-- Aircraft Cabin <-- Aircraft Deck <-- Aircraft Layout

                    var createdSeatLayout = await _unitOfWork.Repository<SeatLayout>().CreateAsync(newResetLayouts.Item2);
                    await _unitOfWork.SaveChangesAsync();
                    // Save, if not success, go with this sequence | Seat <-- SeatConfiguration <-- Seat Layout

                    var createdoverheadLayout = await _unitOfWork.Repository<OverheadLayout>().CreateAsync(newResetLayouts.Item3);
                    await _unitOfWork.SaveChangesAsync();
                    // Save, if not success, go with this sequence | Seat <-- SeatConfiguration <-- Seat Layout

                    // Update Position - Seat Id after saving Seats
                    foreach (var item in newResetLayouts.Item4)
                        if (item != null)
                        {
                            var position = await _unitOfWork.Repository<CargoPosition>().GetByIdAsync(item.Id);
                            if (item.SeatId != null)
                                position.SeatId = item.SeatId;
                            if (item.OverheadPositionId != null)
                                position.OverheadPositionId = item.OverheadPositionId;

                            _unitOfWork.Repository<CargoPosition>().Update(position);
                            await _unitOfWork.SaveChangesAsync();
                            _unitOfWork.Repository<CargoPosition>().Detach(position);
                        }                           

                    // Create Load Plan                    
                    var createdLoadPlanStatus = await _loadPlanService.CreateAsync(
                        new Models.Dtos.LoadPlanDto()
                        {
                            AircraftLayoutId = createdAircraftLayout.Id,
                            SeatLayoutId = createdSeatLayout.Id,
                            OverheadLayoutId = createdoverheadLayout.Id,
                            LoadPlanStatus = Common.Enums.LoadPlanStatus.None
                        });                    

                    // Save Flight Schedule Sector
                    sector.FlightScheduleId = flightSchedule.Id;
                    sector.LoadPlanId = createdLoadPlanStatus.Id;
                    await _flightScheduleSectorService.CreateAsync(sector);
                }
            }
            return true;
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

        private Task<Tuple<AircraftLayout, SeatLayout, OverheadLayout, List<CargoPosition>>> ResetLayoutAsync(AircraftLayout aircraftLayout, SeatLayout seatLayout, OverheadLayout overheadLayout)
        {
            List<KeyValuePair<Guid, Guid>> zoneIDs = new List<KeyValuePair<Guid, Guid>>();
            List<KeyValuePair<Guid, Guid>> seatIDs = new List<KeyValuePair<Guid, Guid>>();
            List<KeyValuePair<Guid, Guid>> overheadIDs = new List<KeyValuePair<Guid, Guid>>();

            aircraftLayout.Id = Guid.NewGuid();
            aircraftLayout.IsBaseLayout = false;
            seatLayout.Id = Guid.NewGuid();
            seatLayout.IsBaseLayout = false;
            overheadLayout.Id = Guid.NewGuid();
            overheadLayout.IsBaseLayout = false;

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
                        zoneIDs.Add(new KeyValuePair<Guid, Guid>(zoneId, zone.Id));

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
                    var seatID = seat.Id;   
                    seat.SeatConfigurationId = conf.Id;
                    seat.Id = Guid.NewGuid();
                    seat.ZoneAreaId = zoneIDs.FirstOrDefault(x => x.Key == seat.ZoneAreaId).Value;
                    if(!seatIDs.Any(x=>x.Key == seatID))
                        seatIDs.Add(new KeyValuePair<Guid, Guid>(seatID, seat.Id));
                }
            }

            foreach (var compartment in overheadLayout.OverheadCompartments)
            {
                compartment.Id = Guid.NewGuid();
                foreach (var pos in compartment.OverheadPositions)
                {
                    var overheadID = pos.Id;
                    pos.OverheadCompartmentId = compartment.Id;
                    pos.Id = Guid.NewGuid();
                    pos.ZoneAreaId = zoneIDs.FirstOrDefault(x => x.Key == pos.ZoneAreaId).Value;
                    if (!overheadIDs.Any(x => x.Key == overheadID))
                        overheadIDs.Add(new KeyValuePair<Guid, Guid>(overheadID, pos.Id));
                }
            }

            List<CargoPosition> cargoPositionsList = new List<CargoPosition>();

            foreach (var deck in aircraftLayout.AircraftDecks)
            {
                foreach (var cabin in deck.AircraftCabins)
                {
                    foreach (var zone in cabin.ZoneAreas)
                    {
                        foreach (var position in zone.CargoPositions)
                        {
                            var pos = new CargoPosition().MapCargoPosition(position.Id,
                                position.SeatId != null ? seatIDs.FirstOrDefault(x => x.Key == position.SeatId).Value : null,
                                position.OverheadPositionId != null ? overheadIDs.FirstOrDefault(x => x.Key == position.OverheadPositionId).Value : null);
                            cargoPositionsList.Add(pos);
                        }
                    }
                }
            }

            Tuple<AircraftLayout, SeatLayout,OverheadLayout, List<CargoPosition>> layouts = new Tuple<AircraftLayout, SeatLayout, OverheadLayout, List<CargoPosition>>(aircraftLayout, seatLayout, overheadLayout,cargoPositionsList);

            // Reset Ids, default values
            return Task.FromResult(layouts);
        }

        private async Task<SeatLayout> GetSeatLayoutAsync(Guid aircraftLayoutId)
        {
            var seatLayoutSpec = new SeatLayoutSpecification(
               new Models.Queries.SeatLayoutQMs.SeatLayoutQM() { Id = aircraftLayoutId, IncludeSeatConfiguration = true });

            return await _unitOfWork.Repository<SeatLayout>().GetEntityWithSpecAsync(seatLayoutSpec);
        }
        
        private async Task<OverheadLayout> GetOverheadLayoutAsync(Guid overheadLayoutId)
        {
            var overheadLayoutSpec = new OverheadLayoutSpecification(
               new OverheadLayoutQM() { Id = overheadLayoutId, IncludeOverheadCompartment = true });

            return await _unitOfWork.Repository<OverheadLayout>().GetEntityWithSpecAsync(overheadLayoutSpec);
        }
    }
}