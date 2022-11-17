using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_BlockTime_To_FlightSector_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DestinationBlockTimeHrs",
                table: "FlightSectors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OriginBlockTimeHrs",
                table: "FlightSectors",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "824e0cf1-e65f-436d-b554-69e22b57ce93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "d3644df7-c0bf-4aaa-bbdd-458d3de616d0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationBlockTimeHrs",
                table: "FlightSectors");

            migrationBuilder.DropColumn(
                name: "OriginBlockTimeHrs",
                table: "FlightSectors");

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
        }
    }
}
