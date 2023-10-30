using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class UpdateCargoPositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Breadth",
                table: "CargoPositions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FlightLeg",
                table: "CargoPositions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "CargoPositions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "CargoPositions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Priority",
                table: "CargoPositions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName" },
                values: new object[] { "fb30ba91-7e4f-45d0-a471-f538b5d570bf", "BOOKINGADMIN@YOPMAIL.COM" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName" },
                values: new object[] { "9b8a9d8c-9517-426b-812f-f4e36f3300ce", "BACKOFFICEADMIN@YOPMAIL.COM" });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("16a9609a-de6d-4d7f-803a-baf9ef80dfcf"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("20e81604-02cd-4bb4-9004-1782a70248d8"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("47e9c885-5b58-4d34-9b35-edf1a1ffd24c"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("507388e5-7101-476a-afba-523033832484"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5271d1b5-b157-4984-b463-1967c0e899e4"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("575660cd-b062-47f2-903b-82b2dbc55523"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("65af4d12-3f61-4174-ade1-e9c1fcc8147e"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("687cea80-09d4-45b2-b26c-5db97ee4190f"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6a4a7dbf-1d72-45b8-8924-c9a6ce343e66"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6fb941a5-883f-48e3-a611-fee21e03c8bc"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7a98da3d-6df3-461a-951d-8fb0cb5256ab"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("84dfd57f-7047-4397-81fc-8b5d2e5bdd7b"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8c539701-d185-44dc-aa3a-fef9faaf6abe"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("92085e85-70ff-4eb5-8032-3d0eb42d32bb"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("963354d6-5d9a-4c58-9a00-68c43d491d9c"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("99c84a72-a3ef-454a-aecc-acf508c9d73c"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9bdad1de-3849-4d9b-830d-5ec84e74ca3b"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9efb973d-9d14-4790-920f-f6f6ac356cd2"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a308ea90-7563-45ab-b66b-cb7a337fb13a"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ab24cfcb-056d-4405-b8cb-50ca45682fa0"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("aee338b3-5956-4093-9d3a-562eca51f111"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b204a0c4-5615-4871-acd1-bc570dfb96e1"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c5cf9c03-1e5f-4a3e-b5e1-62f7370595a2"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c6bfe680-576b-4665-b8c4-983cd40ae75c"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c82a3478-b75a-4f29-b14a-04bf35e4a621"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cf2ac95f-2457-429d-87aa-13789cd6f6ab"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("de85a837-c37c-40be-bda1-b1932651fe00"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ef7c6071-f97e-4be7-aae7-fcfa9be55dd9"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6688957-381c-4693-a396-b40592b3d2f5"),
                columns: new[] { "Breadth", "FlightLeg", "Height", "Length", "Priority" },
                values: new object[] { 10.0, 1.0, 10.0, 20.0, 1.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breadth",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "FlightLeg",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "CargoPositions");

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
