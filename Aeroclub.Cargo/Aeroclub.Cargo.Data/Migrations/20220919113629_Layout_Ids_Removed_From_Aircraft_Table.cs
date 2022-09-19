using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Layout_Ids_Removed_From_Aircraft_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AircraftLayouts_AircraftLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_AircraftLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "AircraftLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "3c1a2335-5722-4ac0-9b7d-d08a7b33c899");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "fcaf5c25-cce7-422f-8b42-a2382f19e403");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AircraftLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OverheadLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SeatLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "cd23ddef-4890-44b7-8a00-8e5455b8014e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "586bd2e8-ebc5-4607-a77e-ff7330919f3e");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AircraftLayoutId",
                table: "Aircrafts",
                column: "AircraftLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AircraftLayouts_AircraftLayoutId",
                table: "Aircrafts",
                column: "AircraftLayoutId",
                principalTable: "AircraftLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id");
        }
    }
}
