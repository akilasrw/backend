using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Seed_Aircraft_Type_And_Sub_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("aeb095ac-8223-475f-ac38-aa121701a8e5"),
                column: "ConfigType",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9876fc3-8d2b-4692-b1b6-75e35d5b507e"),
                column: "ConfigType",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"),
                column: "ConfigType",
                value: (short)1);

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0590732-9743-4516-83ed-9b0793606592"),
                column: "ConfigType",
                value: (short)1);

            migrationBuilder.InsertData(
                table: "AircraftTypes",
                columns: new[] { "Id", "ConfigType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[] { new Guid("38e09702-0304-477c-abf5-126d78eae873"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B737-400", (short)3 });

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

            migrationBuilder.InsertData(
                table: "AircraftSubTypes",
                columns: new[] { "Id", "AircraftTypeId", "ConfigType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[] { new Guid("f3a48155-5dd6-4517-a682-28fa19b79387"), new Guid("38e09702-0304-477c-abf5-126d78eae873"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B737-400-TypeOne", (short)3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f3a48155-5dd6-4517-a682-28fa19b79387"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("38e09702-0304-477c-abf5-126d78eae873"));

            migrationBuilder.UpdateData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("aeb095ac-8223-475f-ac38-aa121701a8e5"),
                column: "ConfigType",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9876fc3-8d2b-4692-b1b6-75e35d5b507e"),
                column: "ConfigType",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"),
                column: "ConfigType",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0590732-9743-4516-83ed-9b0793606592"),
                column: "ConfigType",
                value: (short)0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "0799a77e-0d7d-4f2c-a606-3757495d8907");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "bee7a345-0e4b-42c5-932a-d2e2b4404fda");
        }
    }
}
