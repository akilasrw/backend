using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Seat_Configuration_Table_ULD_Container_Table_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_CargoPositions_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropIndex(
                name: "IX_ULDContainers_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.AddColumn<bool>(
                name: "IsFullRowOccupied",
                table: "SeatConfigurations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "MaxWeight",
                table: "SeatConfigurations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "770ce484-bdd2-4687-be4e-41c64a1f49cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "4713840e-b502-4d9c-ab5c-fc2c12d559d8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFullRowOccupied",
                table: "SeatConfigurations");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "SeatConfigurations");

            migrationBuilder.AddColumn<Guid>(
                name: "CargoPositionId",
                table: "ULDContainers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "744e736b-3653-42d6-9b67-b340670c5ddd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "203d78dc-ee9e-4799-a663-c6c4e845561d");

            migrationBuilder.CreateIndex(
                name: "IX_ULDContainers_CargoPositionId",
                table: "ULDContainers",
                column: "CargoPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDContainers_CargoPositions_CargoPositionId",
                table: "ULDContainers",
                column: "CargoPositionId",
                principalTable: "CargoPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
