using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class AddAgreementAgent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Agreement",
                table: "CargoAgents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName" },
                values: new object[] { "6382bd7b-4d98-40ab-b978-1d29afa7eaec", "BOOKINGADMIN@YOPMAIL.COM" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName" },
                values: new object[] { "8cd10c9a-3dc8-4378-8d79-a054768987db", "BACKOFFICEADMIN@YOPMAIL.COM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agreement",
                table: "CargoAgents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName" },
                values: new object[] { "6ddcd52d-9838-45ec-84ae-3dffe8da9aa8", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName" },
                values: new object[] { "cd9da79a-94ff-4d65-8db2-8905cb337e86", null });
        }
    }
}
