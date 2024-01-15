using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class TruckInfoTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfos_AspNetUsers_UserID",
                table: "TruckInfos");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "TruckInfos",
                newName: "LastModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfos_UserID",
                table: "TruckInfos",
                newName: "IX_TruckInfos_LastModifiedBy");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TruckInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TruckInfos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TruckInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TruckInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TruckInfos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "4413225a-88a8-4e1b-a903-345a2a20cc24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "54973c87-a4cd-4b87-894e-f615d499ec77");

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfos_AspNetUsers_LastModifiedBy",
                table: "TruckInfos",
                column: "LastModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TruckInfos_AspNetUsers_LastModifiedBy",
                table: "TruckInfos");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TruckInfos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TruckInfos");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TruckInfos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TruckInfos");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TruckInfos");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "TruckInfos",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_TruckInfos_LastModifiedBy",
                table: "TruckInfos",
                newName: "IX_TruckInfos_UserID");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a9546b9d-fc1c-44c3-a880-9cdf964b9933");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "a8412f5f-5805-4ddb-8310-1fcee61b1e97");

            migrationBuilder.AddForeignKey(
                name: "FK_TruckInfos_AspNetUsers_UserID",
                table: "TruckInfos",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
