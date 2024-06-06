using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class UpdateSectorAirportLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "063d6c7f-155d-44ea-ac8d-f762da0ab4a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "2fe0c428-163c-465e-955b-b5c9c6392ca9");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_OriginAirportId",
                table: "Sectors",
                column: "OriginAirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sectors_Airports_OriginAirportId",
                table: "Sectors",
                column: "OriginAirportId",
                principalTable: "Airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sectors_Airports_OriginAirportId",
                table: "Sectors");

            migrationBuilder.DropIndex(
                name: "IX_Sectors_OriginAirportId",
                table: "Sectors");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "53ad1f7a-7fc5-4d3a-902a-1fef829b9436");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "86f97948-5efc-48ad-83d3-136a3603df3f");
        }
    }
}
