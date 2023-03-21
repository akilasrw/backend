using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Agent_Rate_Management_and_Rate_History_Tabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgentRateManagements_CargoAgents_CargoAgentId",
                table: "AgentRateManagements");

            migrationBuilder.AlterColumn<Guid>(
                name: "CargoAgentId",
                table: "AgentRateManagements",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<byte>(
                name: "CargoType",
                table: "AgentRateManagements",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "RateType",
                table: "AgentRateManagements",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<Guid>(
                name: "CargoAgentId",
                table: "AgentRateManagementHistorys",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<byte>(
                name: "CargoType",
                table: "AgentRateManagementHistorys",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "RateType",
                table: "AgentRateManagementHistorys",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AgentRateManagements_CargoAgents_CargoAgentId",
                table: "AgentRateManagements",
                column: "CargoAgentId",
                principalTable: "CargoAgents",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgentRateManagements_CargoAgents_CargoAgentId",
                table: "AgentRateManagements");

            migrationBuilder.DropColumn(
                name: "CargoType",
                table: "AgentRateManagements");

            migrationBuilder.DropColumn(
                name: "RateType",
                table: "AgentRateManagements");

            migrationBuilder.DropColumn(
                name: "CargoType",
                table: "AgentRateManagementHistorys");

            migrationBuilder.DropColumn(
                name: "RateType",
                table: "AgentRateManagementHistorys");

            migrationBuilder.AlterColumn<Guid>(
                name: "CargoAgentId",
                table: "AgentRateManagements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CargoAgentId",
                table: "AgentRateManagementHistorys",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AgentRateManagements_CargoAgents_CargoAgentId",
                table: "AgentRateManagements",
                column: "CargoAgentId",
                principalTable: "CargoAgents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
