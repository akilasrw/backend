using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Two_Id_Columns_to_LoadPlan_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AircraftLayoutId",
                table: "LoadPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SeatLayoutId",
                table: "LoadPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_LoadPlans_AircraftLayoutId",
                table: "LoadPlans",
                column: "AircraftLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadPlans_SeatLayoutId",
                table: "LoadPlans",
                column: "SeatLayoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadPlans_AircraftLayouts_AircraftLayoutId",
                table: "LoadPlans",
                column: "AircraftLayoutId",
                principalTable: "AircraftLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoadPlans_SeatLayouts_SeatLayoutId",
                table: "LoadPlans",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoadPlans_AircraftLayouts_AircraftLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadPlans_SeatLayouts_SeatLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropIndex(
                name: "IX_LoadPlans_AircraftLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropIndex(
                name: "IX_LoadPlans_SeatLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropColumn(
                name: "AircraftLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropColumn(
                name: "SeatLayoutId",
                table: "LoadPlans");
        }
    }
}
