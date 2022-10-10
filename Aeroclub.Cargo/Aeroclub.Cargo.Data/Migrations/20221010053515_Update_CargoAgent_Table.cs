using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_CargoAgent_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BaseAirportId",
                table: "CargoAgents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "f2b00fdd-61e5-46ec-9ce4-a749f10fade3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "0ef96d1f-99bc-4d5d-97af-0ad8febc90ff");

            migrationBuilder.CreateIndex(
                name: "IX_CargoAgents_BaseAirportId",
                table: "CargoAgents",
                column: "BaseAirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoAgents_Airports_BaseAirportId",
                table: "CargoAgents",
                column: "BaseAirportId",
                principalTable: "Airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoAgents_Airports_BaseAirportId",
                table: "CargoAgents");

            migrationBuilder.DropIndex(
                name: "IX_CargoAgents_BaseAirportId",
                table: "CargoAgents");

            migrationBuilder.DropColumn(
                name: "BaseAirportId",
                table: "CargoAgents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "444b8b30-e009-4416-967f-d3571b9df529");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "a2e3612b-d417-4477-9cd6-0ad3ca27fe5c");
        }
    }
}
