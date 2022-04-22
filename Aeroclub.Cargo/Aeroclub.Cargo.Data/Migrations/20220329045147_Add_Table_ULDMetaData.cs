using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Table_ULDMetaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingPriorityType",
                table: "CargoBookings");

            migrationBuilder.AddColumn<Guid>(
                name: "ULDMetaDataId",
                table: "ULDs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<byte>(
                name: "PackagePriorityType",
                table: "PackageItems",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "PackageRefNumber",
                table: "PackageItems",
                type: "varchar(40)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ULDMetaData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    VolumeUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ULDMetaData", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ULDs_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ULDs_ULDMetaData_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId",
                principalTable: "ULDMetaData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDs_ULDMetaData_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.DropTable(
                name: "ULDMetaData");

            migrationBuilder.DropIndex(
                name: "IX_ULDs_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "PackagePriorityType",
                table: "PackageItems");

            migrationBuilder.DropColumn(
                name: "PackageRefNumber",
                table: "PackageItems");

            migrationBuilder.AddColumn<byte>(
                name: "BookingPriorityType",
                table: "CargoBookings",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
