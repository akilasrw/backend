using System;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Services;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Data.Services;
using Aeroclub.Cargo.Infrastructure.Authorization.Interfaces;
using Aeroclub.Cargo.Infrastructure.Authorization.Services;
using Aeroclub.Cargo.Infrastructure.UserResolver.Interfaces;
using Aeroclub.Cargo.Infrastructure.UserResolver.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Aeroclub.Cargo.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJwtUtils, JwtUtils>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ISectorService, SectorService>();
            services.AddScoped<IAirportService, AirportService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IFlightScheduleService, FlightScheduleService>();
            services.AddScoped<IAircraftService, AircraftService>();
            services.AddScoped<IWarehouseService, WarehouseService>();
            services.AddScoped<ICargoBookingService, CargoBookingService>();
            services.AddScoped<IFlightScheduleSectorService, FlightScheduleSectorService>();
            services.AddScoped<ICargoAgentService, CargoAgentService>();
            services.AddScoped<ILoadPlanService, LoadPlanService>();
            services.AddScoped<IULDContainerService, ULDContainerService>();
            services.AddScoped<IULDService, ULDService>();
            services.AddScoped<IULDMetaDataService, ULDMetaDataService>();
            services.AddScoped<IBookingManagerService, BookingManagerService>();
            services.AddScoped<IPackageContainerService, PackageContainerService>();
            services.AddScoped<IRateService, RateService>();
            services.AddScoped<IUnitService, UnitService>();
            services.AddScoped<IPackageItemService, PackageItemService>();
            services.AddScoped<ICargoPositionService, CargoPositionService>();
            services.AddScoped<ISeatService, SeatService>();
            services.AddScoped<ICargoBookingLookupService, CargoBookingLookupService>();
            services.AddScoped<ILayoutCloneService, LayoutCloneService>();
            services.AddScoped<IAWBService, AWBService>();
            services.AddScoped<IUserResolverService, UserResolverService>();
            services.AddScoped<ISeatConfigurationService, SeatConfigurationService>();
            services.AddScoped<IOverheadService, OverheadService>();
            services.AddScoped<IULDContainerCargoPositionService,ULDContainerCargoPositionService>();


            return services;
        }
    }
}
