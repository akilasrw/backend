using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Agent_Rate_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentRateManagementHistorys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoAgentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginAirportCode = table.Column<string>(type: "varchar(3)", nullable: false),
                    DestinationAirportCode = table.Column<string>(type: "varchar(3)", nullable: false),
                    OriginAirportName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    DestinationAirportName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    WeightType = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentRateManagementHistorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgentRateManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoAgentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginAirportCode = table.Column<string>(type: "varchar(3)", nullable: false),
                    DestinationAirportCode = table.Column<string>(type: "varchar(3)", nullable: false),
                    OriginAirportName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    DestinationAirportName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentRateManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentRateManagements_Airports_DestinationAirportId",
                        column: x => x.DestinationAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgentRateManagements_Airports_OriginAirportId",
                        column: x => x.OriginAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgentRateManagements_CargoAgents_CargoAgentId",
                        column: x => x.CargoAgentId,
                        principalTable: "CargoAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgentRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgentRateManagementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    WeightType = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentRates_AgentRateManagements_AgentRateManagementId",
                        column: x => x.AgentRateManagementId,
                        principalTable: "AgentRateManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a0a7fc80-6d5a-41b8-bfbf-73bf7d114916");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "dfb05d0e-f6a7-4387-9c96-7c094ebffb2c");

            migrationBuilder.CreateIndex(
                name: "IX_AgentRateManagements_CargoAgentId",
                table: "AgentRateManagements",
                column: "CargoAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentRateManagements_DestinationAirportId",
                table: "AgentRateManagements",
                column: "DestinationAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentRateManagements_OriginAirportId",
                table: "AgentRateManagements",
                column: "OriginAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentRates_AgentRateManagementId",
                table: "AgentRates",
                column: "AgentRateManagementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentRateManagementHistorys");

            migrationBuilder.DropTable(
                name: "AgentRates");

            migrationBuilder.DropTable(
                name: "AgentRateManagements");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "af894c85-df82-44a3-a76e-ac45846e5855");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "192d3857-2cf2-4c0a-a016-8afaf2d5807a");
        }
    }
}
