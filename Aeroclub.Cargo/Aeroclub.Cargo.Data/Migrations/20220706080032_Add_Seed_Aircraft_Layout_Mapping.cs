using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_Aircraft_Layout_Mapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("c897cdf2-b13b-4b41-9ca8-f2e314567029"));

            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f03deacf-9212-4f47-ad80-6b29e163dad3"));

            migrationBuilder.InsertData(
                table: "AircraftLayoutMappings",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftSubTypeId", "AircraftTypeId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OverheadLayoutId", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("675631d1-6a13-4d65-8700-664a35a44297"), new Guid("6c921671-64df-42fb-bb09-291e392156fd"), new Guid("f9876fc3-8d2b-4692-b1b6-75e35d5b507e"), new Guid("d0590732-9743-4516-83ed-9b0793606592"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("70182a4b-654c-413d-85e4-a9b27d615b0c"), new Guid("87da2cd2-afc4-4258-b67e-003283224206"), new Guid("aeb095ac-8223-475f-ac38-aa121701a8e5"), new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") }
                });

            migrationBuilder.UpdateData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9876fc3-8d2b-4692-b1b6-75e35d5b507e"),
                column: "Type",
                value: (short)2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "b5b79c24-13af-4d63-a518-53852b97c0a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "963b9ed6-e168-4d31-813c-987a13bc78b9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftLayoutMappings",
                keyColumn: "Id",
                keyValue: new Guid("675631d1-6a13-4d65-8700-664a35a44297"));

            migrationBuilder.DeleteData(
                table: "AircraftLayoutMappings",
                keyColumn: "Id",
                keyValue: new Guid("70182a4b-654c-413d-85e4-a9b27d615b0c"));

            migrationBuilder.UpdateData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9876fc3-8d2b-4692-b1b6-75e35d5b507e"),
                column: "Type",
                value: (short)3);

            migrationBuilder.InsertData(
                table: "AircraftSubTypes",
                columns: new[] { "Id", "AircraftTypeId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("c897cdf2-b13b-4b41-9ca8-f2e314567029"), new Guid("d0590732-9743-4516-83ed-9b0793606592"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "A320-200-TypeTwo", (short)4 },
                    { new Guid("f03deacf-9212-4f47-ad80-6b29e163dad3"), new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B787-9-TypeTwo", (short)2 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "0a0f8f99-a972-48ab-8523-903314177020");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "cecf96bc-b425-4cdb-899c-11bd7ee5ee7f");
        }
    }
}
