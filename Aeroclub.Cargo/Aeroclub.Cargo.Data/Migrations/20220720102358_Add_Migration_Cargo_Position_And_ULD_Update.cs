using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Migration_Cargo_Position_And_ULD_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "ULDs",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AddColumn<short>(
                name: "ColumnNumber",
                table: "ULDs",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "RowNumber",
                table: "ULDs",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<Guid>(
                name: "ULDId",
                table: "CargoPositions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "41c1ce2b-37f5-4ea7-abb2-91a8f1f545f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "9655934f-0df7-42de-b46c-5c328fe78146");

            migrationBuilder.CreateIndex(
                name: "IX_CargoPositions_ULDId",
                table: "CargoPositions",
                column: "ULDId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoPositions_ULDs_ULDId",
                table: "CargoPositions",
                column: "ULDId",
                principalTable: "ULDs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoPositions_ULDs_ULDId",
                table: "CargoPositions");

            migrationBuilder.DropIndex(
                name: "IX_CargoPositions_ULDId",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "ColumnNumber",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "ULDId",
                table: "CargoPositions");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "ULDs",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "19a4e0fc-4609-4475-b26d-3593999bb670");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "a9becbb0-7b6f-4889-ab1b-fffaf77e07b5");
        }
    }
}
