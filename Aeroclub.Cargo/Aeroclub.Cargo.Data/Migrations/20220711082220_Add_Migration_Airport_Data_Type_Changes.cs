using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Migration_Airport_Data_Type_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Lon",
                table: "Airports",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "Airports",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("827791b4-c923-49b5-8426-e0c0a6a4c96a"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("95ea7820-ceed-4311-82fd-557e2d1ed436"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c2ac04ca-db7d-4138-8416-bbdc9236a751"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("dd784758-7438-41bf-8a8a-c9f79b03ffff"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "304579e4-bea3-46fb-a90e-659bd3ba470d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "f95474de-d214-4ac1-bb50-5c46c0bd1ca8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Lon",
                table: "Airports",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lat",
                table: "Airports",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("827791b4-c923-49b5-8426-e0c0a6a4c96a"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("95ea7820-ceed-4311-82fd-557e2d1ed436"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c2ac04ca-db7d-4138-8416-bbdc9236a751"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("dd784758-7438-41bf-8a8a-c9f79b03ffff"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"),
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "b5b79c24-13af-4d63-a518-53852b97c0a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "963b9ed6-e168-4d31-813c-987a13bc78b9");
        }
    }
}
