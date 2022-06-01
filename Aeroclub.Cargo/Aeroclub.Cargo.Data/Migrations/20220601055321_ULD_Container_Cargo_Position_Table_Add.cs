using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class ULD_Container_Cargo_Position_Table_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ULDContainerCargoPositions",
                columns: table => new
                {
                    ULDContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoPositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ULDContainerCargoPositions", x => new { x.ULDContainerId, x.CargoPositionId });
                    table.ForeignKey(
                        name: "FK_ULDContainerCargoPositions_CargoPositions_CargoPositionId",
                        column: x => x.CargoPositionId,
                        principalTable: "CargoPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ULDContainerCargoPositions_ULDContainers_ULDContainerId",
                        column: x => x.ULDContainerId,
                        principalTable: "ULDContainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "744e736b-3653-42d6-9b67-b340670c5ddd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "203d78dc-ee9e-4799-a663-c6c4e845561d");

            migrationBuilder.CreateIndex(
                name: "IX_ULDContainerCargoPositions_CargoPositionId",
                table: "ULDContainerCargoPositions",
                column: "CargoPositionId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ULDContainerCargoPositions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a43ac988-4bcc-44b3-8c81-02e375569f4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "883a62f7-77ca-4e09-a88c-9d5e5d7db1a7");
        }
    }
}
