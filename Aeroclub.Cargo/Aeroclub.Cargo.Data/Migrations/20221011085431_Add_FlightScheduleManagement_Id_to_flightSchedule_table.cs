using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_FlightScheduleManagement_Id_to_flightSchedule_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FlightScheduleManagementId",
                table: "FlightSchedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "e1eafdf0-8680-4145-ae6c-cdb257135a2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "68b32082-6e10-4e4d-9cfa-07e348a546cc");

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_FlightScheduleManagementId",
                table: "FlightSchedules",
                column: "FlightScheduleManagementId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedules_FlightScheduleManagements_FlightScheduleManagementId",
                table: "FlightSchedules",
                column: "FlightScheduleManagementId",
                principalTable: "FlightScheduleManagements",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedules_FlightScheduleManagements_FlightScheduleManagementId",
                table: "FlightSchedules");

            migrationBuilder.DropIndex(
                name: "IX_FlightSchedules_FlightScheduleManagementId",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "FlightScheduleManagementId",
                table: "FlightSchedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "444b8b30-e009-4416-967f-d3571b9df529");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "a2e3612b-d417-4477-9cd6-0ad3ca27fe5c");
        }
    }
}
