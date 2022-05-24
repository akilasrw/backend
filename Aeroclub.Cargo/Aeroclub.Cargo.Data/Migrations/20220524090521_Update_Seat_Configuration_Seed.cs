using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Seat_Configuration_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a43ac988-4bcc-44b3-8c81-02e375569f4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "883a62f7-77ca-4e09-a88c-9d5e5d7db1a7");

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"),
                column: "SeatConfigurationType",
                value: (byte)3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "488f7e4e-2770-44b9-9ed9-15a8ebe1934e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "41a5b545-d8f0-4621-9d6e-429c8287c6f8");

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"),
                column: "SeatConfigurationType",
                value: (byte)1);
        }
    }
}
