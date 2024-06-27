using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class AddSubRates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubRateCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRateCategories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "4b43e73c-f4a4-4e6d-83e5-5e2c721da170");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "d767f23c-8422-4d8c-ad89-d0fbd3a312ec");

            migrationBuilder.InsertData(
                table: "SubRateCategories",
                columns: new[] { "Id", "CategoryName", "CategoryType" },
                values: new object[,]
                {
                    { new Guid("43d8d8b8-732b-4b24-8e1d-4e3b78767b7c"), "DANGEROUS GOODS CHARGES", 0 },
                    { new Guid("49d5d81a-5a16-42b6-909c-917de89efb63"), "DOCUMENT CHARGES", 0 },
                    { new Guid("5e8f8129-4f3e-4821-8c8a-feb1715d6157"), "CUSTOMS CHARGES", 0 },
                    { new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "PHYSICAL HANDLING", 1 },
                    { new Guid("a46a62bc-2b2d-4a95-9170-b6ea9cb1d1ec"), "PHARMACEUTICAL SHIPMENTS", 0 },
                    { new Guid("adf8d68a-7af5-49a7-bd7e-d5096a6d3d6d"), "DOCUMENT CHARGES", 1 },
                    { new Guid("b76e546b-50e5-4a88-8a1a-4fa485b845e0"), "AIRFREIGHT SECURITY CHARGE", 0 },
                    { new Guid("bf6b5e9b-8502-4d97-90fc-0b6a1fc2f6ae"), "LIVE ANIMALS CHARGES", 2 },
                    { new Guid("cf8692e7-bb99-4bc1-849b-5c2a228a8f8c"), "VALUABLE GOODS CHARGES", 2 },
                    { new Guid("f12d77b4-2c5b-4c15-81d4-e67cb9a65847"), "HUMAN REMAINS FEES", 0 },
                    { new Guid("f9e1f7e9-5d5c-4ba0-98b5-91889fbac282"), "ARRIVAL FEES", 1 },
                    { new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "PHYSICAL HANDLING", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubRateCategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "57e2bd94-9e27-44c3-9214-2d557986455f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "097d54bd-b417-4ec5-ba4f-eefa7a6255c4");
        }
    }
}
