using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_Flights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationAirportCode",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DestinationAirportName",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OriginAirportCode",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OriginAirportName",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Created", "CreatedBy", "DestinationAirportCode", "DestinationAirportId", "DestinationAirportName", "FlightNumber", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OriginAirportCode", "OriginAirportId", "OriginAirportName" },
                values: new object[] { new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", "AC-100", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Created", "CreatedBy", "DestinationAirportCode", "DestinationAirportId", "DestinationAirportName", "FlightNumber", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OriginAirportCode", "OriginAirportId", "OriginAirportName" },
                values: new object[] { new Guid("f6696ac5-2d2a-41a4-afe9-7f41b89e5e52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport", "AC-101", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"));

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("f6696ac5-2d2a-41a4-afe9-7f41b89e5e52"));

            migrationBuilder.DropColumn(
                name: "DestinationAirportCode",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DestinationAirportName",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "OriginAirportCode",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "OriginAirportName",
                table: "Flights");
        }
    }
}
