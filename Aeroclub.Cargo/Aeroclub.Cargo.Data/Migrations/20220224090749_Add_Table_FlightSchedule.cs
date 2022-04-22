using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Table_FlightSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduledDepartureDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualDepartureDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlightScheduleStatus = table.Column<int>(type: "int", nullable: false),
                    OriginAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginAirportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationAirportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginAirportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationAirportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AircraftId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AircraftRegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightSchedules_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FlightSchedules_Airports_DestinationAirportId",
                        column: x => x.DestinationAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlightSchedules_Airports_OriginAirportId",
                        column: x => x.OriginAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_AircraftId",
                table: "FlightSchedules",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_DestinationAirportId",
                table: "FlightSchedules",
                column: "DestinationAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_OriginAirportId",
                table: "FlightSchedules",
                column: "OriginAirportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightSchedules");
        }
    }
}
