using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Column_CutoffTimeMin_flightSchedule_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CutoffTimeMin",
                table: "FlightScheduleSectors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CutoffTimeMin",
                table: "FlightSchedules",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "93e5973f-abc1-4680-80f6-e96f3af3c32c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "a669d0b7-45a2-45ac-8670-4d89d54ea44a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CutoffTimeMin",
                table: "FlightScheduleSectors");

            migrationBuilder.DropColumn(
                name: "CutoffTimeMin",
                table: "FlightSchedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "fb31af51-f41d-421e-a607-adf79a721b57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "ade3c89b-7c22-4bee-8387-1d49ce754162");
        }
    }
}
