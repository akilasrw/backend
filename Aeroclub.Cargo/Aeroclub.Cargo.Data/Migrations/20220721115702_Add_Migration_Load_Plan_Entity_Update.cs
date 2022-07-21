using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Migration_Load_Plan_Entity_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoadPlans_OverheadLayouts_OverheadLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadPlans_SeatLayouts_SeatLayoutId",
                table: "LoadPlans");

            migrationBuilder.AlterColumn<Guid>(
                name: "SeatLayoutId",
                table: "LoadPlans",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "OverheadLayoutId",
                table: "LoadPlans",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("7286adb4-1da0-4547-ac8d-c3ea5f45c2a9"),
                column: "ConfigurationType",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "057fd81c-6ab6-4ed9-a90a-219453367417");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "bd1f32a2-5f49-4c8e-8b5d-c939994d6f34");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadPlans_OverheadLayouts_OverheadLayoutId",
                table: "LoadPlans",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadPlans_SeatLayouts_SeatLayoutId",
                table: "LoadPlans",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoadPlans_OverheadLayouts_OverheadLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadPlans_SeatLayouts_SeatLayoutId",
                table: "LoadPlans");

            migrationBuilder.AlterColumn<Guid>(
                name: "SeatLayoutId",
                table: "LoadPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OverheadLayoutId",
                table: "LoadPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("7286adb4-1da0-4547-ac8d-c3ea5f45c2a9"),
                column: "ConfigurationType",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "324a5db4-dd8a-4aa8-9dc3-427df23d4856");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "ddeff9ab-1faa-41fd-b6d5-2e81c582c1dd");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadPlans_OverheadLayouts_OverheadLayoutId",
                table: "LoadPlans",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoadPlans_SeatLayouts_SeatLayoutId",
                table: "LoadPlans",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
