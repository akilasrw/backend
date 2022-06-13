﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleSectorService : BaseService, IFlightScheduleSectorService
    {
        private readonly IConfiguration _configuration;

        public FlightScheduleSectorService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
            : base(unitOfWork, mapper)
        {
            _configuration = configuration;
        }

        public async Task<IReadOnlyList<T>> GetListAsync<T>(FlightScheduleSectorListQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var flightScheduleSectorList =
                await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);

            return _mapper.Map<IReadOnlyList<T>>(flightScheduleSectorList);
        }

        public async Task<Pagination<FlightScheduleSectorVM>> GetFilteredListAsync(FlightScheduleSectorFilteredListQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var flightScheduleSectorList =
                await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);

            var countSpec = new FlightScheduleSectorSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<FlightScheduleSector>().CountAsync(countSpec);

            var dtoList =
                _mapper.Map<IReadOnlyList<FlightScheduleSectorVM>>(flightScheduleSectorList);

            foreach (var flightScheduleSector in dtoList)
            {
                flightScheduleSector.AcceptanceCutoffTime = string.IsNullOrEmpty(_configuration["Booking:AcceptanceCutoffTimeHrs"]) ?
                    flightScheduleSector.ScheduledDepartureDateTime : flightScheduleSector.ScheduledDepartureDateTime.AddHours(-int.Parse(_configuration["Booking:AcceptanceCutoffTimeHrs"]));

                flightScheduleSector.BookingCutoffTime = string.IsNullOrEmpty(_configuration["Booking:BookingCutoffTimeHrs"]) ?
                    flightScheduleSector.ScheduledDepartureDateTime : flightScheduleSector.ScheduledDepartureDateTime.AddHours(-int.Parse(_configuration["Booking:BookingCutoffTimeHrs"]));
            }

            //TODO: Add condition to this process
            foreach (var dto in dtoList)
            {
                var flightScheduleSectorCargoPositions = await GetAircraftAvailableSpace(dto.Id);
                dto.FlightScheduleSectorCargoPositions = flightScheduleSectorCargoPositions;
            }

            return new Pagination<FlightScheduleSectorVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleSectorCreateRM dto)
        {
            var response = new ServiceResponseCreateStatus();
            var flightsector = _mapper.Map<FlightScheduleSector>(dto);
            await _unitOfWork.Repository<FlightScheduleSector>().CreateAsync(flightsector);
            await _unitOfWork.SaveChangesAsync();
            response.Id = flightsector.Id;
            response.StatusCode = Enums.ServiceResponseStatus.Success;
            return response;
        }

        public async Task<FlightScheduleSectorVM> GetAsync(FlightScheduleSectorQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var flightSSector = await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);
            var flightSSVm = _mapper.Map<FlightScheduleSector, FlightScheduleSectorVM>(flightSSector);
            flightSSVm.FlightScheduleSectorCargoPositions = await GetAircraftAvailableSpace(query.Id);
            return flightSSVm;
        }

        private async Task<List<FlightScheduleSectorCargoPosition>> GetAircraftAvailableSpace(Guid flightScheduleSectorId)
        {
            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorQM
            {
                Id = flightScheduleSectorId,
                IncludeULDContaines = true,
                IncludeAircraft = true,
            });

            var flightScheduleSector =
                await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);
            // await _unitOfWork.Repository<FlightScheduleSector>().GetByIdAsync(flightScheduleSectorId);

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            {
                AircraftLayoutId = flightScheduleSector.Aircraft.AircraftLayoutId
            });

            var cargoPositions = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            var groupedCargoPositions = cargoPositions.GroupBy(item => item.CargoPositionType,
                    (key, group) => new { CargoPositionType = key, Items = group.ToList() })
                .ToList();

            var flightScheduleSectorCargoPositionsList = new List<FlightScheduleSectorCargoPosition>();

            foreach (var flightScheduleSectorCargoPosition in from groupedCargoPosition in groupedCargoPositions
                                                              let totalCount = groupedCargoPosition.Items.Count
                                                              let cargoPositionType = groupedCargoPosition.CargoPositionType
                                                              //let packedULDContainersCount = flightScheduleSector.LoadPlan.ULDContaines.Count(x =>
                                                              //    x.ULDContainerCargoPositions.Any(y => y.CargoPosition.CargoPositionType == groupedCargoPosition.CargoPositionType))
                                                              let packedULDContainersCount = flightScheduleSector.LoadPlan.ULDContaines.Select(x => new
                                                              {
                                                                  Count = x.ULDContainerCargoPositions.Count(y =>
                                                                       y.CargoPosition.CargoPositionType == groupedCargoPosition.CargoPositionType)
                                                              }).Sum(z=>z.Count)
                                                              select new FlightScheduleSectorCargoPosition
                                                              {
                                                                  CargoPositionType = groupedCargoPosition.CargoPositionType,
                                                                  AvailableSpaceCount = totalCount - packedULDContainersCount
                                                              })
            {
                flightScheduleSectorCargoPositionsList.Add(flightScheduleSectorCargoPosition);
            }

            return flightScheduleSectorCargoPositionsList;
        }

        public async Task<CargoPositionSummaryVM> GetCargoPositionSummaryAsync(FlightScheduleSectorSearchQuery query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var entity = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);
            var flightSector = entity.FirstOrDefault();
            if (flightSector == null)
                return new CargoPositionSummaryVM();

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = flightSector.Aircraft.AircraftLayoutId, IncludeSeat = true, IncludeOverhead = true });

            var cargoPositionList =
                await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            CargoPositionSummaryVM positionSummary = new CargoPositionSummaryVM();
            // Checking Main Deck available positions
            var matchingCargoPosition = cargoPositionList.ToList()
                .Where(x => x.ZoneArea.AircraftCabin.AircraftDeck.AircraftDeckType == AircraftDeckType.MainDeck);

            var cargoPositions = matchingCargoPosition.Where(x => x.CargoPositionType == CargoPositionType.OnSeat);
            positionSummary.TotalOccupiedOnSeats = cargoPositions.Count(y => y.Seat.IsOnSeatOccupied);
            positionSummary.TotalOnSeats = cargoPositions.Count();
            positionSummary.OnSeatsPercentage = positionSummary.TotalOccupiedOnSeats / positionSummary.TotalOnSeats;

            cargoPositions = matchingCargoPosition.Where(x => x.CargoPositionType == CargoPositionType.UnderSeat);
            positionSummary.TotalOccupiedUnderSeats = cargoPositions.Count(y => y.Seat.IsUnderSeatOccupied);
            positionSummary.TotalUnderSeats = cargoPositions.Count();
            positionSummary.UnderSeatsPercentage = positionSummary.TotalOccupiedUnderSeats / positionSummary.TotalUnderSeats;

            cargoPositions = matchingCargoPosition.Where(x => x.CargoPositionType == CargoPositionType.Overhead);
            positionSummary.TotalOccupiedOverheads = cargoPositions.Count(y => y.OverheadPosition.IsOccupied);
            positionSummary.TotalOverheads = cargoPositions.Count();
            positionSummary.OverheadPercentage = positionSummary.TotalOccupiedOverheads / positionSummary.TotalOverheads;

            positionSummary.TotalWeight = matchingCargoPosition.FirstOrDefault().ZoneArea.AircraftCabin.AircraftDeck.MaxWeight;
            positionSummary.TotalBookedWeight = matchingCargoPosition.FirstOrDefault().ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight;
            positionSummary.WeightPercentage = positionSummary.TotalBookedWeight / positionSummary.TotalWeight;

            return positionSummary;
        }

        public async Task TestMethod(FlightScheduleSectorFilteredListQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var flightScheduleSectorList =
                await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);

            if (flightScheduleSectorList.Count < 4)
            {
                query.OriginAirportOnly = true;

                var specWithOriginAirport = new FlightScheduleSectorSpecification(query);
                var flightScheduleSectorListWithOriginAirportList =
                    await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(specWithOriginAirport);

                query.OriginAirportOnly = false;
                query.DestinationAirportOnly = true;

                var specWithDestinationAirport = new FlightScheduleSectorSpecification(query);
                var flightScheduleSectorListWithDestinationAirportList =
                    await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(specWithDestinationAirport);

                var newList = new List<FlightScheduleSector>();

                foreach (var flightScheduleSectorListWithOriginAirport in flightScheduleSectorListWithOriginAirportList)
                {
                    var matchingSector = flightScheduleSectorListWithDestinationAirportList
                        .FirstOrDefault(x => x.OriginAirportId == flightScheduleSectorListWithOriginAirport.DestinationAirportId);

                    if (matchingSector != null)
                    {
                        newList.Add(flightScheduleSectorListWithOriginAirport);
                        newList.Add(matchingSector);
                    }
                }
            }
        }
    }
}