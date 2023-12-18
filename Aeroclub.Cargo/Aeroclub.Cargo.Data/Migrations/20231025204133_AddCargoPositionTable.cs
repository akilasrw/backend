using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class AddCargoPositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Agreement",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LayoutSpecs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LayoutSpectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoPositionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Default_max_weight = table.Column<int>(type: "int", nullable: false),
                    Default_height = table.Column<int>(type: "int", nullable: false),
                    Default_length = table.Column<int>(type: "int", nullable: false),
                    Default_breadth = table.Column<int>(type: "int", nullable: false),
                    Default_volume = table.Column<int>(type: "int", nullable: false),
                    Fit_Max_Input_max_weight = table.Column<int>(type: "int", nullable: false),
                    Fit_Max_Input_height = table.Column<int>(type: "int", nullable: false),
                    Fit_Max_Input_length = table.Column<int>(type: "int", nullable: false),
                    Fit_Max_Input_breadth = table.Column<int>(type: "int", nullable: false),
                    Fit_Max_Input_volume = table.Column<int>(type: "int", nullable: false),
                    Calculated_max_weight = table.Column<int>(type: "int", nullable: false),
                    Calculated_height = table.Column<int>(type: "int", nullable: false),
                    Calculated_length = table.Column<int>(type: "int", nullable: false),
                    Calculated_breadth = table.Column<int>(type: "int", nullable: false),
                    Calculated_volume = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    AircraftSubTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayoutSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LayoutSpecs_AircraftSubTypes_AircraftSubTypeId",
                        column: x => x.AircraftSubTypeId,
                        principalTable: "AircraftSubTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "3e0d141b-0965-4b55-9027-e08897142d44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "b959ed46-0f45-404b-af45-6148c5dc5cbf");

            migrationBuilder.CreateIndex(
                name: "IX_LayoutSpecs_AircraftSubTypeId",
                table: "LayoutSpecs",
                column: "AircraftSubTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LayoutSpecs");

            migrationBuilder.DropColumn(
                name: "Agreement",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "6382bd7b-4d98-40ab-b978-1d29afa7eaec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "8cd10c9a-3dc8-4378-8d79-a054768987db");
        }
    }
}
