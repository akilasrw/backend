using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class uld_table_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AirportID",
                table: "ULDs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "3c697751-0d03-4b5e-a3f9-60ba72afbb34");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "846523bf-282b-438c-9a9b-de86a21678d4");

            migrationBuilder.CreateIndex(
                name: "IX_ULDs_AirportID",
                table: "ULDs",
                column: "AirportID");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDs_Airports_AirportID",
                table: "ULDs",
                column: "AirportID",
                principalTable: "Airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDs_Airports_AirportID",
                table: "ULDs");

            migrationBuilder.DropIndex(
                name: "IX_ULDs_AirportID",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "AirportID",
                table: "ULDs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "35361bb9-0ff0-453a-8d92-4d7a882960ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "bb2bb46e-ab61-481f-bab8-759d36f01ff2");
        }
    }
}
