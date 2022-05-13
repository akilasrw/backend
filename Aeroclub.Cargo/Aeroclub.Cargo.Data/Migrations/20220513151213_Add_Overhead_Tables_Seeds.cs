using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Overhead_Tables_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("9941a104-5ded-4be8-bdcb-a54820635d06"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f9078389-e087-4108-98e5-99f3a467e7df"));

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
                table: "SeatLayouts",
                keyColumn: "Id",
                keyValue: new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"));

            migrationBuilder.DeleteData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"));

            migrationBuilder.DeleteData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("605ee297-42da-4975-a072-c356cfd9afd3"));

            migrationBuilder.AddColumn<Guid>(
                name: "OverheadLayoutId",
                table: "LoadPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OverheadPositionId",
                table: "CargoPositions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OverheadLayoutId",
                table: "Aircrafts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "OverheadLayouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsBaseLayout = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadLayouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OverheadCompartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    ColumnNumber = table.Column<int>(type: "int", nullable: false),
                    OverheadLayoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadCompartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadCompartments_OverheadLayouts_OverheadLayoutId",
                        column: x => x.OverheadLayoutId,
                        principalTable: "OverheadLayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OverheadPositions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sequence = table.Column<short>(type: "smallint", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: false),
                    ZoneAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OverheadCompartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadPositions_OverheadCompartments_OverheadCompartmentId",
                        column: x => x.OverheadCompartmentId,
                        principalTable: "OverheadCompartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OverheadPositions_ZoneAreas_ZoneAreaId",
                        column: x => x.ZoneAreaId,
                        principalTable: "ZoneAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AircraftLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("6c921671-64df-42fb-bb09-291e392156fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "488f7e4e-2770-44b9-9ed9-15a8ebe1934e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "41a5b545-d8f0-4621-9d6e-429c8287c6f8");

            migrationBuilder.InsertData(
                table: "OverheadLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("9788468f-8da6-4573-af43-509af9b224b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "SeatLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsCloned", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AircraftDecks",
                columns: new[] { "Id", "AircraftDeckType", "AircraftLayoutId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight" },
                values: new object[] { new Guid("6e6e9cd3-29d8-422b-9bfd-0dc0751c75c7"), (short)1, new Guid("6c921671-64df-42fb-bb09-291e392156fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8800.0 });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RegNo", "SeatLayoutId" },
                values: new object[] { new Guid("7286adb4-1da0-4547-ac8d-c3ea5f45c2a9"), new Guid("6c921671-64df-42fb-bb09-291e392156fd"), (short)0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), "A320", new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") });

            migrationBuilder.InsertData(
                table: "OverheadCompartments",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[,]
                {
                    { new Guid("16202785-603d-4261-8057-a35dac9190bc"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 1 },
                    { new Guid("8fcbe5b8-5626-4023-87fa-a05cf56df46e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 2 },
                    { new Guid("a1f00792-eaa4-4216-a5ea-ca650ef42078"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 1 },
                    { new Guid("a63dbf79-e791-4e60-8cee-f8cd3d271872"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 2 },
                    { new Guid("d73021c1-9b4e-4be9-b1d4-8f7428242709"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 3 },
                    { new Guid("f20c7153-4ead-4a47-b6c7-2e59288aa983"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 3 }
                });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("3a9484f7-b074-42e7-980f-c435f1637e1b"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("3cac6b12-f9a9-4a8f-9f26-ec0c510f8cb3"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("458da1a4-15ea-471e-9c0c-49d3a4ffe7fc"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("5d1e4e65-466b-4a27-af41-ce7d55617353"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("61218d5e-987b-4078-bce3-93e46d771d70"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("6175acf7-2dfe-4670-80c8-ed02a605b0e2"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("6af12a15-d5d3-4ed6-b015-cae2a43de479"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("76fc17fa-1cee-4ad3-94ef-6d9d5ae8131a"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("8ab00536-4a4e-4bde-82dc-28c08343f88a"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("90f940d6-b7ad-4fa3-892a-5ed6fb894662"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("c5ea9a98-44f0-4379-ae26-37a892a2bb04"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("c7b27cc1-2510-4ee2-a84c-3d7416833c23"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("c8d4a560-e9d8-49c9-a7c0-3f706d2791fd"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("cd5ff7b8-4d02-4ee7-85ba-94da08073709"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("def86f27-bb76-4fe2-8763-3acb6f0f32ca"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, (byte)1, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") }
                });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("95fb73ba-2285-4a32-ae20-378d2612eacc"), new Guid("6e6e9cd3-29d8-422b-9bfd-0dc0751c75c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8800.0, "" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("2d662146-21b3-476d-8053-9c5994e16637"), new Guid("95fb73ba-2285-4a32-ae20-378d2612eacc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 3200.0, "OC" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("945454c3-c085-4c27-b596-e55bc17971cd"), new Guid("95fb73ba-2285-4a32-ae20-378d2612eacc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 3200.0, "OB" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853"), new Guid("95fb73ba-2285-4a32-ae20-378d2612eacc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2400.0, "OA" });

            migrationBuilder.InsertData(
                table: "OverheadPositions",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadCompartmentId", "Sequence", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("0ed2916a-45e3-4178-8b5b-44201cf067eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("a63dbf79-e791-4e60-8cee-f8cd3d271872"), (short)2, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("184e3c7c-59b0-4430-9e1b-bd7ae54cda25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("a1f00792-eaa4-4216-a5ea-ca650ef42078"), (short)1, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("425f3fc5-2631-4b6a-9734-3ae151b3f258"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8fcbe5b8-5626-4023-87fa-a05cf56df46e"), (short)2, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4a3bc38b-ba62-4b0d-9abd-3e6c77936fc3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("a1f00792-eaa4-4216-a5ea-ca650ef42078"), (short)2, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4ecc77c5-ff36-4bdf-86e2-e5be66dca083"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d73021c1-9b4e-4be9-b1d4-8f7428242709"), (short)1, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("793f3313-c037-4fba-a808-5c857e6bc970"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f20c7153-4ead-4a47-b6c7-2e59288aa983"), (short)1, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("95178f78-5f3e-4bcc-bf78-be6d7df345e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("a63dbf79-e791-4e60-8cee-f8cd3d271872"), (short)3, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("9f666a88-6887-42f3-aeff-2ec1650fc7b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8fcbe5b8-5626-4023-87fa-a05cf56df46e"), (short)3, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("a6c8aecd-4c14-40da-9a04-4d48fa8e8bf6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f20c7153-4ead-4a47-b6c7-2e59288aa983"), (short)2, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c1d1efec-3af5-4d88-a4d6-2f21be2a62a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("a1f00792-eaa4-4216-a5ea-ca650ef42078"), (short)3, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c2af61f7-889b-4ce5-9e9f-eec3f3edd6e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("16202785-603d-4261-8057-a35dac9190bc"), (short)2, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c8d01d74-a80f-4ced-bf07-a0c8cffd600e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d73021c1-9b4e-4be9-b1d4-8f7428242709"), (short)2, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ccfc9b94-6e07-418b-ba6d-05cc824f6351"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8fcbe5b8-5626-4023-87fa-a05cf56df46e"), (short)1, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("e247b36f-fd52-46e4-8346-87f024928769"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("16202785-603d-4261-8057-a35dac9190bc"), (short)3, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("eee7739c-3c12-4ff8-a2c2-ae7e305ec8e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("a63dbf79-e791-4e60-8cee-f8cd3d271872"), (short)1, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f1fa5634-0728-4a67-be42-6ebccbe03f7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("16202785-603d-4261-8057-a35dac9190bc"), (short)1, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("0a20756c-be54-40a2-816a-4a68f02491cc"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, new Guid("3cac6b12-f9a9-4a8f-9f26-ec0c510f8cb3"), "4E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("0fa9ba07-2009-47ba-8461-027fbfa15c45"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, new Guid("5d1e4e65-466b-4a27-af41-ce7d55617353"), "5C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("0fb5901c-7471-4091-930d-bfa71f0237e7"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("c8d4a560-e9d8-49c9-a7c0-3f706d2791fd"), "1B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("144c2683-e60d-437b-9834-c628cd9d2e1a"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("6175acf7-2dfe-4670-80c8-ed02a605b0e2"), "3C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("29e80353-123d-4d8c-9e40-653aae42737f"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("c8d4a560-e9d8-49c9-a7c0-3f706d2791fd"), "1A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("3093eefe-c2fc-4fdf-9076-9547918ad12e"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, new Guid("90f940d6-b7ad-4fa3-892a-5ed6fb894662"), "4B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("3b94462b-3005-4ad3-9493-65ec3fd31cb6"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"), "6E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4910e28d-9419-4e46-9b72-5ed18a7c91e6"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"), "6F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4a8b6f8d-4134-447b-a89c-0bb15501fa14"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, new Guid("def86f27-bb76-4fe2-8763-3acb6f0f32ca"), "8B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("5599797c-7863-4a82-8c28-ac91fbd5b6e9"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, new Guid("76fc17fa-1cee-4ad3-94ef-6d9d5ae8131a"), "2B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("61f71143-453e-4f33-a762-9558e3e43524"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, new Guid("76fc17fa-1cee-4ad3-94ef-6d9d5ae8131a"), "2C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("6c710f60-cc13-4968-a17e-2332b2693d28"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, new Guid("76fc17fa-1cee-4ad3-94ef-6d9d5ae8131a"), "2A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("792db330-4a86-4da2-822e-d8f59ffaa36d"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, new Guid("c7b27cc1-2510-4ee2-a84c-3d7416833c23"), "6C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("7d9aa98f-b5b9-4f78-9dcc-c6bff941a640"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, new Guid("def86f27-bb76-4fe2-8763-3acb6f0f32ca"), "8A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8135717e-02ab-4162-a714-97f52a5c548d"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("c8d4a560-e9d8-49c9-a7c0-3f706d2791fd"), "1C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("82ad83db-3cf5-4700-a04d-362427627298"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("458da1a4-15ea-471e-9c0c-49d3a4ffe7fc"), "3D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("85458746-0f2a-4cd3-9fc3-99601073ae2d"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, new Guid("90f940d6-b7ad-4fa3-892a-5ed6fb894662"), "4C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("870d28ee-2152-47d4-b0cd-2b278f0775a7"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, new Guid("c7b27cc1-2510-4ee2-a84c-3d7416833c23"), "6B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("884f7e69-5f53-4bc4-9da4-ab47b33fe4bc"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("6175acf7-2dfe-4670-80c8-ed02a605b0e2"), "3B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8a59ba63-e693-4310-8f3e-da5374b0d536"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, new Guid("8ab00536-4a4e-4bde-82dc-28c08343f88a"), "7A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8c3d5966-a3ca-41c2-8dfb-a11cd87038a6"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("c5ea9a98-44f0-4379-ae26-37a892a2bb04"), "1D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8d020ef8-a330-4b53-89a9-569bd3ce3aa2"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("6175acf7-2dfe-4670-80c8-ed02a605b0e2"), "3A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8d8661e8-f3db-4e81-8807-3f5a2acd584b"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, new Guid("90f940d6-b7ad-4fa3-892a-5ed6fb894662"), "4A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8f757628-2781-4148-ac0a-90a33d95f701"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, new Guid("def86f27-bb76-4fe2-8763-3acb6f0f32ca"), "8C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("95e962bd-0449-4f77-bce2-42e1645bf26e"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("458da1a4-15ea-471e-9c0c-49d3a4ffe7fc"), "3E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("9907ecb2-f93e-4a07-b320-e9f46acc60d1"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("c5ea9a98-44f0-4379-ae26-37a892a2bb04"), "1E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("9b56f0d6-fee5-411c-ad0f-02c0e9f24e6e"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, new Guid("61218d5e-987b-4078-bce3-93e46d771d70"), "7E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("a1eca4b6-58d5-40a5-bdd0-977bbe8f1ced"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, new Guid("8ab00536-4a4e-4bde-82dc-28c08343f88a"), "7B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("a2ecdc1f-fb45-443f-8279-b5027edf9e68"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, new Guid("3cac6b12-f9a9-4a8f-9f26-ec0c510f8cb3"), "4D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("a5b93fe5-d2ff-4f3f-a52a-d44909530ead"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, new Guid("3a9484f7-b074-42e7-980f-c435f1637e1b"), "8E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("b8eebba1-5fb1-494e-b8d8-1f9ad08d38d4"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"), "6D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c35d5181-9ef2-4bc5-90e6-78551fe0aa4f"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, new Guid("61218d5e-987b-4078-bce3-93e46d771d70"), "7F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c3bc1fda-0862-4b08-8e6c-4adce141d305"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, new Guid("6af12a15-d5d3-4ed6-b015-cae2a43de479"), "1E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c601b7da-11f0-48a0-9d42-f242aeb3b16a"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, new Guid("cd5ff7b8-4d02-4ee7-85ba-94da08073709"), "5F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d3e1ecf4-ccf9-4c17-9f76-5ee46f3b1c0b"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("458da1a4-15ea-471e-9c0c-49d3a4ffe7fc"), "3F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d4b51b93-abdb-45be-b9b9-047eade5341d"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, new Guid("3a9484f7-b074-42e7-980f-c435f1637e1b"), "8D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d53be4bf-ae9b-4b01-8a15-d0296860d5e1"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, new Guid("5d1e4e65-466b-4a27-af41-ce7d55617353"), "5B", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d55381ec-3b71-42ac-a8ad-a55340df1fc9"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, new Guid("61218d5e-987b-4078-bce3-93e46d771d70"), "7D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d82b38b6-9a16-4643-b09a-a9e7f6af211f"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, new Guid("c7b27cc1-2510-4ee2-a84c-3d7416833c23"), "6A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("e49e115a-f4cb-4067-931c-fb71818979e5"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, new Guid("5d1e4e65-466b-4a27-af41-ce7d55617353"), "5A", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("e98fb03a-d625-4ab4-b113-c0cbe83de27d"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, new Guid("6af12a15-d5d3-4ed6-b015-cae2a43de479"), "2D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ea6d8db3-1f00-4a40-8cc8-8583d19752c5"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, new Guid("cd5ff7b8-4d02-4ee7-85ba-94da08073709"), "5E", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f179a1e3-13df-43ee-b24e-7bf774328ecb"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, new Guid("8ab00536-4a4e-4bde-82dc-28c08343f88a"), "7C", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f5b4f7f2-d1e6-4d94-b87b-5b8eafc5d740"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, new Guid("cd5ff7b8-4d02-4ee7-85ba-94da08073709"), "5D", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f62a939c-ac83-4cbb-b118-ce1000aecbfe"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, new Guid("3cac6b12-f9a9-4a8f-9f26-ec0c510f8cb3"), "4F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f6b61d71-4a08-4bca-9c3a-a56ce4bf3556"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("c5ea9a98-44f0-4379-ae26-37a892a2bb04"), "1F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("fa88dbd9-8755-4668-bed7-42dda4ffa1ff"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, new Guid("6af12a15-d5d3-4ed6-b015-cae2a43de479"), "2F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("fdb9b7b8-eb62-4c22-a18e-1bb13a17b42a"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, new Guid("3a9484f7-b074-42e7-980f-c435f1637e1b"), "8F", new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("01b305e4-54b3-40c1-abff-5241d44f4340"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("29e80353-123d-4d8c-9e40-653aae42737f"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("03345728-cfc5-4c16-9f0b-fc4669995c43"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e98fb03a-d625-4ab4-b113-c0cbe83de27d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("0903136f-0ab6-4ed1-af32-fc2df15d5b22"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d82b38b6-9a16-4643-b09a-a9e7f6af211f"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("0d8b21bc-7406-4304-9cbf-7b0489cb0335"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0fb5901c-7471-4091-930d-bfa71f0237e7"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("0f19e68b-9ed2-45bb-9050-8f36ee4940df"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a5b93fe5-d2ff-4f3f-a52a-d44909530ead"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("10b5fe1d-b961-4481-8997-9c5a27b3ea98"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f5b4f7f2-d1e6-4d94-b87b-5b8eafc5d740"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("1338086c-ee72-4fcd-b4b2-6d708e314886"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("95e962bd-0449-4f77-bce2-42e1645bf26e"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("16864a15-ba14-4ab1-b8e2-7c1d44e679f5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6c710f60-cc13-4968-a17e-2332b2693d28"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("17e5be06-4dba-4644-86ea-2a6c3fd17d0e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d4b51b93-abdb-45be-b9b9-047eade5341d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("17f1f267-d3fe-4f8c-a76f-57cc8303960d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d82b38b6-9a16-4643-b09a-a9e7f6af211f"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("18f0c505-73f3-44e0-9c08-89601852c49d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d3e1ecf4-ccf9-4c17-9f76-5ee46f3b1c0b"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("1963f6e3-2aeb-468a-b6ad-e3d736773069"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d53be4bf-ae9b-4b01-8a15-d0296860d5e1"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("1fa04e98-63b4-4705-a4b5-8d686b41eca8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4910e28d-9419-4e46-9b72-5ed18a7c91e6"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("2499afce-2178-43e9-869e-e60d2c09e2dd"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7d9aa98f-b5b9-4f78-9dcc-c6bff941a640"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("28b0dd28-d68f-43fe-9539-fdf34c37c3ee"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fa88dbd9-8755-4668-bed7-42dda4ffa1ff"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("29259f1d-d3b0-4834-96ad-83eaf5a7ad29"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a1eca4b6-58d5-40a5-bdd0-977bbe8f1ced"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("2b769f88-47e0-4322-a03f-de399183c975"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("85458746-0f2a-4cd3-9fc3-99601073ae2d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("2d8346d6-c46c-4bf9-8c0a-341aff781744"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("870d28ee-2152-47d4-b0cd-2b278f0775a7"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("30f1ebac-6254-444b-bb1e-012ac09a13c7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e49e115a-f4cb-4067-931c-fb71818979e5"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("31a254c9-e328-4ec6-af14-e6bd67710d92"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5599797c-7863-4a82-8c28-ac91fbd5b6e9"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("32315494-3403-4d04-9cb3-910fba1da270"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("0ed2916a-45e3-4178-8b5b-44201cf067eb"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("376b53a4-598a-4dd8-836d-48695114e0c1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8d8661e8-f3db-4e81-8807-3f5a2acd584b"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("3aad13fc-9af9-416d-88ca-07e5d1f1d170"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d4b51b93-abdb-45be-b9b9-047eade5341d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("3fcb238e-4e8f-46c8-bf08-c52b471a7ea3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9b56f0d6-fee5-411c-ad0f-02c0e9f24e6e"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("3fd03d4b-c835-465d-9413-3b3c2d1c7abc"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("144c2683-e60d-437b-9834-c628cd9d2e1a"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("40906838-7f90-4e6a-a70a-73684a508a15"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d55381ec-3b71-42ac-a8ad-a55340df1fc9"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("42e211e8-45e5-4e32-84bf-38a65523f983"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f6b61d71-4a08-4bca-9c3a-a56ce4bf3556"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4371d6ca-83b1-4d21-8c67-a5cec989ffd9"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("425f3fc5-2631-4b6a-9734-3ae151b3f258"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("437caf3d-ca39-4b68-aa2f-5381dd5e9d1c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c35d5181-9ef2-4bc5-90e6-78551fe0aa4f"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("43bc87e3-8a51-4854-ad1d-228f6c30e8e6"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("793f3313-c037-4fba-a808-5c857e6bc970"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("45a91f55-6394-4e9f-a0e4-1c3428811735"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0a20756c-be54-40a2-816a-4a68f02491cc"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4a171ad3-8d7a-4bd2-a1ff-dee33a2f47df"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8f757628-2781-4148-ac0a-90a33d95f701"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4d138643-4c55-4635-9b5a-9aa864e304e4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("61f71143-453e-4f33-a762-9558e3e43524"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4e6a324b-1364-43ec-9547-14aa1c3b57c2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a2ecdc1f-fb45-443f-8279-b5027edf9e68"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4e7f116d-5f70-4202-8a43-431d35d54628"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("884f7e69-5f53-4bc4-9da4-ab47b33fe4bc"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("4fec5393-82be-46d8-b990-d3d109000020"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8d020ef8-a330-4b53-89a9-569bd3ce3aa2"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("53c6a1e7-e1d0-42b2-825f-54e0d4685a53"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fdb9b7b8-eb62-4c22-a18e-1bb13a17b42a"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("547c1f7e-a847-4da8-91a1-1f36c80ff3f2"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("184e3c7c-59b0-4430-9e1b-bd7ae54cda25"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("57afdbb7-cc36-46a7-a567-d5a51bbed637"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8a59ba63-e693-4310-8f3e-da5374b0d536"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("58473a7b-427a-49de-859a-b3240c2d5ee6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4a8b6f8d-4134-447b-a89c-0bb15501fa14"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("599444e6-fae2-4aa0-8374-27afb26e3580"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a2ecdc1f-fb45-443f-8279-b5027edf9e68"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("5a83733c-d715-4539-8de4-54f5bd09a4e6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8d8661e8-f3db-4e81-8807-3f5a2acd584b"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("5c6bfcb4-c65d-4478-b6d9-f14ec0a32d0f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ea6d8db3-1f00-4a40-8cc8-8583d19752c5"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("5fc1128a-a363-4610-8919-456a31241961"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f6b61d71-4a08-4bca-9c3a-a56ce4bf3556"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("5fe2d21c-1ec8-4d44-8327-a0943ef2c035"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3093eefe-c2fc-4fdf-9076-9547918ad12e"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("6118b2d2-38bc-45f3-afdd-0f3b35963843"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8c3d5966-a3ca-41c2-8dfb-a11cd87038a6"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("61d573a1-aa08-4903-b043-5780d7525763"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("870d28ee-2152-47d4-b0cd-2b278f0775a7"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("65a2ece4-5efa-4ecd-bfac-8468416432eb"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("f1fa5634-0728-4a67-be42-6ebccbe03f7b"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("66a87042-060d-4972-a28d-3b60cb46b112"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("e247b36f-fd52-46e4-8346-87f024928769"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("677b76c6-b3fe-47c9-ac0b-6b5071738945"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4a8b6f8d-4134-447b-a89c-0bb15501fa14"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("67b27247-cc54-4000-b05c-7c064a596be9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5599797c-7863-4a82-8c28-ac91fbd5b6e9"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("67e1ec75-7d21-4fd2-948b-dcd03c680b3f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3b94462b-3005-4ad3-9493-65ec3fd31cb6"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("6a67356e-7c13-4a80-805c-89379cc73910"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9b56f0d6-fee5-411c-ad0f-02c0e9f24e6e"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("6d66b0ea-ebaa-4747-ab48-8a6fb03f8e5f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("85458746-0f2a-4cd3-9fc3-99601073ae2d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("6ee6f9c1-640f-469e-9ce4-46168be548e7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8135717e-02ab-4162-a714-97f52a5c548d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("71430cd3-39f1-4da4-871d-9306386c353a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f5b4f7f2-d1e6-4d94-b87b-5b8eafc5d740"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("7376deb8-cbce-4ebf-8734-379ad41c2fac"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e49e115a-f4cb-4067-931c-fb71818979e5"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("739fc12d-6b6b-4cf3-aa61-e7e268505afb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8a59ba63-e693-4310-8f3e-da5374b0d536"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("7476a4f5-33c2-4a8e-98ea-2279fa73824d"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("ccfc9b94-6e07-418b-ba6d-05cc824f6351"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("78996074-2609-4a0c-941f-0ea18104f175"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4910e28d-9419-4e46-9b72-5ed18a7c91e6"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("798980cb-c8b0-4ba4-84b3-f1c1746f5373"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c3bc1fda-0862-4b08-8e6c-4adce141d305"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("7eda3062-53dd-472e-a84b-9629e3db7b70"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fdb9b7b8-eb62-4c22-a18e-1bb13a17b42a"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("83175ed6-ac4c-4a26-809d-a72cd6a04272"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f179a1e3-13df-43ee-b24e-7bf774328ecb"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("860a0b69-4bf9-4996-a75c-af30eaa6fce0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e98fb03a-d625-4ab4-b113-c0cbe83de27d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8c4c5c20-03b3-4fc8-9fd0-7fe8cb711011"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("a6c8aecd-4c14-40da-9a04-4d48fa8e8bf6"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("8ded055b-221b-4ae9-aa87-2637b7a50ae2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("792db330-4a86-4da2-822e-d8f59ffaa36d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("90226198-3d6d-4886-9737-67f261049add"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9907ecb2-f93e-4a07-b320-e9f46acc60d1"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("9078aceb-0f5c-430c-8431-27dead3b6c00"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8d020ef8-a330-4b53-89a9-569bd3ce3aa2"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("90cf17da-89b7-4fb2-bfb0-855e498ea195"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("82ad83db-3cf5-4700-a04d-362427627298"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("90dbcf46-69f4-4ce6-a064-4a1ff9730b3a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d55381ec-3b71-42ac-a8ad-a55340df1fc9"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("91f04eaf-de62-4486-a875-ff0251b745c0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("884f7e69-5f53-4bc4-9da4-ab47b33fe4bc"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("98ef6afd-bcf8-4b1f-8c8d-734cf97c7b28"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a5b93fe5-d2ff-4f3f-a52a-d44909530ead"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("a048a549-f37b-4dad-ae84-bb2de2328821"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("792db330-4a86-4da2-822e-d8f59ffaa36d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ab80ff89-08cc-404b-8cbc-7d7904d1970e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("9f666a88-6887-42f3-aeff-2ec1650fc7b9"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ab953c96-4748-432f-a677-be562e48653c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c601b7da-11f0-48a0-9d42-f242aeb3b16a"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("abef89ba-c9e4-404c-9746-b653fa930417"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c35d5181-9ef2-4bc5-90e6-78551fe0aa4f"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ae2388b1-bc1e-4bab-9a16-c3185bf00943"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c601b7da-11f0-48a0-9d42-f242aeb3b16a"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("af7c41f9-ce64-4c6e-ac7c-a7086d7b5131"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("c1d1efec-3af5-4d88-a4d6-2f21be2a62a0"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("afbc0dae-2d40-4600-b2fb-f30a629f6ea2"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("4a3bc38b-ba62-4b0d-9abd-3e6c77936fc3"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("afdec263-4e72-4111-8a64-c1a4376a2b37"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9907ecb2-f93e-4a07-b320-e9f46acc60d1"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("b85a5128-045b-4a12-b66a-b60dc55353ed"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8135717e-02ab-4162-a714-97f52a5c548d"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("b9dfafa0-fa54-488d-9bc8-cd40fa7746cd"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d53be4bf-ae9b-4b01-8a15-d0296860d5e1"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("bb7411f3-4e7c-4dde-8575-242910a267d1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f62a939c-ac83-4cbb-b118-ce1000aecbfe"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c059a767-e258-43af-9fb0-669cd4ef1711"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b8eebba1-5fb1-494e-b8d8-1f9ad08d38d4"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("c30080a1-0ba5-4719-b027-8dde3e9e57b3"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("4ecc77c5-ff36-4bdf-86e2-e5be66dca083"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c4d51279-bccc-43e1-a3f9-0a45a0128714"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ea6d8db3-1f00-4a40-8cc8-8583d19752c5"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("c6a3a6a1-6044-46c1-b186-fbf496704548"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("29e80353-123d-4d8c-9e40-653aae42737f"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ca96da3f-43f5-455f-b31d-33de373cb3d5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a1eca4b6-58d5-40a5-bdd0-977bbe8f1ced"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ce1bdc1f-7cda-41e2-b6c5-4f4898d808b2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("61f71143-453e-4f33-a762-9558e3e43524"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ce79b16a-5625-4973-ad3f-9437b7144b48"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d3e1ecf4-ccf9-4c17-9f76-5ee46f3b1c0b"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d01c6acd-ad70-4fc4-afbf-4664737f542a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("144c2683-e60d-437b-9834-c628cd9d2e1a"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d549f710-3af3-485d-8e3d-d72375fcc90a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0a20756c-be54-40a2-816a-4a68f02491cc"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("d5572da1-9ca9-495e-bd7b-6d05af0b476d"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("c2af61f7-889b-4ce5-9e9f-eec3f3edd6e5"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("db796bca-a669-49e7-95b5-a9a41ee4b8c6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("82ad83db-3cf5-4700-a04d-362427627298"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("e2482d50-0769-4241-8db5-c401dfb766ab"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("95178f78-5f3e-4bcc-bf78-be6d7df345e6"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("e33235ea-1fb0-4965-ba16-7354a30bf764"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3093eefe-c2fc-4fdf-9076-9547918ad12e"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("e5ebd4a2-dad8-48e2-84c6-ad0b587e1dec"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0fa9ba07-2009-47ba-8461-027fbfa15c45"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ea89792c-e996-47b6-b4c3-c29a7de88738"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6c710f60-cc13-4968-a17e-2332b2693d28"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ee29981c-c061-42d8-b8b1-0c09a012b2a1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8f757628-2781-4148-ac0a-90a33d95f701"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ee3ff687-0633-446c-b7e6-55f97ffae38c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fa88dbd9-8755-4668-bed7-42dda4ffa1ff"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("ef8fa486-b9e1-47da-b2e5-fa6a93efae40"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("c8d01d74-a80f-4ced-bf07-a0c8cffd600e"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f08051bc-f0f9-47ed-88a7-fe99da20bd43"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8c3d5966-a3ca-41c2-8dfb-a11cd87038a6"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f0f0374c-fa41-4fdb-b93f-f32b95ea80e0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3b94462b-3005-4ad3-9493-65ec3fd31cb6"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f3e5ef35-b5d3-4418-b682-e6fb20c3ec3c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f62a939c-ac83-4cbb-b118-ce1000aecbfe"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f54705fa-7ced-44a7-8f87-784c93487958"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c3bc1fda-0862-4b08-8e6c-4adce141d305"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f5e19d69-6257-41c1-8e8e-febf5e17b0c9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0fa9ba07-2009-47ba-8461-027fbfa15c45"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f665e2af-44cc-471a-83fc-dc1a8b1dd223"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0fb5901c-7471-4091-930d-bfa71f0237e7"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f83aecdb-c621-4dbe-8c8b-319a744f30d9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f179a1e3-13df-43ee-b24e-7bf774328ecb"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f8752d46-19d4-464b-a5ed-beb7fe3426ae"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7d9aa98f-b5b9-4f78-9dcc-c6bff941a640"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("f9854d31-b11e-415e-9b92-767634290534"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("eee7739c-3c12-4ff8-a2c2-ae7e305ec8e7"), null, new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("fa4434a2-874b-4afe-b8d5-90092e113a35"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b8eebba1-5fb1-494e-b8d8-1f9ad08d38d4"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") },
                    { new Guid("fa963c69-35f8-4635-966c-a2f650405433"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("95e962bd-0449-4f77-bce2-42e1645bf26e"), new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoadPlans_OverheadLayoutId",
                table: "LoadPlans",
                column: "OverheadLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoPositions_OverheadPositionId",
                table: "CargoPositions",
                column: "OverheadPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadCompartments_OverheadLayoutId",
                table: "OverheadCompartments",
                column: "OverheadLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadPositions_OverheadCompartmentId",
                table: "OverheadPositions",
                column: "OverheadCompartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadPositions_ZoneAreaId",
                table: "OverheadPositions",
                column: "ZoneAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CargoPositions_OverheadPositions_OverheadPositionId",
                table: "CargoPositions",
                column: "OverheadPositionId",
                principalTable: "OverheadPositions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoadPlans_OverheadLayouts_OverheadLayoutId",
                table: "LoadPlans",
                column: "OverheadLayoutId",
                principalTable: "OverheadLayouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_OverheadLayouts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_CargoPositions_OverheadPositions_OverheadPositionId",
                table: "CargoPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_LoadPlans_OverheadLayouts_OverheadLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropTable(
                name: "OverheadPositions");

            migrationBuilder.DropTable(
                name: "OverheadCompartments");

            migrationBuilder.DropTable(
                name: "OverheadLayouts");

            migrationBuilder.DropIndex(
                name: "IX_LoadPlans_OverheadLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropIndex(
                name: "IX_CargoPositions_OverheadPositionId",
                table: "CargoPositions");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("7286adb4-1da0-4547-ac8d-c3ea5f45c2a9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("01b305e4-54b3-40c1-abff-5241d44f4340"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("03345728-cfc5-4c16-9f0b-fc4669995c43"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0903136f-0ab6-4ed1-af32-fc2df15d5b22"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0d8b21bc-7406-4304-9cbf-7b0489cb0335"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0f19e68b-9ed2-45bb-9050-8f36ee4940df"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("10b5fe1d-b961-4481-8997-9c5a27b3ea98"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1338086c-ee72-4fcd-b4b2-6d708e314886"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("16864a15-ba14-4ab1-b8e2-7c1d44e679f5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("17e5be06-4dba-4644-86ea-2a6c3fd17d0e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("17f1f267-d3fe-4f8c-a76f-57cc8303960d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("18f0c505-73f3-44e0-9c08-89601852c49d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1963f6e3-2aeb-468a-b6ad-e3d736773069"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1fa04e98-63b4-4705-a4b5-8d686b41eca8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2499afce-2178-43e9-869e-e60d2c09e2dd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("28b0dd28-d68f-43fe-9539-fdf34c37c3ee"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("29259f1d-d3b0-4834-96ad-83eaf5a7ad29"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2b769f88-47e0-4322-a03f-de399183c975"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d8346d6-c46c-4bf9-8c0a-341aff781744"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("30f1ebac-6254-444b-bb1e-012ac09a13c7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("31a254c9-e328-4ec6-af14-e6bd67710d92"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("32315494-3403-4d04-9cb3-910fba1da270"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("376b53a4-598a-4dd8-836d-48695114e0c1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3aad13fc-9af9-416d-88ca-07e5d1f1d170"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3fcb238e-4e8f-46c8-bf08-c52b471a7ea3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3fd03d4b-c835-465d-9413-3b3c2d1c7abc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("40906838-7f90-4e6a-a70a-73684a508a15"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("42e211e8-45e5-4e32-84bf-38a65523f983"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4371d6ca-83b1-4d21-8c67-a5cec989ffd9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("437caf3d-ca39-4b68-aa2f-5381dd5e9d1c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("43bc87e3-8a51-4854-ad1d-228f6c30e8e6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("45a91f55-6394-4e9f-a0e4-1c3428811735"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4a171ad3-8d7a-4bd2-a1ff-dee33a2f47df"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4d138643-4c55-4635-9b5a-9aa864e304e4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4e6a324b-1364-43ec-9547-14aa1c3b57c2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4e7f116d-5f70-4202-8a43-431d35d54628"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4fec5393-82be-46d8-b990-d3d109000020"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("53c6a1e7-e1d0-42b2-825f-54e0d4685a53"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("547c1f7e-a847-4da8-91a1-1f36c80ff3f2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("57afdbb7-cc36-46a7-a567-d5a51bbed637"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("58473a7b-427a-49de-859a-b3240c2d5ee6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("599444e6-fae2-4aa0-8374-27afb26e3580"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5a83733c-d715-4539-8de4-54f5bd09a4e6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5c6bfcb4-c65d-4478-b6d9-f14ec0a32d0f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5fc1128a-a363-4610-8919-456a31241961"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5fe2d21c-1ec8-4d44-8327-a0943ef2c035"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6118b2d2-38bc-45f3-afdd-0f3b35963843"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("61d573a1-aa08-4903-b043-5780d7525763"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("65a2ece4-5efa-4ecd-bfac-8468416432eb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("66a87042-060d-4972-a28d-3b60cb46b112"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("677b76c6-b3fe-47c9-ac0b-6b5071738945"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("67b27247-cc54-4000-b05c-7c064a596be9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("67e1ec75-7d21-4fd2-948b-dcd03c680b3f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6a67356e-7c13-4a80-805c-89379cc73910"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6d66b0ea-ebaa-4747-ab48-8a6fb03f8e5f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6ee6f9c1-640f-469e-9ce4-46168be548e7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("71430cd3-39f1-4da4-871d-9306386c353a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7376deb8-cbce-4ebf-8734-379ad41c2fac"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("739fc12d-6b6b-4cf3-aa61-e7e268505afb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7476a4f5-33c2-4a8e-98ea-2279fa73824d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("78996074-2609-4a0c-941f-0ea18104f175"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("798980cb-c8b0-4ba4-84b3-f1c1746f5373"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7eda3062-53dd-472e-a84b-9629e3db7b70"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("83175ed6-ac4c-4a26-809d-a72cd6a04272"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("860a0b69-4bf9-4996-a75c-af30eaa6fce0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8c4c5c20-03b3-4fc8-9fd0-7fe8cb711011"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ded055b-221b-4ae9-aa87-2637b7a50ae2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("90226198-3d6d-4886-9737-67f261049add"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9078aceb-0f5c-430c-8431-27dead3b6c00"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("90cf17da-89b7-4fb2-bfb0-855e498ea195"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("90dbcf46-69f4-4ce6-a064-4a1ff9730b3a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("91f04eaf-de62-4486-a875-ff0251b745c0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("98ef6afd-bcf8-4b1f-8c8d-734cf97c7b28"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a048a549-f37b-4dad-ae84-bb2de2328821"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ab80ff89-08cc-404b-8cbc-7d7904d1970e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ab953c96-4748-432f-a677-be562e48653c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("abef89ba-c9e4-404c-9746-b653fa930417"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ae2388b1-bc1e-4bab-9a16-c3185bf00943"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("af7c41f9-ce64-4c6e-ac7c-a7086d7b5131"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("afbc0dae-2d40-4600-b2fb-f30a629f6ea2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("afdec263-4e72-4111-8a64-c1a4376a2b37"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b85a5128-045b-4a12-b66a-b60dc55353ed"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b9dfafa0-fa54-488d-9bc8-cd40fa7746cd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bb7411f3-4e7c-4dde-8575-242910a267d1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c059a767-e258-43af-9fb0-669cd4ef1711"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c30080a1-0ba5-4719-b027-8dde3e9e57b3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c4d51279-bccc-43e1-a3f9-0a45a0128714"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c6a3a6a1-6044-46c1-b186-fbf496704548"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ca96da3f-43f5-455f-b31d-33de373cb3d5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ce1bdc1f-7cda-41e2-b6c5-4f4898d808b2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ce79b16a-5625-4973-ad3f-9437b7144b48"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d01c6acd-ad70-4fc4-afbf-4664737f542a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d549f710-3af3-485d-8e3d-d72375fcc90a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d5572da1-9ca9-495e-bd7b-6d05af0b476d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("db796bca-a669-49e7-95b5-a9a41ee4b8c6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e2482d50-0769-4241-8db5-c401dfb766ab"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e33235ea-1fb0-4965-ba16-7354a30bf764"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e5ebd4a2-dad8-48e2-84c6-ad0b587e1dec"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ea89792c-e996-47b6-b4c3-c29a7de88738"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ee29981c-c061-42d8-b8b1-0c09a012b2a1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ee3ff687-0633-446c-b7e6-55f97ffae38c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ef8fa486-b9e1-47da-b2e5-fa6a93efae40"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f08051bc-f0f9-47ed-88a7-fe99da20bd43"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f0f0374c-fa41-4fdb-b93f-f32b95ea80e0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f3e5ef35-b5d3-4418-b682-e6fb20c3ec3c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f54705fa-7ced-44a7-8f87-784c93487958"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f5e19d69-6257-41c1-8e8e-febf5e17b0c9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f665e2af-44cc-471a-83fc-dc1a8b1dd223"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f83aecdb-c621-4dbe-8c8b-319a744f30d9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f8752d46-19d4-464b-a5ed-beb7fe3426ae"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f9854d31-b11e-415e-9b92-767634290534"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fa4434a2-874b-4afe-b8d5-90092e113a35"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fa963c69-35f8-4635-966c-a2f650405433"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("2d662146-21b3-476d-8053-9c5994e16637"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("945454c3-c085-4c27-b596-e55bc17971cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a20756c-be54-40a2-816a-4a68f02491cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fa9ba07-2009-47ba-8461-027fbfa15c45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fb5901c-7471-4091-930d-bfa71f0237e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("144c2683-e60d-437b-9834-c628cd9d2e1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29e80353-123d-4d8c-9e40-653aae42737f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3093eefe-c2fc-4fdf-9076-9547918ad12e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b94462b-3005-4ad3-9493-65ec3fd31cb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4910e28d-9419-4e46-9b72-5ed18a7c91e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a8b6f8d-4134-447b-a89c-0bb15501fa14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5599797c-7863-4a82-8c28-ac91fbd5b6e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61f71143-453e-4f33-a762-9558e3e43524"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c710f60-cc13-4968-a17e-2332b2693d28"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("792db330-4a86-4da2-822e-d8f59ffaa36d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d9aa98f-b5b9-4f78-9dcc-c6bff941a640"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8135717e-02ab-4162-a714-97f52a5c548d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82ad83db-3cf5-4700-a04d-362427627298"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85458746-0f2a-4cd3-9fc3-99601073ae2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("870d28ee-2152-47d4-b0cd-2b278f0775a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("884f7e69-5f53-4bc4-9da4-ab47b33fe4bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a59ba63-e693-4310-8f3e-da5374b0d536"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c3d5966-a3ca-41c2-8dfb-a11cd87038a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d020ef8-a330-4b53-89a9-569bd3ce3aa2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d8661e8-f3db-4e81-8807-3f5a2acd584b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f757628-2781-4148-ac0a-90a33d95f701"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95e962bd-0449-4f77-bce2-42e1645bf26e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9907ecb2-f93e-4a07-b320-e9f46acc60d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b56f0d6-fee5-411c-ad0f-02c0e9f24e6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1eca4b6-58d5-40a5-bdd0-977bbe8f1ced"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2ecdc1f-fb45-443f-8279-b5027edf9e68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5b93fe5-d2ff-4f3f-a52a-d44909530ead"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8eebba1-5fb1-494e-b8d8-1f9ad08d38d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c35d5181-9ef2-4bc5-90e6-78551fe0aa4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3bc1fda-0862-4b08-8e6c-4adce141d305"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c601b7da-11f0-48a0-9d42-f242aeb3b16a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3e1ecf4-ccf9-4c17-9f76-5ee46f3b1c0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4b51b93-abdb-45be-b9b9-047eade5341d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d53be4bf-ae9b-4b01-8a15-d0296860d5e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d55381ec-3b71-42ac-a8ad-a55340df1fc9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d82b38b6-9a16-4643-b09a-a9e7f6af211f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e49e115a-f4cb-4067-931c-fb71818979e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e98fb03a-d625-4ab4-b113-c0cbe83de27d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea6d8db3-1f00-4a40-8cc8-8583d19752c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f179a1e3-13df-43ee-b24e-7bf774328ecb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5b4f7f2-d1e6-4d94-b87b-5b8eafc5d740"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f62a939c-ac83-4cbb-b118-ce1000aecbfe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6b61d71-4a08-4bca-9c3a-a56ce4bf3556"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa88dbd9-8755-4668-bed7-42dda4ffa1ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fdb9b7b8-eb62-4c22-a18e-1bb13a17b42a"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3a9484f7-b074-42e7-980f-c435f1637e1b"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3cac6b12-f9a9-4a8f-9f26-ec0c510f8cb3"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("458da1a4-15ea-471e-9c0c-49d3a4ffe7fc"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5d1e4e65-466b-4a27-af41-ce7d55617353"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("61218d5e-987b-4078-bce3-93e46d771d70"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6175acf7-2dfe-4670-80c8-ed02a605b0e2"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6af12a15-d5d3-4ed6-b015-cae2a43de479"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("76fc17fa-1cee-4ad3-94ef-6d9d5ae8131a"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("8ab00536-4a4e-4bde-82dc-28c08343f88a"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("90f940d6-b7ad-4fa3-892a-5ed6fb894662"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c5ea9a98-44f0-4379-ae26-37a892a2bb04"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c7b27cc1-2510-4ee2-a84c-3d7416833c23"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c8d4a560-e9d8-49c9-a7c0-3f706d2791fd"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cd5ff7b8-4d02-4ee7-85ba-94da08073709"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("def86f27-bb76-4fe2-8763-3acb6f0f32ca"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("aa9d13c3-7f45-4250-abf5-54ab68a2c853"));

            migrationBuilder.DeleteData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("95fb73ba-2285-4a32-ae20-378d2612eacc"));

            migrationBuilder.DeleteData(
                table: "SeatLayouts",
                keyColumn: "Id",
                keyValue: new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6"));

            migrationBuilder.DeleteData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("6e6e9cd3-29d8-422b-9bfd-0dc0751c75c7"));

            migrationBuilder.DeleteData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("6c921671-64df-42fb-bb09-291e392156fd"));

            migrationBuilder.DropColumn(
                name: "OverheadLayoutId",
                table: "LoadPlans");

            migrationBuilder.DropColumn(
                name: "OverheadPositionId",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "OverheadLayoutId",
                table: "Aircrafts");

            migrationBuilder.InsertData(
                table: "AircraftLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("605ee297-42da-4975-a072-c356cfd9afd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "ebc5958b-089d-4572-8b28-1f7e99877304");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "1a17e21f-dd34-4421-9571-b05c20326193");

            migrationBuilder.InsertData(
                table: "SeatLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsCloned", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AircraftDecks",
                columns: new[] { "Id", "AircraftDeckType", "AircraftLayoutId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight" },
                values: new object[] { new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"), (short)1, new Guid("605ee297-42da-4975-a072-c356cfd9afd3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 15000.0 });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "RegNo", "SeatLayoutId" },
                values: new object[] { new Guid("f2659d05-2507-4c36-8f1b-e84045a9ae15"), new Guid("605ee297-42da-4975-a072-c356cfd9afd3"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "", new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482") });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("93aaf79f-12a3-4264-8172-756123f833b4"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, (byte)1, new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482") },
                    { new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, (byte)3, new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482") },
                    { new Guid("f9078389-e087-4108-98e5-99f3a467e7df"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, (byte)1, new Guid("dfff4e05-1fd3-467e-adb6-e5c75e56e482") }
                });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("916814cb-7631-4e14-aec2-e1c9cfa0cbf8"), new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 10000.0, "FWD Cabin" });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("b6a55e15-8a2f-4081-9e3e-64ac35cb877b"), new Guid("3c72981e-2f23-48dc-b757-f6e456ecd055"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 10000.0, "AFT Cabin" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("9941a104-5ded-4be8-bdcb-a54820635d06"), new Guid("916814cb-7631-4e14-aec2-e1c9cfa0cbf8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 5000.0, "OB" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca"), new Guid("916814cb-7631-4e14-aec2-e1c9cfa0cbf8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 5000.0, "OA" });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("0d5f37dc-ea44-4232-9d7c-a26555ff453a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), "3B", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") },
                    { new Guid("0e9c2131-5d63-4073-bf5a-398e3ba44964"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("f9078389-e087-4108-98e5-99f3a467e7df"), "1B", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") },
                    { new Guid("9310d2be-2d22-4343-84ab-32a70d9c8207"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), "3C", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") },
                    { new Guid("af08b19f-deac-4186-984c-1367cfb25511"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, new Guid("93aaf79f-12a3-4264-8172-756123f833b4"), "1A", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") },
                    { new Guid("e658aed0-cdf6-4540-9e26-60768ad945b5"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, new Guid("cf04a08d-33b9-4c33-af96-06d85443b860"), "3A", new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "SeatId", "ZoneAreaId" },
                values: new object[] { new Guid("0fc9f3ce-5275-4c29-8fce-446a32a5c8ec"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2500.0, "", new Guid("af08b19f-deac-4186-984c-1367cfb25511"), new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "SeatId", "ZoneAreaId" },
                values: new object[] { new Guid("1928a932-3074-4faa-a809-a2b96fe3fda2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2500.0, "", new Guid("af08b19f-deac-4186-984c-1367cfb25511"), new Guid("b68df202-7d6c-443b-b41f-386212a2d2ca") });
        }
    }
}
