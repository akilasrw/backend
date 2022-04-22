using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Changed_Order_Of_ZoneArea_And_Cabin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoPositions_CabinAreas_CabinAreaId",
                table: "CargoPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_CabinAreas_CabinAreaId",
                table: "Seats");

            migrationBuilder.DropTable(
                name: "CabinAreas");

            migrationBuilder.DropTable(
                name: "AircraftZones");

            migrationBuilder.RenameColumn(
                name: "CabinAreaId",
                table: "Seats",
                newName: "ZoneAreaId");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_CabinAreaId",
                table: "Seats",
                newName: "IX_Seats_ZoneAreaId");

            migrationBuilder.RenameColumn(
                name: "CabinAreaId",
                table: "CargoPositions",
                newName: "ZoneAreaId");

            migrationBuilder.RenameIndex(
                name: "IX_CargoPositions_CabinAreaId",
                table: "CargoPositions",
                newName: "IX_CargoPositions_ZoneAreaId");

            migrationBuilder.AddColumn<Guid>(
                name: "SeatId",
                table: "CargoPositions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AircraftCabins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    AircraftDeckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxWeight = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftCabins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftCabins_AircraftDecks_AircraftDeckId",
                        column: x => x.AircraftDeckId,
                        principalTable: "AircraftDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZoneAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    AircraftCabinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxWeight = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZoneAreas_AircraftCabins_AircraftCabinId",
                        column: x => x.AircraftCabinId,
                        principalTable: "AircraftCabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoPositions_SeatId",
                table: "CargoPositions",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftCabins_AircraftDeckId",
                table: "AircraftCabins",
                column: "AircraftDeckId");

            migrationBuilder.CreateIndex(
                name: "IX_ZoneAreas_AircraftCabinId",
                table: "ZoneAreas",
                column: "AircraftCabinId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoPositions_Seats_SeatId",
                table: "CargoPositions",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoPositions_ZoneAreas_ZoneAreaId",
                table: "CargoPositions",
                column: "ZoneAreaId",
                principalTable: "ZoneAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_ZoneAreas_ZoneAreaId",
                table: "Seats",
                column: "ZoneAreaId",
                principalTable: "ZoneAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoPositions_Seats_SeatId",
                table: "CargoPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_CargoPositions_ZoneAreas_ZoneAreaId",
                table: "CargoPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_ZoneAreas_ZoneAreaId",
                table: "Seats");

            migrationBuilder.DropTable(
                name: "ZoneAreas");

            migrationBuilder.DropTable(
                name: "AircraftCabins");

            migrationBuilder.DropIndex(
                name: "IX_CargoPositions_SeatId",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "CargoPositions");

            migrationBuilder.RenameColumn(
                name: "ZoneAreaId",
                table: "Seats",
                newName: "CabinAreaId");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_ZoneAreaId",
                table: "Seats",
                newName: "IX_Seats_CabinAreaId");

            migrationBuilder.RenameColumn(
                name: "ZoneAreaId",
                table: "CargoPositions",
                newName: "CabinAreaId");

            migrationBuilder.RenameIndex(
                name: "IX_CargoPositions_ZoneAreaId",
                table: "CargoPositions",
                newName: "IX_CargoPositions_CabinAreaId");

            migrationBuilder.CreateTable(
                name: "AircraftZones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AircraftDeckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxWeight = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftZones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftZones_AircraftDecks_AircraftDeckId",
                        column: x => x.AircraftDeckId,
                        principalTable: "AircraftDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CabinAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AircraftZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxWeight = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabinAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CabinAreas_AircraftZones_AircraftZoneId",
                        column: x => x.AircraftZoneId,
                        principalTable: "AircraftZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AircraftZones_AircraftDeckId",
                table: "AircraftZones",
                column: "AircraftDeckId");

            migrationBuilder.CreateIndex(
                name: "IX_CabinAreas_AircraftZoneId",
                table: "CabinAreas",
                column: "AircraftZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoPositions_CabinAreas_CabinAreaId",
                table: "CargoPositions",
                column: "CabinAreaId",
                principalTable: "CabinAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_CabinAreas_CabinAreaId",
                table: "Seats",
                column: "CabinAreaId",
                principalTable: "CabinAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
