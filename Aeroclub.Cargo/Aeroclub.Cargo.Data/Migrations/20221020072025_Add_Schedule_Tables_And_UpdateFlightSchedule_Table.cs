using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Schedule_Tables_And_UpdateFlightSchedule_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ChargeableWeight",
                table: "PackageItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "FlightScheduleManagementId",
                table: "FlightSchedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MasterSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaysOfWeek = table.Column<string>(type: "varchar(20)", nullable: false),
                    ScheduleStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    CalendarType = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterSchedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScheduleStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    MasterScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AircraftId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftSchedules_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AircraftSchedules_MasterSchedules_MasterScheduleId",
                        column: x => x.MasterScheduleId,
                        principalTable: "MasterSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "9577e275-b7d3-43be-8173-0f02a5c36066");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "5f9649b4-de15-49c9-a49b-15a55ec2703f");

            migrationBuilder.CreateIndex(
                name: "IX_FlightSchedules_FlightScheduleManagementId",
                table: "FlightSchedules",
                column: "FlightScheduleManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftSchedules_AircraftId",
                table: "AircraftSchedules",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftSchedules_MasterScheduleId",
                table: "AircraftSchedules",
                column: "MasterScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedules_FlightScheduleManagements_FlightScheduleManagementId",
                table: "FlightSchedules",
                column: "FlightScheduleManagementId",
                principalTable: "FlightScheduleManagements",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedules_FlightScheduleManagements_FlightScheduleManagementId",
                table: "FlightSchedules");

            migrationBuilder.DropTable(
                name: "AircraftSchedules");

            migrationBuilder.DropTable(
                name: "MasterSchedules");

            migrationBuilder.DropIndex(
                name: "IX_FlightSchedules_FlightScheduleManagementId",
                table: "FlightSchedules");

            migrationBuilder.DropColumn(
                name: "ChargeableWeight",
                table: "PackageItems");

            migrationBuilder.DropColumn(
                name: "FlightScheduleManagementId",
                table: "FlightSchedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "f2b00fdd-61e5-46ec-9ce4-a749f10fade3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "0ef96d1f-99bc-4d5d-97af-0ad8febc90ff");
        }
    }
}
