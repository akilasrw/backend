using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingFlightScheduleSectorRMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingFlightScheduleSectorService :BaseService, ICargoBookingFlightScheduleSectorService
    {
        public CargoBookingFlightScheduleSectorService(IUnitOfWork unitOfWork,
            IMapper mapper):base(unitOfWork, mapper) {
        }
       
        public async Task<ServiceResponseCreateStatus> BookingFlightScheduleSectorCreate(CargoBookingFlightScheduleSectorRM rm)
        {
            var res = new ServiceResponseCreateStatus();
            var entity = _mapper.Map<CargoBookingFlightScheduleSector>(rm);
            var response = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            if (response != null)
            {
                res.StatusCode = ServiceResponseStatus.Success;
                res.Id = response.Id;
            }
            else
            {
                res.StatusCode = ServiceResponseStatus.Failed;
            }
            return res;

        }
    }
}
