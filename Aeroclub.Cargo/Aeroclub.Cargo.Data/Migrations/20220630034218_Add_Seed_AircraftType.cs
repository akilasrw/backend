using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_AircraftType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AircraftTypes",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B7879", (short)1 },
                    { new Guid("d0590732-9743-4516-83ed-9b0793606592"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "A320200", (short)2 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "04e4ad07-24e0-457e-a2d3-c0a0035d4e70");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "1c3dda50-76f9-490e-958a-dfc9e27b1f57");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0590732-9743-4516-83ed-9b0793606592"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "5b5739a7-75a8-49b4-8b2d-294a757dee4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "8f3e5ead-6f16-482c-b347-c93cf87ec63c");
        }
    }
}
