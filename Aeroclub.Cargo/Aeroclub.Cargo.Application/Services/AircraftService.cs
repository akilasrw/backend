using Aeroclub.Cargo.Application.Interfaces;
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
    }
}