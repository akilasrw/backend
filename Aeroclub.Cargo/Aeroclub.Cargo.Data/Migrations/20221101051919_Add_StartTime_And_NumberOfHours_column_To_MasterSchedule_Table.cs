using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_StartTime_And_NumberOfHours_column_To_MasterSchedule_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ScheduleStartDateTime",
                table: "MasterSchedules",
                newName: "ScheduleStartDate");

            migrationBuilder.RenameColumn(
                name: "ScheduleEndDateTime",
                table: "MasterSchedules",
                newName: "ScheduleEndDate");

            migrationBuilder.AddColumn<double>(
                name: "NumberOfHours",
                table: "MasterSchedules",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ScheduleStartTime",
                table: "MasterSchedules",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "0a1a026c-6652-451d-aed6-20d22933e2a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "35bd9850-ff33-452e-9ac1-8c59450225cf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfHours",
                table: "MasterSchedules");

            migrationBuilder.DropColumn(
                name: "ScheduleStartTime",
                table: "MasterSchedules");

            migrationBuilder.RenameColumn(
                name: "ScheduleStartDate",
                table: "MasterSchedules",
                newName: "ScheduleStartDateTime");

            migrationBuilder.RenameColumn(
                name: "ScheduleEndDate",
                table: "MasterSchedules",
                newName: "ScheduleEndDateTime");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "6a8262ec-c13d-47f8-892b-730613839878");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "0163663a-7e61-41d6-831f-8657752277a1");
        }
    }
}
