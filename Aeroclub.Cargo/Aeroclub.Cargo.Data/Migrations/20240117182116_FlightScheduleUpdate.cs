using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class FlightScheduleUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedules_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightSchedules");

            migrationBuilder.AlterColumn<Guid>(
                name: "AircraftSubTypeId",
                table: "FlightSchedules",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "336a9535-85cd-43f2-9593-c14f1bca47a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "e99ff589-ace1-4f2f-9c41-178745c90e5c");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedules_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightSchedules",
                column: "AircraftSubTypeId",
                principalTable: "AircraftSubTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedules_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightSchedules");

            migrationBuilder.AlterColumn<Guid>(
                name: "AircraftSubTypeId",
                table: "FlightSchedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "0f7336b8-4237-4789-8f07-7a5976d0d6e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "7f9c73b6-26f1-4b38-9110-681a9b0ae2ca");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedules_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightSchedules",
                column: "AircraftSubTypeId",
                principalTable: "AircraftSubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
