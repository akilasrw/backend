using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_AWBStack_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AWBStacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartSequenceNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    EndSequenceNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUsedSequenceNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    IsSequenceCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CargoAgentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AWBStacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AWBStacks_CargoAgents_CargoAgentId",
                        column: x => x.CargoAgentId,
                        principalTable: "CargoAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AWBStacks_CargoAgentId",
                table: "AWBStacks",
                column: "CargoAgentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AWBStacks");
        }
    }
}
