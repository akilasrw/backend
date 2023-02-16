using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Tables_PackageULDContainer_And_CargoBookingFlightScheduleSector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoBookings_FlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_ULDContainers_ULDContainerId",
                table: "PackageItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "ULDContainerId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FlightScheduleSectorId",
                table: "CargoBookings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "CargoBookingFlightScheduleSectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightScheduleSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoBookingFlightScheduleSectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoBookingFlightScheduleSectors_CargoBookings_CargoBookingId",
                        column: x => x.CargoBookingId,
                        principalTable: "CargoBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoBookingFlightScheduleSectors_FlightScheduleSectors_FlightScheduleSectorId",
                        column: x => x.FlightScheduleSectorId,
                        principalTable: "FlightScheduleSectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageULDContainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ULDContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageULDContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageULDContainers_PackageItems_PackageItemId",
                        column: x => x.PackageItemId,
                        principalTable: "PackageItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageULDContainers_ULDContainers_ULDContainerId",
                        column: x => x.ULDContainerId,
                        principalTable: "ULDContainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "2d29d7cd-9b79-41ab-a56d-b5b890075da1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "b9e0c37b-7c94-4147-848d-b97f667cec0a");

            migrationBuilder.CreateIndex(
                name: "IX_CargoBookingFlightScheduleSectors_CargoBookingId",
                table: "CargoBookingFlightScheduleSectors",
                column: "CargoBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoBookingFlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookingFlightScheduleSectors",
                column: "FlightScheduleSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageULDContainers_PackageItemId",
                table: "PackageULDContainers",
                column: "PackageItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageULDContainers_ULDContainerId",
                table: "PackageULDContainers",
                column: "ULDContainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoBookings_FlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookings",
                column: "FlightScheduleSectorId",
                principalTable: "FlightScheduleSectors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_ULDContainers_ULDContainerId",
                table: "PackageItems",
                column: "ULDContainerId",
                principalTable: "ULDContainers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoBookings_FlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_ULDContainers_ULDContainerId",
                table: "PackageItems");

            migrationBuilder.DropTable(
                name: "CargoBookingFlightScheduleSectors");

            migrationBuilder.DropTable(
                name: "PackageULDContainers");

            migrationBuilder.AlterColumn<Guid>(
                name: "ULDContainerId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FlightScheduleSectorId",
                table: "CargoBookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "6e7d54cc-4fde-4511-8e5a-e11766340528");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "05e20a2c-54b2-4562-ae07-76d07a5a6b5a");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoBookings_FlightScheduleSectors_FlightScheduleSectorId",
                table: "CargoBookings",
                column: "FlightScheduleSectorId",
                principalTable: "FlightScheduleSectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_ULDContainers_ULDContainerId",
                table: "PackageItems",
                column: "ULDContainerId",
                principalTable: "ULDContainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
