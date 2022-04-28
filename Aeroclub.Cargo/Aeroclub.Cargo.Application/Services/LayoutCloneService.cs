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

        public LayoutCloneService(
            IAircraftService aircraftService,
            IUnitOfWork unitOfWork, 
            IMapper mapper) 
            : base(unitOfWork, mapper)
        {
            _aircraftService = aircraftService;
        }

        public async Task CloneLayoutAsync(Guid aircraftId)
        {
            // Get Aircraft
            var aircraft = await _unitOfWork.Repository<Aircraft>().GetByIdAsync(aircraftId);
            if (aircraft == null) return;

            // Get AircraftLayout including all childs till Position
            // Reset Ids
            var aircraftLayoutSpec = new AircraftLayoutSpecification(
                new Models.Queries.AircraftLayoutQMs.AircraftLayoutQM() { Id = aircraft.AircraftLayoutId, IncludeAircraftDeck= true});
            
            var aircraftLayout = await _unitOfWork.Repository<AircraftLayout>().GetEntityWithSpecAsync(aircraftLayoutSpec);
            
            if (aircraftLayout == null) return;
            
            var newAircraftLayout = aircraftLayout.AircraftDecks
                .Select(d=> 
                new AircraftLayout() { 
                    Id = Guid.Empty,
                    AircraftDecks = (ICollection<AircraftDeck>)d.AircraftLayout.AircraftDecks
                    .Select(a=> new AircraftDeck(){ 
                        CurrentWeight = 0,
                        AircraftDeckType = a.AircraftDeckType,
                        MaxWeight = a.MaxWeight,
                        AircraftCabins = (ICollection<AircraftCabin>)a.AircraftCabins
                        .Select(b=> new AircraftCabin()
                        {
                            MaxWeight=b.MaxWeight,
                            CurrentWeight = 0,
                            Name=b.Name,
                            ZoneAreas = (ICollection<ZoneArea>)b.ZoneAreas
                            .Select(c=> new ZoneArea()
                            {
                                CurrentWeight = 0,
                                Name = c.Name,
                                MaxWeight=c.MaxWeight,   
                                CargoPositions = (ICollection<CargoPosition>)c.CargoPositions
                                .Select(e=>new CargoPosition()
                                {
                                    MaxWeight = e.MaxWeight,
                                    Name = e.Name,
                                    CargoPositionType = e.CargoPositionType,
                                    CurrentWeight = 0,
                                })
                            })
                        })
                    }),
            });
            // Save, if not success, go with 
            //  -- CargoPosition <-- Zone Area <-- Aircraft Cabin <-- Aircraft Deck <-- Aircraft Layout

            // Get SeatLayout including all childs till Seat IsBaseLayout = true
            // Reset Ids
            // Save, if not success, go with 
            // -- Seat <-- SeatConfiguration <-- Seat Layout

            // Create Load Plan

            // Create Flight Schedule Sector
        }
    }
}
