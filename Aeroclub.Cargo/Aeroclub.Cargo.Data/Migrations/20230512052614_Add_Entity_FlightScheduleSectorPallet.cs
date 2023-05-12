using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Entity_FlightScheduleSectorPallet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightScheduleSectorPallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightScheduleSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ULDId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightScheduleSectorPallets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightScheduleSectorPallets_FlightScheduleSectors_FlightScheduleSectorId",
                        column: x => x.FlightScheduleSectorId,
                        principalTable: "FlightScheduleSectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightScheduleSectorPallets_ULDs_ULDId",
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
                value: "3832d160-6744-47b7-82b7-80150a2dfcc4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "894340d9-f1b3-4842-a973-fd99abef99f5");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectorPallets_FlightScheduleSectorId",
                table: "FlightScheduleSectorPallets",
                column: "FlightScheduleSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleSectorPallets_ULDId",
                table: "FlightScheduleSectorPallets",
                column: "ULDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightScheduleSectorPallets");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "fa2db39f-04b0-430b-911e-cb22ce1f7a39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "af55790e-870d-49bf-a630-d7d8a3e3f20f");
        }
    }
}
