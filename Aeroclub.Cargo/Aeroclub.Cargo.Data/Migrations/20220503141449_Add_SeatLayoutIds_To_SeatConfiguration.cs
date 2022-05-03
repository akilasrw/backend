using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_SeatLayoutIds_To_SeatConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<bool>(
            //    name: "IsBaseLayout",
            //    table: "SeatLayouts",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<bool>(
            //    name: "IsBaseLayout",
            //    table: "AircraftLayouts",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("605ee297-42da-4975-a072-c356cfd9afd3"),
                column: "IsBaseLayout",
                value: true);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("93aaf79f-12a3-4264-8172-756123f833b4"),
                column: "SeatLayoutId",
                value: new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"));

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"),
                column: "SeatLayoutId",
                value: new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"));

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f9078389-e087-4108-98e5-99f3a467e7df"),
                column: "SeatLayoutId",
                value: new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"));

            migrationBuilder.UpdateData(
                table: "SeatLayouts",
                keyColumn: "Id",
                keyValue: new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"),
                column: "IsBaseLayout",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "IsBaseLayout",
            //    table: "SeatLayouts");

            //migrationBuilder.DropColumn(
            //    name: "IsBaseLayout",
            //    table: "AircraftLayouts");

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("93aaf79f-12a3-4264-8172-756123f833b4"),
                column: "SeatLayoutId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"),
                column: "SeatLayoutId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f9078389-e087-4108-98e5-99f3a467e7df"),
                column: "SeatLayoutId",
                value: null);
        }
    }
}
