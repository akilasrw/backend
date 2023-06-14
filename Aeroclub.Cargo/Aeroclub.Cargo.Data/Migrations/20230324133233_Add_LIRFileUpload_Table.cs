using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_LIRFileUpload_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIRFileUploads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    OriginalFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileURLPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileFullURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extesnsion = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIRFileUploads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LIRFileUploads_FlightSchedules_FlightScheduleId",
                        column: x => x.FlightScheduleId,
                        principalTable: "FlightSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "fb31af51-f41d-421e-a607-adf79a721b57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "ade3c89b-7c22-4bee-8387-1d49ce754162");

            migrationBuilder.CreateIndex(
                name: "IX_LIRFileUploads_FlightScheduleId",
                table: "LIRFileUploads",
                column: "FlightScheduleId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIRFileUploads");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "772fe11f-ce41-4494-a75a-87c5fd7d03c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "9911bc80-d927-42ce-be1c-747440355be1");
        }
    }
}
