using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Table_Seat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoPositionType",
                table: "CargoPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MaxWeight",
                table: "CabinAreas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "SeatLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "MaxWeight",
                table: "AircraftDecks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "SeatLayouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCloned = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatLayouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeatConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowNumber = table.Column<short>(type: "smallint", nullable: false),
                    ColumnNumber = table.Column<short>(type: "smallint", nullable: false),
                    SeatConfigurationType = table.Column<byte>(type: "tinyint", nullable: false),
                    IsOnSeatOccupied = table.Column<bool>(type: "bit", nullable: false),
                    IsUnderSeatOccupied = table.Column<bool>(type: "bit", nullable: false),
                    SeatLayoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatConfigurations_SeatLayouts_SeatLayoutId",
                        column: x => x.SeatLayoutId,
                        principalTable: "SeatLayouts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    RowNumber = table.Column<short>(type: "smallint", nullable: false),
                    ColumnNumber = table.Column<short>(type: "smallint", nullable: false),
                    CabinAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOnSeatOccupied = table.Column<bool>(type: "bit", nullable: false),
                    IsUnderSeatOccupied = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_CabinAreas_CabinAreaId",
                        column: x => x.CabinAreaId,
                        principalTable: "CabinAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seats_SeatConfigurations_SeatConfigurationId",
                        column: x => x.SeatConfigurationId,
                        principalTable: "SeatConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatConfigurations_SeatLayoutId",
                table: "SeatConfigurations",
                column: "SeatLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_CabinAreaId",
                table: "Seats",
                column: "CabinAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SeatConfigurationId",
                table: "Seats",
                column: "SeatConfigurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "SeatConfigurations");

            migrationBuilder.DropTable(
                name: "SeatLayouts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "CargoPositionType",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "CabinAreas");

            migrationBuilder.DropColumn(
                name: "SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "AircraftDecks");
        }
    }
}
