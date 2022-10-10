using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Delete_Table_PackageContainerSector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageContainerSectors");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "444b8b30-e009-4416-967f-d3571b9df529");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "a2e3612b-d417-4477-9cd6-0ad3ca27fe5c");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PackageContainerSectors",
                columns: table => new
                {
                    PackageContainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageContainerSectors", x => new { x.PackageContainerId, x.SectorId });
                    table.ForeignKey(
                        name: "FK_PackageContainerSectors_PackageContainers_PackageContainerId",
                        column: x => x.PackageContainerId,
                        principalTable: "PackageContainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageContainerSectors_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "b0970a94-f243-4ce0-b80b-4ec696de6b0f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "5619d218-732b-40ef-9d22-06feb06f85ae");

            migrationBuilder.InsertData(
                table: "PackageContainerSectors",
                columns: new[] { "PackageContainerId", "SectorId", "Id", "Rate" },
                values: new object[,]
                {
                    { new Guid("26ea2f00-e28c-4616-8920-eef3fcc16a81"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("24f68a31-93ae-4ec6-b90d-69311d27b9e4"), 40.0 },
                    { new Guid("407dc3d4-f0b9-4d9e-b646-d5fed84736e5"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("bf5f4989-83a3-468a-afe2-c67439b7f24f"), 35.0 },
                    { new Guid("8d462fb5-7fbc-40ea-8c9e-95b0b1485f48"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("fc4ccb73-8cba-46ea-aebc-0b33edda4ce3"), 20.0 },
                    { new Guid("a65dd21b-07c1-43be-9917-2973ccdb0f82"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("8688b077-eb0b-440a-855b-e2d122c5d5d0"), 55.0 },
                    { new Guid("bf0e8db1-fb98-4453-a011-c146931f49c4"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("71607f97-88ad-4a71-b8f8-7dd6e0713d8a"), 20.0 },
                    { new Guid("c586fb65-a6dc-41c1-b512-593f7e088396"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("302ee0c9-92c4-4aa2-a1d7-9aaf93e2249f"), 45.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageContainerSectors_SectorId",
                table: "PackageContainerSectors",
                column: "SectorId");
        }
    }
}
