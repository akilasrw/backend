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

namespace Aeroclub.Cargo.Application.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterRequestRM, AppUser>();
            CreateMap<Airport, BaseSelectListModel>()
                .ForMember(x => x.Value, x => x.MapFrom(c => c.Code));
            CreateMap<Country, BaseSelectListModel>()
                .ForMember(x => x.Value, x => x.MapFrom(c => c.Name));
            CreateMap<Sector, SectorDto>().ReverseMap();
            CreateMap<Currency, BaseSelectListModel>()
               .ForMember(x => x.Value, x => x.MapFrom(c => c.Code));
            CreateMap<Flight, FlightVM>();
            CreateMap<FlightScheduleUpdateRM, FlightSchedule>();
            CreateMap<FlightScheduleCreateRM, FlightSchedule>();
            CreateMap<FlightScheduleSectorCreateRM, FlightScheduleSector>();
            CreateMap<FlightScheduleSector, FlightScheduleSectorVM>()
                .ForMember(d => d.AircraftLayoutId, o => o.MapFrom(s=> s.LoadPlan != null? s.LoadPlan.AircraftLayoutId: Guid.Empty));
            CreateMap<FlightSchedule, FlightScheduleVM>();
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
            CreateMap<ULDDto, ULD>();
            CreateMap<LoadPlanDto, LoadPlan>();
            CreateMap<ULDMetaDataDto, ULDMetaData>();
            CreateMap<ULDMetaDataDto, ULDMetaData>();
            CreateMap<PackageContainer, PackageContainerVM>().ReverseMap();


            CreateMap<CargoBooking, CargoBookingDetailVM>()
               .ForMember(d => d.FlightScheduleSector, o => o.MapFrom(s => s.FlightScheduleSector))
               .ForMember(d => d.PackageItems, o => o.MapFrom(s => s.PackageItems));

            CreateMap<CargoBooking, CargoBookingLookupVM>()
               .ForMember(d => d.FlightScheduleSector, o => o.MapFrom(s => s.FlightScheduleSector))
               .ForMember(d => d.PackageItems, o => o.MapFrom(s => s.PackageItems));

            CreateMap<PackageContainerSector, RateVM>()
               .ForMember(d => d.Width, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.Width : 0))
               .ForMember(d => d.Height, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.Height : 0))
               .ForMember(d => d.Length, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.Length : 0))
               .ForMember(d => d.PackageContainerType, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.PackageContainerType : 0))
               .ForMember(d => d.PackageBoxType, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.PackageBoxType : 0))
               .ForMember(d => d.MaxWaight, o => o.MapFrom(s => s.PackageContainer != null ? s.PackageContainer.MaxWaight : 0));

            CreateMap<Unit, BaseSelectListModel>()
                .ForMember(d => d.Value, o => o.MapFrom(s => s.Name));

            CreateMap<PackageItem, PackageListItemVM>()
                .ForMember(d => d.BookingStatus, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.BookingStatus : 0))
                .ForMember(d => d.BookingDate, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.BookingDate : DateTime.MinValue))
                .ForMember(d => d.FlightNumber, o => o.MapFrom(s => s.CargoBooking != null ? s.CargoBooking.FlightScheduleSector.FlightNumber : ""));

            CreateMap<PackageItemRM, PackageItem>(); 
            CreateMap<Seat, SeatDto>().ReverseMap(); 

        }
    }
}
