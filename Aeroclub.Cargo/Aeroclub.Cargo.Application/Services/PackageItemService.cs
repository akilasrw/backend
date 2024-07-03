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
using Aeroclub.Cargo.Application.Models.Queries.ItemAuditQM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageAuditVM;
using Aeroclub.Cargo.Application.Models.RequestModels.GetPackagesByAWBandULDRM;
using Aeroclub.Cargo.Application.Models.RequestModels.GetAWBbyUldAndFlightScheduleRM;
using Aeroclub.Cargo.Application.Models.Queries.ItemsByDateQM;
using Aeroclub.Cargo.Application.Models.ViewModels.PackagesByULDVM;
using Aeroclub.Cargo.Application.Models.Queries.PackageULDContainerQMs;

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
            package.PackageItemStatus = PackageItemStatus.Booking_Made;

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

        public async Task<string[]> FilterPackagesAsync(PackageItemStatus status,long awbNum, string[] packages) 
        {
            var spec = new ItemStatusSpecification(status, awbNum);
            var packageList = await _unitOfWork.Repository<ItemStatus>().GetListWithSpecAsync(spec);


            var res = packages.Except(packageList.Select(x=> x.packageItem.PackageRefNumber)).ToArray();

            return res;

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
            await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<PackageItem>().Detach(package);

            return ServiceResponseStatus.Success;
        }


        public async Task<ServiceResponseStatus> UpdateDetailsAsync(PackageDetailsUpdateRM rm, Guid id)
        {

            var package = await _unitOfWork.Repository<PackageItem>().GetByIdAsync(id);

            package.Width = rm.width;
            package.Height = rm.height;
            package.Weight = rm.weight;
            package.Length = rm.length;
            package.PackageRefNumber = rm.refNo;
            
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
                await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });
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

        public async Task<IReadOnlyList<PackageListItemVM>> GetFilteredAllListAsync(PackageAllListQM query)
        {
            var spec = new PackageItemSpecification(query);

            var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(spec);

            var dtoList = _mapper.Map<IReadOnlyList<PackageListItemVM>>(packageList);

            return dtoList;
        }

        public async Task<IReadOnlyList<string>> GetListByAwbAndStatus(PackageListByAwbAndStatus query)
        {
            var spec = new PackageItemSpecification(query);
            var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(spec);

            // Extract packageRefnumber values
            var packageRefNumbers = packageList.Select(package => package.PackageRefNumber).ToList();

            return packageRefNumbers;
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

            var list = rm.itemList.Select((x)=> x.packageItemId).ToArray();

            var itemList = await FilterPackagesAsync(rm.packageItemStatus, (long)rm.AWBNumber, list);


            foreach (var x in itemList)
            {
                var spec = new PackageItemSpecification(
                    new PackageItemRefQM 
                    {
                        PackageRefNumber = x,
                        AwbNumber = rm.AWBNumber
                    }

                    );

                var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);

                if(package.PackageItemStatus == PackageItemStatus.AcceptedForFLight)
                {
                    var itemStatusspec = new ItemStatusSpecification(PackageItemStatus.AcceptedForFLight, package.Id);
                    var item = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(itemStatusspec);

                    item.IsDeleted = true;
                    _unitOfWork.Repository<ItemStatus>().Update(item);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<ItemStatus>().Detach(item);

                    var packageULDSpec = new PackageULDContainerSpecification(new ULDContainerByPackageIdQM{ packageId = package.Id });
                    var packageULDitem = await _unitOfWork.Repository<PackageULDContainer>().GetEntityWithSpecAsync(packageULDSpec);

                    var shipmentSpec = new ShipmentSpecification(package.CargoBookingId);
                    var shipment = await _unitOfWork.Repository<Shipment>().GetEntityWithSpecAsync(shipmentSpec);

                    shipment.packageCount = shipment.packageCount - 1;
                    _unitOfWork.Repository<Shipment>().Update(shipment);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<Shipment>().Detach(shipment);


                    _unitOfWork.Repository<PackageULDContainer>().Delete(packageULDitem);
                    await _unitOfWork.SaveChangesAsync();
                }
                if (package != null)
                {
                    package.PackageItemStatus = rm.packageItemStatus;
                    _unitOfWork.Repository<PackageItem>().Update(package);
                    await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<PackageItem>().Detach(package);
                }
                
            }



            var awbSpec = new AWBSpecification(new AWBTrackingQM
            {
                AwbTrackingNum = (long)rm.AWBNumber
            });

            var awb = await _unitOfWork.Repository<AWBInformation>().GetEntityWithSpecAsync(awbSpec);

          /*  await _cargoBookingService.UpdateAsync(
                   new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
                   {
                       Id = (Guid)awb.CargoBookingId,
                       BookingStatus = (BookingStatus)rm.status
                   });*/

            if (rm.packageItemStatus == PackageItemStatus.Cargo_Received)
            {
                Guid truckId = Guid.Empty;

                var truckSpecs = new TruckSpecifications(rm.TruckNo);

                var truck = await _unitOfWork.Repository<Truck>().GetEntityWithSpecAsync(truckSpecs);

                if (truck != null)
                {
                    truckId = truck.Id;
                    truck.bookingId = (Guid)awb.CargoBookingId;
                    truck.handOverCount = itemList.Length;

                    _unitOfWork.Repository<Truck>().Update(truck);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<Truck>().Detach(truck);
                }
                else
                {
                    var newTruck = await _unitOfWork.Repository<Truck>().CreateAsync(new Truck { bookingId = (Guid)awb.CargoBookingId, handOverCount = itemList.Count(), truckNumber = rm.TruckNo });
                    truckId = newTruck.Id;
                }

                await _unitOfWork.Repository<TruckInfo>().CreateAsync(new TruckInfo { bookingId = (Guid)awb.CargoBookingId, handOverCount = rm.itemList.Count(), truckId = truckId });
                await _unitOfWork.SaveChangesAsync();
            }

            return ServiceResponseStatus.Success;
           
           
        }

        async public Task<ServiceResponseStatus> CreateTruckBookingAWBAndPackages(ScanAppBookingCreateVM rm)
        {

            try
            {
                rm.Packages = await FilterPackagesAsync(PackageItemStatus.Booking_Made, rm.AWBTrackingNumber, rm.Packages);

               

                var awbSpec = new AWBNumberStackSpecification(rm.AWBTrackingNumber);

                var existingAwb = await _unitOfWork.Repository<AWBNumberStack>().GetEntityWithSpecAsync(awbSpec);

                Guid bId = Guid.Empty;

                if(existingAwb != null)
                {
                    var bSpec = new AWBSpecification(new AWBTrackingQM
                    {
                        AwbTrackingNum = (long)rm.AWBTrackingNumber
                    });
                    var awb = await _unitOfWork.Repository<AWBInformation>().GetEntityWithSpecAsync(bSpec);
                    
                    bId = (Guid)awb.CargoBookingId;
                }
                else
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

                    await _unitOfWork.Repository<AWBNumberStack>().CreateAsync(new AWBNumberStack
                    {
                        AWBTrackingNumber = rm.AWBTrackingNumber,
                        CargoAgentId = rm.CargoAgent,
                    });

                    var res = await _unitOfWork.Repository<AWBInformation>().CreateAsync(new AWBInformation
                    {
                        AwbTrackingNumber = rm.AWBTrackingNumber,
                        CargoBookingId = bRes.Id,
                        RequestedFlightDate = DateTime.Now,
                    });

                    bId = bRes.Id;
                }






                /*var tRes = await _unitOfWork.Repository<TruckInfo>().CreateAsync(new TruckInfo
                {
                    BookingID = bId,
                    TruckID = rm.TruckNo
                });*/
                if (rm.Packages.Length > 0)
                {
                    Guid truckId = Guid.Empty;

                    var truckSpecs = new TruckSpecifications(rm.TruckNo);

                    var truck = await _unitOfWork.Repository<Truck>().GetEntityWithSpecAsync(truckSpecs);

                    if (truck != null)
                    {
                        truckId = truck.Id;
                        truck.bookingId = bId;
                        truck.pickedUpCount = rm.Packages.Length;
                        truck.handOverCount = 0;

                        _unitOfWork.Repository<Truck>().Update(truck);
                        await _unitOfWork.SaveChangesAsync();
                        _unitOfWork.Repository<Truck>().Detach(truck);
                    }
                    else
                    {
                        var newTruck = await _unitOfWork.Repository<Truck>().CreateAsync(new Truck { bookingId = bId, pickedUpCount = rm.Packages.Count(), truckNumber = rm.TruckNo });
                        truckId = newTruck.Id;
                    }

                    await _unitOfWork.Repository<TruckInfo>().CreateAsync(new TruckInfo { bookingId = bId, pickedUpCount = rm.Packages.Count(), truckId = truckId });


                    foreach (var i in rm.Packages)
                    {
                        var existingPackage = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(new PackageItemSpecification(i));
                        if (existingPackage != null)
                        {
                            continue;
                        }
                        var package = await _unitOfWork.Repository<PackageItem>().CreateAsync(new PackageItem
                        {
                            CargoBookingId = bId,
                            PackageRefNumber = i,
                            Description = "",
                            PackageItemCategory = PackageItemCategory.None,
                            PackagePriorityType = PackagePriorityType.None,
                        });

                        await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });
                    }

                    await _unitOfWork.SaveChangesAsync();
                }
               

            }
            catch (Exception ex)
            {
                return ServiceResponseStatus.Failed;
            }
            
            return ServiceResponseStatus.Success;
        }

        async public Task<ServiceResponseStatus> UpdatePackageAndBookingStatusFromULD(PackageUpdateByULD rm)
        {
            foreach(var i in rm.ulds)
            {

                var uldContainerSpecs = new ULDContainerSpecification(i);
                var uldContainer = await _unitOfWork.Repository<ULDContainer>().GetEntityWithSpecAsync(uldContainerSpecs);

                if (rm.IsArrived)
                {
                    uldContainer.ULD.Status = ULDStatus.ULDUnPacked;
                }
                else
                {
                    uldContainer.ULD.Status = ULDStatus.FlightLoaded;
                }

                _unitOfWork.Repository<ULD>().Update(uldContainer.ULD);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<ULD>().Detach(uldContainer.ULD);



                var specs = new PackageULDContainerSpecification(new Application.Models.Queries.PackageULDContainerQMs.PackageByULDQM
                {
                    uldContainer = uldContainer.Id
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
                            package.PackageItemStatus = PackageItemStatus.FlightDispatched;
                        }

                        _unitOfWork.Repository<PackageItem>().Update(package);
                        await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });
                        await _unitOfWork.SaveChangesAsync();
                        _unitOfWork.Repository<PackageItem>().Detach(package);



                   /* var pSpecs = new PackageItemSpecification(new PackageItemByBookingQM { BookingID = package.CargoBookingId });

                    var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(pSpecs);
                    
                    if(packageList.Any(x=> x.PackageItemStatus != PackageItemStatus.FlightDispatched))
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
                        
                    }*/
                }
            }

            return ServiceResponseStatus.Success;
        }


        async public Task<ServiceResponseStatus> UpdateULDandPackageStatus(ScanAppSixthStepRM rm)
        {

            var uldContainerSpecs = new ULDContainerSpecification(rm.uld);
            var uldContainer = await _unitOfWork.Repository<ULDContainer>().GetEntityWithSpecAsync(uldContainerSpecs);

        


            var specs = new PackageULDContainerSpecification(uldContainer.Id);

            var item = await _unitOfWork.Repository<PackageULDContainer>().GetListWithSpecAsync(specs);

            List<PackageItem> uldPackages = new List<PackageItem>();

            foreach (var itemSpec in item)
            {
                uldPackages.Add(itemSpec.PackageItem);
            }

            var uldSpecs = new ULDSpecification(rm.uld);

            uldPackages = uldPackages.Where(x => rm.packageIDs.Contains(x.PackageRefNumber)).ToList();


            foreach (var package in uldPackages)
            {
                package.PackageItemStatus = PackageItemStatus.IndestinationWarehouse;

                _unitOfWork.Repository<PackageItem>().Update(package);
                await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });

                await _unitOfWork.SaveChangesAsync();

                _unitOfWork.Repository<PackageItem>().Detach(package);
            }

            var existingUld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(uldSpecs);

            if(existingUld == null) {

                return ServiceResponseStatus.Failed;
            
            }

            existingUld.ULDLocateStatus = ULDLocateStatus.OnGround;

            _unitOfWork.Repository<ULD>().Update(existingUld);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<ULD>().Detach(existingUld);

            /*foreach (var x in rm.packageIDs)
            {
                var spec = new PackageItemSpecification(
                  new PackageItemRefQM
                  {
                      PackageRefNumber = x,
                      AwbNumber = rm.AwbNumber
                  }

                  );



                var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);

                if(package != null)
                {
                    package.PackageItemStatus = PackageItemStatus.IndestinationWarehouse;

                    _unitOfWork.Repository<PackageItem>().Update(package);
                    await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });

                    await _unitOfWork.SaveChangesAsync();

                    _unitOfWork.Repository<PackageItem>().Detach(package);
                }

               

*//*
                    await _cargoBookingService.UpdateAsync(
             new Models.RequestModels.CargoBookingRMs.CargoBookingUpdateRM
             {
                 Id = package.CargoBookingId,
                 BookingStatus = BookingStatus.IndestinationWarehouse
             });*//*


               

            }*/




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

        async public Task<ServiceResponseStatus> DeletePackage(Guid packageId)
        {
            try
            {
                var package = await _unitOfWork.Repository<PackageItem>().GetByIdAsync(packageId);
                if (package != null)
                {
                    package.IsDeleted = true;
                    _unitOfWork.Repository<PackageItem>().Update(package);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<PackageItem>().Detach(package);
                    return ServiceResponseStatus.Success;
                }
                else
                {
                    return ServiceResponseStatus.Failed;
                }
            }catch(Exception ex)
            {
                return ServiceResponseStatus.Failed;
            }
           


        }
        async public Task<ServiceResponseStatus> CreateFlightScheduleULDandUpdateStatus(ScanAppThirdStepRM rm)
        {
            try
            {
                Guid fId = Guid.NewGuid();

                Guid fsId = Guid.NewGuid();

                Guid uldId = Guid.NewGuid();

                rm.packageIDs = await FilterPackagesAsync(PackageItemStatus.AcceptedForFLight, rm.AwbNumber, rm.packageIDs);

                var flight = await _unitOfWork.Repository<Flight>().GetByIdAsync(rm.FlightID);

                var specs = new FlightScheduleSpecification(new FlightScheduleStandbyQM { FlightDate = rm.ScheduledDepartureDateTime, FlightNumber = flight.FlightNumber, IncludeFlightScheduleSectors = true });

                var existingSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(specs);

                var uldSpecs = new ULDSpecification(rm.ULDSerialNumber);

                var existingUld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(uldSpecs);

                var itemSpec = new PackageItemSpecification(
                          new PackageItemRefQM
                          {
                              PackageRefNumber = rm.packageIDs[0],
                              AwbNumber = rm.AwbNumber,

                          }

                          );



                var packageItem = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(itemSpec);

                if (existingSchedule != null)
                {
                    // Use the existing schedule
                    var flightSchedule = existingSchedule;
                    fId = flightSchedule.Id;
                    fsId = flightSchedule.FlightScheduleSectors.FirstOrDefault().Id;
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

                    var flightSchduleSector = await _unitOfWork.Repository<FlightScheduleSector>().CreateAsync(new FlightScheduleSector
                    {
                        FlightId = rm.FlightID,
                        OriginAirportCode = flight.OriginAirportCode,
                        DestinationAirportCode = flight.DestinationAirportCode,
                        ScheduledDepartureDateTime = rm.ScheduledDepartureDateTime,
                        DestinationAirportName = flight.DestinationAirportName,
                        OriginAirportName = flight.OriginAirportName,
                        DestinationAirportId = flight.DestinationAirportId,
                        OriginAirportId = flight.OriginAirportId,
                        FlightScheduleId = fId,
                        FlightNumber = flight.FlightNumber,
                        SequenceNo = 1
                    });



                    fsId = flightSchduleSector.Id;


                    await _unitOfWork.SaveChangesAsync();
                }

                await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().CreateAsync(new CargoBookingFlightScheduleSector { CargoBookingId = packageItem.CargoBookingId, FlightScheduleSectorId = fsId });
                await _unitOfWork.SaveChangesAsync();

                if (existingUld != null)
                {
                    uldId = existingUld.Id;
                    existingUld.ULDLocateStatus = ULDLocateStatus.OnBoard;
                    existingUld.Status = ULDStatus.ULDPacked;

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
                        Status = ULDStatus.ULDPacked,
                        ULDType = ULDType.None,
                    });
                    await _unitOfWork.SaveChangesAsync();
                    uldId = uld.Id;
                   

                }


                    var sectorPallet = await _unitOfWork.Repository<FlightScheduleSectorPallet>().GetEntityWithSpecAsync(new FlightScheduleSectorPalletSpecification(fsId, uldId));
                
                    if(sectorPallet == null)
                {
                    await _unitOfWork.Repository<FlightScheduleSectorPallet>().CreateAsync(new FlightScheduleSectorPallet
                    {
                        FlightScheduleSectorId = fsId,
                        ULDId = uldId,
                    });
                }
                   
                


                var uldCId = Guid.NewGuid();

                var existingContainerSpecs = new ULDContainerSpecification(uldId);

                var existingContainer = await _unitOfWork.Repository<ULDContainer>().GetEntityWithSpecAsync(existingContainerSpecs);

                if (existingContainer == null)
                {
                    var uldContainer = await _unitOfWork.Repository<ULDContainer>().CreateAsync(new ULDContainer { ULDId = uldId });
                    uldCId = uldContainer.Id;
                }
                else
                {
                    uldCId = existingContainer.Id;
                }





                await _unitOfWork.SaveChangesAsync();

                foreach (var x in rm.packageIDs)
                {
                    var spec = new PackageItemSpecification(
                      new PackageItemRefQM
                      {
                          PackageRefNumber = x,
                          AwbNumber = rm.AwbNumber
                      }

                      );



                    var package = await _unitOfWork.Repository<PackageItem>().GetEntityWithSpecAsync(spec);
                    if (package != null)
                    {
                        var itemStatusspec = new ItemStatusSpecification(PackageItemStatus.Offloaded, package.Id);
                        var item = await _unitOfWork.Repository<ItemStatus>().GetEntityWithSpecAsync(itemStatusspec);

                        if(item != null)
                        {
                            item.IsDeleted = true;
                            _unitOfWork.Repository<ItemStatus>().Update(item);
                            await _unitOfWork.SaveChangesAsync();
                            _unitOfWork.Repository<ItemStatus>().Detach(item);
                        }

                       
                        await _unitOfWork.Repository<PackageULDContainer>().CreateAsync(new PackageULDContainer { PackageItemId = package.Id, ULDContainerId = uldCId });
                        await _unitOfWork.SaveChangesAsync();
                        var shipmentSpec = new ShipmentSpecification(new Models.Queries.ShipmentQM.ShipmentQM
                        {
                            bookingID = package.CargoBookingId,
                            flightScheduleID = fId
                        });

                        var shipmentId = Guid.Empty;

                        var existingShipment = await _unitOfWork.Repository<Shipment>().GetEntityWithSpecAsync(shipmentSpec);

                        if (existingShipment == null)
                        {
                            var shipment = await _unitOfWork.Repository<Shipment>().CreateAsync(new Shipment
                            {
                                bookingID = package.CargoBookingId,
                                flightScheduleID = fId,
                                packageID = package.Id,
                                packageCount = 1,
                            });
                            await _unitOfWork.SaveChangesAsync();
                            shipmentId = shipment.Id;
                        }
                        else
                        {
                            existingShipment.packageCount += 1;
                            _unitOfWork.Repository<Shipment>().Update(existingShipment);
                            await _unitOfWork.SaveChangesAsync();
                            _unitOfWork.Repository<Shipment>().Detach(existingShipment);
                            shipmentId = existingShipment.Id;
                        }


                        package.PackageItemStatus = PackageItemStatus.AcceptedForFLight;
                        package.ShipmentId = shipmentId;


                        _unitOfWork.Repository<PackageItem>().Update(package);
                        await _unitOfWork.Repository<ItemStatus>().CreateAsync(new ItemStatus { PackageID = package.Id, PackageItemStatus = package.PackageItemStatus });

                        await _unitOfWork.SaveChangesAsync();

                        _unitOfWork.Repository<PackageItem>().Detach(package);
                    }



                    /*var pSpecs = new PackageItemSpecification(new PackageItemByBookingQM { BookingID = package.CargoBookingId });

                    var packageList = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(pSpecs);

                    if (packageList.Any(x => x.PackageItemStatus != PackageItemStatus.FlightDispatched))
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


                    }*/

                }




                try
                {
                    await _unitOfWork.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }










                
            }
            catch(Exception ex)
            {
                return ServiceResponseStatus.Failed;
            }

            return ServiceResponseStatus.Success;


        }

        public async Task<IReadOnlyList<PackageAuditVM>> GetPackageItemAuditByBooking(ItemAuditQM query)
        {
            var spec = new PackageAuditSpecification(new ItemAuditQM { bookingID = query.bookingID, awbNumber=query.awbNumber, status=query.status});

            var packageAudit = await _unitOfWork.Repository<ItemStatus>().GetListWithSpecAsync(spec);
            var dtoList = _mapper.Map<IReadOnlyList<PackageAuditVM>>(packageAudit);

            return dtoList;
        }

        public async Task<IReadOnlyList<PackageAuditVM>> GetPackagesByDate(ItemsByDateQM query)
        {
            var spec = new PackageItemSpecification(query);

            var packageAudit = await _unitOfWork.Repository<PackageItem>().GetListWithSpecAsync(spec);

            var dtoList = _mapper.Map<IReadOnlyList<PackageAuditVM>>(packageAudit);

            return dtoList;
        }

        public async Task<IReadOnlyList<PackagesByULDVM>> GetPackagesByAwbAndUld(GetPackageByAwbAndUldRM query)
        {
            var spec = new ULDContainerSpecification(query);
            var res = await _unitOfWork.Repository<ULDContainer>().GetListWithSpecAsync(spec);

            List<PackagesByULDVM> packageList = new List<PackagesByULDVM>();

            foreach (var item in res)
            {
                foreach(var item2 in item.PackageULDContainers)
                {
                    if(item2.PackageItem.PackageItemStatus == PackageItemStatus.Arrived)
                    {
                        packageList.Add(new PackagesByULDVM { packageRef = item2.PackageItem.PackageRefNumber , awbNum = item2.PackageItem.CargoBooking.AWBInformation.AwbTrackingNumber});
                    }
                }
            }

            return packageList;


        }

        public async Task<HashSet<long>> GetAwbByUldAndFlightSchdule(GetAWBbyUldAndFlightScheduleRM query)
        {

            var uldContainerSpecs = new ULDContainerSpecification(query);
            var uldContainer = await _unitOfWork.Repository<ULDContainer>().GetEntityWithSpecAsync(uldContainerSpecs);

            var specs = new PackageULDContainerSpecification(new Application.Models.Queries.PackageULDContainerQMs.PackageByULDQM
            {
                uldContainer = uldContainer.Id
            });

            var item = await _unitOfWork.Repository<PackageULDContainer>().GetListWithSpecAsync(specs);

            HashSet<long> longList = new HashSet<long>();

            foreach(var x in item)
            {
                if (x.PackageItem.CargoBooking.AWBInformation.AwbTrackingNumber != 0)
                {
                    longList.Add(x.PackageItem.CargoBooking.AWBInformation.AwbTrackingNumber);
                }
            }

            return longList;


        }
    }
}
