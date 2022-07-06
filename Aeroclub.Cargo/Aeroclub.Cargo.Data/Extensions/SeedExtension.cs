using System.IO;
using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Aeroclub.Cargo.Data.Extensions
{
    public static class SeedExtension
    {
        public static void Execute(ModelBuilder modelBuilder, string basePath)
        {
            SeedCountries(modelBuilder, basePath);
            SeedAirports(modelBuilder, basePath);
            SeedSectors(modelBuilder, basePath);
            SeedFlights(modelBuilder, basePath);
            SeedCurrencies(modelBuilder, basePath);
            SeedUnits(modelBuilder, basePath);
            SeedRoles(modelBuilder, basePath);
            SeedUsers(modelBuilder, basePath);
            SeedUserRoles(modelBuilder, basePath);
            SeedAircraftLayout(modelBuilder, basePath);
            SeedAircraftDeck(modelBuilder, basePath);
            SeedAircraftCabin(modelBuilder, basePath);
            SeedZoneArea(modelBuilder, basePath);
            SeedCargoPosition(modelBuilder, basePath);
            SeedSeatConfiguration(modelBuilder, basePath);
            SeedSeat(modelBuilder, basePath);
            SeedSeatLayout(modelBuilder, basePath);
            SeedOverheadLayout(modelBuilder, basePath);
            SeedOverheadCompartment(modelBuilder, basePath);
            SeedOverheadPosition(modelBuilder, basePath);
            SeedAircraft(modelBuilder, basePath);
            SeedFlightSector(modelBuilder, basePath);
            SeedPackageContainer(modelBuilder, basePath);
            SeedPackageContainerSector(modelBuilder, basePath);
            SeedAircraftType(modelBuilder, basePath);
            SeedAircraftSubType(modelBuilder, basePath);
            SeedAircraftLayoutMapping(modelBuilder, basePath);  
            
        }

        private static void SeedCountries(ModelBuilder modelBuilder, string basePath)
        {
            var countries =
                JsonConvert.DeserializeObject<Country[]>(File.ReadAllText(Path.Combine(basePath, "Countries.json")));
            if (countries != null)
                modelBuilder.Entity<Country>().HasData(countries);
        }

        private static void SeedAirports(ModelBuilder modelBuilder, string basePath)
        {
            var airports =
                JsonConvert.DeserializeObject<Airport[]>(File.ReadAllText(Path.Combine(basePath, "Airports.json")));
            if (airports != null)
                modelBuilder.Entity<Airport>().HasData(airports);
        }

        private static void SeedSectors(ModelBuilder modelBuilder, string basePath)
        {
            var sectors =
                JsonConvert.DeserializeObject<Sector[]>(File.ReadAllText(Path.Combine(basePath, "Sectors.json")));
            if (sectors != null)
                modelBuilder.Entity<Sector>().HasData(sectors);
        }

        private static void SeedFlights(ModelBuilder modelBuilder, string basePath)
        {
            var flights =
                JsonConvert.DeserializeObject<Flight[]>(File.ReadAllText(Path.Combine(basePath, "Flights.json")));
            if (flights != null)
                modelBuilder.Entity<Flight>().HasData(flights);
        }

        private static void SeedCurrencies(ModelBuilder modelBuilder, string basePath)
        {
            var currencies =
                JsonConvert.DeserializeObject<Currency[]>(File.ReadAllText(Path.Combine(basePath, "Currencies.json")));
            if (currencies != null)
                modelBuilder.Entity<Currency>().HasData(currencies);
        }

        private static void SeedUnits(ModelBuilder modelBuilder, string basePath)
        {
            var units =
                JsonConvert.DeserializeObject<Unit[]>(File.ReadAllText(Path.Combine(basePath, "Units.json")));
            if (units != null)
                modelBuilder.Entity<Unit>().HasData(units);
        }

        private static void SeedRoles(ModelBuilder modelBuilder, string basePath)
        {
            var roles =
                JsonConvert.DeserializeObject<AppRole[]>(File.ReadAllText(Path.Combine(basePath, "Roles.json")));
            if (roles != null)
                modelBuilder.Entity<AppRole>().HasData(roles);
        }

        private static void SeedUsers(ModelBuilder modelBuilder, string basePath)
        {
            var users =
                JsonConvert.DeserializeObject<AppUser[]>(File.ReadAllText(Path.Combine(basePath, "Users.json")));
            if (users != null)
                modelBuilder.Entity<AppUser>().HasData(users);
        }

        private static void SeedUserRoles(ModelBuilder modelBuilder, string basePath)
        {
            var userRoles =
                JsonConvert.DeserializeObject<AppUserRole[]>(File.ReadAllText(Path.Combine(basePath, "UserRoles.json")));
            if (userRoles != null)
                modelBuilder.Entity<AppUserRole>().HasData(userRoles);
        }

        private static void SeedAircraftLayout(ModelBuilder modelBuilder, string basePath)
        {
            var aircraftLayout =
                JsonConvert.DeserializeObject<AircraftLayout[]>(File.ReadAllText(Path.Combine(basePath, "AircraftLayout.json")));
            if (aircraftLayout != null)
                modelBuilder.Entity<AircraftLayout>().HasData(aircraftLayout);
        }

        private static void SeedAircraftDeck(ModelBuilder modelBuilder, string basePath)
        {
            var aircraftDeck =
                JsonConvert.DeserializeObject<AircraftDeck[]>(File.ReadAllText(Path.Combine(basePath, "AircraftDeck.json")));
            if (aircraftDeck != null)
                modelBuilder.Entity<AircraftDeck>().HasData(aircraftDeck);
        }

        private static void SeedAircraftCabin(ModelBuilder modelBuilder, string basePath)
        {
            var aircraftZone =
                JsonConvert.DeserializeObject<AircraftCabin[]>(File.ReadAllText(Path.Combine(basePath, "AircraftCabin.json")));
            if (aircraftZone != null)
                modelBuilder.Entity<AircraftCabin>().HasData(aircraftZone);
        }

        private static void SeedZoneArea(ModelBuilder modelBuilder, string basePath)
        {
            var cabinArea =
                JsonConvert.DeserializeObject<ZoneArea[]>(File.ReadAllText(Path.Combine(basePath, "ZoneArea.json")));
            if (cabinArea != null)
                modelBuilder.Entity<ZoneArea>().HasData(cabinArea);
        }

        private static void SeedCargoPosition(ModelBuilder modelBuilder, string basePath)
        {
            var cargoPosition =
                JsonConvert.DeserializeObject<CargoPosition[]>(File.ReadAllText(Path.Combine(basePath, "CargoPosition.json")));
            if (cargoPosition != null)
                modelBuilder.Entity<CargoPosition>().HasData(cargoPosition);
        }

        private static void SeedSeatConfiguration(ModelBuilder modelBuilder, string basePath)
        {
            var seatConfiguration =
                JsonConvert.DeserializeObject<SeatConfiguration[]>(File.ReadAllText(Path.Combine(basePath, "SeatConfiguration.json")));
            if (seatConfiguration != null)
                modelBuilder.Entity<SeatConfiguration>().HasData(seatConfiguration);
        }

        private static void SeedSeat(ModelBuilder modelBuilder, string basePath)
        {
            var seat =
                JsonConvert.DeserializeObject<Seat[]>(File.ReadAllText(Path.Combine(basePath, "Seat.json")));
            if (seat != null)
                modelBuilder.Entity<Seat>().HasData(seat);
        }

        private static void SeedSeatLayout(ModelBuilder modelBuilder, string basePath)
        {
            var seatLayout =
                JsonConvert.DeserializeObject<SeatLayout[]>(File.ReadAllText(Path.Combine(basePath, "SeatLayout.json")));
            if (seatLayout != null)
                modelBuilder.Entity<SeatLayout>().HasData(seatLayout);
        }

        private static void SeedAircraft(ModelBuilder modelBuilder, string basePath)
        {
            var aircraft =
                JsonConvert.DeserializeObject<Aircraft[]>(File.ReadAllText(Path.Combine(basePath, "Aircraft.json")));
            if (aircraft != null)
                modelBuilder.Entity<Aircraft>().HasData(aircraft);
        }

        private static void SeedFlightSector(ModelBuilder modelBuilder, string basePath)
        {
            var flightSector =
                JsonConvert.DeserializeObject<FlightSector[]>(File.ReadAllText(Path.Combine(basePath, "FlightSector.json")));
            if (flightSector != null)
                modelBuilder.Entity<FlightSector>().HasData(flightSector);
        }

        private static void SeedPackageContainer(ModelBuilder modelBuilder, string basePath)
        {
            var packageContainer =
                JsonConvert.DeserializeObject<PackageContainer[]>(File.ReadAllText(Path.Combine(basePath, "PackageContainer.json")));
            if (packageContainer != null)
                modelBuilder.Entity<PackageContainer>().HasData(packageContainer);
        }

        private static void SeedPackageContainerSector(ModelBuilder modelBuilder, string basePath)
        {
            var packageContainerSector =
                JsonConvert.DeserializeObject<PackageContainerSector[]>(File.ReadAllText(Path.Combine(basePath, "PackageContainerSector.json")));
            if (packageContainerSector != null)
                modelBuilder.Entity<PackageContainerSector>().HasData(packageContainerSector);
        }
        private static void SeedOverheadLayout(ModelBuilder modelBuilder, string basePath)
        {
            var overheadLayout =
                JsonConvert.DeserializeObject<OverheadLayout[]>(File.ReadAllText(Path.Combine(basePath, "OverheadLayout.json")));
            if (overheadLayout != null)
                modelBuilder.Entity<OverheadLayout>().HasData(overheadLayout);
        }
        
        private static void SeedOverheadCompartment(ModelBuilder modelBuilder, string basePath)
        {
            var overhead =
                JsonConvert.DeserializeObject<OverheadCompartment[]>(File.ReadAllText(Path.Combine(basePath, "OverheadCompartment.json")));
            if (overhead != null)
                modelBuilder.Entity<OverheadCompartment>().HasData(overhead);
        }
        
        private static void SeedOverheadPosition(ModelBuilder modelBuilder, string basePath)
        {
            var overhead =
                JsonConvert.DeserializeObject<OverheadPosition[]>(File.ReadAllText(Path.Combine(basePath, "OverheadPosition.json")));
            if (overhead != null)
                modelBuilder.Entity<OverheadPosition>().HasData(overhead);
        }

        private static void SeedAircraftType(ModelBuilder modelBuilder, string basePath)
        {
            var aircraftType =
                JsonConvert.DeserializeObject<AircraftType[]>(File.ReadAllText(Path.Combine(basePath, "AircraftType.json")));
            if (aircraftType != null)
                modelBuilder.Entity<AircraftType>().HasData(aircraftType);
        }

        private static void SeedAircraftSubType(ModelBuilder modelBuilder, string basePath)
        {
            var aircraftSubType =
                JsonConvert.DeserializeObject<AircraftSubType[]>(File.ReadAllText(Path.Combine(basePath, "AircraftSubType.json")));
            if (aircraftSubType != null)
                modelBuilder.Entity<AircraftSubType>().HasData(aircraftSubType);
        }

        private static void SeedAircraftLayoutMapping(ModelBuilder modelBuilder, string basePath)
        {
            var aircraftLayoutMapping =
                JsonConvert.DeserializeObject<AircraftLayoutMapping[]>(File.ReadAllText(Path.Combine(basePath, "AircraftLayoutMapping.json")));
            if (aircraftLayoutMapping != null)
                modelBuilder.Entity<AircraftLayoutMapping>().HasData(aircraftLayoutMapping);
        }

    }
}