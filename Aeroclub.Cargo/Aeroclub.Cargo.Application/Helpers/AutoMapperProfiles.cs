using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.RequestModels;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.WarehouseRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageContainerVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.WarehouseVMs;
using Aeroclub.Cargo.Core.Entities;
using AutoMapper;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageListItemVM;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBStackVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirportRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AircraftRMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainer;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDMetaDataVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerCargoPositionVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightSectorVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRateRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AgentRateManagementVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AircraftScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.MasterScheduleVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberStackRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBNumberStackVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftScheduleVMs;
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.ViewModels.NotificationVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingFlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.ViewModels.LoadPlanVMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SystemUserRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SystemUserVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageAuditVM;

namespace Aeroclub.Cargo.Application.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterRequestRM, AppUser>();
            CreateMap<Airport, BaseSelectListModel>()
                .ForMember(x => x.Value, x => x.MapFrom(c => c.Code + " - " + c.Name));
            CreateMap<Country, BaseSelectListModel>()
                .ForMember(x => x.Value, x => x.MapFrom(c => c.Name));
            CreateMap<Sector, SectorDto>().ReverseMap();
            CreateMap<Sector, SectorVM>()
                .ForMember(d => d.DestinationAirportName, x => x.MapFrom(s => s.DestinationAirport.Name))
                .ForMember(d => d.OriginAirportName, x => x.MapFrom(s => s.OriginAirport.Name))
                .ForMember(d => d.DestinationAirportCode, x => x.MapFrom(s => s.DestinationAirport.Code))
                .ForMember(d => d.OriginAirportCode, x => x.MapFrom(s => s.OriginAirport.Code));
            CreateMap<Currency, BaseSelectListModel>()
               .ForMember(x => x.Value, x => x.MapFrom(c => c.Code));
            CreateMap<Flight, FlightVM>();
            CreateMap<Flight, FlightFilterVM>()
                .ForMember(d => d.SectorCount, o => o.MapFrom(s => s.FlightSectors == null ? 0 : s.FlightSectors.Count));
            CreateMap<FlightCreateRM, Flight>();
            CreateMap<FlightSectorDto, FlightSector>()
                .ForMember(d => d.DepartureDateTime, o => o.MapFrom(s => TimeSpan.Parse(s.DepartureDateDisplayTime)))
                .ForMember(d => d.ArrivalDateTime, o => o.MapFrom(s => TimeSpan.Parse(s.ArrivalDateDisplayTime)));
            CreateMap<FlightScheduleUpdateRM, FlightSchedule>().ReverseMap();
            CreateMap<FlightScheduleCreateRM, FlightSchedule>();
            CreateMap<FlightScheduleSectorCreateRM, FlightScheduleSector>();
            CreateMap<FlightScheduleSector, FlightScheduleSectorVM>()
                .ForMember(d => d.AircraftConfigType, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.ConfigType : AircraftConfigType.None))
                .ForMember(d => d.AircraftLayoutId, o => o.MapFrom(s => s.LoadPlan != null ? s.LoadPlan.AircraftLayoutId : Guid.Empty))
                .ForMember(d => d.SeatLayoutId, o => o.MapFrom(s => s.LoadPlan != null ? s.LoadPlan.SeatLayoutId : Guid.Empty));
            CreateMap<FlightSchedule, FlightScheduleSearchVM>()
                .ForMember(d => d.AircraftConfigType, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.ConfigType : AircraftConfigType.None));
            CreateMap<FlightSchedule, FlightScheduleVM>();
            CreateMap<FlightSchedule, FlightScheduleLinkVM>()
                .ForMember(d => d.AircraftSubTypeName, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.AircraftType.Name : ""))
                .ForMember(d => d.ScheduledArrivalDateTime, o => o.MapFrom(s => new DateTime()
                    .Add((TimeSpan)s.FlightScheduleSectors.FirstOrDefault().Flight.FlightSectors.FirstOrDefault(r => r.Sequence == 1).ArrivalDateTime)));
            CreateMap<FlightScheduleVM, FlightScheduleUpdateRM>();
            CreateMap<FlightSchedule, CargoBookingSummaryVM>()
                .ForMember(d => d.AircraftConfigurationType, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.ConfigType : AircraftConfigType.None))
                .ForMember(d => d.CutoffTime, o => o.MapFrom(s => s.CutoffTimeMin != null ? s.ScheduledDepartureDateTime.AddMinutes(-s.CutoffTimeMin.Value) : s.ScheduledDepartureDateTime))
                .ForMember(d => d.AircraftSubTypeName, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.AircraftType.Name : ""));
            CreateMap<FlightSchedule, CargoBookingSummaryDetailVM>()
               .ForMember(d => d.AircraftSubType, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.Type : AircraftSubTypes.None))
               .ForMember(d => d.AircraftType, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.AircraftType.Type : AircraftTypes.None))
               .ForMember(d => d.AircraftConfigurationType, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.ConfigType : AircraftConfigType.None))
               .ForMember(d => d.AircraftSubTypeName, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.AircraftType.Name : ""));
            CreateMap<WarehouseCreateRM, Warehouse>();
            CreateMap<WarehouseUpdateRM, Warehouse>();
            CreateMap<Warehouse, WarehouseVM>();

            CreateMap<CargoAgentCreateRM, CargoAgent>();
            CreateMap<CargoAgentCreateRM, AppUser>()
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.AgentName))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.PrimaryTelephoneNumber));

            CreateMap<CargoAgentUpdateRM, CargoAgent>();

            CreateMap<CargoAgent, CargoAgentVM>()
                .ForMember(d => d.CountryName, o => o.MapFrom(s => s.Country.Name))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.AppUser.Email))
                .ForMember(d => d.BaseAirportName, o => o.MapFrom(s => s.BaseAirport.Name))
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.AppUser.UserName));

            CreateMap<CargoBooking, CargoBookingVM>()
                .ForMember(d => d.AWBNumber, o => o.MapFrom(s => s.AWBInformation.AwbTrackingNumber))
                .ForMember(d => d.DestinationAirportCode, o => o.MapFrom(s => s.DestinationAirport.Code))
                //.ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.CargoBookingFlightScheduleSectors.Count() > 0 ? s.CargoBookingFlightScheduleSectors.First().FlightScheduleSector.FlightNumber:""))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.CargoBookingFlightScheduleSectors.Count()>0 ? s.CargoBookingFlightScheduleSectors.LastOrDefault(x => x.FlightScheduleSector.SequenceNo == 1)!.FlightScheduleSector.ScheduledDepartureDateTime : DateTime.MinValue))
                .ForMember(d => d.AircraftConfigType, o => o.MapFrom(s => s.CargoBookingFlightScheduleSectors.Count() > 0 ? s.CargoBookingFlightScheduleSectors.First().FlightScheduleSector.AircraftSubType.ConfigType: AircraftConfigType.None))
                //.ForMember(d => d.NumberOfBoxes, o => o.MapFrom(s => s.PackageItems.Count))
                //.ForMember(d => d.BookingStatus, o => o.MapFrom(s => s.PackageItems.ToList()[0].PackageItemStatus))
                .ForMember(d => d.TotalWeight, o => o.MapFrom(s => s.PackageItems.Sum(x => x.Weight)));

            CreateMap<ItemStatus, PackageAuditVM>()
                .ForMember(d => d.packageId, o => o.MapFrom(s => s.PackageID))
                .ForMember(d => d.packageNumber, o => o.MapFrom(s => s.packageItem.PackageRefNumber))
                .ForMember(d => d.flightNumber, o => o.MapFrom(s => s.packageItem.Shipment.FlightSchedule.FlightNumber))
                .ForMember(d => d.packageStatus, o => o.MapFrom(s => s.PackageItemStatus))
                .ForMember(d => d.awb, o => o.MapFrom(s => s.packageItem.CargoBooking.AWBInformation.AwbTrackingNumber))
                .ForMember(d => d.collectedDate, o => o.MapFrom(s => s.packageItem.Created))
                .ForMember(d => d.flightDate, o => o.MapFrom(s => s.packageItem.Shipment.FlightSchedule.ScheduledDepartureDateTime));

            CreateMap<PackageItem, PackageAuditVM>()
                .ForMember(d => d.packageId, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.packageNumber, o => o.MapFrom(s => s.PackageRefNumber))
                .ForMember(d => d.flightNumber, o => o.MapFrom(s => s.Shipment.FlightSchedule.FlightNumber))
                .ForMember(d => d.packageStatus, o => o.MapFrom(s => s.PackageItemStatus))
                .ForMember(d => d.awb, o => o.MapFrom(s => s.CargoBooking.AWBInformation.AwbTrackingNumber))
                .ForMember(d => d.collectedDate, o => o.MapFrom(s => s.Created))
                .ForMember(d => d.flightDate, o => o.MapFrom(s => s.Shipment.FlightSchedule.ScheduledDepartureDateTime));



            CreateMap<CargoBookingRM, CargoBooking>();
            CreateMap<CargoBooking, CargoBookingULDVM>()
                .ForMember(d => d.TotalWeight, o => o.MapFrom(s => s.PackageItems != null ? s.PackageItems.Sum(x => x.Weight) : 0))
                .ForMember(d => d.TotalVolume, o => o.MapFrom(s => s.PackageItems != null ? s.PackageItems.Sum(x => x.Height * x.Length * x.Width) : 0))
                .ForMember(d => d.AwbTrackingNumber, o => o.MapFrom(s => s.AWBInformation != null ? s.AWBInformation.AwbTrackingNumber : 0));

            CreateMap<ULDContainerDto, ULDContainer>();
            CreateMap<ULDContainerUpdateRM, ULDContainer>();
            CreateMap<ULDDto, ULD>().ReverseMap();
            CreateMap<LoadPlanDto, LoadPlan>();
            CreateMap<LoadPlan, LoadPlanVM>();
            CreateMap<ULDMetaDataDto, ULDMetaData>();
            CreateMap<ULDMetaData, ULDMetaDataDto>();
            CreateMap<PackageContainer, PackageContainerVM>().ReverseMap();

            CreateMap<CargoBooking, CargoBookingDetailVM>();
            CreateMap<PackageItem, PackageItemVM>()
                .ForMember(d => d.CargoPositionId, o => o.MapFrom(s => s.PackageULDContainers.Count()>0? s.PackageULDContainers.FirstOrDefault(x=>x.PackageItemId == s.Id)!.ULDContainer.ULDContainerCargoPositions.Count > 0 ?
                s.PackageULDContainers.FirstOrDefault(x => x.PackageItemId == s.Id)!.ULDContainer.ULDContainerCargoPositions.First().CargoPositionId : Guid.Empty:Guid.Empty));

            CreateMap<CargoBooking, CargoBookingLookupVM>();

            CreateMap<Unit, BaseSelectListModel>()
                .ForMember(d => d.Value, o => o.MapFrom(s => s.Name));
            CreateMap<Unit, UnitDto>();

            CreateMap<PackageItem, PackageListItemVM>()
                .ForMember(d => d.packageItemStatus, o => o.MapFrom(s => s.CargoBooking != null ? s.PackageItemStatus : 0))
                .ForMember(d => d.BookingDate, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.BookingDate : DateTime.MinValue))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.CargoBookingFlightScheduleSectors.Count()>0?s.CargoBooking.CargoBookingFlightScheduleSectors.First().FlightScheduleSector.FlightNumber:"" : ""));

            CreateMap<PackageItemCreateRM, PackageItem>();
            CreateMap<Seat, SeatDto>().ReverseMap();

            CreateMap<AWBCreateRM, AWBInformation>();

            CreateMap<AWBInformation, AWBInformationVM>();

            CreateMap<PackageItem, PackageItemMobileVM>()
                .ForMember(d => d.WeightUnit, o => o.MapFrom(s => s.WeightUnit != null ? s.WeightUnit.Name : ""))
                .ForMember(d => d.VolumeUnit, o => o.MapFrom(s => s.VolumeUnit != null ? s.VolumeUnit.Name : ""))
                .ForMember(d => d.BookingRefNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.BookingNumber : ""))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.CargoBookingFlightScheduleSectors.Count() > 0 ? s.CargoBooking.CargoBookingFlightScheduleSectors.FirstOrDefault(x => x.FlightScheduleSector.SequenceNo == 1)!.FlightScheduleSector.ScheduledDepartureDateTime : DateTime.MinValue : DateTime.MinValue))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.CargoBookingFlightScheduleSectors.Count() > 0 ? s.CargoBooking.CargoBookingFlightScheduleSectors.First().FlightScheduleSector.FlightNumber : "": ""))
                .ForMember(d => d.AwbTrackingNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.AWBInformation.AwbTrackingNumber : 0))
                .ForMember(d => d.CargoPositionType, o => o.MapFrom(s => s.PackageULDContainers.Count()>0? s.PackageULDContainers.FirstOrDefault(x=>x.PackageItemId==s.Id)!.ULDContainer.ULDContainerCargoPositions.First().CargoPosition.CargoPositionType : 0));

            CreateMap<PackageItem, PackageMobileVMs>().
                ForMember(d => d.Dimension, o => o.MapFrom(s => string.Format("{0} x {1} x {2} {3}", s.Length, s.Width, s.Height, s.VolumeUnit.Name)));

            CreateMap<SeatConfiguration, SeatConfigurationDto>().ReverseMap();

            CreateMap<OverheadCompartmentDto, OverheadCompartment>();
            CreateMap<OverheadCompartment, OverheadCompartmentDto>();

            CreateMap<ULDContainerCargoPositionDto, ULDContainerCargoPosition>();

            CreateMap<AWBStackRM, AWBStack>();
            CreateMap<AWBStack, AWBStackVM>()
                .ForMember(d => d.CargoAgentName, o => o.MapFrom(s => s.CargoAgent != null ? s.CargoAgent.AgentName : ""));

            CreateMap<CargoAgent, BaseSelectListModel>()
               .ForMember(d => d.Value, o => o.MapFrom(s => s.AgentName))
                .ForMember(d => d.Id, o => o.MapFrom(s => s.AppUserId));

            CreateMap<AWBUpdateRM, AWBInformation>();

            CreateMap<PackageItemUpdateRM, PackageItem>();
            CreateMap<PackageItemVM, PackageItemUpdateRM>();

            CreateMap<Airport, AirportVM>()
                .ForMember(d => d.CountryName, o => o.MapFrom(s => s.Country != null ? s.Country.Name : ""))
                .ForMember(d => d.CountryCode, o => o.MapFrom(s => s.Country != null ? s.Country.Code : ""));
            CreateMap<AirportCreateRM, Airport>();
            CreateMap<AirportUpdateRM, Airport>();

            CreateMap<SectorUpdateRM, Sector>();
            CreateMap<SectorCreateRM, Sector>();

            CreateMap<AircraftType, AircraftTypeVM>();
            CreateMap<AircraftSubType, AircraftSubTypeVM>();

            CreateMap<AircaftCreateRM, Aircraft>();
            CreateMap<AircaftUpdateRM, Aircraft>();
            CreateMap<Aircraft, AircraftVM>();

            CreateMap<CargoPosition, CargoPositionVM>();

            CreateMap<ULDContainer, ULDContainerVM>();                        
            CreateMap<ULDCargoPositionDto, ULDCargoPosition>().ReverseMap();
            CreateMap<ULD, ULDVM>();
            CreateMap<ULDMetaData, ULDMetaDataVM>();
            CreateMap<ULDContainerCargoPosition, ULDContainerCargoPositionVM>();

            CreateMap<FlightScheduleManagement, FlightScheduleManagementVM>()
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.Flight != null ? s.Flight.FlightNumber : ""))
                .ForMember(d => d.OriginAirportCode, o => o.MapFrom(s => s.Flight != null ? s.Flight.OriginAirport.Code : ""))
                .ForMember(d => d.OriginAirportName, o => o.MapFrom(s => s.Flight != null ? s.Flight.OriginAirport.Name : ""))
                .ForMember(d => d.DestinationAirportCode, o => o.MapFrom(s => s.Flight != null ? s.Flight.DestinationAirport.Code : ""))
                .ForMember(d => d.DestinationAirportName, o => o.MapFrom(s => s.Flight != null ? s.Flight.DestinationAirport.Name : ""))
                .ForMember(d => d.AircraftSubType, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.Type : AircraftSubTypes.None))
                .ForMember(d => d.ScheduledTime, o => o.MapFrom(s => (s.Flight != null && s.Flight.FlightSectors != null) ? new DateTime()
                .Add((TimeSpan)s.Flight.FlightSectors.First(r => r.Sequence == 1).DepartureDateTime) : new DateTime()));


            CreateMap<FlightSchedule, FlightScheduleLinkAircraftVM>()
                .ForMember(d => d.AircraftSubTypeName, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.AircraftType.Name : ""))
                .ForMember(d => d.DestinationAirportName, o => o.MapFrom(s => s.FlightScheduleSectors.LastOrDefault().Flight != null ? s.FlightScheduleSectors.LastOrDefault().Flight.DestinationAirportCode : ""))
                .ForMember(d => d.OriginAirportName, o => o.MapFrom(s => s.FlightScheduleSectors.FirstOrDefault().Flight != null ? s.FlightScheduleSectors.FirstOrDefault().Flight.OriginAirportCode : ""))
                .ForMember(d=> d.ScheduledArrivalDateTime, o => o.MapFrom(s=> new DateTime()
                    .Add((TimeSpan)s.FlightScheduleSectors.FirstOrDefault().Flight.FlightSectors.FirstOrDefault(r => r.Sequence == 1).ArrivalDateTime)));

            CreateMap<FlightScheduleManagementRM, FlightScheduleManagement>();

            CreateMap<FlightScheduleManagementUpdateRM,FlightScheduleManagementRM>();

            CreateMap<FlightScheduleManagementUpdateRM, FlightScheduleManagement>();
            CreateMap<FlightScheduleSector, FlightScheduleSectorUldPositionVM>()
                .ForMember(d => d.AircraftSubTypeName, o => o.MapFrom(s => s.AircraftSubType != null ? s.AircraftSubType.AircraftType.Name : ""));

            CreateMap<Aircraft, BaseSelectListModel>()
                .ForMember(d => d.Value, o => o.MapFrom(s => s.RegNo));

            CreateMap<Flight, BaseSelectListModel>()
               .ForMember(d => d.Value, o => o.MapFrom(s => s.FlightNumber));

            CreateMap<FlightSector, FlightSectorVM>()
                .ForMember(d => d.DepartureDateTime, o => o.MapFrom(s => (s.DepartureDateTime != null) ? new DateTime()
                .Add((TimeSpan)s.DepartureDateTime): new DateTime()))
                .ForMember(d => d.ArrivalDateTime, o => o.MapFrom(s => (s.ArrivalDateTime != null) ? new DateTime()
                .Add((TimeSpan)s.ArrivalDateTime) : new DateTime()));

            CreateMap<AgentRateManagementCreateRM, AgentRateManagement>();
            CreateMap<AgentRateRM, AgentRate>();
            CreateMap<AgentRateManagement, AgentRateManagementVM>()
                            .ForMember(d => d.CargoAgentName, o => o.MapFrom(s => s.CargoAgent != null ? s.CargoAgent.AgentName:""));
            CreateMap<AgentRate, AgentRateVM>();
            CreateMap<AgentRateManagement, AgentRateManagementHistory>();
            CreateMap<AgentRateManagementUpdateRM, AgentRateManagement>();
            CreateMap<CountryDto, Country>().ReverseMap();

            CreateMap<MasterScheduleCreateRM, MasterSchedule>()
                                .ForMember(d => d.ScheduleStartTime, o => o.MapFrom(s => TimeSpan.Parse(s.ScheduleStartTime)));
            CreateMap<MasterSchedule, MasterScheduleVM>();
            CreateMap<AircraftScheduleRM, AircraftSchedule>();

            CreateMap<AWBNumberStackCreateRM, AWBNumberStack>();
            CreateMap<AWBNumberStackUpdateRM, AWBNumberStack>();
            CreateMap<MasterScheduleUpdateRM, AircraftSchedule>()
                .ForMember(d => d.ScheduleStartDateTime, o=> o.MapFrom(s=> s.ScheduleStartDate.Date + TimeSpan.Parse(s.ScheduleStartTime)))
                .ForMember(d => d.ScheduleEndDateTime, o=> o.MapFrom(s=> s.ScheduleEndDate.Date + TimeSpan.Parse(s.ScheduleEndTime)));
            CreateMap<AWBNumberStack, AWBNumberStackVM>()
                .ForMember(d => d.CargoAgentName, o => o.MapFrom(s=> s.CargoAgent != null? s.CargoAgent.AgentName:""));

            CreateMap<AircraftSchedule, AircraftScheduleVM>()
                .ForMember(d => d.RegNo, o => o.MapFrom(s => s.Aircraft != null ? s.Aircraft.RegNo : ""));

            CreateMap <Aircraft,AircraftDto>().ReverseMap();

            CreateMap <Notification,NotificationVM>();
            CreateMap <NotificationRM, Notification>();
            CreateMap <CargoBookingFlightScheduleSectorRM, CargoBookingFlightScheduleSector>();
            CreateMap <PackageULDContainerRM, PackageULDContainer>();
            CreateMap <ULDCreateRM, ULD>();
            CreateMap <ULDUpdateRM, ULD>();
            CreateMap <ULDMetaDataCreateRM, ULDMetaData>();
            CreateMap <ULDMetaDataUpdateRM, ULDMetaData>();
            CreateMap<ULD, ULDFilteredListVM>()
                .ForMember(d => d.Weight, o => o.MapFrom(s => s.ULDMetaData != null ? s.ULDMetaData.Weight : 0))
                .ForMember(d => d.MaxWeight, o => o.MapFrom(s => s.ULDMetaData != null ? s.ULDMetaData.MaxWeight : 0))
                .ForMember(d => d.MaxVolume, o => o.MapFrom(s => s.ULDMetaData != null ? s.ULDMetaData.MaxVolume : 0))
                .ForMember(d => d.Length, o => o.MapFrom(s => s.ULDMetaData != null ? s.ULDMetaData.Length : 0))
                .ForMember(d => d.Width, o => o.MapFrom(s => s.ULDMetaData != null ? s.ULDMetaData.Width : 0))
                .ForMember(d => d.ULDLocateStatus, o => o.MapFrom(s => s.ULDLocateStatus))
                .ForMember(d => d.Height, o => o.MapFrom(s => s.ULDMetaData != null ? s.ULDMetaData.Height : 0))
                .ForMember(d => d.Station, o => o.MapFrom(s => s.Airport.Code))
                .ForMember(d => d.LastFlight, o => o.MapFrom(s => s.LastFlight))
                .ForMember(d => d.LastUsed, o => o.MapFrom(s => s.LastUsed))

                .ForMember(d => d.LastLocatedAirportCode, o => o.MapFrom(s => s.ULDTrackings != null && s.ULDTrackings.Count() > 0 ? s.ULDTrackings.LastOrDefault().LastLocatedAirportCode : ""));
            CreateMap <LIRFileUploadDto, LIRFileUpload>().ReverseMap();

            CreateMap <CargoBookingListVM, CargoBookingStandByCargoVM>();
            CreateMap <CargoBookingListVM, CargoBookingMobileVM>();
            CreateMap <FlightScheduleSectorPalletCreateRM, FlightScheduleSectorPallet>();

            CreateMap<SystemUserCreateRM, SystemUser>();
            CreateMap<SystemUserCreateRM, AppUser>();

            // CreateMap<SystemUserUpdateRM, SystemUser>();

            CreateMap<SystemUser, SystemUserVM>()
                .ForMember(d => d.CountryName, o => o.MapFrom(s => s.Country.Name))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.AppUser.Email))
                .ForMember(d => d.BaseAirportName, o => o.MapFrom(s => s.BaseAirport.Name))
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.AppUser.UserName))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.AppUser.PhoneNumber))
                .ForMember(d=> d.FirstName, o => o.MapFrom(s=>s.AppUser.FirstName))
                .ForMember(d=> d.LastName, o => o.MapFrom(s=>s.AppUser.LastName));

        }
    }
}
