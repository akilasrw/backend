using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingLookupService : BaseService,ICargoBookingLookupService
    {
        public CargoBookingLookupService(IUnitOfWork unitOfWork,IMapper mapper):
            base(unitOfWork,mapper)
        {
                
        }
        public async Task<CargoBookingLookupVM> GetAsync(CargoBookingLookupQM query)
        {
            var spec = new CargoBookingLookupSpecification(query);

            var entity = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);

            var mappedEntity = _mapper.Map<CargoBookingLookupVM>(entity);

            return mappedEntity;

        }
    }
}
