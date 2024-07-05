using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightService : BaseService, IFlightService
    {
        private readonly ISectorService _sectorService;

        public FlightService(IUnitOfWork unitOfWork, 
            IMapper mapper, ISectorService sectorService) :
            base(unitOfWork,mapper)
        {
            _sectorService = sectorService;
        }

        public async Task<T> GetAsync<T>(FlightQM query)
        {
            var spec = new FlightSpecification(query);
            var flight = await _unitOfWork.Repository<Flight>().GetEntityWithSpecAsync(spec);
            // flight = await MappedFlightSectorData(flight, false);
            return _mapper.Map<T>(flight);
        }

        public async Task<FlightVM> GetDetailAsync(FlightDetailQM query)
        {
            var spec = new FlightSpecification(query);
            var flight = await _unitOfWork.Repository<Flight>().GetEntityWithSpecAsync(spec);

            if (flight != null && flight.FlightSectors != null)
                flight.FlightSectors.OrderBy(r => r.Sequence);

            // flight = await MappedFlightSectorData(flight, false);
            return _mapper.Map<FlightVM>(flight);
        }

        public async Task<IReadOnlyList<T>> GetListAsync<T>(FlightListQM query)
        {
            var spec = new FlightSpecification(query);
            var flights = await _unitOfWork.Repository<Flight>().GetListWithSpecAsync(spec);
            return _mapper.Map<IReadOnlyList<T>>(flights);
        }

        public async Task<string> GetFlightNumber(Guid id)
        {
            var flight = await _unitOfWork.Repository<Flight>().GetByIdAsync(id);
            return flight.FlightNumber;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightCreateRM flightRM)
        {
            var res = new ServiceResponseCreateStatus();
            var entity = _mapper.Map<FlightCreateRM, Flight>(flightRM);

            if (entity.FlightSectors.Any())
            {
                entity = await MappingFlight(entity);
                // entity = await MappedFlightSectorData(entity);               
            }

            await _unitOfWork.Repository<Flight>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            res.Id = entity.Id;
            res.StatusCode = ServiceResponseStatus.Success;
            return res;
        }

        public async Task<ServiceResponseStatus> UpdateAsync(FlightCreateRM flightRM)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var createdShedule = await _unitOfWork.Repository<FlightSchedule>()
                        .GetEntityWithSpecAsync(new FlightScheduleSpecification(new FlightScheduleQM() { FlightId = flightRM.Id }));

                    if (createdShedule != null)
                    {
                        return ServiceResponseStatus.ValidationError;
                    }

                    var entity = _mapper.Map<FlightCreateRM, Flight>(flightRM);

                    if (entity.FlightSectors.Any())
                    {
                        var createdFlight = await _unitOfWork.Repository<Flight>()
                            .GetEntityWithSpecAsync(new FlightSpecification(new FlightQM() { Id = flightRM.Id, IncludeSectors = true }));
                       
                        // Delete created Sectors. 
                        foreach (var sector in createdFlight.FlightSectors)
                        {
                            _unitOfWork.Repository<FlightSector>().Delete(sector);
                            await _unitOfWork.SaveChangesAsync();
                            _unitOfWork.Repository<FlightSector>().Detach(sector);
                            
                        }
                        _unitOfWork.Repository<Flight>().Detach(createdFlight);

                        // Set first and last sector 
                        entity = await MappingFlight(entity);
                        var flightSectors = entity.FlightSectors;
                        entity.FlightSectors = null;
                        _unitOfWork.Repository<Flight>().Update(entity);
                        await _unitOfWork.SaveChangesAsync();

                        // create new flight sectors
                        foreach (var flightSector in flightSectors)
                        {
                            //flightSector.DepartureDateTime = await GetMappedTimeAsync(flightSector.DepartureDateTime, flightSector.SectorId);
                            //flightSector.ArrivalDateTime = await GetMappedTimeAsync(flightSector.ArrivalDateTime, flightSector.SectorId, false);
                            await _unitOfWork.Repository<FlightSector>().CreateAsync(flightSector);
                            await _unitOfWork.SaveChangesAsync();
                        }
                    }
                    await transaction.CommitAsync();
                    return ServiceResponseStatus.Success;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }
        }

        public async Task<ServiceResponseStatus> DeleteAsync(Guid Id)
        {
            var createdShedule = await _unitOfWork.Repository<FlightSchedule>()
                        .GetEntityWithSpecAsync(new FlightScheduleSpecification(new FlightScheduleQM() { FlightId = Id }));

            if (createdShedule != null)
            {
                return ServiceResponseStatus.ValidationError;
            }

            var entity = await _unitOfWork.Repository<Flight>().GetByIdAsync(Id, false);
            entity.IsDeleted = true;
            if (await _unitOfWork.SaveChangesAsync() > 0)
                return ServiceResponseStatus.Success;
            return ServiceResponseStatus.Failed;
        }
        
        public async Task<Pagination<FlightFilterVM>> GetFilteredListAsync(FlightFilterListQM query)
        {
            var spec = new FlightSpecification(query);
            var flightList = await _unitOfWork.Repository<Flight>().GetListWithSpecAsync(spec);

            var countSpec = new FlightSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<Flight>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<FlightFilterVM>>(flightList);

            return new Pagination<FlightFilterVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<bool> IsExistsAsync(FlightCreateRM dto)
        {
            return await _unitOfWork.Repository<Flight>()
                .AnyAsync(new FlightSpecification(
                new FlightCheckExistsQM { FlightNumber = dto.FlightNumber }));
        }

        public async Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync()
        {
            var list = await _unitOfWork.Repository<Flight>().GetListWithSpecAsync(new FlightSpecification());
            return _mapper.Map<IReadOnlyList<BaseSelectListModel>>(list);
        }


        public async Task<IReadOnlyList<FlightWithSectorsVM>> GetSelectListWithSectorsAsync()
        {
     
            var list = await _unitOfWork.Repository<Flight>().GetListWithSpecAsync(new FlightSpecification());

            List<FlightWithSectorsVM> flightList = new List<FlightWithSectorsVM>();

            foreach (var flight in list)
            {
                

                List<SectorsList> sectorList  = new List<SectorsList>();

                var sectorSpec = new SectorSpecification(flight.Id);

                var sectors = await _unitOfWork.Repository<Sector>().GetListWithSpecAsync(sectorSpec);

                foreach (var sector in sectors)
                {
                    sectorList.Add(new SectorsList
                    {
                        destinationId = sector.DestinationAirportId,
                        destinationName = sector.DestinationAirportName,
                        originId = sector.OriginAirportId,
                        originName = sector.OriginAirportName,
                        destinationCode = sector.DestinationAirportCode,
                        originCode = sector.OriginAirportCode,
                    });
                }

                flightList.Add(new FlightWithSectorsVM { destinationCode = flight.DestinationAirportCode,originCode=flight.OriginAirportCode,destinationId = flight.DestinationAirportId, destinationName = flight.DestinationAirportName, flightId = flight.Id, originId = flight.OriginAirportId, flightNumber = flight.FlightNumber, originName = flight.OriginAirportName, sectors = sectorList });


            }


            

            return flightList;
        }

        private async Task<Flight> MappingFlight(Flight entity)
        {
            var orderedSectorList = entity.FlightSectors.OrderBy(x => x.Sequence);
            var firstFlightSector = orderedSectorList.FirstOrDefault();
            var lastFlightSector = orderedSectorList.LastOrDefault();

            var firstSector = await _unitOfWork.Repository<Sector>().GetByIdAsync(firstFlightSector.SectorId);
            var lastSector = await _unitOfWork.Repository<Sector>().GetByIdAsync(lastFlightSector.SectorId);

            entity.OriginAirportId = firstSector.OriginAirportId;
            entity.OriginAirportCode = firstSector.OriginAirportCode;
            entity.OriginAirportName = firstSector.OriginAirportName;
            entity.DestinationAirportId = lastSector.DestinationAirportId;
            entity.DestinationAirportCode = lastSector.DestinationAirportCode;
            entity.DestinationAirportName = lastSector.DestinationAirportName;

            return entity;
        }

    }
}