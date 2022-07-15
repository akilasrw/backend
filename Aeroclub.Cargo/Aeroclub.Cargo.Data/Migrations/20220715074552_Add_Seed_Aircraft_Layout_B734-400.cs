using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_Aircraft_Layout_B734400 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AircraftLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("4fabebe4-0300-42ae-9a8f-3239e485f5d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "0d4d8245-82fa-423b-af5e-738e56cf211a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "f956aac3-4f27-4595-9a11-15f1e37d50d7");

            migrationBuilder.InsertData(
                table: "AircraftDecks",
                columns: new[] { "Id", "AircraftDeckType", "AircraftLayoutId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight" },
                values: new object[] { new Guid("67167a1a-e21a-4e94-be2b-dfa731d24999"), (short)1, new Guid("4fabebe4-0300-42ae-9a8f-3239e485f5d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 17500.0 });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("b7ed5af0-4788-4528-ab2d-dc80a8bb182e"), new Guid("67167a1a-e21a-4e94-be2b-dfa731d24999"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 17500.0, "" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("22019ea9-d91a-4b95-835d-80b9659133cf"), new Guid("b7ed5af0-4788-4528-ab2d-dc80a8bb182e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 17500.0, "OA" });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("47e9c885-5b58-4d34-9b35-edf1a1ffd24c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2948.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("575660cd-b062-47f2-903b-82b2dbc55523"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 3628.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("65af4d12-3f61-4174-ade1-e9c1fcc8147e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2948.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("687cea80-09d4-45b2-b26c-5db97ee4190f"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 3628.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("6fb941a5-883f-48e3-a611-fee21e03c8bc"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2948.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("92085e85-70ff-4eb5-8032-3d0eb42d32bb"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 1814.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("9efb973d-9d14-4790-920f-f6f6ac356cd2"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2948.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("cf2ac95f-2457-429d-87aa-13789cd6f6ab"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2948.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("ef7c6071-f97e-4be7-aae7-fcfa9be55dd9"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 1814.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("f6688957-381c-4693-a396-b40592b3d2f5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2948.0, "", null, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("47e9c885-5b58-4d34-9b35-edf1a1ffd24c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("575660cd-b062-47f2-903b-82b2dbc55523"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("65af4d12-3f61-4174-ade1-e9c1fcc8147e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("687cea80-09d4-45b2-b26c-5db97ee4190f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6fb941a5-883f-48e3-a611-fee21e03c8bc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("92085e85-70ff-4eb5-8032-3d0eb42d32bb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9efb973d-9d14-4790-920f-f6f6ac356cd2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cf2ac95f-2457-429d-87aa-13789cd6f6ab"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ef7c6071-f97e-4be7-aae7-fcfa9be55dd9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6688957-381c-4693-a396-b40592b3d2f5"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("22019ea9-d91a-4b95-835d-80b9659133cf"));

            migrationBuilder.DeleteData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("b7ed5af0-4788-4528-ab2d-dc80a8bb182e"));

            migrationBuilder.DeleteData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("67167a1a-e21a-4e94-be2b-dfa731d24999"));

            migrationBuilder.DeleteData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("4fabebe4-0300-42ae-9a8f-3239e485f5d5"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "304579e4-bea3-46fb-a90e-659bd3ba470d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "f95474de-d214-4ac1-bb50-5c46c0bd1ca8");
        }
    }
}
