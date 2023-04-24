using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using static Grpc.Core.Metadata;


namespace Aeroclub.Cargo.Application.Services
{
    public class ULDCargoBookingService : BaseService, IULDCargoBookingService
    {
        public ULDCargoBookingService(IUnitOfWork unitOfWork,
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
            var response = await _unitOfWork.Repository<CargoBooking>().CreateAsync(cargoBooking);
            await _unitOfWork.SaveChangesAsync();
            if (response != null)
            {
                res.StatusCode = ServiceResponseStatus.Success;
                res.Id = cargoBooking.Id;
            }
            else
            {
                res.StatusCode = ServiceResponseStatus.Failed;
            }           
            return res;
        }

        public async Task<CargoBookingDetailVM> GetAsync(CargoBookingDetailQM query)
        {
            var spec = new CargoBookingSpecification(query);

            var entity = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);

            var mappedEntity = _mapper.Map<CargoBookingDetailVM>(entity);

            mappedEntity = GetCargoBookingSectorInfo(entity, mappedEntity);

            return mappedEntity;
        }

        public async Task<ServiceResponseCreateStatus> UpdateStatusAsync(CargoBookingUpdateRM rm)
        {
            var res = new ServiceResponseCreateStatus();

            var booking = await _unitOfWork.Repository<CargoBooking>().GetByIdAsync(rm.Id);
            if (booking != null)
            {
                booking.BookingStatus = rm.BookingStatus;
                _unitOfWork.Repository<CargoBooking>().Update(booking);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<CargoBooking>().Detach(booking);
                res.StatusCode = ServiceResponseStatus.Success;
                res.Id = rm.Id;
            }
            else
            {
                res.StatusCode = ServiceResponseStatus.Failed;
            }
            return res;
        }

      

        private CargoBookingDetailVM GetCargoBookingSectorInfo(CargoBooking cargoBooking, CargoBookingDetailVM bookingDetail)
        {
            var orderedCrgoBookingFlightScheduleSectors = cargoBooking.CargoBookingFlightScheduleSectors.OrderBy(x => x.FlightScheduleSector.SequenceNo).ToList();
            var lastCrgoBookingFlightScheduleSector = orderedCrgoBookingFlightScheduleSectors.Last();
            bookingDetail.DestinationAirportCode = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.DestinationAirportCode;
            bookingDetail.DestinationAirportId = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.DestinationAirportId;
            bookingDetail.DestinationAirportName = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.DestinationAirportName;
            bookingDetail.ScheduledDepartureDateTime = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.FlightSchedule.ScheduledDepartureDateTime;
            bookingDetail.FlightNumber = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.FlightNumber;

            var firstCrgoBookingFlightScheduleSector = orderedCrgoBookingFlightScheduleSectors.First();
            bookingDetail.OriginAirportCode = firstCrgoBookingFlightScheduleSector.FlightScheduleSector.OriginAirportCode;
            return bookingDetail;
        }
    }
}
