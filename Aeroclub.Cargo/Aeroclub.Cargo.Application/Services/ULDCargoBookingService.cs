﻿using Aeroclub.Cargo.Application.Enums;
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

            return mappedEntity;
        }
    }
}