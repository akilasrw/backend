using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class FlightScheduleSectorTableUpdateSectorField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleSectors_Sectors_SectorId",
                table: "FlightScheduleSectors");

            migrationBuilder.AlterColumn<Guid>(
                name: "SectorId",
                table: "FlightScheduleSectors",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
                name: "FK_FlightScheduleSectors_Sectors_SectorId",
                table: "FlightScheduleSectors",
                column: "SectorId",
                principalTable: "Sectors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleSectors_Sectors_SectorId",
                table: "FlightScheduleSectors");

            migrationBuilder.AlterColumn<Guid>(
                name: "SectorId",
                table: "FlightScheduleSectors",
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
                value: "67ffde89-c30a-4680-8c24-d5950725cd40");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "4a63f21a-3871-4258-909a-a55efffb0a3d");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleSectors_Sectors_SectorId",
                table: "FlightScheduleSectors",
                column: "SectorId",
                principalTable: "Sectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
