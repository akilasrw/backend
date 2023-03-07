using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AircraftLayoutQMs;
using Aeroclub.Cargo.Application.Models.Queries.AircrftLayoutMappingQM;
using Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs;
using Aeroclub.Cargo.Application.Models.Queries.OverheadLayoutQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Google.Cloud.Firestore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Policy;
using static Google.Rpc.Context.AttributeContext.Types;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeroclub.Cargo.Application.Services
{
    public class LayoutCloneService : BaseService, ILayoutCloneService
    {
        private readonly ILoadPlanService _loadPlanService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly IAircraftService _aircraftService;

        public LayoutCloneService(
            ILoadPlanService loadPlanService,
            IFlightScheduleSectorService flightScheduleSectorService,
            IAircraftService aircraftService,
            IUnitOfWork unitOfWork,
            IMapper mapper)
            : base(unitOfWork, mapper)
        {
            _loadPlanService = loadPlanService;
            _flightScheduleSectorService = flightScheduleSectorService;
            _aircraftService = aircraftService;
        }

        public async Task<bool> CloneLayoutAsync(FlightSchedule flightSchedule, IEnumerable<FlightScheduleSectorCreateRM>? FlightScheduleSectors)
        {
            if (FlightScheduleSectors != null)
            {
                if (flightSchedule.AircraftSubTypeId == Guid.Empty) return false;

                // Get Aircraft Sub Type
                var aircraftSubTypeDetail = await GetAircraftSubTypeAsync(flightSchedule.AircraftSubTypeId);
                if (aircraftSubTypeDetail == null) return false;

                if (aircraftSubTypeDetail.ConfigType != AircraftConfigType.P2C) return false;

                // Get Aircrat Layout Mapping
                var aircraftLayoutMappingDetail = await GetAircraftLayoutMappingAsync(aircraftSubTypeDetail.Id);
                if (aircraftLayoutMappingDetail == null) return false;
                if (aircraftLayoutMappingDetail.AircraftLayoutId == null) return false;
                if (aircraftLayoutMappingDetail.SeatLayoutId == null) return false;
                if (aircraftLayoutMappingDetail.OverheadLayoutId == null) return false;

                foreach (var sector in FlightScheduleSectors)
                {
                    // Get AircraftLayout including all childs till Position
                    var aircraftLayout = await GetAircraftLayoutAsync((Guid)aircraftLayoutMappingDetail.AircraftLayoutId);
                    if (aircraftLayout == null) return false;

                    // Get SeatLayout including all childs till Seat
                    var seatLayout = await GetSeatLayoutAsync((Guid)aircraftLayoutMappingDetail.SeatLayoutId);
                    if (seatLayout == null) return false;

                    // Get OverheadLayout including all childs till overheadPosition
                    var overheadLayout = await GetOverheadLayoutAsync((Guid)aircraftLayoutMappingDetail.OverheadLayoutId);
                    if (overheadLayout == null) return false;


                    var newResetLayouts = await ResetLayoutAsync(aircraftLayout, seatLayout, overheadLayout);


                    // Create Aircraft Layout
                    var createdAircraftLayout = await _unitOfWork.Repository<AircraftLayout>().CreateAsync(newResetLayouts.Item1);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<AircraftLayout>().Detach(createdAircraftLayout);
                    // Save, if not success, go with this sequence | CargoPosition <-- Zone Area <-- Aircraft Cabin <-- Aircraft Deck <-- Aircraft Layout

                    var createdSeatLayout = await _unitOfWork.Repository<SeatLayout>().CreateAsync(newResetLayouts.Item2);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<SeatLayout>().Detach(createdSeatLayout);
                    foreach (var seatConfig in createdSeatLayout.SeatConfigurations)
                        _unitOfWork.Repository<SeatConfiguration>().Detach(seatConfig);
                    // Save, if not success, go with this sequence | Seat <-- SeatConfiguration <-- Seat Layout

                    var createdoverheadLayout = await _unitOfWork.Repository<OverheadLayout>().CreateAsync(newResetLayouts.Item3);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<OverheadLayout>().Detach(createdoverheadLayout);
                    // Save, if not success, go with this sequence | Seat <-- SeatConfiguration <-- Seat Layout

                    // Update Position - Seat Id after saving Seats
                    foreach (var item in newResetLayouts.Item4)
                        if (item != null)
                        {
                            var position = await _unitOfWork.Repository<CargoPosition>().GetByIdAsync(item.Id);
                            if (item.SeatId != null)
                                position.SeatId = item.SeatId;
                            if (item.OverheadCompartmentId != null)
                                position.OverheadCompartmentId = item.OverheadCompartmentId;

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
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<AircraftSubType> GetAircraftSubTypeAsync(Guid id)
        {
            return await _unitOfWork.Repository<AircraftSubType>().GetByIdAsync(id);
        }

        private async Task<AircraftLayoutMapping> GetAircraftLayoutMappingAsync(Guid subTypeId)
        {
            var spec = new AircraftLayoutMappingSpecification(new AircraftLayoutMappingQM() { AircraftSubTypeId = subTypeId });
            return await _unitOfWork.Repository<AircraftLayoutMapping>().GetEntityWithSpecAsync(spec);
        }

        private async Task<AircraftLayout> GetAircraftLayoutAsync(Guid aircraftLayoutId)
        {
            var aircraftLayoutSpec = new AircraftLayoutSpecification(
                 new Models.Queries.AircraftLayoutQMs.AircraftLayoutQM() { Id = aircraftLayoutId, IncludeAircraftDeck = true });

            return await _unitOfWork.Repository<AircraftLayout>().GetEntityWithSpecAsync(aircraftLayoutSpec);
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

            // Reset Aircraft Decks, Aircraft Cabin, Zone, CargoPositions 
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
                        zoneIDs.Add(new KeyValuePair<Guid, Guid>(zoneId, zone.Id)); // mapping of zone old Id and new id 

                        foreach (var position in zone.CargoPositions)
                        {
                            position.ZoneAreaId = zone.Id;
                            position.Id = Guid.NewGuid();
                        }
                    }
                }
            }

            // Reset Seat Configurations,  Seats
            foreach (var conf in seatLayout.SeatConfigurations)
            {
                conf.Id = Guid.NewGuid();
                foreach (var seat in conf.Seats)
                {
                    var seatID = seat.Id;
                    seat.SeatConfigurationId = conf.Id;
                    seat.Id = Guid.NewGuid();
                    seat.ZoneAreaId = zoneIDs.FirstOrDefault(x => x.Key == seat.ZoneAreaId).Value;
                    if (!seatIDs.Any(x => x.Key == seatID))
                        seatIDs.Add(new KeyValuePair<Guid, Guid>(seatID, seat.Id));
                }
            }

            // Reset Overhead Compartments,  Overheads
            foreach (var compartment in overheadLayout.OverheadCompartmentConfigurations)
            {
                compartment.Id = Guid.NewGuid();
                foreach (var pos in compartment.OverheadCompartments)
                {
                    var overheadID = pos.Id;
                    pos.OverheadCompartmentConfigurationId = compartment.Id;
                    pos.Id = Guid.NewGuid();
                    pos.ZoneAreaId = zoneIDs.FirstOrDefault(x => x.Key == pos.ZoneAreaId).Value;
                    if (!overheadIDs.Any(x => x.Key == overheadID))
                        overheadIDs.Add(new KeyValuePair<Guid, Guid>(overheadID, pos.Id));
                }
            }

            // Reset Cargo Positions
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
                                position.OverheadCompartmentId != null ? overheadIDs.FirstOrDefault(x => x.Key == position.OverheadCompartmentId).Value : null);
                            cargoPositionsList.Add(pos);
                        }
                    }
                }
            }

            Tuple<AircraftLayout, SeatLayout, OverheadLayout, List<CargoPosition>> layouts = new Tuple<AircraftLayout, SeatLayout, OverheadLayout, List<CargoPosition>>(aircraftLayout, seatLayout, overheadLayout, cargoPositionsList);
            return Task.FromResult(layouts);
        }


        public async Task<bool> CloneULDCargoLayoutAsync(FlightSchedule flightSchedule, IEnumerable<FlightScheduleSectorCreateRM>? FlightScheduleSectors)
        {
            if (FlightScheduleSectors != null)
            {

                if (flightSchedule.AircraftSubTypeId == Guid.Empty) return false;

                // Get Aircraft Sub Type
                var aircraftSubTypeDetail = await GetAircraftSubTypeAsync(flightSchedule.AircraftSubTypeId);
                if (aircraftSubTypeDetail == null) return false;

                if (aircraftSubTypeDetail.ConfigType != AircraftConfigType.Freighter) return false;

                // Get Aircrat Layout Mapping
                var aircraftLayoutMappingDetail = await GetAircraftLayoutMappingAsync(aircraftSubTypeDetail.Id);
                if (aircraftLayoutMappingDetail == null) return false;
                if (aircraftLayoutMappingDetail.AircraftLayoutId == null) return false;

                // Get AircraftLayout including all childs till Position
                var aircraftLayout = await GetAircraftLayoutAsync((Guid)aircraftLayoutMappingDetail.AircraftLayoutId);
                if (aircraftLayout == null) return false;

                foreach (var sector in FlightScheduleSectors)
                {

                    var newResetLayouts = await ResetULDCargoLayoutAsync(aircraftLayout);
                    // Create Aircraft Layout
                    var createdAircraftLayout = await _unitOfWork.Repository<AircraftLayout>().CreateAsync(newResetLayouts.Item1);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<AircraftLayout>().Detach(createdAircraftLayout);
                    // Save, if not success, go with this sequence | CargoPosition <-- Zone Area <-- Aircraft Cabin <-- Aircraft Deck <-- Aircraft Layout

                    // Create Load Plan                    
                    var createdLoadPlanStatus = await _loadPlanService.CreateAsync(
                        new Models.Dtos.LoadPlanDto()
                        {
                            AircraftLayoutId = createdAircraftLayout.Id,
                            LoadPlanStatus = Common.Enums.LoadPlanStatus.None
                        });

                    // Save Flight Schedule Sector
                    sector.FlightScheduleId = flightSchedule.Id;
                    sector.LoadPlanId = createdLoadPlanStatus.Id;
                    await _flightScheduleSectorService.CreateAsync(sector);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private Task<Tuple<AircraftLayout>> ResetULDCargoLayoutAsync(AircraftLayout aircraftLayout)
        {
            aircraftLayout.Id = Guid.NewGuid();
            aircraftLayout.IsBaseLayout = false;

            // Reset Aircraft Decks, Aircraft Cabin, Zone, CargoPositions 
            foreach (var deck in aircraftLayout.AircraftDecks)
            {
                deck.Id = Guid.NewGuid();
                foreach (var cabin in deck.AircraftCabins)
                {
                    cabin.AircraftDeckId = deck.Id;
                    cabin.Id = Guid.NewGuid();
                    foreach (var zone in cabin.ZoneAreas)
                    {
                        zone.AircraftCabinId = cabin.Id;
                        zone.Id = Guid.NewGuid();

                        foreach (var position in zone.CargoPositions)
                        {
                            position.ZoneAreaId = zone.Id;
                            position.Id = Guid.NewGuid();
                        }
                    }
                }
            }

            Tuple<AircraftLayout> layouts = new Tuple<AircraftLayout>(aircraftLayout);
            return Task.FromResult(layouts);
        }

        public async Task<bool> DeleteClonedCargoLayoutAsync(FlightSchedule flightSchedule)
        {

            if (flightSchedule.FlightScheduleSectors == null) return false;

            var aircraftConfigType = await _aircraftService.GetAircraftConfigType(flightSchedule.AircraftSubTypeId);


            foreach (var sector in flightSchedule.FlightScheduleSectors)
            {
                if (sector.LoadPlanId != null) return false;


                // Delete Flight Schedule Sector
                var sectorDeleteResponse = await _flightScheduleSectorService.DeleteAsync(sector.Id);
                if (sectorDeleteResponse == ServiceResponseStatus.Failed) return false;

                // Delete Aircraft Layout
                var spec = new LoadPlanSpecification(new LoadPlanQM() { Id = sector.LoadPlanId!.Value, IncludeAircraftLayout = true });
                var loadPlan = await _unitOfWork.Repository<LoadPlan>().GetEntityWithSpecAsync(spec);
                if (aircraftConfigType == AircraftConfigType.Freighter)
                {
                    var deleteAircraftLayoutsResponse = await DeleteULDCargoLayoutAsync(loadPlan.AircraftLayout);
                    if (deleteAircraftLayoutsResponse == ServiceResponseStatus.Failed) return false;
                }


                // Delete Load Plan
                var loadPlanDeleteResponse = await _loadPlanService.DeleteAsync(sector.LoadPlanId!.Value);
                if (loadPlanDeleteResponse == ServiceResponseStatus.Failed) return false;

            }
            return true;
        }

        private async Task<ServiceResponseStatus> DeleteULDCargoLayoutAsync(AircraftLayout aircraftLayout)
        {
            foreach (var deck in aircraftLayout.AircraftDecks)
            {
                foreach (var cabin in deck.AircraftCabins)
                {
                    foreach (var zone in cabin.ZoneAreas)
                    {
                        foreach (var position in zone.CargoPositions)
                        {
                            if (position.CurrentWeight > 0 || position.CurrentVolume > 0) return ServiceResponseStatus.Failed;

                            _unitOfWork.Repository<CargoPosition>().Delete(position);
                            await _unitOfWork.SaveChangesAsync();
                            _unitOfWork.Repository<CargoPosition>().Detach(position);
                        }
                    }
                }
            }

            foreach (var deck in aircraftLayout.AircraftDecks)
            {
                foreach (var cabin in deck.AircraftCabins)
                {
                    foreach (var zone in cabin.ZoneAreas)
                    {
                        if (zone.CurrentWeight > 0) return ServiceResponseStatus.Failed;

                        _unitOfWork.Repository<ZoneArea>().Delete(zone);
                        await _unitOfWork.SaveChangesAsync();
                        _unitOfWork.Repository<ZoneArea>().Detach(zone);
                    }
                }
            }

            foreach (var deck in aircraftLayout.AircraftDecks)
            {
                foreach (var cabin in deck.AircraftCabins)
                {
                    if (cabin.CurrentWeight > 0) return ServiceResponseStatus.Failed;

                    _unitOfWork.Repository<AircraftCabin>().Delete(cabin);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<AircraftCabin>().Detach(cabin);

                }
            }

            foreach (var deck in aircraftLayout.AircraftDecks)
            {
                if (deck.CurrentWeight > 0) return ServiceResponseStatus.Failed;

                _unitOfWork.Repository<AircraftDeck>().Delete(deck);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<AircraftDeck>().Detach(deck);
            }

            _unitOfWork.Repository<AircraftLayout>().Delete(aircraftLayout);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AircraftLayout>().Detach(aircraftLayout);


            return ServiceResponseStatus.Success;
        }


    }
}
