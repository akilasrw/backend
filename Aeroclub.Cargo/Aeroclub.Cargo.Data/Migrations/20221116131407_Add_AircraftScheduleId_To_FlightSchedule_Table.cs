using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_AircraftScheduleId_To_FlightSchedule_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AircraftScheduleId",
                table: "FlightSchedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "5f3111bf-6c82-4bd1-85a9-dc45c6ac1c27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "b35adbb7-8bea-4c88-83d0-f5ba252b788c");

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_AircraftScheduleId",
                table: "FlightSchedules",
                column: "AircraftScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedules_AircraftSchedules_AircraftScheduleId",
                table: "FlightSchedules",
                column: "AircraftScheduleId",
                principalTable: "AircraftSchedules",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedules_AircraftSchedules_AircraftScheduleId",
                table: "FlightSchedules");

            migrationBuilder.DropIndex(
                name: "IX_FlightSchedules_AircraftScheduleId",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "AircraftScheduleId",
                table: "FlightSchedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "971c0d14-0039-46a8-ac9b-8804e4e98f09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "fccc8bf7-adc1-4088-baee-9b6d164d5126");
        }
    }
}
