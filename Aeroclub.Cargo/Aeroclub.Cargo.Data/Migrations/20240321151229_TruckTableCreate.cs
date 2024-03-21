using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class TruckTableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfos_CargoBookings_BookingID",
                table: "TruckInfos");

            migrationBuilder.RenameColumn(
                name: "TruckID",
                table: "TruckInfos",
                newName: "truckId");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "TruckInfos",
                newName: "bookingId");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfos_BookingID",
                table: "TruckInfos",
                newName: "IX_TruckInfos_bookingId");

            migrationBuilder.AlterColumn<Guid>(
                name: "truckId",
                table: "TruckInfos",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "handOverCount",
                table: "TruckInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pickedUpCount",
                table: "TruckInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "truck",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    truckNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pickedUpCount = table.Column<int>(type: "int", nullable: false),
                    handOverCount = table.Column<int>(type: "int", nullable: false),
                    bookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_truck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_truck_CargoBookings_bookingId",
                        column: x => x.bookingId,
                        principalTable: "CargoBookings",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "f4febf0e-f91c-46ac-8324-40a81a3665c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "f4c50b23-a9cb-44f5-81a1-3838b3b6e120");

            migrationBuilder.CreateIndex(
                name: "IX_TruckInfos_truckId",
                table: "TruckInfos",
                column: "truckId");

            migrationBuilder.CreateIndex(
                name: "IX_truck_bookingId",
                table: "truck",
                column: "bookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfos_CargoBookings_bookingId",
                table: "TruckInfos",
                column: "bookingId",
                principalTable: "CargoBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfos_truck_truckId",
                table: "TruckInfos",
                column: "truckId",
                principalTable: "truck",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfos_CargoBookings_bookingId",
                table: "TruckInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfos_truck_truckId",
                table: "TruckInfos");

            migrationBuilder.DropTable(
                name: "truck");

            migrationBuilder.DropIndex(
                name: "IX_TruckInfos_truckId",
                table: "TruckInfos");

            migrationBuilder.DropColumn(
                name: "handOverCount",
                table: "TruckInfos");

            migrationBuilder.DropColumn(
                name: "pickedUpCount",
                table: "TruckInfos");

            migrationBuilder.RenameColumn(
                name: "truckId",
                table: "TruckInfos",
                newName: "TruckID");

            migrationBuilder.RenameColumn(
                name: "bookingId",
                table: "TruckInfos",
                newName: "BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfos_bookingId",
                table: "TruckInfos",
                newName: "IX_TruckInfos_BookingID");

            migrationBuilder.AlterColumn<string>(
                name: "TruckID",
                table: "TruckInfos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "66dcfe07-6ef2-40f2-9082-ca2bc562d384");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "6370b46a-27e1-4e73-8a61-2c5eb6cf4d22");

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfos_CargoBookings_BookingID",
                table: "TruckInfos",
                column: "BookingID",
                principalTable: "CargoBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
