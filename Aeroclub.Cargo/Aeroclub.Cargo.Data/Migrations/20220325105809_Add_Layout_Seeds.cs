using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Layout_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AircraftLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("605ee297-42da-4975-a072-c356cfd9afd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "FlightSectors",
                columns: new[] { "FlightId", "SectorId", "Sequence" },
                values: new object[] { new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"), new Guid("8ae55489-4677-411a-802e-b74f5885f893"), (byte)1 });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("93aaf79f-12a3-4264-8172-756123f833b4"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, (byte)1, null },
                    { new Guid("f9078389-e087-4108-98e5-99f3a467e7df"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, (byte)1, null }
                });

            migrationBuilder.InsertData(
                table: "SeatLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsCloned", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AircraftDecks",
                columns: new[] { "Id", "AircraftDeckType", "AircraftLayoutId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight" },
                values: new object[] { new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"), (short)1, new Guid("605ee297-42da-4975-a072-c356cfd9afd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 15000.0 });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "RegNo", "SeatLayoutId" },
                values: new object[] { new Guid("f2659d05-2507-4c36-8f1b-e84045a9ae15"), new Guid("605ee297-42da-4975-a072-c356cfd9afd3"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "", new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482") });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("916814cb-7631-4e14-aec2-e1c9cfa0cbf8"), new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 10000.0, "FWD Cabin" });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("b6a55e15-8a2f-4081-9e3e-64ac35cb877b"), new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 10000.0, "AFT Cabin" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("9941a104-5ded-4be8-bdcb-a54820635d06"), new Guid("916814cb-7631-4e14-aec2-e1c9cfa0cbf8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 5000.0, "OB" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca"), new Guid("916814cb-7631-4e14-aec2-e1c9cfa0cbf8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 5000.0, "OA" });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "SeatId", "ZoneAreaId" },
                values: new object[] { new Guid("1928a932-3074-4faa-a809-a2b96fe3fda2"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2500.0, "", null, new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[] { new Guid("af08b19f-deac-4186-984c-1367cfb25511"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("93aaf79f-12a3-4264-8172-756123f833b4"), "1A", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "SeatId", "ZoneAreaId" },
                values: new object[] { new Guid("0fc9f3ce-5275-4c29-8fce-446a32a5c8ec"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2500.0, "", new Guid("af08b19f-deac-4186-984c-1367cfb25511"), new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("b6a55e15-8a2f-4081-9e3e-64ac35cb877b"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("f2659d05-2507-4c36-8f1b-e84045a9ae15"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0fc9f3ce-5275-4c29-8fce-446a32a5c8ec"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1928a932-3074-4faa-a809-a2b96fe3fda2"));

            migrationBuilder.DeleteData(
                table: "FlightSectors",
                keyColumns: new[] { "FlightId", "SectorId" },
                keyValues: new object[] { new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"), new Guid("8ae55489-4677-411a-802e-b74f5885f893") });

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f9078389-e087-4108-98e5-99f3a467e7df"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("9941a104-5ded-4be8-bdcb-a54820635d06"));

            migrationBuilder.DeleteData(
                table: "SeatLayouts",
                keyColumn: "Id",
                keyValue: new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af08b19f-deac-4186-984c-1367cfb25511"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("93aaf79f-12a3-4264-8172-756123f833b4"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca"));

            migrationBuilder.DeleteData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("916814cb-7631-4e14-aec2-e1c9cfa0cbf8"));

            migrationBuilder.DeleteData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"));

            migrationBuilder.DeleteData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("605ee297-42da-4975-a072-c356cfd9afd3"));
        }
    }
}
