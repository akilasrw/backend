using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Arranged_Package_Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleSectors_LoadPlanId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "AwbTrackingNumber",
                table: "CargoBookings");

            migrationBuilder.AddColumn<string>(
                name: "AwbTrackingNumber",
                table: "PackageItems",
                type: "varchar(40)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ULDContainerId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FlightScheduleSectorId",
                table: "CargoBookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_ULDContainerId",
                table: "PackageItems",
                column: "ULDContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_LoadPlanId",
                table: "FlightScheduleSectors",
                column: "LoadPlanId",
                unique: true,
                filter: "[LoadPlanId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CargoBookings_FlightScheduleSectorId",
                table: "CargoBookings",
                column: "FlightScheduleSectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoBookings_FlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookings",
                column: "FlightScheduleSectorId",
                principalTable: "FlightScheduleSectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_ULDContainers_ULDContainerId",
                table: "PackageItems",
                column: "ULDContainerId",
                principalTable: "ULDContainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoBookings_FlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_ULDContainers_ULDContainerId",
                table: "PackageItems");

            migrationBuilder.DropIndex(
                name: "IX_PackageItems_ULDContainerId",
                table: "PackageItems");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleSectors_LoadPlanId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropIndex(
                name: "IX_CargoBookings_FlightScheduleSectorId",
                table: "CargoBookings");

            migrationBuilder.DropColumn(
                name: "AwbTrackingNumber",
                table: "PackageItems");

            migrationBuilder.DropColumn(
                name: "ULDContainerId",
                table: "PackageItems");

            migrationBuilder.DropColumn(
                name: "FlightScheduleSectorId",
                table: "CargoBookings");

            migrationBuilder.AddColumn<string>(
                name: "AwbTrackingNumber",
                table: "CargoBookings",
                type: "varchar(40)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_LoadPlanId",
                table: "FlightScheduleSectors",
                column: "LoadPlanId");
        }
    }
}
