﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Aeroclub.Cargo.Core.Entities.Core;
using Aeroclub.Cargo.Data.Extensions;
using Aeroclub.Cargo.Data.Extensions.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Aeroclub.Cargo.Data
{
    public class CargoContext : IdentityDbContext<AppUser, AppRole, Guid,
        IdentityUserClaim<Guid>, AppUserRole, IdentityUserLogin<Guid>,
        IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public CargoContext(DbContextOptions<CargoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new AirportConfiguration());
            modelBuilder.ApplyConfiguration(new FlightSectorConfiguration());
            modelBuilder.ApplyConfiguration(new AircraftConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new FlightScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new SectorConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new LoadPlanConfiguration());
            modelBuilder.ApplyConfiguration(new ULDConfiguration());
            modelBuilder.ApplyConfiguration(new AircraftDeckConfiguration());
            modelBuilder.ApplyConfiguration(new CargoPositionConfiguration());
            modelBuilder.ApplyConfiguration(new AircraftCabinConfiguration());
            modelBuilder.ApplyConfiguration(new ZoneAreaConfiguration());
            modelBuilder.ApplyConfiguration(new CargoPositionConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new CargoBookingConfiguration());
            modelBuilder.ApplyConfiguration(new PackageItemConfiguration());
            modelBuilder.ApplyConfiguration(new FlightScheduleSectorConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfigurationConfiguration());
            modelBuilder.ApplyConfiguration(new SeatEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CargoAgentConfiguration());
            modelBuilder.ApplyConfiguration(new PackageContainerSectorConfiguration());
            modelBuilder.ApplyConfiguration(new AWBProductConfiguration());
            modelBuilder.ApplyConfiguration(new AWBInformationConfigration());
            modelBuilder.ApplyConfiguration(new OverheadPositionConfiguration());
            modelBuilder.ApplyConfiguration(new ULDContainerCargoPositionConfiguration());
            modelBuilder.ApplyConfiguration(new AWBStackConfiguration());
            
            
            
            var location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (location == null) return;
            var basePath = Path.Combine(location, @"SeedData");
            SeedExtension.Execute(modelBuilder, basePath);
        }

        public DbSet<AppUser> AppUsers { get; set; } = null!;
        public DbSet<AppRole> AppRoles { get; set; } = null!;
        public DbSet<AppUserRole> AppUserRoles { get; set; } = null!;
        public DbSet<Aircraft> Aircrafts { get; set; } = null!;
        public DbSet<AircraftLayout> AircraftLayouts { get; set; } = null!;
        public DbSet<Airport> Airports { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Sector> Sectors { get; set; } = null!;
        public DbSet<Flight> Flights { get; set; } = null!;
        public DbSet<FlightSector> FlightSectors { get; set; } = null!;
        public DbSet<FlightSchedule> FlightSchedules { get; set; } = null!;
        public DbSet<Currency> Currencies { get; set; } = null!;
        public DbSet<LoadPlan> LoadPlans { get; set; } = null!;
        public DbSet<ULD> ULDs { get; set; } = null!;
        public DbSet<ULDMetaData> ULDMetaDatas { get; set; } = null!;
        public DbSet<ULDContainer> ULDContainers { get; set; } = null!;
        public DbSet<AircraftDeck> AircraftDecks { get; set; } = null!;
        public DbSet<AircraftCabin> AircraftCabins { get; set; } = null!;
        public DbSet<ZoneArea> ZoneAreas { get; set; } = null!;
        public DbSet<CargoPosition> CargoPositions { get; set; } = null!;
        public DbSet<Warehouse> Warehouses { get; set; } = null!;
        public DbSet<Unit> Units { get; set; } = null!;
        public DbSet<CargoBooking> CargoBookings { get; set; } = null!;
        public DbSet<PackageItem> PackageItems { get; set; } = null!;
        public DbSet<FlightScheduleSector> FlightScheduleSectors { get; set; } = null!;
        public DbSet<SeatConfiguration> SeatConfigurations { get; set; } = null!;
        public DbSet<Seat> Seats { get; set; } = null!;
        public DbSet<SeatLayout> SeatLayouts { get; set; } = null!;
        public DbSet<CargoAgent> CargoAgents { get; set; } = null!;
        public DbSet<PackageContainer> PackageContainers { get; set; } = null!;
        public DbSet<PackageContainerSector> PackageContainerSectors { get; set; } = null!;
        public DbSet<AWBProduct> AWBProducts { get; set; } = null!;
        public DbSet<AWBInformation> AWBInformations { get; set; } = null!;
        public DbSet<OverheadLayout> OverheadLayouts { get; set; } = null!;
        public DbSet<OverheadCompartment> OverheadCompartments { get; set; } = null!;
        public DbSet<OverheadPosition> OverheadPositions { get; set; } = null!;
        public DbSet<ULDContainerCargoPosition> ULDContainerCargoPositions { get; set; } = null!;
        public DbSet<AWBStack> AWBStacks { get; set; } = null!;


        public async Task<int> SaveAuditableChangesAsync(Guid userid, CancellationToken cancellationToken = default)
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is AuditableEntity && x.State is EntityState.Added or EntityState.Modified);
            foreach (var entity in entities)
            {
                switch (entity.State)
                {
                    case EntityState.Modified:
                        entity.Property("Created").IsModified = false;
                        entity.Property("CreatedBy").IsModified = false;
                        ((AuditableEntity)entity.Entity).LastModified = DateTime.UtcNow;
                        ((AuditableEntity)entity.Entity).LastModifiedBy = userid;
                        break;
                    case EntityState.Added:
                        ((AuditableEntity)entity.Entity).Created = DateTime.UtcNow;
                        ((AuditableEntity)entity.Entity).CreatedBy = userid;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return await base.SaveChangesAsync(true, cancellationToken);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is AuditableEntity && x.State is EntityState.Added or EntityState.Modified);
            foreach (var entity in entities)
            {
                switch (entity.State)
                {
                    case EntityState.Modified:
                        ((AuditableEntity)entity.Entity).LastModified = DateTime.UtcNow;
                        break;
                    case EntityState.Added:
                        ((AuditableEntity)entity.Entity).Created = DateTime.UtcNow;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return await base.SaveChangesAsync(true, cancellationToken);
        }
    }
}