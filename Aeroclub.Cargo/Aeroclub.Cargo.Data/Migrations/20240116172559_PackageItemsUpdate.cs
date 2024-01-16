using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class PackageItemsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_Units_VolumeUnitId",
                table: "PackageItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_Units_WeightUnitId",
                table: "PackageItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "WeightUnitId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "VolumeUnitId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PackageItems",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "0f7336b8-4237-4789-8f07-7a5976d0d6e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "7f9c73b6-26f1-4b38-9110-681a9b0ae2ca");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_Units_VolumeUnitId",
                table: "PackageItems",
                column: "VolumeUnitId",
                principalTable: "Units",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_Units_WeightUnitId",
                table: "PackageItems",
                column: "WeightUnitId",
                principalTable: "Units",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_Units_VolumeUnitId",
                table: "PackageItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_Units_WeightUnitId",
                table: "PackageItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "WeightUnitId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "VolumeUnitId",
                table: "PackageItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PackageItems",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "c193c319-892e-493f-9c82-b53fdb91db67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "ffd9ef05-e324-4783-9df8-f3f8d9af6b60");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_Units_VolumeUnitId",
                table: "PackageItems",
                column: "VolumeUnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_Units_WeightUnitId",
                table: "PackageItems",
                column: "WeightUnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
