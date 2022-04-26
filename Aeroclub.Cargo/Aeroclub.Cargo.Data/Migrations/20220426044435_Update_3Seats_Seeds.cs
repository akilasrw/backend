using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_3Seats_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1928a932-3074-4faa-a809-a2b96fe3fda2"),
                columns: new[] { "CargoPositionType", "SeatId" },
                values: new object[] { 3, new Guid("af08b19f-deac-4186-984c-1367cfb25511") });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[] { new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, (byte)3, null });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[] { new Guid("0e9c2131-5d63-4073-bf5a-398e3ba44964"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("f9078389-e087-4108-98e5-99f3a467e7df"), "1B", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[] { new Guid("0d5f37dc-ea44-4232-9d7c-a26555ff453a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), "3B", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[] { new Guid("9310d2be-2d22-4343-84ab-32a70d9c8207"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), "3C", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[] { new Guid("e658aed0-cdf6-4540-9e26-60768ad945b5"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), "3A", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d5f37dc-ea44-4232-9d7c-a26555ff453a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e9c2131-5d63-4073-bf5a-398e3ba44964"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9310d2be-2d22-4343-84ab-32a70d9c8207"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e658aed0-cdf6-4540-9e26-60768ad945b5"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"));

            migrationBuilder.UpdateData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1928a932-3074-4faa-a809-a2b96fe3fda2"),
                columns: new[] { "CargoPositionType", "SeatId" },
                values: new object[] { 1, null });
        }
    }
}
