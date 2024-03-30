using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class DeliveryAuditTableAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "deliveryAudit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CollectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AWBs = table.Column<int>(type: "int", nullable: false),
                    ParcellsCollected = table.Column<int>(type: "int", nullable: false),
                    ParcellsRetured = table.Column<int>(type: "int", nullable: false),
                    ParcellsOnHold = table.Column<int>(type: "int", nullable: false),
                    ULDPacked = table.Column<int>(type: "int", nullable: false),
                    OnRoute = table.Column<int>(type: "int", nullable: false),
                    ParcellsDeliverd = table.Column<int>(type: "int", nullable: false),
                    OneDay = table.Column<int>(type: "int", nullable: false),
                    OneDayToOneAndHalf = table.Column<int>(type: "int", nullable: false),
                    AfterOneAndHalf = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deliveryAudit", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deliveryAudit");

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
        }
    }
}
