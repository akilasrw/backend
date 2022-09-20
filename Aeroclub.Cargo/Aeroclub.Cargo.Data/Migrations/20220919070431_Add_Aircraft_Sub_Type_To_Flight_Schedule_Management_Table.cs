using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Aircraft_Sub_Type_To_Flight_Schedule_Management_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleManagements_Aircrafts_AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleManagements_AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropColumn(
                name: "AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.AddColumn<short>(
                name: "AircraftSubType",
                table: "FlightScheduleManagements",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "cd23ddef-4890-44b7-8a00-8e5455b8014e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "586bd2e8-ebc5-4607-a77e-ff7330919f3e");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AircraftSubType",
                table: "FlightScheduleManagements");

            migrationBuilder.AddColumn<Guid>(
                name: "AircraftId",
                table: "FlightScheduleManagements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "83447383-b720-44e0-85ea-562eb6203210");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "4a51b3d4-77e5-432d-97bc-14e4b6300c27");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleManagements_AircraftId",
                table: "FlightScheduleManagements",
                column: "AircraftId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleManagements_Aircrafts_AircraftId",
                table: "FlightScheduleManagements",
                column: "AircraftId",
                principalTable: "Aircrafts",
                principalColumn: "Id");
        }
    }
}
