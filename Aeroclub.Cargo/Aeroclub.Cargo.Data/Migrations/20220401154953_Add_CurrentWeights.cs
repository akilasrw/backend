using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_CurrentWeights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CurrentWeight",
                table: "ZoneAreas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CurrentWeight",
                table: "CargoPositions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CurrentWeight",
                table: "AircraftDecks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CurrentWeight",
                table: "AircraftCabins",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentWeight",
                table: "ZoneAreas");

            migrationBuilder.DropColumn(
                name: "CurrentWeight",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "CurrentWeight",
                table: "AircraftDecks");

            migrationBuilder.DropColumn(
                name: "CurrentWeight",
                table: "AircraftCabins");
        }
    }
}
