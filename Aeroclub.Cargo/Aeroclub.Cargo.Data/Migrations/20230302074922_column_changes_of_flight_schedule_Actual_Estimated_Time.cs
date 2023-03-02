using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class column_changes_of_flight_schedule_Actual_Estimated_Time : Migration
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

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualArrivalDateTime",
                table: "FlightScheduleSectors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedArrivalDateTime",
                table: "FlightScheduleSectors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedDepartureDateTime",
                table: "FlightScheduleSectors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualArrivalDateTime",
                table: "FlightSchedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedArrivalDateTime",
                table: "FlightSchedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedDepartureDateTime",
                table: "FlightSchedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightScheduleOrderStatus",
                table: "FlightSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDispatched",
                table: "FlightSchedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHistory",
                table: "FlightSchedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VerifyStatus",
                table: "CargoBookings",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "772fe11f-ce41-4494-a75a-87c5fd7d03c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "9911bc80-d927-42ce-be1c-747440355be1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualArrivalDateTime",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "EstimatedArrivalDateTime",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "EstimatedDepartureDateTime",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "ActualArrivalDateTime",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "EstimatedArrivalDateTime",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "EstimatedDepartureDateTime",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "FlightScheduleOrderStatus",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "IsDispatched",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "IsHistory",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "VerifyStatus",
                table: "CargoBookings");

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
