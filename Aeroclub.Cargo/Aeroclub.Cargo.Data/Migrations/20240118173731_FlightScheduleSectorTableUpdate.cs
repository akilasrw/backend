using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class FlightScheduleSectorTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleSectors_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleSectors");

            migrationBuilder.AlterColumn<Guid>(
                name: "AircraftSubTypeId",
                table: "FlightScheduleSectors",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "67ffde89-c30a-4680-8c24-d5950725cd40");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "4a63f21a-3871-4258-909a-a55efffb0a3d");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleSectors_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleSectors",
                column: "AircraftSubTypeId",
                principalTable: "AircraftSubTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleSectors_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleSectors");

            migrationBuilder.AlterColumn<Guid>(
                name: "AircraftSubTypeId",
                table: "FlightScheduleSectors",
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
                value: "336a9535-85cd-43f2-9593-c14f1bca47a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "e99ff589-ace1-4f2f-9c41-178745c90e5c");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleSectors_AircraftSubTypes_AircraftSubTypeId",
                table: "FlightScheduleSectors",
                column: "AircraftSubTypeId",
                principalTable: "AircraftSubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
