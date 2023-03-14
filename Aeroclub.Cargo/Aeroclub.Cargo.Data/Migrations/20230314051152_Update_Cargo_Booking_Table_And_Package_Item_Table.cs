using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Cargo_Booking_Table_And_Package_Item_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_CargoBookings_FlightScheduleSectorId",
                table: "CargoBookings");

            migrationBuilder.DropColumn(
                name: "ULDContainerId",
                table: "PackageItems");

            migrationBuilder.DropColumn(
                name: "FlightScheduleSectorId",
                table: "CargoBookings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "3b591ad9-99c7-4001-a9a5-6ab2af33a964");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "cbc7eebd-d1af-415c-9561-2d0eb75f3500");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ULDContainerId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FlightScheduleSectorId",
                table: "CargoBookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "2d29d7cd-9b79-41ab-a56d-b5b890075da1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "b9e0c37b-7c94-4147-848d-b97f667cec0a");

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_ULDContainerId",
                table: "PackageItems",
                column: "ULDContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoBookings_FlightScheduleSectorId",
                table: "CargoBookings",
                column: "FlightScheduleSectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoBookings_FlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookings",
                column: "FlightScheduleSectorId",
                principalTable: "FlightScheduleSectors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_ULDContainers_ULDContainerId",
                table: "PackageItems",
                column: "ULDContainerId",
                principalTable: "ULDContainers",
                principalColumn: "Id");
        }
    }
}
