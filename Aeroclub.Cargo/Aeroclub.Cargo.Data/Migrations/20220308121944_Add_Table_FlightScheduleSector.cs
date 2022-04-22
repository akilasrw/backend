using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Table_FlightScheduleSector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightScheduleSectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SequenceNo = table.Column<int>(type: "int", nullable: false),
                    ScheduledDepartureDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualDepartureDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlightScheduleStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    OriginAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginAirportCode = table.Column<string>(type: "varchar(3)", nullable: false),
                    DestinationAirportCode = table.Column<string>(type: "varchar(3)", nullable: false),
                    OriginAirportName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    DestinationAirportName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    FlightNumber = table.Column<string>(type: "varchar(10)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightScheduleSectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightScheduleSectors_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlightScheduleSectors_FlightSchedules_FlightScheduleId",
                        column: x => x.FlightScheduleId,
                        principalTable: "FlightSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FlightScheduleSectors_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_FlightId",
                table: "FlightScheduleSectors",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_FlightScheduleId",
                table: "FlightScheduleSectors",
                column: "FlightScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectors_SectorId",
                table: "FlightScheduleSectors",
                column: "SectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightScheduleSectors");
        }
    }
}
