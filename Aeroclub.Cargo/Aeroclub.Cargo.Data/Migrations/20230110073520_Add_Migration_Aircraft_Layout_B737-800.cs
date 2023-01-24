using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Migration_Aircraft_Layout_B737800 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AircraftLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("229c3fbd-7f2e-4031-9c25-3b379ed3e384"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AircraftTypes",
                columns: new[] { "Id", "ConfigType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[] { new Guid("1dba5394-c448-4572-a213-ca5efed3ac4a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B737-800", (short)4 });

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

            migrationBuilder.InsertData(
                table: "AircraftDecks",
                columns: new[] { "Id", "AircraftDeckType", "AircraftLayoutId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight" },
                values: new object[] { new Guid("b987b1b8-b11d-4d37-adaa-2181a55f6e55"), (short)1, new Guid("229c3fbd-7f2e-4031-9c25-3b379ed3e384"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 23950.0 });

            migrationBuilder.InsertData(
                table: "AircraftSubTypes",
                columns: new[] { "Id", "AircraftTypeId", "ConfigType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Type" },
                values: new object[] { new Guid("0c4aaa7f-1946-4298-9e07-c0b98b15ecb1"), new Guid("1dba5394-c448-4572-a213-ca5efed3ac4a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "B737-800-TypeOne", (short)4 });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("734b679e-fb85-4000-bf05-96b98c644bbc"), new Guid("b987b1b8-b11d-4d37-adaa-2181a55f6e55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 23950.0, "" });

            migrationBuilder.InsertData(
                table: "AircraftLayoutMappings",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftSubTypeId", "AircraftTypeId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OverheadLayoutId", "SeatLayoutId" },
                values: new object[] { new Guid("b729d9af-7475-401f-8dd4-4fcb4be0bad1"), new Guid("229c3fbd-7f2e-4031-9c25-3b379ed3e384"), new Guid("0c4aaa7f-1946-4298-9e07-c0b98b15ecb1"), new Guid("1dba5394-c448-4572-a213-ca5efed3ac4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), null, null });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4"), new Guid("734b679e-fb85-4000-bf05-96b98c644bbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 23950.0, "OA" });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentVolume", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxVolume", "MaxWeight", "Name", "OverheadCompartmentId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("16a9609a-de6d-4d7f-803a-baf9ef80dfcf"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "4", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("20e81604-02cd-4bb4-9004-1782a70248d8"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "9", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("6a4a7dbf-1d72-45b8-8924-c9a6ce343e66"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "10", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("84dfd57f-7047-4397-81fc-8b5d2e5bdd7b"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "8", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("8c539701-d185-44dc-aa3a-fef9faaf6abe"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 3628.0, "6", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("a308ea90-7563-45ab-b66b-cb7a337fb13a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 1814.0, "1", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("aee338b3-5956-4093-9d3a-562eca51f111"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "7", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("c5cf9c03-1e5f-4a3e-b5e1-62f7370595a2"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 1814.0, "11", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("c6bfe680-576b-4665-b8c4-983cd40ae75c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "3", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("c82a3478-b75a-4f29-b14a-04bf35e4a621"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 3628.0, "5", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("de85a837-c37c-40be-bda1-b1932651fe00"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9000000.0, 2948.0, "2", null, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftLayoutMappings",
                keyColumn: "Id",
                keyValue: new Guid("b729d9af-7475-401f-8dd4-4fcb4be0bad1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("16a9609a-de6d-4d7f-803a-baf9ef80dfcf"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("20e81604-02cd-4bb4-9004-1782a70248d8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6a4a7dbf-1d72-45b8-8924-c9a6ce343e66"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("84dfd57f-7047-4397-81fc-8b5d2e5bdd7b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8c539701-d185-44dc-aa3a-fef9faaf6abe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a308ea90-7563-45ab-b66b-cb7a337fb13a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("aee338b3-5956-4093-9d3a-562eca51f111"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c5cf9c03-1e5f-4a3e-b5e1-62f7370595a2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c6bfe680-576b-4665-b8c4-983cd40ae75c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c82a3478-b75a-4f29-b14a-04bf35e4a621"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("de85a837-c37c-40be-bda1-b1932651fe00"));

            migrationBuilder.DeleteData(
                table: "AircraftSubTypes",
                keyColumn: "Id",
                keyValue: new Guid("0c4aaa7f-1946-4298-9e07-c0b98b15ecb1"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4"));

            migrationBuilder.DeleteData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("734b679e-fb85-4000-bf05-96b98c644bbc"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("1dba5394-c448-4572-a213-ca5efed3ac4a"));

            migrationBuilder.DeleteData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("b987b1b8-b11d-4d37-adaa-2181a55f6e55"));

            migrationBuilder.DeleteData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("229c3fbd-7f2e-4031-9c25-3b379ed3e384"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "bd41a0f9-a19e-4a79-a974-6d0ad725e835");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "9c38d2e4-e405-4d52-a724-2c8f94a02595");
        }
    }
}
