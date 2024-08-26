using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class deletepackage_uld_containers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PackageULDContainers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "35361bb9-0ff0-453a-8d92-4d7a882960ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "bb2bb46e-ab61-481f-bab8-759d36f01ff2");

            migrationBuilder.UpdateData(
                table: "ChildRateCategories",
                keyColumn: "Id",
                keyValue: new Guid("69287538-ff9f-417e-9e1c-1797599d5248"),
                column: "CategoryName",
                value: "DANGEROUS GOODS CHARGES « LIGHT »");

            migrationBuilder.UpdateData(
                table: "ChildRateCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2b956d3-ecdc-4e4b-8b6e-1e11847fda59"),
                column: "CategoryName",
                value: "IMPROPERLY LOADED ULD – RECONTOURING");

            migrationBuilder.UpdateData(
                table: "ChildRateCategories",
                keyColumn: "Id",
                keyValue: new Guid("c7c5f4f3-9b13-4a9b-8978-5a9ae7c53c60"),
                column: "CategoryName",
                value: "FRAIS DE MISE À DISPOSITION");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PackageULDContainers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a6c43710-8ee1-491f-b800-8d1c86862e5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "2495b5c9-0684-43d2-86ad-9bf1cc67c613");

            migrationBuilder.UpdateData(
                table: "ChildRateCategories",
                keyColumn: "Id",
                keyValue: new Guid("69287538-ff9f-417e-9e1c-1797599d5248"),
                column: "CategoryName",
                value: "DANGEROUS GOODS CHARGES � LIGHT �");

            migrationBuilder.UpdateData(
                table: "ChildRateCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2b956d3-ecdc-4e4b-8b6e-1e11847fda59"),
                column: "CategoryName",
                value: "IMPROPERLY LOADED ULD � RECONTOURING");

            migrationBuilder.UpdateData(
                table: "ChildRateCategories",
                keyColumn: "Id",
                keyValue: new Guid("c7c5f4f3-9b13-4a9b-8978-5a9ae7c53c60"),
                column: "CategoryName",
                value: "FRAIS DE MISE � DISPOSITION");
        }
    }
}
