using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class ShipmentChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShipmentId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_ShipmentId",
                table: "PackageItems",
                column: "ShipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_Shipments_ShipmentId",
                table: "PackageItems",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_Shipments_ShipmentId",
                table: "PackageItems");

            migrationBuilder.DropIndex(
                name: "IX_PackageItems_ShipmentId",
                table: "PackageItems");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "PackageItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "7033fb4f-2e3b-4e1a-ae47-1b9d20bfda5a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "283fea57-eb5f-44b3-9e92-fea7ccbfa028");
        }
    }
}
