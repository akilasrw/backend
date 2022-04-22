using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Remove_UnitId_ULDMetaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ULDs_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "VolumeUnitId",
                table: "ULDMetaData");

            migrationBuilder.CreateIndex(
                name: "IX_ULDs_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ULDs_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.AddColumn<Guid>(
                name: "VolumeUnitId",
                table: "ULDMetaData",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ULDs_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId",
                unique: true);
        }
    }
}
