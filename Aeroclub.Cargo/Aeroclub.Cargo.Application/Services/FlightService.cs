using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightService : BaseService, IFlightService
    {
        public IFlightScheduleService _flightScheduleService { get; }

        public FlightService(IUnitOfWork unitOfWork, IMapper mapper, IFlightScheduleService flightScheduleService):
            base(unitOfWork,mapper)
        {
            _flightScheduleService = flightScheduleService;
        }

        public async Task<T> GetAsync<T>(FlightQM query)
        {
            var spec = new FlightSpecification(query);
            var flight = await _unitOfWork.Repository<Flight>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<T>(flight);
        }

        public async Task<FlightVM> GetDetailAsync(FlightDetailQM query)
        {
            var spec = new FlightSpecification(query);
            var flight = await _unitOfWork.Repository<Flight>().GetEntityWithSpecAsync(spec);

            if (flight != null && flight.FlightSectors != null)
                flight.FlightSectors.OrderBy(r => r.Sequence);
            
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
            }

            await _unitOfWork.Repository<Flight>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            res.Id = entity.Id;
            res.StatusCode = Enums.ServiceResponseStatus.Success;


            return res;
        }
        
        public async Task<ServiceResponseStatus> UpdateAsync(FlightCreateRM flightRM)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
            }
                var createdShedule = await _flightScheduleService.GetAsync(new Models.Queries.FlightScheduleQMs.FlightScheduleQM() { FlightId = flightRM.Id });

            if (createdShedule != null)
            {
                return ServiceResponseStatus.ValidationError;
            }

            var entity = _mapper.Map<FlightCreateRM, Flight>(flightRM);

            if (entity.FlightSectors.Any())
            {                    
                var createdFlight = await _unitOfWork.Repository<Flight>()
                    .GetEntityWithSpecAsync(new  FlightSpecification(new FlightQM() { Id = flightRM.Id}));

                createdFlight.FlightSectors.Clear();
                
                // Set first and last sector 
                if (createdFlight.FlightNumber != flightRM.FlightNumber)
                {
                    createdFlight = await MappingFlight(createdFlight);
                    _unitOfWork.Repository<Flight>().Update(createdFlight);
                    await _unitOfWork.SaveChangesAsync();
                }

                //// Delete created Sectors. 
                //foreach (var sector in createdFlight.FlightSectors)
                //{
                //    _unitOfWork.Repository<FlightSector>().Delete(sector);
                //    await _unitOfWork.SaveChangesAsync();
                //}

                // create new flight sectors
                foreach (var flightSector in entity.FlightSectors)
                {
                    await _unitOfWork.Repository<FlightSector>().CreateAsync(flightSector);
                    await _unitOfWork.SaveChangesAsync();
                }
            }

            return ServiceResponseStatus.Success;
        }

        async Task<Flight> MappingFlight(Flight entity)
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
            var list = await _unitOfWork.Repository<Flight>().GetListAsync();
            return _mapper.Map<IReadOnlyList<BaseSelectListModel>>(list);
        }

    }
}