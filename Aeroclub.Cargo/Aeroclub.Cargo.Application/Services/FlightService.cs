using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightService : BaseService, IFlightService
    {
        public FlightService(IUnitOfWork unitOfWork, IMapper mapper):
            base(unitOfWork,mapper)
        {
     
        }

        public async Task<T> GetAsync<T>(FlightQM query)
        {
            var spec = new FlightSpecification(query);
            var flight = await _unitOfWork.Repository<Flight>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<T>(flight);
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
            }

            await _unitOfWork.Repository<Flight>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            res.Id = entity.Id;
            res.StatusCode = Enums.ServiceResponseStatus.Success;


            return res;
        }
    }
}