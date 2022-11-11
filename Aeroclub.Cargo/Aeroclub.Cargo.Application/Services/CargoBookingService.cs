using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
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
        private readonly ICargoAgentService _cargoAgentService;
        private readonly IBaseUnitConverter _baseUnitConverter;

        public CargoBookingService(
            IUnitOfWork unitOfWork,
            IMapper mapper, ICargoAgentService cargoAgentService, IBaseUnitConverter baseUnitConverter) : base(unitOfWork, mapper)
        {
            _cargoAgentService = cargoAgentService;
            _baseUnitConverter = baseUnitConverter;
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
        public async Task<IReadOnlyList<CargoBookingListVM>> GetListAsync(FlightScheduleSectorBookingListQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var fSectorList = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);
            List<CargoBookingListVM> list = new List<CargoBookingListVM>();
            foreach (var f in fSectorList)
            {
                foreach (var booking in f.CargoBookings)
                {
                    var agent = await _cargoAgentService.GetAsync(new Models.Queries.CargoAgentQMs.CargoAgentQM() { AppUserId = booking.CreatedBy });
                    CargoBookingListVM vm = new CargoBookingListVM();
                    vm.BookingNumber = booking.BookingNumber;
                    vm.AWBNumber = booking.AWBInformation == null ? "-" : booking.AWBInformation.AwbTrackingNumber.ToString();
                    vm.BookingAgent = agent != null ? agent.AgentName : string.Empty;
                    vm.BookingDate = booking.BookingDate;
                    vm.BookingStatus = booking.BookingStatus;
                    vm.NumberOfBoxes = booking.PackageItems==null? 0: booking.PackageItems.Count();
                    vm.TotalWeight = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x => x.Weight);
                    vm.TotalVolume = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x => 
                    ( _baseUnitConverter.VolumeCalculatorAsync(x.Height,x.VolumeUnitId).Result *
                     _baseUnitConverter.VolumeCalculatorAsync(x.Width, x.VolumeUnitId).Result *
                     _baseUnitConverter.VolumeCalculatorAsync(x.Length, x.VolumeUnitId).Result
                    ));
                    list.Add(vm);
                }               
            }
            return list;
        }

        public async Task<IReadOnlyList<CargoBookingULDVM>> GetFreighterBookingListAsync(FlightScheduleSectorBookingListQM query)
        {
            var spec = new FlightScheduleSectorSpecification(query);
            var fSectorList = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);
            var bookings = fSectorList.Select(x => x.CargoBookings);
            List<CargoBookingULDVM> list = new List<CargoBookingULDVM>();
            foreach (var f in fSectorList)
            {
                var res = _mapper.Map<ICollection<CargoBooking>, IReadOnlyList<CargoBookingULDVM>>(f.CargoBookings);
                if(res != null)
                {
                    list.AddRange(res);
                }                     
            }
            return list;
        }

        public async Task<ServiceResponseStatus> UpdateAWBStatus(Guid bookingId)
        {
            try
            {
                var entity = await _unitOfWork.Repository<CargoBooking>().GetByIdAsync(bookingId);
                entity.AWBStatus = AWBStatus.AddedAWB;

                _unitOfWork.Repository<CargoBooking>().Update(entity);
                await _unitOfWork.SaveChangesAsync();

                _unitOfWork.Repository<CargoBooking>().Detach(entity);
                return ServiceResponseStatus.Success;

            }catch (Exception ex)
            {
                return ServiceResponseStatus.Failed;
            }

        }

        public async Task<ServiceResponseCreateStatus> UpdateAsync(CargoBookingUpdateRM rm)
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

    }
}