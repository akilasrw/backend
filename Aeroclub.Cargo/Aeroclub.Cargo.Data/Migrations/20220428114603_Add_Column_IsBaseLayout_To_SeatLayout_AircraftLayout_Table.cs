using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Column_IsBaseLayout_To_SeatLayout_AircraftLayout_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBaseLayout",
                table: "SeatLayouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBaseLayout",
                table: "AircraftLayouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("605ee297-42da-4975-a072-c356cfd9afd3"),
                column: "IsBaseLayout",
                value: true);

            migrationBuilder.UpdateData(
                table: "SeatLayouts",
                keyColumn: "Id",
                keyValue: new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"),
                column: "IsBaseLayout",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBaseLayout",
                table: "SeatLayouts");

            migrationBuilder.DropColumn(
                name: "IsBaseLayout",
                table: "AircraftLayouts");
        }
    }
}
