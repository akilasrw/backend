using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class AddAgentOtherRates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentOtherRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RateDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPreceptionRate = table.Column<int>(type: "int", nullable: false),
                    RatePerKG = table.Column<int>(type: "int", nullable: false),
                    FixRate = table.Column<int>(type: "int", nullable: false),
                    TrancheRate = table.Column<int>(type: "int", nullable: false),
                    IATACode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentOtherRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentOtherRates_ChildRateCategories_ChildCategoryID",
                        column: x => x.ChildCategoryID,
                        principalTable: "ChildRateCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a6c43710-8ee1-491f-b800-8d1c86862e5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "2495b5c9-0684-43d2-86ad-9bf1cc67c613");

            migrationBuilder.CreateIndex(
                name: "IX_AgentOtherRates_ChildCategoryID",
                table: "AgentOtherRates",
                column: "ChildCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentOtherRates");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a831c1ce-3e3f-4ad7-9e58-46365214ddde");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "996c0966-807a-4b2a-b692-79bac9ceeb39");
        }
    }
}
