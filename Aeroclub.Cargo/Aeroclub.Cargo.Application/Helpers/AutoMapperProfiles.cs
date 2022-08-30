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
using Aeroclub.Cargo.Application.Models.ViewModels.RateVMs;
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

namespace Aeroclub.Cargo.Application.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterRequestRM, AppUser>();
            CreateMap<Airport, BaseSelectListModel>()
                .ForMember(x => x.Value, x => x.MapFrom(c => c.Code +" - "+c.Name));
            CreateMap<Country, BaseSelectListModel>()
                .ForMember(x => x.Value, x => x.MapFrom(c => c.Name));
            CreateMap<Sector, SectorDto>().ReverseMap();
            CreateMap<Sector, SectorVM>();
            CreateMap<Currency, BaseSelectListModel>()
               .ForMember(x => x.Value, x => x.MapFrom(c => c.Code));
            CreateMap<Flight, FlightVM>();
            CreateMap<FlightScheduleUpdateRM, FlightSchedule>();
            CreateMap<FlightScheduleCreateRM, FlightSchedule>();
            CreateMap<FlightScheduleSectorCreateRM, FlightScheduleSector>();
            CreateMap<FlightScheduleSector, FlightScheduleSectorVM>()
                .ForMember(d => d.AircraftConfigType, o => o.MapFrom(s=> s.Aircraft != null? s.Aircraft.ConfigurationType: AircraftConfigType.None))
                .ForMember(d => d.AircraftLayoutId, o => o.MapFrom(s=> s.LoadPlan != null? s.LoadPlan.AircraftLayoutId: Guid.Empty))
                .ForMember(d => d.SeatLayoutId, o => o.MapFrom(s=> s.LoadPlan != null? s.LoadPlan.SeatLayoutId: Guid.Empty));
            CreateMap<FlightSchedule, FlightScheduleVM>();
            CreateMap<FlightSchedule, CargoBookingSummaryVM>()
                .ForMember(d => d.AircraftConfigurationType, o => o.MapFrom(s => s.Aircraft != null ? s.Aircraft.ConfigurationType : AircraftConfigType.None));
            CreateMap<FlightSchedule, CargoBookingSummaryDetailVM>()
               .ForMember(d => d.AircraftSubType, o => o.MapFrom(s => s.Aircraft != null ? s.Aircraft.AircraftSubType : AircraftSubTypes.None))
               .ForMember(d => d.AircraftType, o => o.MapFrom(s => s.Aircraft != null ? s.Aircraft.AircraftType : AircraftTypes.None))
               .ForMember(d => d.AircraftConfigurationType, o => o.MapFrom(s => s.Aircraft != null ? s.Aircraft.ConfigurationType : AircraftConfigType.None));
            CreateMap<WarehouseCreateRM, Warehouse>();
            CreateMap<WarehouseUpdateRM, Warehouse>();
            CreateMap<Warehouse, WarehouseVM>();

            CreateMap<CargoAgentCreateRM,CargoAgent>();
            CreateMap<CargoAgentCreateRM, AppUser>()
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.PrimaryTelephoneNumber));

            CreateMap<CargoAgentUpdateRM,CargoAgent>();

            CreateMap<CargoAgent, CargoAgentVM>()
                .ForMember(d => d.CountryName, o => o.MapFrom(s => s.Country.Name))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.AppUser.Email))
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.AppUser.UserName));

            CreateMap<CargoBooking, CargoBookingVM>()
                .ForMember(d => d.DestinationAirportCode, o => o.MapFrom(s => s.FlightScheduleSector.DestinationAirportCode))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.FlightScheduleSector.FlightNumber))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.FlightScheduleSector.ScheduledDepartureDateTime))
                .ForMember(d => d.NumberOfBoxes, o => o.MapFrom(s => s.PackageItems.Count))
                .ForMember(d => d.TotalWeight, o => o.MapFrom(s => s.PackageItems.Sum(x=>x.Weight)));

            CreateMap<CargoBookingRM, CargoBooking>();

            CreateMap<ULDContainerDto, ULDContainer>();
            CreateMap<ULDContainerUpdateRM, ULDContainer>();
            CreateMap<ULDDto, ULD>();
            CreateMap<LoadPlanDto, LoadPlan>();
            CreateMap<ULDMetaDataDto, ULDMetaData>();
            CreateMap<ULDMetaDataDto, ULDMetaData>();
            CreateMap<PackageContainer, PackageContainerVM>().ReverseMap();

            CreateMap<CargoBooking, CargoBookingDetailVM>();
            CreateMap<PackageItem, PackageItemVM>();

            CreateMap<CargoBooking, CargoBookingLookupVM>();

            CreateMap<PackageContainerSector, RateVM>()
               .ForMember(d => d.Width, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.Width : 0))
               .ForMember(d => d.Height, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.Height : 0))
               .ForMember(d => d.Length, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.Length : 0))
               .ForMember(d => d.PackageContainerType, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.PackageContainerType : 0))
               .ForMember(d => d.PackageBoxType, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.PackageBoxType : 0))
               .ForMember(d => d.MaxWaight, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.MaxWaight : 0));

            CreateMap<Unit, BaseSelectListModel>()
                .ForMember(d => d.Value, o => o.MapFrom(s => s.Name));
            CreateMap<Unit, UnitDto>();   

            CreateMap<PackageItem, PackageListItemVM>()
                .ForMember(d => d.BookingStatus, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.BookingStatus : 0))
                .ForMember(d => d.BookingDate, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.BookingDate : DateTime.MinValue))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.FlightScheduleSector.FlightNumber : ""));

            CreateMap<PackageItemCreateRM, PackageItem>(); 
            CreateMap<Seat, SeatDto>().ReverseMap();

            CreateMap<AWBCreateRM, AWBInformation>();

            CreateMap<AWBInformation, AWBInformationVM>();

            CreateMap<PackageItem, PackageItemMobileVM>()
                .ForMember(d => d.WeightUnit, o => o.MapFrom(s => s.WeightUnit != null ? s.WeightUnit.Name : ""))
                .ForMember(d => d.VolumeUnit, o => o.MapFrom(s => s.VolumeUnit != null ? s.VolumeUnit.Name : ""))
                .ForMember(d => d.BookingRefNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.BookingNumber : ""))
                .ForMember(d => d.FlightDate, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.FlightScheduleSector.ScheduledDepartureDateTime : DateTime.MinValue))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.FlightScheduleSector.FlightNumber : ""))
                .ForMember(d => d.AwbTrackingNumber, o=> o.MapFrom(s => s.CargoBooking != null? s.CargoBooking.AWBInformation.AwbTrackingNumber:0))
                .ForMember(d => d.CargoPositionType, o => o.MapFrom(s => s.ULDContainer != null ? s.ULDContainer.ULDContainerCargoPositions.First().CargoPosition.CargoPositionType : 0));

            CreateMap<SeatConfiguration, SeatConfigurationDto>().ReverseMap();

            CreateMap<OverheadCompartmentDto, OverheadCompartment>();
            CreateMap<OverheadCompartment, OverheadCompartmentDto>();

            CreateMap<ULDContainerCargoPositionDto, ULDContainerCargoPosition>();

            CreateMap<AWBStackRM, AWBStack>();
            CreateMap<AWBStack, AWBStackVM>()
                .ForMember(d => d.CargoAgentName,o => o.MapFrom(s => s.CargoAgent != null? s.CargoAgent.AgentName : ""));

            CreateMap<CargoAgent, BaseSelectListModel>()
               .ForMember(d => d.Value, o => o.MapFrom(s => s.AgentName));

            CreateMap<AWBUpdateRM,AWBInformation>();

            CreateMap<PackageItemUpdateRM, PackageItem>();
            CreateMap<PackageItemVM, PackageItemUpdateRM>();

            CreateMap<Airport, AirportVM>()
                .ForMember(d => d.CountryName, o => o.MapFrom(s => s.Country != null? s.Country.Name : ""));
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
            CreateMap<ULD, ULDVM>();
            CreateMap<ULDMetaData, ULDMetaDataVM>();
            CreateMap<ULDContainerCargoPosition, ULDContainerCargoPositionVM>();
        }
    }
}
