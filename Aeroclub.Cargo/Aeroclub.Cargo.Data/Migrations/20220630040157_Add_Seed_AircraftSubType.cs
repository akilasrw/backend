using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_AircraftSubType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AircraftSubTypes",
                columns: new[] { "Id", "AircraftTypeId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("aeb095ac-8223-475f-ac38-aa121701a8e5"), new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B787-9-TypeOne", (short)1 },
                    { new Guid("c897cdf2-b13b-4b41-9ca8-f2e314567029"), new Guid("d0590732-9743-4516-83ed-9b0793606592"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "A320-200-TypeTwo", (short)4 },
                    { new Guid("f03deacf-9212-4f47-ad80-6b29e163dad3"), new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B787-9-TypeTwo", (short)2 },
                    { new Guid("f9876fc3-8d2b-4692-b1b6-75e35d5b507e"), new Guid("d0590732-9743-4516-83ed-9b0793606592"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "A320-200-TypeOne", (short)3 }
                });

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"),
                column: "Name",
                value: "B787-9");

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0590732-9743-4516-83ed-9b0793606592"),
                column: "Name",
                value: "A320-200");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "7f407655-e2d5-4700-b9a0-aca65ef77859");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "234189a0-db27-4a0b-9b0d-b0909a779512");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("aeb095ac-8223-475f-ac38-aa121701a8e5"));

            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("c897cdf2-b13b-4b41-9ca8-f2e314567029"));

            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f03deacf-9212-4f47-ad80-6b29e163dad3"));

            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9876fc3-8d2b-4692-b1b6-75e35d5b507e"));

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4206db7d-6bc5-4cb3-9167-619bde990e8d"),
                column: "Name",
                value: "B7879");

            migrationBuilder.UpdateData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0590732-9743-4516-83ed-9b0793606592"),
                column: "Name",
                value: "A320200");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "04e4ad07-24e0-457e-a2d3-c0a0035d4e70");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "1c3dda50-76f9-490e-958a-dfc9e27b1f57");
        }
    }
}
