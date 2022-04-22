using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Table_MaxWeaight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AircraftId",
                table: "FlightScheduleSectors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LoadPlanId",
                table: "FlightScheduleSectors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaxWeight",
                table: "CargoPositions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxWeight",
                table: "AircraftZones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_AircraftId",
                table: "FlightScheduleSectors",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_LoadPlanId",
                table: "FlightScheduleSectors",
                column: "LoadPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleSectors_Aircrafts_AircraftId",
                table: "FlightScheduleSectors",
                column: "AircraftId",
                principalTable: "Aircrafts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleSectors_LoadPlans_LoadPlanId",
                table: "FlightScheduleSectors",
                column: "LoadPlanId",
                principalTable: "LoadPlans",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleSectors_Aircrafts_AircraftId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleSectors_LoadPlans_LoadPlanId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleSectors_AircraftId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleSectors_LoadPlanId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "AircraftId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "LoadPlanId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "AircraftZones");
        }
    }
}
