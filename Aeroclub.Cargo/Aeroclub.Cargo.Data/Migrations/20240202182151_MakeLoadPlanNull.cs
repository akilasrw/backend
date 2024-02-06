using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class MakeLoadPlanNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_LoadPlans_LoadPlanId",
                table: "ULDContainers");

            migrationBuilder.AlterColumn<Guid>(
                name: "LoadPlanId",
                table: "ULDContainers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "d89a435f-4f3f-4a53-a8d4-2cfa2bcf9aa4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "dce16b76-0faa-4151-98ec-bf51be2fac14");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDContainers_LoadPlans_LoadPlanId",
                table: "ULDContainers",
                column: "LoadPlanId",
                principalTable: "LoadPlans",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_LoadPlans_LoadPlanId",
                table: "ULDContainers");

            migrationBuilder.AlterColumn<Guid>(
                name: "LoadPlanId",
                table: "ULDContainers",
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
                value: "1e18110f-f1d6-484e-8821-2ef6f33e5ead");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "04db895b-3630-44f4-9f3d-32e9427530bd");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDContainers_LoadPlans_LoadPlanId",
                table: "ULDContainers",
                column: "LoadPlanId",
                principalTable: "LoadPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
