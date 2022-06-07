using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class AWBInformation_PackageItem_Entity_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbTrackingNumber",
                table: "PackageItems");

            migrationBuilder.AddColumn<int>(
                name: "AwbTrackingNumber",
                table: "AWBInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PackageItemId",
                table: "AWBInformations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "12884137-da52-4808-9fe5-94f059d74335");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "2996d824-5b03-436e-b657-66c340a27da3");

            migrationBuilder.CreateIndex(
                name: "IX_AWBInformations_PackageItemId",
                table: "AWBInformations",
                column: "PackageItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AWBInformations_PackageItems_PackageItemId",
                table: "AWBInformations",
                column: "PackageItemId",
                principalTable: "PackageItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWBInformations_PackageItems_PackageItemId",
                table: "AWBInformations");

            migrationBuilder.DropIndex(
                name: "IX_AWBInformations_PackageItemId",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "AwbTrackingNumber",
                table: "AWBInformations");

            migrationBuilder.DropColumn(
                name: "PackageItemId",
                table: "AWBInformations");

            migrationBuilder.AddColumn<string>(
                name: "AwbTrackingNumber",
                table: "PackageItems",
                type: "varchar(40)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "fec51702-5787-47a9-b510-fa34f016dc6b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "6b521716-ba70-4d08-9cbf-5c104cb8a86c");
        }
    }
}
