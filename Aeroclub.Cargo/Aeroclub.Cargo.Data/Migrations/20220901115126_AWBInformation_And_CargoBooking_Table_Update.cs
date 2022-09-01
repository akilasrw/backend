using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class AWBInformation_And_CargoBooking_Table_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWBInformations_PackageItems_PackageItemId",
                table: "AWBInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_CargoPositions_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropTable(
                name: "AWBProducts");

            migrationBuilder.DropIndex(
                name: "IX_ULDContainers_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropIndex(
                name: "IX_AWBInformations_PackageItemId",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "DestinationAirportCode",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "PackageItemId",
                table: "AWBInformations");

            migrationBuilder.AddColumn<byte>(
                name: "AWBStatus",
                table: "CargoBookings",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<Guid>(
                name: "CargoBookingId",
                table: "AWBInformations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationAirportName",
                table: "AWBInformations",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQualityOfGoods",
                table: "AWBInformations",
                type: "nvarchar(400)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RateCharge",
                table: "AWBInformations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "89f747a4-9821-4652-bc16-b122a34a4266");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "c211b714-58e9-4c67-93c7-0209920a9769");

            migrationBuilder.CreateIndex(
                name: "IX_AWBInformations_CargoBookingId",
                table: "AWBInformations",
                column: "CargoBookingId",
                unique: true,
                filter: "[CargoBookingId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AWBInformations_CargoBookings_CargoBookingId",
                table: "AWBInformations",
                column: "CargoBookingId",
                principalTable: "CargoBookings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWBInformations_CargoBookings_CargoBookingId",
                table: "AWBInformations");

            migrationBuilder.DropIndex(
                name: "IX_AWBInformations_CargoBookingId",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "AWBStatus",
                table: "CargoBookings");

            migrationBuilder.DropColumn(
                name: "CargoBookingId",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "DestinationAirportName",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "NatureAndQualityOfGoods",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "RateCharge",
                table: "AWBInformations");

            migrationBuilder.AddColumn<Guid>(
                name: "CargoPositionId",
                table: "ULDContainers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationAirportCode",
                table: "AWBInformations",
                type: "varchar(3)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PackageItemId",
                table: "AWBInformations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AWBProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AWBInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProductRefNumber = table.Column<string>(type: "varchar(40)", nullable: true),
                    ProductType = table.Column<byte>(type: "tinyint", nullable: false),
                    Quantity = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AWBProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AWBProducts_AWBInformations_AWBInformationId",
                        column: x => x.AWBInformationId,
                        principalTable: "AWBInformations",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AWBInformations_PackageItemId",
                table: "AWBInformations",
                column: "PackageItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AWBProducts_AWBInformationId",
                table: "AWBProducts",
                column: "AWBInformationId");

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
