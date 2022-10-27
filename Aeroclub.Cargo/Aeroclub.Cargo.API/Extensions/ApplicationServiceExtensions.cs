using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Services;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Data.Services;
using Aeroclub.Cargo.Infrastructure.Authorization.Interfaces;
using Aeroclub.Cargo.Infrastructure.Authorization.Services;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Interfaces;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Services;
using Aeroclub.Cargo.Infrastructure.UserResolver.Interfaces;
using Aeroclub.Cargo.Infrastructure.UserResolver.Services;

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
            services.AddScoped<IULDCargoPositionService,ULDCargoPositionService>();
            services.AddScoped<IAWBStackService, AWBStackService>();
            services.AddScoped<IULDCargoBookingManagerService, ULDCargoBookingManagerService>();
            services.AddScoped<IULDCargoBookingService, ULDCargoBookingService>();
            services.AddScoped<ICargoBookingSummaryService, CargoBookingSummaryService>();
            services.AddScoped<IPalletService, PalletService>();
            services.AddScoped<IULDContainerCargoPositionService, ULDContainerCargoPositionService>();
            services.AddScoped<IFlightScheduleManagementService, FlightScheduleManagementService>();
            services.AddScoped<IAgentRateManagementService, AgentRateManagementService>();
            services.AddScoped<IDateGeneratorService, DateGeneratorService>();
            services.AddScoped<IMasterScheduleService, MasterScheduleService>();
            services.AddScoped<IAgentRateManagementService, AgentRateManagementService>();
            services.AddScoped<ILinkAircraftToScheduleService, LinkAircraftToScheduleService>();
            services.AddScoped<IBaseUnitConverter, BaseUnitConverter>();
            services.AddScoped<IAWBNumberStackService, AWBNumberStackService>();
            services.AddScoped<IAssignCargoToULDService, AssignCargoToULDService>();


            return services;
        }
    }
}
