using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_ULDTracking_Table_And_Update_ULD_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "ULDType",
                table: "ULDs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LendAirlineCode",
                table: "ULDs",
                type: "varchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerAirlineCode",
                table: "ULDs",
                type: "varchar(2)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ULDLocateStatus",
                table: "ULDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "ULDOwnershipType",
                table: "ULDs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<double>(
                name: "MaxVolume",
                table: "ULDMetaDatas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxWeight",
                table: "ULDMetaDatas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ULDTrackings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUsedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUsedFlightNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    LastLocatedAirportCode = table.Column<string>(type: "varchar(3)", nullable: false),
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
                    table.PrimaryKey("PK_ULDTrackings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ULDTrackings_ULDs_ULDId",
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
                value: "58e394d6-f691-45ad-84f8-607d80225b22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "ef632cc4-3c51-4dec-974b-8fbaa7e74364");

            migrationBuilder.CreateIndex(
                name: "IX_ULDTrackings_ULDId",
                table: "ULDTrackings",
                column: "ULDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ULDTrackings");

            migrationBuilder.DropColumn(
                name: "LendAirlineCode",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "OwnerAirlineCode",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "ULDLocateStatus",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "ULDOwnershipType",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "MaxVolume",
                table: "ULDMetaDatas");

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "ULDMetaDatas");

            migrationBuilder.AlterColumn<int>(
                name: "ULDType",
                table: "ULDs",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "f351dc37-e8ad-4500-b2b4-503d61c665b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "57e1024f-eadc-496d-becd-0716d58c07d5");
        }
    }
}
