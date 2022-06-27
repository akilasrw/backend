using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AircraftService :BaseService, IAircraftService
    {
       
        public AircraftService(IUnitOfWork unitOfWork, IMapper mapper):
            base(unitOfWork,mapper)
        {
           
        }
        
        public async Task<string> GetAircraftRegNo(Guid id)
        {
            var flight = await _unitOfWork.Repository<Aircraft>().GetByIdAsync(id);
            return flight.RegNo;
        }

        public async Task<IReadOnlyList<AircraftTypeVM>> GetAircraftTypesAsync(AircraftTypeQM query)
        {
            var spec = new AircraftTypeSpecification(query);
            var aircraftTypes = await _unitOfWork.Repository<AircraftType>().GetListWithSpecAsync(spec);

            return _mapper.Map<IReadOnlyList<AircraftTypeVM>>(aircraftTypes);
        }

    }
}