using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Cargo_Agent_Table_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AircraftDecks_AircraftLayouts_AircraftLayoutId",
                table: "AircraftDecks");

            migrationBuilder.AlterColumn<Guid>(
                name: "AircraftLayoutId",
                table: "AircraftDecks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CargoAgents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgentName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    PrimaryTelephoneNumber = table.Column<string>(type: "varchar(12)", nullable: false),
                    SecondaryTelephoneNumber = table.Column<string>(type: "varchar(12)", nullable: false),
                    CargoAccountNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    AgentIATACode = table.Column<string>(type: "varchar(20)", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoAgents_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoAgents_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoAgents_AppUserId",
                table: "CargoAgents",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoAgents_CountryId",
                table: "CargoAgents",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AircraftDecks_AircraftLayouts_AircraftLayoutId",
                table: "AircraftDecks",
                column: "AircraftLayoutId",
                principalTable: "AircraftLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AircraftDecks_AircraftLayouts_AircraftLayoutId",
                table: "AircraftDecks");

            migrationBuilder.DropTable(
                name: "CargoAgents");

            migrationBuilder.AlterColumn<Guid>(
                name: "AircraftLayoutId",
                table: "AircraftDecks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_AircraftDecks_AircraftLayouts_AircraftLayoutId",
                table: "AircraftDecks",
                column: "AircraftLayoutId",
                principalTable: "AircraftLayouts",
                principalColumn: "Id");
        }
    }
}
