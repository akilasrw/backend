using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class ULDTableUpdateMakeMetaDataIDOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDs_ULDMetaDatas_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.AlterColumn<Guid>(
                name: "ULDMetaDataId",
                table: "ULDs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "02478e03-0625-492b-89b9-dd481f013426");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "ae23bb86-9c9d-4ea1-9995-7193fb1b3899");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDs_ULDMetaDatas_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId",
                principalTable: "ULDMetaDatas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDs_ULDMetaDatas_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.AlterColumn<Guid>(
                name: "ULDMetaDataId",
                table: "ULDs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "5d4e0f4e-30e4-44e2-a22c-98040c8faf02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "8ba9854d-49a9-4ef6-b80b-25f3fe2e6fe7");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDs_ULDMetaDatas_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId",
                principalTable: "ULDMetaDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
