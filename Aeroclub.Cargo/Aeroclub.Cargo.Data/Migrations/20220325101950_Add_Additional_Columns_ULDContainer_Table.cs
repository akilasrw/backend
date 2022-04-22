using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Additional_Columns_ULDContainer_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_ULDs_ULDId",
                table: "ULDContainers");

            migrationBuilder.AlterColumn<Guid>(
                name: "ULDId",
                table: "ULDContainers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "ULDContainers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "ULDContainers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalWeight",
                table: "ULDContainers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ULDContainerType",
                table: "ULDContainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "ULDContainers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_ULDContainers_ULDs_ULDId",
                table: "ULDContainers",
                column: "ULDId",
                principalTable: "ULDs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_ULDs_ULDId",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "TotalWeight",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "ULDContainerType",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "ULDContainers");

            migrationBuilder.AlterColumn<Guid>(
                name: "ULDId",
                table: "ULDContainers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ULDContainers_ULDs_ULDId",
                table: "ULDContainers",
                column: "ULDId",
                principalTable: "ULDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
