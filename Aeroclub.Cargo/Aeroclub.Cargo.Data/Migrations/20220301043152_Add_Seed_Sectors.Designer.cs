﻿// <auto-generated />
using System;
using Aeroclub.Cargo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    [DbContext(typeof(CargoContext))]
    [Migration("20220301043152_Add_Seed_Sectors")]
    partial class Add_Seed_Sectors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Aircraft", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AircraftLayoutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("AircraftType")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RegNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("AircraftLayoutId");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.AircraftLayout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AircraftLayouts");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Airport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Lon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"),
                            Code = "YYC",
                            CountryId = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Lat = 0m,
                            Lon = 0m,
                            Name = "Calgary International Airport"
                        },
                        new
                        {
                            Id = new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"),
                            Code = "YEG",
                            CountryId = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Lat = 0m,
                            Lon = 0m,
                            Name = "Edmonton International Airport"
                        },
                        new
                        {
                            Id = new Guid("dd784758-7438-41bf-8a8a-c9f79b03ffff"),
                            Code = "YFC",
                            CountryId = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Lat = 0m,
                            Lon = 0m,
                            Name = "Fredericton International Airport"
                        },
                        new
                        {
                            Id = new Guid("c2ac04ca-db7d-4138-8416-bbdc9236a751"),
                            Code = "YQX",
                            CountryId = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Lat = 0m,
                            Lon = 0m,
                            Name = "Gander International Airport"
                        },
                        new
                        {
                            Id = new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"),
                            Code = "YHZ",
                            CountryId = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Lat = 0m,
                            Lon = 0m,
                            Name = "Halifax Stanfield International Airport"
                        },
                        new
                        {
                            Id = new Guid("827791b4-c923-49b5-8426-e0c0a6a4c96a"),
                            Code = "YQM",
                            CountryId = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Lat = 0m,
                            Lon = 0m,
                            Name = "Greater Moncton Roméo LeBlanc International Airport"
                        },
                        new
                        {
                            Id = new Guid("95ea7820-ceed-4311-82fd-557e2d1ed436"),
                            Code = "YUL",
                            CountryId = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Lat = 0m,
                            Lon = 0m,
                            Name = "Montréal–Trudeau International Airport"
                        });
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe48de72-11bf-463f-8272-6bcb1f7f99e8"),
                            Code = "LKA",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Sri Lanka"
                        },
                        new
                        {
                            Id = new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"),
                            Code = "CAN",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Canada"
                        },
                        new
                        {
                            Id = new Guid("a98700dd-b40a-49b7-a00e-3cd96f2ca75d"),
                            Code = "IND",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "India"
                        });
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Flight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DestinationAirportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OriginAirportId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.FlightSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ActualDepartureDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("AircraftId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AircraftRegNo")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinationAirportCode")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<Guid>("DestinationAirportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinationAirportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<Guid?>("FlightId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FlightNumber")
                        .HasColumnType("varchar(10)");

                    b.Property<byte>("FlightScheduleStatus")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OriginAirportCode")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<Guid>("OriginAirportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OriginAirportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("ScheduledDepartureDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AircraftId");

                    b.HasIndex("DestinationAirportId");

                    b.HasIndex("OriginAirportId");

                    b.ToTable("FlightSchedules");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.FlightSector", b =>
                {
                    b.Property<Guid>("FlightId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Sequence")
                        .HasColumnType("tinyint");

                    b.HasKey("FlightId", "SectorId");

                    b.HasIndex("SectorId");

                    b.ToTable("FlightSectors");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Sector", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinationAirportCode")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<Guid>("DestinationAirportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinationAirportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OriginAirportCode")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<Guid>("OriginAirportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OriginAirportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<byte>("SectorType")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Sectors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8ae55489-4677-411a-802e-b74f5885f893"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            DestinationAirportCode = "YEG",
                            DestinationAirportId = new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"),
                            DestinationAirportName = "Edmonton International Airport",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginAirportCode = "YYC",
                            OriginAirportId = new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"),
                            OriginAirportName = "Calgary International Airport",
                            SectorType = (byte)1
                        },
                        new
                        {
                            Id = new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            DestinationAirportCode = "YYC",
                            DestinationAirportId = new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"),
                            DestinationAirportName = "Calgary International Airport",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginAirportCode = "YEG",
                            OriginAirportId = new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"),
                            OriginAirportName = "Edmonton International Airport",
                            SectorType = (byte)1
                        },
                        new
                        {
                            Id = new Guid("826b781d-8682-492b-8777-be5562e203b1"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            DestinationAirportCode = "YHZ",
                            DestinationAirportId = new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"),
                            DestinationAirportName = "Halifax Stanfield International Airport",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginAirportCode = "YEG",
                            OriginAirportId = new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"),
                            OriginAirportName = "Edmonton International Airport",
                            SectorType = (byte)1
                        },
                        new
                        {
                            Id = new Guid("e35fe0fc-6e76-405b-8abb-a8eadc228795"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            DestinationAirportCode = "YEG",
                            DestinationAirportId = new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"),
                            DestinationAirportName = "Edmonton International Airport",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginAirportCode = "YHZ",
                            OriginAirportId = new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"),
                            OriginAirportName = "Halifax Stanfield International Airport",
                            SectorType = (byte)1
                        });
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Aircraft", b =>
                {
                    b.HasOne("Aeroclub.Cargo.Core.Entities.AircraftLayout", "AircraftLayout")
                        .WithMany()
                        .HasForeignKey("AircraftLayoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AircraftLayout");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Airport", b =>
                {
                    b.HasOne("Aeroclub.Cargo.Core.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.FlightSchedule", b =>
                {
                    b.HasOne("Aeroclub.Cargo.Core.Entities.Aircraft", "Aircraft")
                        .WithMany()
                        .HasForeignKey("AircraftId");

                    b.HasOne("Aeroclub.Cargo.Core.Entities.Airport", "DestinationAirport")
                        .WithMany()
                        .HasForeignKey("DestinationAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aeroclub.Cargo.Core.Entities.Airport", "OriginAirport")
                        .WithMany()
                        .HasForeignKey("OriginAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aircraft");

                    b.Navigation("DestinationAirport");

                    b.Navigation("OriginAirport");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.FlightSector", b =>
                {
                    b.HasOne("Aeroclub.Cargo.Core.Entities.Flight", "Flight")
                        .WithMany("FlightSectors")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aeroclub.Cargo.Core.Entities.Sector", "Sector")
                        .WithMany("FlightSectors")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.User", b =>
                {
                    b.OwnsMany("Aeroclub.Cargo.Core.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime2");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime2");

                            b1.Property<string>("ReasonRevoked")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime2");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Token")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("UserId")
                                .HasColumnType("int");

                            b1.HasKey("Id");

                            b1.HasIndex("UserId");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Flight", b =>
                {
                    b.Navigation("FlightSectors");
                });

            modelBuilder.Entity("Aeroclub.Cargo.Core.Entities.Sector", b =>
                {
                    b.Navigation("FlightSectors");
                });
#pragma warning restore 612, 618
        }
    }
}
