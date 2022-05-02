using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_AWB_Information_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AWBInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipperName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ShipperAccountNumber = table.Column<string>(type: "varchar(40)", nullable: true),
                    ShipperAddress = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ConsigneeName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ConsigneeAccountNumber = table.Column<string>(type: "varchar(40)", nullable: true),
                    ConsigneeAddress = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    AgentName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AgentCity = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    AgentAITACode = table.Column<string>(type: "varchar(40)", nullable: true),
                    AgentAccountNumber = table.Column<string>(type: "varchar(40)", nullable: true),
                    AgentAccountInformation = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    RequestedRouting = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RoutingAndDestinationTo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RoutingAndDestinationBy = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RequestedFlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestinationAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationAirportCode = table.Column<string>(type: "varchar(3)", nullable: true),
                    ShippingReferenceNumber = table.Column<string>(type: "varchar(40)", nullable: true),
                    Currency = table.Column<string>(type: "varchar(10)", nullable: true),
                    DeclaredValueForCarriage = table.Column<double>(type: "float", nullable: false),
                    DeclaredValueForCustomer = table.Column<double>(type: "float", nullable: false),
                    AmountOfInsurance = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AWBInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AWBProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductRefNumber = table.Column<string>(type: "varchar(40)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProductType = table.Column<byte>(type: "tinyint", nullable: false),
                    Quantity = table.Column<byte>(type: "tinyint", nullable: false),
                    AWBInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AWBProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AWBProducts_AWBInformations_AWBInformationId",
                        column: x => x.AWBInformationId,
                        principalTable: "AWBInformations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AWBProducts_AWBInformationId",
                table: "AWBProducts",
                column: "AWBInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AWBProducts");

            migrationBuilder.DropTable(
                name: "AWBInformations");
        }
    }
}
