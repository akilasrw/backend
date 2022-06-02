using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Seat_Seed_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "32814d72-ac3d-485f-a6df-15d39b955575");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "5d4376e5-9fa4-44d4-ae54-0bc23be825cd");

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3bc1fda-0862-4b08-8e6c-4adce141d305"),
                column: "SeatNumber",
                value: "2E");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "4ddd965a-08c5-41bf-9f4f-6acba59fd6ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "4722e9b8-626b-4886-8244-fdc85476af6e");

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3bc1fda-0862-4b08-8e6c-4adce141d305"),
                column: "SeatNumber",
                value: "1E");
        }
    }
}
