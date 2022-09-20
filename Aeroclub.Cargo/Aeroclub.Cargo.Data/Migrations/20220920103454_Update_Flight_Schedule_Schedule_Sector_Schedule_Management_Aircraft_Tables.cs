using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Flight_Schedule_Schedule_Sector_Schedule_Management_Aircraft_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AircraftLayouts_AircraftLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleManagements_Aircrafts_AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleManagements_Flights_FlightId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleManagements_AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_AircraftLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropColumn(
                name: "AircraftLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.AddColumn<Guid>(
                name: "AircraftSubTypeId",
                table: "FlightScheduleSectors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AircraftSubTypeId",
                table: "FlightSchedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "FlightId",
                table: "FlightScheduleManagements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AircraftSubTypeId",
                table: "FlightScheduleManagements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "af894c85-df82-44a3-a76e-ac45846e5855");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "192d3857-2cf2-4c0a-a016-8afaf2d5807a");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_AircraftSubTypeId",
                table: "FlightScheduleSectors",
                column: "AircraftSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_AircraftSubTypeId",
                table: "FlightSchedules",
                column: "AircraftSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleManagements_AircraftSubTypeId",
                table: "FlightScheduleManagements",
                column: "AircraftSubTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleManagements_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleManagements",
                column: "AircraftSubTypeId",
                principalTable: "AircraftSubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleManagements_Flights_FlightId",
                table: "FlightScheduleManagements",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedules_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightSchedules",
                column: "AircraftSubTypeId",
                principalTable: "AircraftSubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleSectors_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleSectors",
                column: "AircraftSubTypeId",
                principalTable: "AircraftSubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleManagements_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleManagements_Flights_FlightId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedules_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleSectors_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleSectors_AircraftSubTypeId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropIndex(
                name: "IX_FlightSchedules_AircraftSubTypeId",
                table: "FlightSchedules");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleManagements_AircraftSubTypeId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropColumn(
                name: "AircraftSubTypeId",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "AircraftSubTypeId",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "AircraftSubTypeId",
                table: "FlightScheduleManagements");

            migrationBuilder.AlterColumn<Guid>(
                name: "FlightId",
                table: "FlightScheduleManagements",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "AircraftId",
                table: "FlightScheduleManagements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AircraftLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OverheadLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SeatLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "f6afed43-f3ab-4b17-85c9-a4f7bcec5cbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "1789761b-d6d0-4297-b195-1b1af8a7afe3");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleManagements_AircraftId",
                table: "FlightScheduleManagements",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AircraftLayoutId",
                table: "Aircrafts",
                column: "AircraftLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AircraftLayouts_AircraftLayoutId",
                table: "Aircrafts",
                column: "AircraftLayoutId",
                principalTable: "AircraftLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleManagements_Aircrafts_AircraftId",
                table: "FlightScheduleManagements",
                column: "AircraftId",
                principalTable: "Aircrafts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleManagements_Flights_FlightId",
                table: "FlightScheduleManagements",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id");
        }
    }
}
