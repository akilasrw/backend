using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Aircraft_Type_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AircraftTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    Type = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftSubTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AircraftTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    Type = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftSubTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftSubTypes_AircraftTypes_AircraftTypeId",
                        column: x => x.AircraftTypeId,
                        principalTable: "AircraftTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AircraftLayoutMappings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AircraftTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AircraftSubTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AircraftLayoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeatLayoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OverheadLayoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftLayoutMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AircraftLayoutMappings_AircraftLayouts_AircraftLayoutId",
                        column: x => x.AircraftLayoutId,
                        principalTable: "AircraftLayouts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AircraftLayoutMappings_AircraftSubTypes_AircraftSubTypeId",
                        column: x => x.AircraftSubTypeId,
                        principalTable: "AircraftSubTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AircraftLayoutMappings_AircraftTypes_AircraftTypeId",
                        column: x => x.AircraftTypeId,
                        principalTable: "AircraftTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AircraftLayoutMappings_OverheadLayouts_OverheadLayoutId",
                        column: x => x.OverheadLayoutId,
                        principalTable: "OverheadLayouts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AircraftLayoutMappings_SeatLayouts_SeatLayoutId",
                        column: x => x.SeatLayoutId,
                        principalTable: "SeatLayouts",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "64259524-3282-4984-8fe6-9e503d97aa34");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "5532d7e2-3db2-4e43-83a5-d927998c4ff7");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftLayoutMappings_AircraftLayoutId",
                table: "AircraftLayoutMappings",
                column: "AircraftLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftLayoutMappings_AircraftSubTypeId",
                table: "AircraftLayoutMappings",
                column: "AircraftSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftLayoutMappings_AircraftTypeId",
                table: "AircraftLayoutMappings",
                column: "AircraftTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftLayoutMappings_OverheadLayoutId",
                table: "AircraftLayoutMappings",
                column: "OverheadLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftLayoutMappings_SeatLayoutId",
                table: "AircraftLayoutMappings",
                column: "SeatLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftSubTypes_AircraftTypeId",
                table: "AircraftSubTypes",
                column: "AircraftTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftLayoutMappings");

            migrationBuilder.DropTable(
                name: "AircraftSubTypes");

            migrationBuilder.DropTable(
                name: "AircraftTypes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "12884137-da52-4808-9fe5-94f059d74335");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "2996d824-5b03-436e-b657-66c340a27da3");
        }
    }
}
