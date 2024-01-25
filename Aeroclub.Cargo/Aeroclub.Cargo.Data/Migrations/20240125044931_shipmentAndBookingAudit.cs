using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class shipmentAndBookingAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingAudits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bookingStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingAudits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingAudits_CargoBookings_bookingId",
                        column: x => x.bookingId,
                        principalTable: "CargoBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    packageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    flightScheduleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_CargoBookings_bookingID",
                        column: x => x.bookingID,
                        principalTable: "CargoBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipments_FlightSchedules_flightScheduleID",
                        column: x => x.flightScheduleID,
                        principalTable: "FlightSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipments_PackageItems_packageID",
                        column: x => x.packageID,
                        principalTable: "PackageItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "95572319-9a48-4ac6-a610-c13d66eaadba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "6bb1cc3a-bd6b-4537-a902-d70f5c009a73");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAudits_bookingId",
                table: "BookingAudits",
                column: "bookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_bookingID",
                table: "Shipments",
                column: "bookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_flightScheduleID",
                table: "Shipments",
                column: "flightScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_packageID",
                table: "Shipments",
                column: "packageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingAudits");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "2ec60af7-4673-43b5-813d-691e6d462ab2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "dd86a936-14ac-4ca4-be5a-336c6239f6f6");
        }
    }
}
