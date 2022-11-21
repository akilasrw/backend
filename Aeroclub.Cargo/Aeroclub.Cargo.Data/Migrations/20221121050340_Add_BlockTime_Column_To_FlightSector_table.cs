using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_BlockTime_Column_To_FlightSector_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DestinationBlockTimeMin",
                table: "FlightSectors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OriginBlockTimeMin",
                table: "FlightSectors",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "65389a6f-9628-464c-a10e-8576f4ac1572");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "5411f356-8486-4ef4-b15c-ac6cc784dcc7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationBlockTimeMin",
                table: "FlightSectors");

            migrationBuilder.DropColumn(
                name: "OriginBlockTimeMin",
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
