using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Migration_CargoBooking_And_AWBInformation_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWBInformations_PackageItems_PackageItemId",
                table: "AWBInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_CargoPositions_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropIndex(
                name: "IX_ULDContainers_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.RenameColumn(
                name: "PackageItemId",
                table: "AWBInformations",
                newName: "CargoBookingId");

            migrationBuilder.RenameIndex(
                name: "IX_AWBInformations_PackageItemId",
                table: "AWBInformations",
                newName: "IX_AWBInformations_CargoBookingId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "764c86a8-0b81-4946-ae1e-23c7d516d899");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "209cbc30-1fdb-4e62-9f15-f7fce6d95bed");

            migrationBuilder.AddForeignKey(
                name: "FK_AWBInformations_CargoBookings_CargoBookingId",
                table: "AWBInformations",
                column: "CargoBookingId",
                principalTable: "CargoBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWBInformations_CargoBookings_CargoBookingId",
                table: "AWBInformations");

            migrationBuilder.RenameColumn(
                name: "CargoBookingId",
                table: "AWBInformations",
                newName: "PackageItemId");

            migrationBuilder.RenameIndex(
                name: "IX_AWBInformations_CargoBookingId",
                table: "AWBInformations",
                newName: "IX_AWBInformations_PackageItemId");

            migrationBuilder.AddColumn<Guid>(
                name: "CargoPositionId",
                table: "ULDContainers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a51b064e-2845-42ca-a889-0286e2a292c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "5dd3c624-9c55-4332-a3c2-ad077d150c01");

            migrationBuilder.CreateIndex(
                name: "IX_ULDContainers_CargoPositionId",
                table: "ULDContainers",
                column: "CargoPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AWBInformations_PackageItems_PackageItemId",
                table: "AWBInformations",
                column: "PackageItemId",
                principalTable: "PackageItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ULDContainers_CargoPositions_CargoPositionId",
                table: "ULDContainers",
                column: "CargoPositionId",
                principalTable: "CargoPositions",
                principalColumn: "Id");
        }
    }
}
