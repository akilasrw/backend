using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.ItemAuditQM;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageULDContainerQMs;
using Aeroclub.Cargo.Application.Models.Queries.ShipmentQM;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.GetShipmentsRM;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.ViewModels.BookingShipmentSummeryVM;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using SendGrid.Helpers.Errors.Model;


namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingService : BaseService, ICargoBookingService
    {
        private readonly ICargoAgentService _cargoAgentService;
        private readonly IBaseUnitConverter _baseUnitConverter;
        private readonly INotificationService _notificationService;

        public CargoBookingService(
            IUnitOfWork unitOfWork,
            IMapper mapper, ICargoAgentService cargoAgentService, IBaseUnitConverter baseUnitConverter, INotificationService notificationService) : base(unitOfWork, mapper)
        {
            _cargoAgentService = cargoAgentService;
            _baseUnitConverter = baseUnitConverter;
            _notificationService = notificationService;
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

            mappedEntity = GetCargoBookingSectorInfo(entity, mappedEntity);

            return mappedEntity;

        }
        
        public async Task<CargoBookingDetailVM> GetDetailAsync(CargoBookingQM query)
        {
            var spec = new CargoBookingSpecification(query);

            var entity = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);
            var mappedEntity = _mapper.Map<CargoBookingDetailVM>(entity);

            mappedEntity = GetCargoBookingSectorInfo(entity, mappedEntity);

            return mappedEntity;

        }

        public async Task<Pagination<CargoBookingVM>> GetFilteredListAsync(CargoBookingFilteredListQM query)
        {
            var spec = new CargoBookingSpecification(query);

            var bookingList = await _unitOfWork.Repository<CargoBooking>().GetListWithSpecAsync(spec);

            var countSpec = new CargoBookingSpecification(query, true);

            var totalCount = await _unitOfWork.Repository<CargoBooking>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<CargoBookingVM>>(bookingList);

            foreach(var d in dtoList)
            {
                var sSpec = new PackageAuditSpecification(new ItemAuditQM{bookingID = d.Id, status = PackageItemStatus.AcceptedForFLight });
                var sCount = await _unitOfWork.Repository<ItemStatus>().GetListWithSpecAsync(sSpec);
                var pSpec = new PackageAuditSpecification(new ItemAuditQM { bookingID = d.Id, status = PackageItemStatus.Booking_Made });
                var pCount = await _unitOfWork.Repository<ItemStatus>().GetListWithSpecAsync(pSpec);

                var shSpec = new ShipmentSpecification(new ShipmentQM { bookingID = d.Id });  
                var shList = await _unitOfWork.Repository<Shipment>().GetListWithSpecAsync(shSpec);
                if(shList.Count() > 0)
                {
                     d.FlightNumber = shList[0].FlightSchedule.FlightNumber;
                }



                var pkPpec = new PackageItemSpecification(new PackageItemByBookingQM { BookingID = d.Id });
                var packages = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(pkPpec);

                PackageItemStatus status = PackageItemStatus.Booking_Made;

                foreach (PackageItemStatus itemStatus in Enum.GetValues(typeof(PackageItemStatus)))
                {
                    if (packages.Any(x => x.PackageItemStatus == itemStatus))
                    {
                        status = itemStatus;
                        break;
                    }
                };

                d.BookingStatus = status;


                d.shipmentCount = sCount.Count();
                d.NumberOfBoxes = pCount.Count();
            }
         
            return new Pagination<CargoBookingVM>(query.PageIndex, query.PageSize, totalCount, dtoList);

        }

        public async Task<IReadOnlyList<CargoBookingListVM>> GetListAsync(FlightScheduleSectorBookingListQM query)
        {
            var spec = new CargoBookingFlightScheduleSectorSpecification(query);
            var bookingFlightScheduleSectorList = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().GetListWithSpecAsync(spec);

            List<CargoBookingListVM> list = new List<CargoBookingListVM>();

            foreach (var sectorBooking in bookingFlightScheduleSectorList)
            {
                var booking = sectorBooking.CargoBooking;
                StandByStatus standByStatus = booking.StandByStatus == null ? StandByStatus.None : (StandByStatus)booking.StandByStatus;
                if (standByStatus != StandByStatus.None || 
                    booking.BookingStatus == BookingStatus.Cancelled) // ignore when status is cancel or null or not none
                    continue;
                var mappedBooking = await MappedListAsync(booking);
                if (query.IncludePackageItems) {
                    mappedBooking.PackageItems = _mapper.Map<IReadOnlyList<PackageMobileVMs>>(booking.PackageItems);
                    foreach (var package in mappedBooking.PackageItems) {
                        var packageUldcontainer =  await _unitOfWork.Repository<PackageULDContainer>().GetEntityWithSpecAsync(new PackageULDContainerSpecification(new PackageULDContainerListQM() {
                            PackageItemId = package.Id,
                        }));

                        package.AssignedUldId = packageUldcontainer.ULDContainer.ULDId;
                    }
                }
                list.Add(mappedBooking);
            }
            list = list.DistinctBy(x => x.Id).ToList();
            
            return list;
        }

        public async Task<IReadOnlyList<BookingShipmentSummeryVM>> GetShipmentsByAWB(GetShipmentsRM rm, Guid userId, bool isAdmin = false)
        {
            

            Guid bookingID = Guid.Empty;

            var shipBookings = new List<BookingShipmentSummeryVM>();

            if(rm.AWBNumber != null)
            {
                if(rm.packageID != null)
                {
                    var spec = new PackageItemSpecification(
                        new PackageItemWithAWBQM
                        {
                            PackageRefNumber = rm.packageID,
                            AwbNumber = rm.AWBNumber
                        }

                    );

                    var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);
                    if (package == null)
                    {
                        return null;
                    }

                    bookingID = (Guid)package.CargoBookingId;
                }
                else
                {
                    var awbSpec = new AWBSpecification(new AWBTrackingQM
                    {
                        AwbTrackingNum = (long)rm.AWBNumber
                    });
                    var awb = await _unitOfWork.Repository<AWBInformation>().GetEntityWithSpecAsync(awbSpec);
                    if(awb == null)
                    {
                        return null;
                    }
                    bookingID = (Guid)awb.CargoBookingId;
                }
            }


            var shipmentSpec = new ShipmentSpecification(new Models.Queries.ShipmentQM.ShipmentQM { bookingID = bookingID, userId=isAdmin?Guid.Empty:userId });

            var shipments = await _unitOfWork.Repository<Shipment>().GetListWithSpecAsync(shipmentSpec);

            if(shipments.Count == 0)
            {

                var bSpec = new CargoBookingSpecification(new CargoBookingQM { Id = bookingID , userId = isAdmin? Guid.Empty : userId});

                var booking  = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(bSpec);
                if (booking == null)
                {
                    return null;
                }
                var pSpec = new PackageItemSpecification(new PackageItemByBookingQM
                {
                    BookingID = bookingID,
                });
                var packages = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(pSpec);

                var pRSpec = new PackageAuditSpecification(PackageItemStatus.Booking_Made, packages[0].Id);
                var pRRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(pRSpec);

                var pDSpec = new PackageAuditSpecification(PackageItemStatus.Cargo_Received, packages[0].Id);
                var pDRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(pDSpec);

                var shipBooking = new BookingShipmentSummeryVM
                {
                    awbNumber = (long)booking?.AWBInformation?.AwbTrackingNumber,
                    bookedDate = (DateTime)booking?.Created,
                    shipmentStatus = packages[0].PackageItemStatus,
                    packageCount = packages.Count,
                    enrouteToWahouse = pRRes?.Created,
                    inOriginWahouse = pDRes?.Created,
                };

                shipBookings.Add(shipBooking);
            }
            else
            {
                foreach (var shipment in shipments)
                {
                    var paSpec = new PackageAuditSpecification(PackageItemStatus.Arrived, shipment.packageID);
                    var paRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(paSpec);

                    var pdSpec = new PackageAuditSpecification(PackageItemStatus.FlightDispatched, shipment.packageID);
                    var pdRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(pdSpec);

                    var pAFSpec = new PackageAuditSpecification(PackageItemStatus.AcceptedForFLight, shipment.packageID);
                    var pAFRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(pAFSpec);

                    var pDSpec = new PackageAuditSpecification(PackageItemStatus.Deliverd, shipment.packageID);
                    var pDRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(pDSpec);

                    var pIDSpec = new PackageAuditSpecification(PackageItemStatus.IndestinationWarehouse, shipment.packageID);
                    var pIDRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(pIDSpec);

                    var pRSpec = new PackageAuditSpecification(PackageItemStatus.Booking_Made, shipment.packageID);
                    var pRRes = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(pRSpec);

                    var shipBooking = new BookingShipmentSummeryVM
                    {
                        awbNumber = shipment.CargoBooking.AWBInformation.AwbTrackingNumber,
                        bookedDate = shipment.CargoBooking.Created,
                        flightNumber = shipment.FlightSchedule.FlightNumber,
                        packageCount = shipment.packageCount,
                        from = shipment.FlightSchedule.OriginAirportName,
                        to = shipment.FlightSchedule.DestinationAirportName,
                        shipmentID = shipment.Id,
                        shipmentStatus = shipment.PackageItem.PackageItemStatus,
                        flightArr = paRes?.Created,
                        flightDate = shipment.FlightSchedule.ScheduledDepartureDateTime,
                        flightDep = pdRes?.Created,
                        inDestinationWahouse = pIDRes?.Created,
                        acceptedForFLight = pAFRes?.Created,
                        deliverdToAgent = pDRes?.Created,
                        enrouteToWahouse = pRRes?.Created,
                        inOriginWahouse = pDRes?.Created,
                    };

                    shipBookings.Add(shipBooking);
                }
            }

            return shipBookings;
        }

        public async Task<CargoBookingMobileVM> GetMobileBookingAsync(FlightScheduleSectorMobileQM query)
        {
            var spec = new CargoBookingFlightScheduleSectorSpecification(query);
            var bookingFlightScheduleSectorList = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().GetListWithSpecAsync(spec);

            List<CargoBookingMobileVM> list = new List<CargoBookingMobileVM>();

            foreach (var sectorBooking in bookingFlightScheduleSectorList)
            {
                var booking = sectorBooking.CargoBooking;
                var mappedBooking = await MappedListAsync(booking);
                var mobBooking = _mapper.Map<CargoBookingMobileVM>(mappedBooking);
                mobBooking.Origin = sectorBooking.FlightScheduleSector.OriginAirportCode;
                mobBooking.Destination = sectorBooking.FlightScheduleSector.DestinationAirportCode;
                mobBooking.FlightNumber = sectorBooking.FlightScheduleSector.FlightNumber;
                mobBooking.CutoffTimeMin = sectorBooking.FlightScheduleSector.FlightSchedule.CutoffTimeMin;
                mobBooking.ScheduledDepartureDateTime = sectorBooking.FlightScheduleSector.ScheduledDepartureDateTime;
                if (sectorBooking.FlightScheduleSector.AircraftSubType != null && sectorBooking.FlightScheduleSector.AircraftSubType.AircraftType != null)
                    mobBooking.AircraftSubTypeName = sectorBooking.FlightScheduleSector.AircraftSubType.AircraftType.Name;
                mobBooking.PackageItems = _mapper.Map<IReadOnlyList<PackageMobileVMs>>(booking.PackageItems);
                list.Add(mobBooking);
            }
            
            return list.Count > 0? list.DistinctBy(x => x.Id).ToList().FirstOrDefault(): new CargoBookingMobileVM();
        }

        public async Task<IReadOnlyList<CargoBookingStandByCargoVM>> GetStandByCargoListAsync(FlightScheduleSectorBookingListQM query)
        {
            var spec = new CargoBookingFlightScheduleSectorSpecification(query);
            var bookingFlightScheduleSectorList = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().GetListWithSpecAsync(spec);

            List<CargoBookingStandByCargoVM> list = new List<CargoBookingStandByCargoVM>();

            foreach (var sectorBooking in bookingFlightScheduleSectorList)
            {
                var booking = sectorBooking.CargoBooking;
                StandByStatus standByStatus = booking.StandByStatus == null ? StandByStatus.None : (StandByStatus)booking.StandByStatus;
                if (booking.StandByStatus == query.StandByStatus)
                {
                    var mappedBooking = await MappedListAsync(booking);
                    if (mappedBooking != null)
                    {
                        var standByCargo = _mapper.Map<CargoBookingStandByCargoVM>(mappedBooking);
                        standByCargo.Origin = sectorBooking.FlightScheduleSector.OriginAirportCode;
                        standByCargo.Destination = sectorBooking.FlightScheduleSector.DestinationAirportCode;
                        if (query.AgentId == null)
                            list.Add(standByCargo);
                        else
                        {
                            var agent = await _cargoAgentService.GetAsync(new Models.Queries.CargoAgentQMs.CargoAgentQM() { AppUserId = booking.CreatedBy });
                            if(agent.Id == query.AgentId) 
                                list.Add(standByCargo);
                        }
                    }                      
                }
                    
            }
            list = list.DistinctBy(x => x.Id).ToList();
            return list;
        }

        public async Task<IReadOnlyList<CargoBookingListVM>> GetVerifyBookingListAsync(FlightScheduleSectorVerifyBookingListQM query)
        {
            var spec = new CargoBookingFlightScheduleSectorSpecification(query);
            var bookingFlightScheduleSectorList = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().GetListWithSpecAsync(spec);

            List<CargoBookingListVM> list = new List<CargoBookingListVM>();

            foreach (var sectorBooking in bookingFlightScheduleSectorList)
            {
                if (sectorBooking.CargoBooking.BookingStatus == BookingStatus.Cargo_Received 
                    // && sectorBooking.CargoBooking.StandByStatus != StandByStatus.OffLoad
                    )
                    list.Add(await MappedListAsync(sectorBooking.CargoBooking));
            }
                
            
            list = list.DistinctBy(x => x.Id).ToList();
            return list;
        }

        async Task<CargoBookingListVM> MappedListAsync(CargoBooking booking)
        {
            var agent = await _cargoAgentService.GetAsync(new Models.Queries.CargoAgentQMs.CargoAgentQM() { AppUserId = booking.CreatedBy });
            CargoBookingListVM vm = new CargoBookingListVM();
            vm.Id = booking.Id;
            vm.BookingNumber = booking.BookingNumber;
            vm.AWBNumber = booking.AWBInformation == null ? "-" : booking.AWBInformation.AwbTrackingNumber.ToString();
            vm.BookingAgent = agent != null ? agent.AgentName : string.Empty;
            vm.BookingDate = booking.BookingDate;
            vm.BookingStatus = booking.BookingStatus;
            vm.VerifyStatus = booking.VerifyStatus;
            vm.CargoHandlingInstruction = booking.CargoHandlingInstruction;
            vm.NumberOfBoxes = booking.PackageItems == null ? 0 : booking.PackageItems.Count();
            vm.TotalWeight = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x => x.Weight);
            vm.TotalVolume = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x =>
            (_baseUnitConverter.VolumeCalculatorAsync(x.Height, (Guid)x.VolumeUnitId).Result *
             _baseUnitConverter.VolumeCalculatorAsync(x.Width, (Guid)x.VolumeUnitId).Result *
             _baseUnitConverter.VolumeCalculatorAsync(x.Length, (Guid)x.VolumeUnitId).Result
            ));

            if (booking.PackageItems != null)
            {
                var recBookings = booking.PackageItems.Where(c => c.PackageItemStatus == PackageItemStatus.Cargo_Received);

                vm.NumberOfRecBoxes = recBookings == null ? 0 : recBookings.Count();
                vm.TotalRecWeight = recBookings == null ? 0 : recBookings.Sum(x => x.Weight);
                vm.TotalRecVolume = recBookings == null ? 0 : recBookings.Sum(x =>
                (_baseUnitConverter.VolumeCalculatorAsync(x.Height, (Guid)x.VolumeUnitId).Result *
                 _baseUnitConverter.VolumeCalculatorAsync(x.Width, (Guid)x.VolumeUnitId).Result *
                 _baseUnitConverter.VolumeCalculatorAsync(x.Length, (Guid)x.VolumeUnitId).Result
                ));
            }
            return vm;
        }

        public async Task<IReadOnlyList<CargoBookingULDVM>> GetFreighterBookingListAsync(FlightScheduleSectorBookingListQM query)
        {
            var spec = new CargoBookingFlightScheduleSectorSpecification(query);
            var bookingFlightScheduleSectorList = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().GetListWithSpecAsync(spec);
            List<CargoBookingULDVM> bookingList = new List<CargoBookingULDVM>();
            foreach (var sectorBooking in bookingFlightScheduleSectorList)
            {
               var res = _mapper.Map<CargoBooking,CargoBookingULDVM>(sectorBooking.CargoBooking);
               if (res != null){
                    var loadPlanId = sectorBooking.FlightScheduleSector.LoadPlanId;

                    if(res.PackageItems!= null)
                    {
                        foreach(var package in res.PackageItems)
                        {
                            var uldSpec = new PackageULDContainerSpecification(new PackageULDContainerListQM() { PackageItemId = package.Id });
                            var packageUldContainerList = await _unitOfWork.Repository<PackageULDContainer>().GetListWithSpecAsync(uldSpec);
                            if(packageUldContainerList != null)
                            {
                                foreach(var packageULDContainer in packageUldContainerList)
                                {
                                    if(packageULDContainer.ULDContainer.LoadPlanId == loadPlanId)
                                    {
                                        package.ULDContainerId = packageULDContainer.ULDContainer.Id;
                                    }
                                }
                            }
                        }
                    }
                    bookingList.Add(res);
               }
            }
            return bookingList;
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

                await _unitOfWork.Repository<BookingAudit>().CreateAsync(new BookingAudit { bookingId = rm.Id, bookingStatus = rm.BookingStatus });
                await _unitOfWork.SaveChangesAsync();
                res.StatusCode = ServiceResponseStatus.Success;
                res.Id = rm.Id;
            }
            else
            {
                res.StatusCode = ServiceResponseStatus.Failed;
            }
            return res;
        }

        public async Task<ServiceResponseStatus> UpdateDeleteListAsync(IEnumerable<CargoBookingUpdateRM> list)
        {
            foreach (var cargo in list)
            {
                var booking = await _unitOfWork.Repository<CargoBooking>().GetByIdAsync(cargo.Id);
                if (booking != null)
                {
                    booking.BookingStatus = cargo.BookingStatus;
                    _unitOfWork.Repository<CargoBooking>().Update(booking);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<CargoBooking>().Detach(booking);

                }
            }
            return ServiceResponseStatus.Success;
        }

        public async Task<ServiceResponseStatus> UpdateStandByStatusAsync(CargoBookingStatusUpdateListRM rm)
        {
            foreach (CargoBookingStatusUpdateRM cargo in rm.CargoBookingStatusUpdateList)
            {
                var spec = new CargoBookingSpecification(new Models.Queries.CargoBookingQMs.CargoBookingQM { Id = cargo.Id, IsIncludeAWBDetail = true, IsIncludeFlightDetail = true });
                var booking = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);
                if (booking != null)
                {
                    if (rm.StandByStatus != null)
                        booking.StandByStatus = rm.StandByStatus;

                    if(cargo.VerifyStatus!= null && cargo.VerifyStatus != VerifyStatus.None)
                    {
                        booking.VerifyStatus = cargo.VerifyStatus;
                        if (cargo.StandByStatus == StandByStatus.OffLoad)
                        {
                            booking.VerifyStatus = VerifyStatus.OffLoad;
                        await UpdateAsync(new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                        {
                            Id = booking.Id,
                            BookingStatus = BookingStatus.Off_Loaded
                        });
                            NotificationRM notificationRM = new NotificationRM();
                            CargoBookingDetailVM cargoBookingDetail = GetCargoBookingSectorInfo(booking, new CargoBookingDetailVM());
                            notificationRM.Title = "Cargo offloaded for AWB : " + booking.AWBInformation.AwbTrackingNumber;
                            notificationRM.UserId = booking.CreatedBy;
                            notificationRM.Body = "Your cargo originally planned to go on "+ cargoBookingDetail.FlightNumber+" on "+cargoBookingDetail.ScheduledDepartureDateTime+" has to offloaded and will be re allocated to another flight sooner. Sorry for the inconvenience.";
                            notificationRM.NotificationType = Common.Enums.NotificationType.Off_Loaded;
                            await _notificationService.CreateAsync(notificationRM);
                        }
                    }                        
                    _unitOfWork.Repository<CargoBooking>().Update(booking);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<CargoBooking>().Detach(booking);
                }
            }
            return ServiceResponseStatus.Success;
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

        public async Task<IReadOnlyList<CargoBookingListVM>> GetOnlyAssignedListAsync(AssignedCargoQM query)
        {
            var spec = new CargoBookingFlightScheduleSectorSpecification(new FlightScheduleSectorBookingListQM()
            {
                FlightScheduleSectorId = query.FlightScheduleSectorId
            });
            var bookingFlightScheduleSectorList = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().GetListWithSpecAsync(spec);

            List<CargoBookingListVM> list = new List<CargoBookingListVM>();

            foreach (var sectorBooking in bookingFlightScheduleSectorList)
            {
                var booking = sectorBooking.CargoBooking;
                StandByStatus standByStatus = booking.StandByStatus == null ? StandByStatus.None : (StandByStatus)booking.StandByStatus;
                if (standByStatus != StandByStatus.None ||
                    booking.BookingStatus == BookingStatus.Cancelled) // ignore when status is cancel or null or not none
                    continue;
                if (booking.PackageItems.Count == 0)
                {
                    continue;
                }
                List<PackageItem> filteredPackages = new List<PackageItem>();
                foreach (var package in booking.PackageItems)
                {
                    var packageUldcontainer = await _unitOfWork.Repository<PackageULDContainer>().GetEntityWithSpecAsync(new PackageULDContainerSpecification(new PackageULDContainerListQM()
                    {
                        PackageItemId = package.Id,
                    }));
                    if (packageUldcontainer.ULDContainer.ULDId == query.UldId)
                    {
                        filteredPackages.Add(package);
                    }
                }

                booking.PackageItems = filteredPackages;

                var mappedBooking = await MappedListAsync(booking);
                mappedBooking.PackageItems = _mapper.Map<IReadOnlyList<PackageMobileVMs>>(filteredPackages);
                if (mappedBooking.PackageItems.Count > 0)
                {
                    list.Add(mappedBooking); 
                }
            }
            list = list.DistinctBy(x => x.Id).ToList();
            return list;
        }
    }
}