using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class UpdateDeliveryAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_deliveryAudit",
                table: "deliveryAudit");

            migrationBuilder.RenameTable(
                name: "deliveryAudit",
                newName: "DeliveryAudit");

            migrationBuilder.AddColumn<int>(
                name: "WhRec",
                table: "DeliveryAudit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryAudit",
                table: "DeliveryAudit",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "473f75e9-a77f-4037-8a76-1ae1e98d0b20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "96fe96ad-475d-4e66-9caa-d8b58c629ea2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryAudit",
                table: "DeliveryAudit");

            migrationBuilder.DropColumn(
                name: "WhRec",
                table: "DeliveryAudit");

            migrationBuilder.RenameTable(
                name: "DeliveryAudit",
                newName: "deliveryAudit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_deliveryAudit",
                table: "deliveryAudit",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "e1e3323d-c33d-4e08-aadd-7d2364cefa3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "85604d71-041a-4f63-a164-93e77754294a");
        }
    }
}
