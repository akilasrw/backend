using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Seed_Aircraft_Layout_Mapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.AlterColumn<Guid>(
                name: "SeatLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "OverheadLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AircraftLayoutMappings",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftSubTypeId", "AircraftTypeId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OverheadLayoutId", "SeatLayoutId" },
                values: new object[] { new Guid("e2de2fd8-cefb-4e0b-b506-9f48e3c95f2b"), new Guid("4fabebe4-0300-42ae-9a8f-3239e485f5d5"), new Guid("f3a48155-5dd6-4517-a682-28fa19b79387"), new Guid("38e09702-0304-477c-abf5-126d78eae873"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "19a4e0fc-4609-4475-b26d-3593999bb670");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "a9becbb0-7b6f-4889-ab1b-fffaf77e07b5");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts");

            migrationBuilder.DeleteData(
                table: "AircraftLayoutMappings",
                keyColumn: "Id",
                keyValue: new Guid("e2de2fd8-cefb-4e0b-b506-9f48e3c95f2b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SeatLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OverheadLayoutId",
                table: "Aircrafts",
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
                value: "bc9dac54-ba02-432d-ab44-5ee57683beba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "517634be-5b27-4f4d-9b25-7681a92cff81");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_SeatLayouts_SeatLayoutId",
                table: "Aircrafts",
                column: "SeatLayoutId",
                principalTable: "SeatLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
