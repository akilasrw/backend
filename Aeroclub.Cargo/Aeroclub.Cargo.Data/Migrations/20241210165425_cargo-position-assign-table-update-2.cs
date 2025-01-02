using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class cargopositionassigntableupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "ULDCargoPositions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "b87ab0a5-1362-4680-b8f3-53be3845eaef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "0f9d6e9a-7e46-47a8-b795-dfb119cc473c");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
