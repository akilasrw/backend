using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class UpdateItemStatusTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStatus_PackageItems_PackageItemId",
                table: "ItemStatus");

            migrationBuilder.DropIndex(
                name: "IX_ItemStatus_PackageItemId",
                table: "ItemStatus");

            migrationBuilder.DropColumn(
                name: "PackageItemId",
                table: "ItemStatus");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a302c356-80f2-4200-af0f-efe70c743bb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "2e33538c-1baa-4baa-9187-5ac19a30551d");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatus_PackageID",
                table: "ItemStatus",
                column: "PackageID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStatus_PackageItems_PackageID",
                table: "ItemStatus",
                column: "PackageID",
                principalTable: "PackageItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStatus_PackageItems_PackageID",
                table: "ItemStatus");

            migrationBuilder.DropIndex(
                name: "IX_ItemStatus_PackageID",
                table: "ItemStatus");

            migrationBuilder.AddColumn<Guid>(
                name: "PackageItemId",
                table: "ItemStatus",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a5bc72c1-51ca-4ec0-9454-31d53ac2ed87");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "39e7504d-7341-4eba-917c-dec5e51f2fb9");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatus_PackageItemId",
                table: "ItemStatus",
                column: "PackageItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStatus_PackageItems_PackageItemId",
                table: "ItemStatus",
                column: "PackageItemId",
                principalTable: "PackageItems",
                principalColumn: "Id");
        }
    }
}
