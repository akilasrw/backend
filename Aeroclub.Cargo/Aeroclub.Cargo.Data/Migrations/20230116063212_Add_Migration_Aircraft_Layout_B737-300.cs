using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Migration_Aircraft_Layout_B737300 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AircraftLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("9df78fa4-09dc-4c96-b2c3-bc813ceb825f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AircraftTypes",
                columns: new[] { "Id", "ConfigType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[] { new Guid("09ba043c-5e15-4b65-af7a-673b7b75d393"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B737-300", (short)5 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "6e7d54cc-4fde-4511-8e5a-e11766340528");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "05e20a2c-54b2-4562-ae07-76d07a5a6b5a");

            migrationBuilder.InsertData(
                table: "AircraftDecks",
                columns: new[] { "Id", "AircraftDeckType", "AircraftLayoutId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight" },
                values: new object[] { new Guid("d1511f6c-94a0-4da1-82db-b13fd59fadfa"), (short)1, new Guid("9df78fa4-09dc-4c96-b2c3-bc813ceb825f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 19460.0 });

            migrationBuilder.InsertData(
                table: "AircraftSubTypes",
                columns: new[] { "Id", "AircraftTypeId", "ConfigType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[] { new Guid("b7a3ef2d-e39a-4684-8fb8-c16cf14402ce"), new Guid("09ba043c-5e15-4b65-af7a-673b7b75d393"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B737-300-TypeOne", (short)5 });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("5bf67920-3d3e-457f-9f45-589388ac432a"), new Guid("d1511f6c-94a0-4da1-82db-b13fd59fadfa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 19460.0, "" });

            migrationBuilder.InsertData(
                table: "AircraftLayoutMappings",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftSubTypeId", "AircraftTypeId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OverheadLayoutId", "SeatLayoutId" },
                values: new object[] { new Guid("3fa43888-8cf7-43f6-87e0-172c34503997"), new Guid("9df78fa4-09dc-4c96-b2c3-bc813ceb825f"), new Guid("b7a3ef2d-e39a-4684-8fb8-c16cf14402ce"), new Guid("09ba043c-5e15-4b65-af7a-673b7b75d393"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), null, null });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b"), new Guid("5bf67920-3d3e-457f-9f45-589388ac432a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 19460.0, "OA" });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentVolume", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxVolume", "MaxWeight", "Name", "OverheadCompartmentId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("507388e5-7101-476a-afba-523033832484"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "3", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("5271d1b5-b157-4984-b463-1967c0e899e4"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "8", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("7a98da3d-6df3-461a-951d-8fb0cb5256ab"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 3628.0, "4", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("963354d6-5d9a-4c58-9a00-68c43d491d9c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 3628.0, "5", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("99c84a72-a3ef-454a-aecc-acf508c9d73c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "6", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("9bdad1de-3849-4d9b-830d-5ec84e74ca3b"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "2", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("ab24cfcb-056d-4405-b8cb-50ca45682fa0"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "7", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("b204a0c4-5615-4871-acd1-bc570dfb96e1"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 1814.0, "1", null, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftLayoutMappings",
                keyColumn: "Id",
                keyValue: new Guid("3fa43888-8cf7-43f6-87e0-172c34503997"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("507388e5-7101-476a-afba-523033832484"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5271d1b5-b157-4984-b463-1967c0e899e4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7a98da3d-6df3-461a-951d-8fb0cb5256ab"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("963354d6-5d9a-4c58-9a00-68c43d491d9c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("99c84a72-a3ef-454a-aecc-acf508c9d73c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9bdad1de-3849-4d9b-830d-5ec84e74ca3b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ab24cfcb-056d-4405-b8cb-50ca45682fa0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b204a0c4-5615-4871-acd1-bc570dfb96e1"));

            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7a3ef2d-e39a-4684-8fb8-c16cf14402ce"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b"));

            migrationBuilder.DeleteData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("5bf67920-3d3e-457f-9f45-589388ac432a"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("09ba043c-5e15-4b65-af7a-673b7b75d393"));

            migrationBuilder.DeleteData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("d1511f6c-94a0-4da1-82db-b13fd59fadfa"));

            migrationBuilder.DeleteData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("9df78fa4-09dc-4c96-b2c3-bc813ceb825f"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "9fac9deb-6c6a-4f16-8f2b-4268aa2a18da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "af12ba28-1c40-4e23-8a40-837d42ce4680");
        }
    }
}
