using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;


namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingService : BaseService, ICargoBookingService
    {

        public CargoBookingService(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(CargoBookingRM rm)
        {
            var res = new ServiceResponseCreateStatus();
            var spec = new CargoBookingSpecification(new CargoBookingCountQM() { Year = DateTime.Now.Year, Month = DateTime.Now.Month });
            var bookingCount = await _unitOfWork.Repository<CargoBooking>().CountAsync(spec);
            ReferenceNumberSingletonService b1 = ReferenceNumberSingletonService.GetInstance(bookingCount, CargoReferenceNumberType.Booking);            

            var cargoBooking = _mapper.Map<CargoBooking>(rm);
            cargoBooking.BookingNumber = b1.GetNextRefNumber();
            await _unitOfWork.Repository<CargoBooking>().CreateAsync(cargoBooking);
            await _unitOfWork.SaveChangesAsync();

            res.StatusCode= ServiceResponseStatus.Success;
            res.Id = cargoBooking.Id;
            return res;
        }

        public async Task<CargoBookingDetailVM> GetAsync(CargoBookingDetailQM query)
        {
            var spec = new CargoBookingSpecification(query);

            var entity = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);

            var mappedEntity = _mapper.Map<CargoBookingDetailVM>(entity);

            return mappedEntity;
        }

        public async Task<Pagination<CargoBookingVM>> GetFilteredListAsync(CargoBookingFilteredListQM query)
        {
            var spec = new CargoBookingSpecification(query);

            var bookingList = await _unitOfWork.Repository<CargoBooking>().GetListWithSpecAsync(spec);

            var countSpec = new CargoBookingSpecification(query, true);

            var totalCount = await _unitOfWork.Repository<CargoBooking>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<CargoBookingVM>>(bookingList);

         
            return new Pagination<CargoBookingVM>(query.PageIndex, query.PageSize, totalCount, dtoList);

        }
    }
}