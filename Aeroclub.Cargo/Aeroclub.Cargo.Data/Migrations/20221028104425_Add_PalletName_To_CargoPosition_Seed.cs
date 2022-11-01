using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_PalletName_To_CargoPosition_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "971c0d14-0039-46a8-ac9b-8804e4e98f09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "fccc8bf7-adc1-4088-baee-9b6d164d5126");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("47e9c885-5b58-4d34-9b35-edf1a1ffd24c"),
                column: "Name",
                value: "2");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("575660cd-b062-47f2-903b-82b2dbc55523"),
                column: "Name",
                value: "5");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("65af4d12-3f61-4174-ade1-e9c1fcc8147e"),
                column: "Name",
                value: "4");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("687cea80-09d4-45b2-b26c-5db97ee4190f"),
                column: "Name",
                value: "6");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6fb941a5-883f-48e3-a611-fee21e03c8bc"),
                column: "Name",
                value: "9");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("92085e85-70ff-4eb5-8032-3d0eb42d32bb"),
                column: "Name",
                value: "10");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9efb973d-9d14-4790-920f-f6f6ac356cd2"),
                column: "Name",
                value: "7");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cf2ac95f-2457-429d-87aa-13789cd6f6ab"),
                column: "Name",
                value: "3");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ef7c6071-f97e-4be7-aae7-fcfa9be55dd9"),
                column: "Name",
                value: "1");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6688957-381c-4693-a396-b40592b3d2f5"),
                column: "Name",
                value: "8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "2c2263aa-d28a-440f-b227-8d43f74d3107");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "50e01fe6-c677-42c9-ae58-6e87a47aa414");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("47e9c885-5b58-4d34-9b35-edf1a1ffd24c"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("575660cd-b062-47f2-903b-82b2dbc55523"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("65af4d12-3f61-4174-ade1-e9c1fcc8147e"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("687cea80-09d4-45b2-b26c-5db97ee4190f"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6fb941a5-883f-48e3-a611-fee21e03c8bc"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("92085e85-70ff-4eb5-8032-3d0eb42d32bb"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9efb973d-9d14-4790-920f-f6f6ac356cd2"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cf2ac95f-2457-429d-87aa-13789cd6f6ab"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ef7c6071-f97e-4be7-aae7-fcfa9be55dd9"),
                column: "Name",
                value: "");

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6688957-381c-4693-a396-b40592b3d2f5"),
                column: "Name",
                value: "");
        }
    }
}
