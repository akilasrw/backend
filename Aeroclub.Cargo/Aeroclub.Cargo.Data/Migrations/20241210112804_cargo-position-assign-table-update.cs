using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class cargopositionassigntableupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FlightScheduleSectorId",
                table: "ULDCargoPositions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SectorId",
                table: "ULDCargoPositions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "3cbb58db-5805-4c64-a1db-327fb3190974");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "5ff7f1fe-1d8c-47fd-ab66-f2fe28bc3c6a");

            migrationBuilder.CreateIndex(
                name: "IX_ULDCargoPositions_FlightScheduleSectorId",
                table: "ULDCargoPositions",
                column: "FlightScheduleSectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDCargoPositions_FlightScheduleSectors_FlightScheduleSectorId",
                table: "ULDCargoPositions",
                column: "FlightScheduleSectorId",
                principalTable: "FlightScheduleSectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDCargoPositions_FlightScheduleSectors_FlightScheduleSectorId",
                table: "ULDCargoPositions");

            migrationBuilder.DropIndex(
                name: "IX_ULDCargoPositions_FlightScheduleSectorId",
                table: "ULDCargoPositions");

            migrationBuilder.DropColumn(
                name: "FlightScheduleSectorId",
                table: "ULDCargoPositions");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "ULDCargoPositions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "1db668fa-26e4-4baa-b281-835f2e955852");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "24c0beb0-5146-4b85-b01f-7622f09aa451");
        }
    }
}
