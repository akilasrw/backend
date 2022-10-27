using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Added_ULDCargoPosition_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ULDCargoPositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ULDId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoPositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ULDCargoPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ULDCargoPositions_CargoPositions_CargoPositionId",
                        column: x => x.CargoPositionId,
                        principalTable: "CargoPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ULDCargoPositions_ULDs_ULDId",
                        column: x => x.ULDId,
                        principalTable: "ULDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "01a5b745-2e46-42b4-aa28-7a4d48f15e84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "ab753bbe-361f-4fe5-a103-372418bfd28e");

            migrationBuilder.CreateIndex(
                name: "IX_ULDCargoPositions_CargoPositionId",
                table: "ULDCargoPositions",
                column: "CargoPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ULDCargoPositions_ULDId",
                table: "ULDCargoPositions",
                column: "ULDId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ULDCargoPositions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "87312afc-e376-44d2-93da-374a656b513f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "31238709-a1c8-413b-8ed8-03d6318ea83f");
        }
    }
}
