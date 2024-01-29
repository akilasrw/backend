using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageItemQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageQMs;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingFlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppThirdStepRM;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBStackVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Aeroclub.Cargo.Application.Models.ViewModels.ScanAppBookingCreateVM;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Aeroclub.Cargo.Application.Models.RequestModels.ScanAppSixthStepRM;
using System.Security.Cryptography;

namespace Aeroclub.Cargo.Application.Services
{
    public class PackageItemService : BaseService, IPackageItemService
    {
        private readonly ICargoBookingService _cargoBookingService;
        private readonly INotificationService _notificationService;

        public PackageItemService(IUnitOfWork unitOfWork, IMapper mapper, ICargoBookingService cargoBookingService, INotificationService notificationService) 
            : base(unitOfWork, mapper)
        {
            _cargoBookingService = cargoBookingService;
            _notificationService = notificationService;
        }

        public async Task<PackageItemCreateResponseM> CreateAsync(PackageItemCreateRM packageItem)
        {
            var spec = new PackageItemSpecification(new PackageItemCountQM() { Year = DateTime.Now.Year, Month = DateTime.Now.Month });
            var packageCount = await _unitOfWork.Repository<PackageItem>().CountAsync(spec);

            ReferenceNumberSingletonService b1 = ReferenceNumberSingletonService.GetInstance(packageCount, CargoReferenceNumberType.Package);
            var package = _mapper.Map<PackageItem>(packageItem);
            package.PackageRefNumber = b1.GetNextRefNumber();

            var createdPackage =await _unitOfWork.Repository<PackageItem>().CreateAsync(package);
            await _unitOfWork.SaveChangesAsync();

            var response = new PackageItemCreateResponseM();
            if (createdPackage != null)
            {
                response.StatusCode = ServiceResponseStatus.Success;
                response.Id = createdPackage.Id;
            }
            else
            {
                response.StatusCode = ServiceResponseStatus.Failed;
            }

            return response;
        }

        public async Task<PackageItemMobileVM> GetAsync(PackageItemRefQM query)
        {
            var spec = new PackageItemSpecification(query);
            var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<PackageItem, PackageItemMobileVM>(package);

        }

        public async Task<PackageItemVM> GetAsync(PackageItemQM query)
        {
            var package = await _unitOfWork.Repository<PackageItem>().GetByIdAsync(query.Id);
            return _mapper.Map<PackageItem, PackageItemVM>(package);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(PackageItemUpdateRM rm)
        {
            var package = _mapper.Map<PackageItemUpdateRM, PackageItem>(rm);
            _unitOfWork.Repository<PackageItem>().Update(package);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<PackageItem>().Detach(package);

            return ServiceResponseStatus.Success;
        }
        
        public async Task<ServiceResponseStatus> UpdateStatusAsync(PackageItemUpdateStatusRM rm)
        {
            var package = await _unitOfWork.Repository<PackageItem>().GetByIdAsync(rm.Id);
            if (package != null)
            {
                package.PackageItemStatus = rm.PackageItemStatus;
                _unitOfWork.Repository<PackageItem>().Update(package);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<PackageItem>().Detach(package);

                await UpdateBookingStatusAsync(package.CargoBookingId);// update cargo booking status when all package items are received.
                return ServiceResponseStatus.Success;
            }
            else
            {
                return ServiceResponseStatus.Failed;
            }
        }
    
        public async Task<Pagination<PackageListItemVM>> GetFilteredListAsync(PackageListQM query)
        {
            var spec = new PackageItemSpecification(query);

            var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(spec);

            var countSpec = new PackageItemSpecification(query, true);

            var totalCount = await _unitOfWork.Repository<PackageItem>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<PackageListItemVM>>(packageList);

            return new Pagination<PackageListItemVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<ServiceResponseCreateStatus> PackageULDContainerCreate(PackageULDContainerRM rm)
        {
            var res = new ServiceResponseCreateStatus();
            var entity = _mapper.Map<PackageULDContainer>(rm);
            var response = await _unitOfWork.Repository<PackageULDContainer>().CreateAsync(entity);
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

        async Task UpdateBookingStatusAsync(Guid BookingId)
        {
            var spec = new CargoBookingSpecification(new Models.Queries.CargoBookingQMs.CargoBookingQM { Id = BookingId, IsIncludePackageDetail = true, IsIncludeAWBDetail = true, IsIncludeFlightDetail = true });
            var bookings = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);
            var acceptedCount = bookings.PackageItems.Count(x => x.PackageItemStatus == PackageItemStatus.Booking_Made);
            if (acceptedCount > 0 && acceptedCount == bookings.PackageItems.Count)
            {
                await _cargoBookingService.UpdateAsync(
                    new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM 
                    { 
                        Id = BookingId,
                        BookingStatus = BookingStatus.Cargo_Received
                    });
                
            }
            await CreateNotification(bookings);
        }
        async Task CreateNotification(CargoBooking cargoBooking)
        {
            var orderedCrgoBookingFlightScheduleSectors = cargoBooking.CargoBookingFlightScheduleSectors.OrderBy(x => x.FlightScheduleSector.SequenceNo).ToList();
            var lastCrgoBookingFlightScheduleSector = orderedCrgoBookingFlightScheduleSectors.Last();
            var destinationAirportCode = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.DestinationAirportCode;
            var scheduledDepartureDateTime = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.FlightSchedule.ScheduledDepartureDateTime.ToString("g");
            var flightNumber = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.FlightNumber;

            var firstCrgoBookingFlightScheduleSector = orderedCrgoBookingFlightScheduleSectors.First();
            var originAirportCode = firstCrgoBookingFlightScheduleSector.FlightScheduleSector.OriginAirportCode;
            double totalWeight = 0;
            foreach (var package in cargoBooking.PackageItems)
            {
                totalWeight += package.Weight;
            }
            NotificationRM notificationRM = new NotificationRM();
            notificationRM.NotificationType = Common.Enums.NotificationType.Cargo_Received;
            notificationRM.UserId = cargoBooking.CreatedBy;
            notificationRM.Title = "Cargo received for AWB : "+ cargoBooking.AWBInformation.AwbTrackingNumber;
            notificationRM.Body = "Flight details; " + flightNumber + " - " + originAirportCode + " - " + destinationAirportCode + ",Flight Date time; " + scheduledDepartureDateTime + ",Cargo weight ; " + totalWeight + " kg" + ",Number of packages ; " + cargoBooking.PackageItems.Count + ",Your cargo has arrived to our warehouse and we will forward your cargo to the destination."; 
            await _notificationService.CreateAsync(notificationRM);
        }

        async public Task<ServiceResponseStatus> UpdatePackageStatusAsync(PackageItemStatusUpdateRM rm)
        {
            foreach (var x in rm.itemList)
            {
                var spec = new PackageItemSpecification(
                    new PackageItemRefQM
                    {
                        PackageRefNumber = x.packageItemId.ToString()
                    }

                    );

                var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);
                if (package != null)
                {
                    package.PackageItemStatus = x.status;
                    _unitOfWork.Repository<PackageItem>().Update(package);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<PackageItem>().Detach(package);
                }
                else
                {
                    return ServiceResponseStatus.Failed;
                }
            }

            if (rm.AWBNumber != null)
            {
                var awbSpec = new AWBSpecification(new AWBTrackingQM
                {
                    AwbTrackingNum = (long)rm.AWBNumber
                });

                var awb = await _unitOfWork.Repository<AWBInformation>().GetEntityWithSpecAsync(awbSpec);

                await _cargoBookingService.UpdateAsync(
                       new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                       {
                           Id = (Guid)awb.CargoBookingId,
                           BookingStatus = (BookingStatus)rm.status
                       });
            }

            return ServiceResponseStatus.Success;
           
           
        }

        async public Task<ServiceResponseStatus> CreateTruckBookingAWBAndPackages(ScanAppBookingCreateVM rm)
        {
            try
            {
                var bRes  = await _unitOfWork.Repository<CargoBooking>().CreateAsync(new CargoBooking
                {
                    AWBStatus = AWBStatus.AddedAWB,
                    BookingDate = DateTime.Now,
                    BookingNumber = rm.AWBTrackingNumber.ToString(),
                    BookingStatus = BookingStatus.Booking_Made,
                    DestinationAirportId = rm.Destination,
                    OriginAirportId = rm.Origin,
                    CreatedBy = rm.CargoAgentAppUserId,
                    Created = DateTime.Now
                });

                var awbSpec = new AWBNumberStackSpecification(rm.AWBTrackingNumber);

                var existingAwb = await _unitOfWork.Repository<AWBNumberStack>().GetEntityWithSpecAsync(awbSpec);

                if(existingAwb == null)
                {
                    await _unitOfWork.Repository<AWBNumberStack>().CreateAsync(new AWBNumberStack
                    {
                        AWBTrackingNumber = rm.AWBTrackingNumber,
                        CargoAgentId = rm.CargoAgent,
                    });
                }

                var res = await _unitOfWork.Repository<AWBInformation>().CreateAsync(new AWBInformation
                {
                    AwbTrackingNumber = rm.AWBTrackingNumber,
                    CargoBookingId = bRes.Id,
                    RequestedFlightDate = DateTime.Now,
                });

                var tRes = await _unitOfWork.Repository<TruckInfo>().CreateAsync(new TruckInfo
                {
                    BookingID = bRes.Id,
                    TruckID = rm.TruckNo
                });

                foreach(var i in rm.Packages)
                {
                    await _unitOfWork.Repository<PackageItem>().CreateAsync(new PackageItem
                    {
                        CargoBookingId= bRes.Id,
                        PackageRefNumber = i,
                        Description = "",
                        PackageItemCategory = PackageItemCategory.None,
                        PackagePriorityType = PackagePriorityType.None,
                    });
                }

                await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
            
            return ServiceResponseStatus.Success;
        }

        async public Task<ServiceResponseStatus> UpdatePackageAndBookingStatusFromULD(PackageUpdateByULD rm)
        {
            foreach(var i in rm.ulds)
            {
                var specs = new PackageULDContainerSpecification(new Application.Models.Queries.PackageULDContainerQMs.PackageByULDQM
                {
                    uldContainer = i
                });

                var item = await _unitOfWork.Repository<PackageULDContainer>().GetListWithSpecAsync(specs);

                foreach(var x in item)
                {
                    var package = x.PackageItem;
                    if (rm.IsArrived)
                    {
                        package.PackageItemStatus = PackageItemStatus.Arrived;
                    }
                    else
                    {
                        package.PackageItemStatus = PackageItemStatus.Dispatched;
                    }
                    
                    _unitOfWork.Repository<PackageItem>().Update(package);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<PackageItem>().Detach(package);



                    var pSpecs = new PackageItemSpecification(new PackageItemByBookingQM { BookingID = package.CargoBookingId });

                    var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(pSpecs);
                    
                    if(packageList.Any(x=> x.PackageItemStatus != PackageItemStatus.Dispatched))
                    {
                        if (rm.IsArrived)
                        {
                            await _cargoBookingService.UpdateAsync(
                     new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                     {
                         Id = package.CargoBookingId,
                         BookingStatus = BookingStatus.Partialy_Arrived
                     });
                        }
                        else
                        {
                            await _cargoBookingService.UpdateAsync(
                     new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                     {
                         Id = package.CargoBookingId,
                         BookingStatus = BookingStatus.Partialy_Dispatched
                     });
                        }
                      
                    }
                    else
                    {
                        if(rm.IsArrived)
                        {
                            await _cargoBookingService.UpdateAsync(
                      new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                      {
                          Id = package.CargoBookingId,
                          BookingStatus = BookingStatus.Flight_Arrived
                      });
                        }
                        else
                        {
                            await _cargoBookingService.UpdateAsync(
                      new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                      {
                          Id = package.CargoBookingId,
                          BookingStatus = BookingStatus.Flight_Dispatched
                      });
                        }
                        
                    }
                }
            }

            return ServiceResponseStatus.Success;
        }


        async public Task<ServiceResponseStatus> UpdateULDandPackageStatus(ScanAppSixthStepRM rm)
        { 

            var uldSpecs = new ULDSpecification(rm.uld);

            var existingUld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(uldSpecs);

            if(existingUld == null) {

                return ServiceResponseStatus.Failed;
            
            }

            existingUld.ULDLocateStatus = ULDLocateStatus.OnGround;

            _unitOfWork.Repository<ULD>().Update(existingUld);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<ULD>().Detach(existingUld);

            foreach (var x in rm.packageIDs)
            {
                var spec = new PackageItemSpecification(
                  new PackageItemRefQM
                  {
                      PackageRefNumber = x
                  }

                  );



                var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);

                package.PackageItemStatus = PackageItemStatus.IndestinationWarehouse;

                _unitOfWork.Repository<PackageItem>().Update(package);


                await _unitOfWork.SaveChangesAsync();

                _unitOfWork.Repository<PackageItem>().Detach(package);


                    await _cargoBookingService.UpdateAsync(
             new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
             {
                 Id = package.CargoBookingId,
                 BookingStatus = BookingStatus.IndestinationWarehouse
             });


               

            }




            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            return ServiceResponseStatus.Success;

        }

        async public Task<ServiceResponseStatus> CreateFlightScheduleULDandUpdateStatus(ScanAppThirdStepRM rm)
        {

            var flight = await _unitOfWork.Repository<Flight>().GetByIdAsync(rm.FlightID);

            var specs = new FlightScheduleSpecification(new FlightScheduleStandbyQM { FlightDate = rm.ScheduledDepartureDateTime, FlightNumber = flight.FlightNumber });

            var existingSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(specs);

            Guid fId = Guid.NewGuid();

            
            if (existingSchedule != null)
            {
                // Use the existing schedule
               var flightSchedule = existingSchedule;
                fId = flightSchedule.Id;
            }
            else
            {
                // Create a new schedule if no existing schedule is found
               var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().CreateAsync(new FlightSchedule
                {
                    ScheduledDepartureDateTime = rm.ScheduledDepartureDateTime,
                    FlightId = rm.FlightID,
                    OriginAirportCode = flight.OriginAirportCode,
                    DestinationAirportCode = flight.DestinationAirportCode,
                    DestinationAirportName = flight.DestinationAirportName,
                    OriginAirportName = flight.OriginAirportName,
                    DestinationAirportId = flight.DestinationAirportId,
                    OriginAirportId = flight.OriginAirportId,
                    FlightNumber = flight.FlightNumber
                });

                fId = flightSchedule.Id;
            }


            var flightSchduleSector = await _unitOfWork.Repository<FlightScheduleSector>().CreateAsync(new FlightScheduleSector
            {
                FlightId = rm.FlightID,
                OriginAirportCode = flight.OriginAirportCode,
                DestinationAirportCode = flight.DestinationAirportCode,
                DestinationAirportName = flight.DestinationAirportName,
                OriginAirportName = flight.OriginAirportName,
                DestinationAirportId = flight.DestinationAirportId,
                OriginAirportId = flight.OriginAirportId,
                FlightScheduleId = fId,
                FlightNumber = flight.FlightNumber
            });

            Guid uldId = Guid.NewGuid();

            var uldSpecs = new ULDSpecification(rm.ULDSerialNumber);

            var existingUld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(uldSpecs);

            if(existingUld != null)
            {
                uldId = existingUld.Id;
                existingUld.ULDLocateStatus = ULDLocateStatus.OnBoard;

                _unitOfWork.Repository<ULD>().Update(existingUld);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<ULD>().Detach(existingUld);
            }
            else
            {
                var uld = await _unitOfWork.Repository<ULD>().CreateAsync(new ULD
                {
                    SerialNumber = rm.ULDSerialNumber,
                    ULDLocateStatus = ULDLocateStatus.OnBoard,
                    ULDType = ULDType.None,
                });

                uldId = uld.Id;
            }

            var flightScheduleSectorPallet = await _unitOfWork.Repository<FlightScheduleSectorPallet>().CreateAsync(new FlightScheduleSectorPallet
            {
                FlightScheduleSectorId = flightSchduleSector.Id,
                ULDId = uldId,
            });

            foreach(var x in rm.packageIDs)
            {
                var spec = new PackageItemSpecification(
                  new PackageItemRefQM
                  {
                      PackageRefNumber = x
                  }

                  );

               

                var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);
                var shipmentSpec = new ShipmentSpecification(new Models.Queries.ShipmentQM.ShipmentQM
                {
                    bookingID = package.CargoBookingId,
                    flightScheduleID = fId
                });

                var existingShipment = await _unitOfWork.Repository<Shipment>().GetEntityWithSpecAsync(shipmentSpec);

                if (existingShipment == null)
                {
                    await _unitOfWork.Repository<Shipment>().CreateAsync(new Shipment
                    {
                        bookingID = package.CargoBookingId,
                        flightScheduleID = fId,
                        packageID = package.Id,
                        packageCount = 1,
                    });
                }
                else
                {
                    existingShipment.packageCount += 1;
                    _unitOfWork.Repository<Shipment>().Update(existingShipment);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<Shipment>().Detach(existingShipment);
                }
                

                package.PackageItemStatus = PackageItemStatus.AcceptedForFLight;
                
                _unitOfWork.Repository<PackageItem>().Update(package);
                
                
                await _unitOfWork.SaveChangesAsync();

                _unitOfWork.Repository<PackageItem>().Detach(package);
                

                var pSpecs = new PackageItemSpecification(new PackageItemByBookingQM { BookingID = package.CargoBookingId });

                var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(pSpecs);

                if (packageList.Any(x => x.PackageItemStatus != PackageItemStatus.Dispatched))
                {
                    
                    
                        await _cargoBookingService.UpdateAsync(
                 new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                 {
                     Id = package.CargoBookingId,
                     BookingStatus = BookingStatus.Accepted_for_Flight
                 });
                    

                }
                else
                {
                  
                 
                        await _cargoBookingService.UpdateAsync(
                  new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                  {
                      Id = package.CargoBookingId,
                      BookingStatus = BookingStatus.Partshipment_for_Flight
                  });
                    

                }

            }

           


            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }










            return ServiceResponseStatus.Success;
        }
    }
}
