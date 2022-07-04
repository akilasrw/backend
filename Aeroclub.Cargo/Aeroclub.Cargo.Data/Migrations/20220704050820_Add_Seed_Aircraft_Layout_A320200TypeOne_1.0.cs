using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_Aircraft_Layout_A320200TypeOne_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AircraftLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("87da2cd2-afc4-4258-b67e-003283224206"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "b4288fb1-def5-4d6f-8f7c-2aff2006e044");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "3a803138-fa51-4a53-b968-9be972443593");

            migrationBuilder.InsertData(
                table: "OverheadCompartments",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[,]
                {
                    { new Guid("0816bf93-fbfe-49ab-a260-b65b9a103659"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 9 },
                    { new Guid("0862c4a4-d2b3-43e7-b257-039447e64983"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 8 },
                    { new Guid("1bca6e23-55e5-4ef8-b31a-c9514381d82f"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 4 },
                    { new Guid("32ea293f-2b5b-4a3f-a821-cf2a25de754e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 4 },
                    { new Guid("4698a608-103e-4166-afe1-c99257c8b44d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 6 },
                    { new Guid("538c9eb2-bdfb-480a-9080-56c3b099b4c5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 9 },
                    { new Guid("5f658532-5f68-48fc-84e5-fa7f7441d71c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 10 },
                    { new Guid("630980b3-4851-45c9-b324-b5888107882a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 8 },
                    { new Guid("af6f8cbf-7d77-4c74-a838-4352788b5643"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 7 },
                    { new Guid("d4d904e9-aff6-4f94-8007-6cedebdb7490"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 6 },
                    { new Guid("ede1aafe-51d1-437f-b755-e0b31c923aad"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 5 },
                    { new Guid("ede2607b-591b-461f-b8f3-faa6f138d258"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 5 },
                    { new Guid("f2fc4660-598f-43d3-8a07-cf0488bd37b2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 10 },
                    { new Guid("f95af152-4270-48d4-9190-48f01c8239d5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 7 }
                });

            migrationBuilder.InsertData(
                table: "OverheadPositions",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadCompartmentId", "Sequence", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("1d6a2bde-55b0-49c1-b84f-08c6c3db7c39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d73021c1-9b4e-4be9-b1d4-8f7428242709"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a3f8011a-97cb-4281-98fe-c9d9c4b6c658"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f20c7153-4ead-4a47-b6c7-2e59288aa983"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsFullRowOccupied", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "MaxWeight", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("0acce13b-4b0c-43e3-855a-7899c9de1ed0"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)19, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("0bf37374-c2f3-4569-9ca2-396584675bba"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)12, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("138a77c3-8371-4a9d-ad6a-48044e61ca2e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)20, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("1a2153a7-2a47-459f-b7d0-3b6360cb7bbb"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)19, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("21a3b94d-102b-4b00-ad2c-b82eb0850bbc"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)13, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("255e1a3f-6de3-4f3f-8e55-6d86448d7e49"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)9, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("274816a9-bee1-487c-a173-0227cbcd39e8"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)25, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("2c175271-34f1-4ef3-adaa-176e528d0c54"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)11, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("2d747796-3345-4a49-aca7-246f1d986f6e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)14, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("2da995ca-4a08-432a-8481-003d2048ffe8"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)23, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("349a398a-8e31-4129-ad75-9aa74e7a52e4"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)25, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("358c2d48-3035-4b9a-88a5-0dc81357c9bb"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)15, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("3c88c62b-7880-4174-8365-a8368a4b5657"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)13, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("3d67def6-3a2b-4a75-9360-0878bcc2cc97"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)18, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("3f5c9d82-6159-4e53-a3d7-9c3d85413b8d"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)24, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("44c9bb32-446b-4c6e-a010-dc76d3d92616"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)11, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("489e640c-6494-4859-a44b-64fca2260602"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)10, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("4f7b5755-bd3e-4f20-b280-6fef70e88839"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)16, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("568f3ac1-6144-48a9-81f6-6d57239ed042"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)12, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("5cdcaaf4-8887-467e-a402-9080a513bfa1"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)24, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("5f9a3602-23b1-4104-a50a-bebc33d28c41"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)23, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("6429c12a-5f46-4bfd-bba3-57abddbe9d91"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)21, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("64fc2883-c4ba-45c5-ad6b-6a7bec785bb7"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)26, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") }
                });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsFullRowOccupied", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "MaxWeight", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("6fa761dc-4cfa-45d4-a1ae-10d0fb7b5fd2"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)27, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("76ec8fd3-1ed6-467a-bb9e-168718fd3c5e"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)9, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("7e2bd102-47c8-42ff-94de-ca8cf28d4c6a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)20, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("831a46c2-306e-4f65-8832-f00755485f78"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)21, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("88b12932-af37-48d5-9887-1063d9a4e5ae"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)17, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("9386ff22-f9f2-4763-82cf-a42f0037954e"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)28, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("95743000-546e-4419-b2ba-0625d8d3e7a9"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)26, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("95e7038e-b248-4902-8c0f-87e543493096"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)16, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("9cf91d9f-3783-45bd-af82-3c8c3bb7786f"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)22, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("ab59ac68-aca5-417d-894a-087d3377ca7d"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)28, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("ad52dc04-fce9-4678-a8aa-298411cbecf4"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)18, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("b856b30c-6d28-43ae-bdcb-0acf59d65bd1"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)14, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("c9dd3b22-b66d-40a5-9a90-c7e05e712f7e"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)27, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("cb35e33c-b59a-4cef-9671-0b0fd9377bc4"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)17, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("db37bde8-b7cc-40b1-9be9-2ac7c73e9527"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)10, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("fbdba069-7a00-473e-af14-5508b4f88ac8"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)22, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") },
                    { new Guid("ffe20315-17ce-4f7a-b74a-4041a833d6ca"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)15, (byte)3, new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6") }
                });

            migrationBuilder.InsertData(
                table: "SeatLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsCloned", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "AircraftDecks",
                columns: new[] { "Id", "AircraftDeckType", "AircraftLayoutId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight" },
                values: new object[] { new Guid("c79ca836-0e98-4804-98a5-eb20605ca368"), (short)1, new Guid("87da2cd2-afc4-4258-b67e-003283224206"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8500.0 });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("4eba096d-116b-4c57-830a-eee0e199b43c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("a3f8011a-97cb-4281-98fe-c9d9c4b6c658"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("93eb7660-d08e-42fd-89c1-379171c14b86"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("1d6a2bde-55b0-49c1-b84f-08c6c3db7c39"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "OverheadPositions",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadCompartmentId", "Sequence", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("00dd5381-d9e1-4786-95d1-3f6601680bd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0862c4a4-d2b3-43e7-b257-039447e64983"), (short)3, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("01cf7347-48b3-46ac-899c-774ddb818f88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("af6f8cbf-7d77-4c74-a838-4352788b5643"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("04c34061-8c8d-4636-a286-ed21478dbf9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("538c9eb2-bdfb-480a-9080-56c3b099b4c5"), (short)3, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("057595ef-69df-45cf-b78d-8d08dd125de7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f95af152-4270-48d4-9190-48f01c8239d5"), (short)2, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("09f81045-a576-47cb-91e7-18ad9fa98004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d4d904e9-aff6-4f94-8007-6cedebdb7490"), (short)2, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1472a61f-4059-44e6-9194-dd1a71c3a85d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("32ea293f-2b5b-4a3f-a821-cf2a25de754e"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1972af1e-d156-4de5-beea-6b20a63d3183"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0816bf93-fbfe-49ab-a260-b65b9a103659"), (short)3, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("28f3df05-3df5-44dc-95f9-2dd28b92f42c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("538c9eb2-bdfb-480a-9080-56c3b099b4c5"), (short)2, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("3a2c9515-7637-421a-8d30-8f5bd14b299d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("af6f8cbf-7d77-4c74-a838-4352788b5643"), (short)2, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("3fea27ab-112f-4f25-a20e-fb94ed065d8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f95af152-4270-48d4-9190-48f01c8239d5"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("492f95c8-3ee3-4dae-9e30-fd802beb8eea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4698a608-103e-4166-afe1-c99257c8b44d"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5181cf79-78cc-4c11-911d-d6f049d1a510"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d4d904e9-aff6-4f94-8007-6cedebdb7490"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("526a2d56-6950-4fb4-a3fb-56fef9732520"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4698a608-103e-4166-afe1-c99257c8b44d"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5dcfe59e-9185-4fbc-a0ff-a813f18deee0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0862c4a4-d2b3-43e7-b257-039447e64983"), (short)2, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("5f3efbb5-ec4e-4af1-92fa-62a4fbc9dba1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("538c9eb2-bdfb-480a-9080-56c3b099b4c5"), (short)1, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("612a1109-3375-46a0-890c-24bd54bf20f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("630980b3-4851-45c9-b324-b5888107882a"), (short)2, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("6425f8e1-a2fd-438c-a1b0-a7caadab45b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("32ea293f-2b5b-4a3f-a821-cf2a25de754e"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("69b699c8-a787-49aa-884b-7bf3b0c13bd7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ede2607b-591b-461f-b8f3-faa6f138d258"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("789c04a4-46e4-4e73-8194-44f79b3c9959"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0816bf93-fbfe-49ab-a260-b65b9a103659"), (short)1, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("864d7b29-1f20-430b-940a-957bdd8b0e12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ede1aafe-51d1-437f-b755-e0b31c923aad"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8e460941-0719-43e1-9f75-6daeb3563036"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1bca6e23-55e5-4ef8-b31a-c9514381d82f"), (short)2, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("91a6bbeb-70e7-414b-bc55-d6450e11efbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ede2607b-591b-461f-b8f3-faa6f138d258"), (short)2, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9612ab4b-f483-4276-97ca-7e13514e8f2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("af6f8cbf-7d77-4c74-a838-4352788b5643"), (short)3, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9d8985ca-18b6-4534-a3fd-43cdf7c106b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("32ea293f-2b5b-4a3f-a821-cf2a25de754e"), (short)2, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a0d6f8fc-5cca-444a-bc70-50afcac5a1d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f95af152-4270-48d4-9190-48f01c8239d5"), (short)3, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("a38a1245-df4a-44bc-88b5-c187e89d4ae9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1bca6e23-55e5-4ef8-b31a-c9514381d82f"), (short)1, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a967be53-5e81-4748-809b-ce1a72f6b285"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ede1aafe-51d1-437f-b755-e0b31c923aad"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("ac19fab1-0fd3-4099-9852-37386073a2c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1bca6e23-55e5-4ef8-b31a-c9514381d82f"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("acfb19cc-7625-40e4-a4cd-5eaa302b06e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ede1aafe-51d1-437f-b755-e0b31c923aad"), (short)2, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b08769b7-0e78-496d-bb02-b98ee99246df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4698a608-103e-4166-afe1-c99257c8b44d"), (short)2, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("bac8a4fd-838c-47c9-89db-9e3cf6829b13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f2fc4660-598f-43d3-8a07-cf0488bd37b2"), (short)1, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("be6809dc-e518-4df6-a0dc-0365693b7b06"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5f658532-5f68-48fc-84e5-fa7f7441d71c"), (short)1, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("c376db5b-6c98-4783-9c9e-3f9715194de1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0862c4a4-d2b3-43e7-b257-039447e64983"), (short)1, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d18a6504-45bb-4ed7-9605-8286126c585b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ede2607b-591b-461f-b8f3-faa6f138d258"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e2695491-6033-47d7-8636-6be2e0b7ccdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("630980b3-4851-45c9-b324-b5888107882a"), (short)3, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("ed6e77fe-5500-4512-a43c-b40adb14cad3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("630980b3-4851-45c9-b324-b5888107882a"), (short)1, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("f6ee7340-6f3d-40c2-b7b9-7349713d274e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0816bf93-fbfe-49ab-a260-b65b9a103659"), (short)2, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("fdca28f7-21e5-4978-8769-9ec63a5c36c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d4d904e9-aff6-4f94-8007-6cedebdb7490"), (short)3, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[] { new Guid("03d9fc83-71b0-4f8a-b0f0-81495cca0253"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)27, new Guid("c9dd3b22-b66d-40a5-9a90-c7e05e712f7e"), "27E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("0b4118c2-1240-4294-97ca-6397385e1088"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)19, new Guid("0acce13b-4b0c-43e3-855a-7899c9de1ed0"), "19E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0c1bd048-1507-4549-a8b5-9755cdb4dbc4"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)12, new Guid("0bf37374-c2f3-4569-9ca2-396584675bba"), "12D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0c2474c8-d294-4062-ae37-951872d1d83d"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)19, new Guid("1a2153a7-2a47-459f-b7d0-3b6360cb7bbb"), "19B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0cac7c35-cbcc-48f8-91a9-8c4b9d92711c"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)13, new Guid("21a3b94d-102b-4b00-ad2c-b82eb0850bbc"), "13E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0df4b32b-64cb-4b8f-8a4f-e12bd193382c"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)14, new Guid("b856b30c-6d28-43ae-bdcb-0acf59d65bd1"), "14F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0e77b93e-a9d4-4188-89fd-7486be51ed9d"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)9, new Guid("255e1a3f-6de3-4f3f-8e55-6d86448d7e49"), "9C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1b3c6a28-f241-44bd-9a3c-c7324dcaea1f"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)10, new Guid("489e640c-6494-4859-a44b-64fca2260602"), "10E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1c1580e2-caa8-4509-89c4-4497f7e56b08"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)14, new Guid("b856b30c-6d28-43ae-bdcb-0acf59d65bd1"), "14E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1d707d69-9409-406b-a139-844c1efcf71b"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)19, new Guid("0acce13b-4b0c-43e3-855a-7899c9de1ed0"), "19F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("21a6952c-190d-42a6-b96a-e3b26f54b454"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)25, new Guid("274816a9-bee1-487c-a173-0227cbcd39e8"), "25A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("21f463d1-9b18-49c3-ba31-c21fec91574e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)19, new Guid("1a2153a7-2a47-459f-b7d0-3b6360cb7bbb"), "19A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("21fd0e07-e95e-420f-a63c-02436129f123"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)18, new Guid("3d67def6-3a2b-4a75-9360-0878bcc2cc97"), "18F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("22068f17-a9d7-4cad-8cc6-d67089b5d6fb"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)11, new Guid("2c175271-34f1-4ef3-adaa-176e528d0c54"), "11B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("228f98a7-4b0a-4c88-ad25-0f17159ffd6b"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)14, new Guid("b856b30c-6d28-43ae-bdcb-0acf59d65bd1"), "14D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("26fe94b4-8dc2-468e-a17a-3bee36e0ce93"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)21, new Guid("6429c12a-5f46-4bfd-bba3-57abddbe9d91"), "21D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("27211033-520b-4cf7-a8e0-e9217d039175"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)23, new Guid("2da995ca-4a08-432a-8481-003d2048ffe8"), "23C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("295ebf18-3fa1-47e7-9905-b2704857412e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)13, new Guid("3c88c62b-7880-4174-8365-a8368a4b5657"), "13A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("2ddab659-3854-40be-86ee-5d01cc9dc924"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)21, new Guid("831a46c2-306e-4f65-8832-f00755485f78"), "21C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2e3b394e-a19d-4739-878d-23f120a087a6"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)26, new Guid("95743000-546e-4419-b2ba-0625d8d3e7a9"), "26C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2f765157-8c7b-4eec-8067-6d77cca2d2d8"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)22, new Guid("9cf91d9f-3783-45bd-af82-3c8c3bb7786f"), "22D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("32fb6fdd-ec79-4186-ab48-dc52bb615a7f"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)15, new Guid("ffe20315-17ce-4f7a-b74a-4041a833d6ca"), "15B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3dda6da0-e2ae-4ffd-a7da-80504c21deb4"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)16, new Guid("95e7038e-b248-4902-8c0f-87e543493096"), "16A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3f261817-b9f8-4fe1-b824-6b3553fcfe27"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)22, new Guid("fbdba069-7a00-473e-af14-5508b4f88ac8"), "22C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("3f3047bc-ae7d-4060-a86d-2a14f230933b"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)21, new Guid("831a46c2-306e-4f65-8832-f00755485f78"), "21B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4110c5bf-b270-4327-9520-1bdeb7b97d8d"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)18, new Guid("3d67def6-3a2b-4a75-9360-0878bcc2cc97"), "18E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("428ed039-f2f8-4efa-8bb3-3770a9523981"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)28, new Guid("ab59ac68-aca5-417d-894a-087d3377ca7d"), "28B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("43230963-f6dc-4b85-8070-2c3f4c773a93"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)27, new Guid("6fa761dc-4cfa-45d4-a1ae-10d0fb7b5fd2"), "27B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("434a21ed-334f-4b31-867f-4bc2e1fd52f6"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)11, new Guid("44c9bb32-446b-4c6e-a010-dc76d3d92616"), "11E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("435add81-7b50-4015-88e7-5bd1011f9776"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)24, new Guid("5cdcaaf4-8887-467e-a402-9080a513bfa1"), "24F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("45318300-55ee-49bd-85e6-edb266ab663b"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)10, new Guid("db37bde8-b7cc-40b1-9be9-2ac7c73e9527"), "10C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("454a0a35-8c9d-4249-b2b4-fc2c3bd2d829"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)13, new Guid("21a3b94d-102b-4b00-ad2c-b82eb0850bbc"), "13D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("45744658-b936-44a4-b208-4b507eff7149"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)15, new Guid("ffe20315-17ce-4f7a-b74a-4041a833d6ca"), "15A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("45be3d60-de2a-46ab-a1a9-d3f5ddf520d6"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)26, new Guid("64fc2883-c4ba-45c5-ad6b-6a7bec785bb7"), "26F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("468ef6ba-d784-4180-be31-da4c657b7247"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)21, new Guid("831a46c2-306e-4f65-8832-f00755485f78"), "21A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("48458511-e099-47c3-a2e5-a7556f6c5718"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)23, new Guid("5f9a3602-23b1-4104-a50a-bebc33d28c41"), "23E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("493206a2-2cdb-4600-a0f7-8dfdd4c3fea3"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)23, new Guid("5f9a3602-23b1-4104-a50a-bebc33d28c41"), "23F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4c9582f0-3be9-45f4-b16b-e44962b313ef"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)20, new Guid("7e2bd102-47c8-42ff-94de-ca8cf28d4c6a"), "20E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4deb0089-ea2c-4b1a-8ef9-34ee43e1c41a"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)11, new Guid("44c9bb32-446b-4c6e-a010-dc76d3d92616"), "11D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4dfa36ca-c546-4d01-a500-c86d838d6acd"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)14, new Guid("2d747796-3345-4a49-aca7-246f1d986f6e"), "14B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("54d6be5c-3ca1-4cf5-8684-0077be50fd4e"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)28, new Guid("9386ff22-f9f2-4763-82cf-a42f0037954e"), "28D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("54fa7b4c-a21d-4f5a-af31-20a757c076da"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)11, new Guid("2c175271-34f1-4ef3-adaa-176e528d0c54"), "11C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5770d1bf-c2c0-4b85-8a47-a4a5a48beda9"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)13, new Guid("21a3b94d-102b-4b00-ad2c-b82eb0850bbc"), "13F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("5772abe7-012a-4d67-ade9-6487a34e9a51"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)10, new Guid("db37bde8-b7cc-40b1-9be9-2ac7c73e9527"), "10B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("59f46794-f4f6-4d46-94f2-1186c8093f8d"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)12, new Guid("568f3ac1-6144-48a9-81f6-6d57239ed042"), "12A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5d39d497-b431-4d53-902d-e5f00d062165"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)27, new Guid("c9dd3b22-b66d-40a5-9a90-c7e05e712f7e"), "27F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("63b834b0-b00c-4cc4-9a63-00b6be30c1b5"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)20, new Guid("7e2bd102-47c8-42ff-94de-ca8cf28d4c6a"), "20F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("6788dcd7-38b9-4409-8197-337243649dbf"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)28, new Guid("9386ff22-f9f2-4763-82cf-a42f0037954e"), "28E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("6a8a03a1-fe03-4647-a924-e56d26359c30"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)27, new Guid("c9dd3b22-b66d-40a5-9a90-c7e05e712f7e"), "27D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("6ac21cd5-3043-40db-928a-70bdb7026854"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)24, new Guid("3f5c9d82-6159-4e53-a3d7-9c3d85413b8d"), "24C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("6b73e0d6-a9b6-4352-b6c1-2e46dfdcbd2a"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)11, new Guid("44c9bb32-446b-4c6e-a010-dc76d3d92616"), "11F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6bf972e2-3c3f-443a-b620-213a5b5987c9"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)13, new Guid("3c88c62b-7880-4174-8365-a8368a4b5657"), "13B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6ed3de65-b834-44e6-b9b8-24c35845b76f"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)17, new Guid("cb35e33c-b59a-4cef-9671-0b0fd9377bc4"), "17E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6f6257ac-9a1e-4b35-b354-a524acd3dfee"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)10, new Guid("db37bde8-b7cc-40b1-9be9-2ac7c73e9527"), "10A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6f808edb-d8ad-40a6-8d96-b6da6e078c37"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)20, new Guid("138a77c3-8371-4a9d-ad6a-48044e61ca2e"), "20A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("6fbed1f9-d9b3-4544-a3bf-9c50dbeff440"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)15, new Guid("ffe20315-17ce-4f7a-b74a-4041a833d6ca"), "15C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("717d1cac-7fef-49f5-b499-a9c9ae07b10e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)27, new Guid("6fa761dc-4cfa-45d4-a1ae-10d0fb7b5fd2"), "27A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("718347e8-24dd-44c8-9bb7-2c345a7996be"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)9, new Guid("76ec8fd3-1ed6-467a-bb9e-168718fd3c5e"), "9F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("73825353-fc54-4940-8bdf-732d42babd72"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)13, new Guid("3c88c62b-7880-4174-8365-a8368a4b5657"), "13C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("73d11230-2a26-4323-a03f-4cd6288f61b6"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)15, new Guid("358c2d48-3035-4b9a-88a5-0dc81357c9bb"), "15F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("7910d72f-6cc7-4903-afe0-13e9814f4b0a"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)22, new Guid("fbdba069-7a00-473e-af14-5508b4f88ac8"), "22A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("7d73fc0d-b501-4b10-a46e-41222680e589"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)25, new Guid("349a398a-8e31-4129-ad75-9aa74e7a52e4"), "25F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("7e81399d-da3d-430e-bcf1-c086519d2628"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)9, new Guid("255e1a3f-6de3-4f3f-8e55-6d86448d7e49"), "9A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("80a6977c-0877-4bc1-bd09-438323d30c7a"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)21, new Guid("6429c12a-5f46-4bfd-bba3-57abddbe9d91"), "21F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("855ddbd9-5a8c-42fe-a17e-d29c3a52e5d4"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)22, new Guid("fbdba069-7a00-473e-af14-5508b4f88ac8"), "22B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("86d8a5ce-7dd1-4c12-a18b-3b8cae9b9141"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)17, new Guid("88b12932-af37-48d5-9887-1063d9a4e5ae"), "17C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8720796c-8d1f-45f4-849b-79731c19402e"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)15, new Guid("358c2d48-3035-4b9a-88a5-0dc81357c9bb"), "15E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8a5adb20-c467-4472-8d7f-c9e91b78e7c9"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)16, new Guid("95e7038e-b248-4902-8c0f-87e543493096"), "16B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8ae01d4a-132d-44be-b4b6-0026865ada31"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)17, new Guid("cb35e33c-b59a-4cef-9671-0b0fd9377bc4"), "17F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8ce5405f-05bc-4b54-b667-f3af07cd4d8b"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)26, new Guid("64fc2883-c4ba-45c5-ad6b-6a7bec785bb7"), "26E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("921662b1-17a2-49a0-9a01-46b3f5e263f7"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)18, new Guid("ad52dc04-fce9-4678-a8aa-298411cbecf4"), "18A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("928b559a-969f-4e0f-89be-76a337b26a4a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)26, new Guid("95743000-546e-4419-b2ba-0625d8d3e7a9"), "26B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9295e9e9-772c-411a-bb52-9f87ac617c53"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)18, new Guid("3d67def6-3a2b-4a75-9360-0878bcc2cc97"), "18D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("95b1092c-8796-48ca-82bd-2cd14f960dc4"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)20, new Guid("138a77c3-8371-4a9d-ad6a-48044e61ca2e"), "20B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9a78886b-e9d4-4042-aeb0-48c53f391afb"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)9, new Guid("76ec8fd3-1ed6-467a-bb9e-168718fd3c5e"), "9E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9bbe0836-32a5-4d6a-9e67-0e55af28ce57"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)25, new Guid("274816a9-bee1-487c-a173-0227cbcd39e8"), "25B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("a0f7ce3e-2566-4814-a7bf-5b434984597a"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)10, new Guid("489e640c-6494-4859-a44b-64fca2260602"), "10D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a2cb6fc8-271c-4396-9109-b44abaa4777d"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)25, new Guid("274816a9-bee1-487c-a173-0227cbcd39e8"), "25C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("a9aebb71-db7d-462c-a3bd-056af59fea10"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)21, new Guid("6429c12a-5f46-4bfd-bba3-57abddbe9d91"), "21E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("a9dd9044-981d-43df-8a2a-9c18eefea542"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)22, new Guid("9cf91d9f-3783-45bd-af82-3c8c3bb7786f"), "22F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("af7ae26f-b34a-4764-87af-1696f7e44b17"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)27, new Guid("6fa761dc-4cfa-45d4-a1ae-10d0fb7b5fd2"), "27C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("afed46a5-144a-4bab-9e97-56a0a5311933"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)24, new Guid("3f5c9d82-6159-4e53-a3d7-9c3d85413b8d"), "24A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b0e18e07-6d90-429d-895b-8722eaf70f5f"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)24, new Guid("5cdcaaf4-8887-467e-a402-9080a513bfa1"), "24E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b1ee230f-e70c-4a0a-bb83-adc76edcaea3"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)22, new Guid("9cf91d9f-3783-45bd-af82-3c8c3bb7786f"), "22E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b31b82e0-0ce8-4121-85a1-4d92a7d0f5f3"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)9, new Guid("255e1a3f-6de3-4f3f-8e55-6d86448d7e49"), "9B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("b3c64465-5285-4e53-a854-6270faa5a2c7"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)18, new Guid("ad52dc04-fce9-4678-a8aa-298411cbecf4"), "18B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b3d2b131-e9dd-4b4b-9bbc-4136838ee162"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)16, new Guid("4f7b5755-bd3e-4f20-b280-6fef70e88839"), "16F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b5579fa9-96eb-487e-a6f3-fdbf69b732d2"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)20, new Guid("138a77c3-8371-4a9d-ad6a-48044e61ca2e"), "20C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b967e634-58fa-43b4-b96c-c1dbc8556bf7"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)14, new Guid("2d747796-3345-4a49-aca7-246f1d986f6e"), "14C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("be3ea9e2-131d-45ad-bd71-367ddf90b50a"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)12, new Guid("0bf37374-c2f3-4569-9ca2-396584675bba"), "12E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("bfa61469-82f6-4109-baab-7157b9e872ed"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)24, new Guid("3f5c9d82-6159-4e53-a3d7-9c3d85413b8d"), "24B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("c1f548d9-cbbc-48f4-b0a9-84565bbdb2b6"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)14, new Guid("2d747796-3345-4a49-aca7-246f1d986f6e"), "14A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("c3d00f7d-d1fb-4993-8354-e3246b55c3fb"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)28, new Guid("ab59ac68-aca5-417d-894a-087d3377ca7d"), "28A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("c7e8c8d1-9bbd-42be-944b-5ac1c6f14c1c"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)20, new Guid("7e2bd102-47c8-42ff-94de-ca8cf28d4c6a"), "20D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d040e013-1da2-451a-8442-8333ba03a3ba"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)16, new Guid("95e7038e-b248-4902-8c0f-87e543493096"), "16C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d044500b-8ab9-43fc-bda0-4d01a68d67e8"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)25, new Guid("349a398a-8e31-4129-ad75-9aa74e7a52e4"), "25D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d52409a3-91e1-4260-8058-46a5af138cec"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)26, new Guid("95743000-546e-4419-b2ba-0625d8d3e7a9"), "26A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d67f6935-336f-48c3-bf30-9c947291eab2"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)19, new Guid("0acce13b-4b0c-43e3-855a-7899c9de1ed0"), "19D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d7411a08-03f3-447d-9ce7-c73ba0a6ccb1"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)11, new Guid("2c175271-34f1-4ef3-adaa-176e528d0c54"), "11A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("dd0cdafc-1296-41d2-80d9-4a5f8e25b068"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)12, new Guid("568f3ac1-6144-48a9-81f6-6d57239ed042"), "12B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("dd95d62c-6b9f-44f7-b4be-2b6021f85a29"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)28, new Guid("ab59ac68-aca5-417d-894a-087d3377ca7d"), "28C", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("df009349-3c94-4345-93ed-e593cb88d01b"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)26, new Guid("64fc2883-c4ba-45c5-ad6b-6a7bec785bb7"), "26D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("df0b050c-c6b9-4502-bce5-ee97dd866628"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)15, new Guid("358c2d48-3035-4b9a-88a5-0dc81357c9bb"), "15D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e0558a25-1b22-4172-be25-033cb02d7238"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)12, new Guid("568f3ac1-6144-48a9-81f6-6d57239ed042"), "12C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e2869cd1-7583-4006-a655-7a899bdb2c82"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)9, new Guid("76ec8fd3-1ed6-467a-bb9e-168718fd3c5e"), "9D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e291c6c9-efa8-44b3-bec9-f14845cde434"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)25, new Guid("349a398a-8e31-4129-ad75-9aa74e7a52e4"), "25E", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e33fbb17-5ba2-440d-b902-4a00bca90da3"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)23, new Guid("2da995ca-4a08-432a-8481-003d2048ffe8"), "23B", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e466b3ea-bbc7-4ef1-9fee-9873973d6374"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)16, new Guid("4f7b5755-bd3e-4f20-b280-6fef70e88839"), "16D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e652c39f-620d-4e2a-82bc-eef81ab9aadf"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)10, new Guid("489e640c-6494-4859-a44b-64fca2260602"), "10F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e97fc920-4cc6-435e-89bc-7b27a612caf6"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)12, new Guid("0bf37374-c2f3-4569-9ca2-396584675bba"), "12F", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("ee77ee2d-1657-4d13-b4ca-b4f43ef16565"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)23, new Guid("5f9a3602-23b1-4104-a50a-bebc33d28c41"), "23D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("f2bfad1f-e89e-4d47-8d69-e8500dd5212c"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)23, new Guid("2da995ca-4a08-432a-8481-003d2048ffe8"), "23A", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("f45861ec-97bc-46c4-80d7-613cd002ff0c"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)17, new Guid("cb35e33c-b59a-4cef-9671-0b0fd9377bc4"), "17D", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f4594468-afdd-4022-84fe-a762572b8a64"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)17, new Guid("88b12932-af37-48d5-9887-1063d9a4e5ae"), "17B", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("fa850353-6ce0-4a1a-b674-0fe7a0036d4f"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)24, new Guid("5cdcaaf4-8887-467e-a402-9080a513bfa1"), "24D", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("fd5d4b9a-8848-45e1-af34-30e4d18d5679"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)17, new Guid("88b12932-af37-48d5-9887-1063d9a4e5ae"), "17A", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("fd797c32-9e45-426d-ba70-13df5b52d47b"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)18, new Guid("ad52dc04-fce9-4678-a8aa-298411cbecf4"), "18C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("fdded7d7-97f7-4c37-aaac-37e4e3f32b70"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)16, new Guid("4f7b5755-bd3e-4f20-b280-6fef70e88839"), "16E", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("fe11ccfb-e99a-4b9a-92b7-f721cf35a8d9"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)28, new Guid("9386ff22-f9f2-4763-82cf-a42f0037954e"), "28F", new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("feb133e3-3311-496a-aa54-4587b279ed52"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)19, new Guid("1a2153a7-2a47-459f-b7d0-3b6360cb7bbb"), "19C", new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "AircraftCabins",
                columns: new[] { "Id", "AircraftDeckId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("4fd7c6e4-d926-4998-8a8e-a8c27423c79a"), new Guid("c79ca836-0e98-4804-98a5-eb20605ca368"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8500.0, "" });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("015f1234-5da8-45c2-b203-9b4aa5b6524d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f4594468-afdd-4022-84fe-a762572b8a64"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("03a12918-8452-436a-82bb-cd7236f2bc57"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("454a0a35-8c9d-4249-b2b4-fc2c3bd2d829"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("03c14fa3-e46e-4436-98d8-cdaf845d203f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1c1580e2-caa8-4509-89c4-4497f7e56b08"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("04850faa-1326-4b6d-8201-1679cd8e9ba0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("95b1092c-8796-48ca-82bd-2cd14f960dc4"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("058ecd3c-373d-499e-80ec-ad2485d25d36"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d7411a08-03f3-447d-9ce7-c73ba0a6ccb1"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("074be6c3-b348-41b0-a1a3-6169acb64636"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("5181cf79-78cc-4c11-911d-d6f049d1a510"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0795abbf-cd3e-4c0d-a7aa-e2357f7cb942"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6a8a03a1-fe03-4647-a924-e56d26359c30"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("07bb93b6-58ac-4614-926c-feb9da3de27c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5770d1bf-c2c0-4b85-8a47-a4a5a48beda9"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("09dc1b00-91fb-4ee6-a503-d81ebb224abc"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("54d6be5c-3ca1-4cf5-8684-0077be50fd4e"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("09e09d97-7a8b-478d-836a-0b52602dd6c6"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("9d8985ca-18b6-4534-a3fd-43cdf7c106b4"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0a671f41-d362-427a-b1ab-e356e6f76844"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e652c39f-620d-4e2a-82bc-eef81ab9aadf"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0ae2b89e-1f4b-40ef-8cc7-d377d7cb805f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fdded7d7-97f7-4c37-aaac-37e4e3f32b70"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0b4d6b11-75c3-4792-878d-1ba30572cf21"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("43230963-f6dc-4b85-8070-2c3f4c773a93"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("0bda7499-5637-4219-93a8-814d1057c1c3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e0558a25-1b22-4172-be25-033cb02d7238"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("0ddc6830-fb56-4b45-b55b-f17dde3a8755"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("21a6952c-190d-42a6-b96a-e3b26f54b454"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("1112c443-da18-4b2c-a035-67582b780ef8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("af7ae26f-b34a-4764-87af-1696f7e44b17"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("111439c7-4f24-4188-8dac-2cd5c2c5e976"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("45be3d60-de2a-46ab-a1a9-d3f5ddf520d6"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("11cf9c17-73d4-4756-b460-40b93fec9db9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("bfa61469-82f6-4109-baab-7157b9e872ed"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("139540fa-6727-4de0-aa9a-eae07e2fb788"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("718347e8-24dd-44c8-9bb7-2c345a7996be"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("167404bd-6c2e-4cb1-ac64-142cf32109bc"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a0f7ce3e-2566-4814-a7bf-5b434984597a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1a00ddec-efbb-4aa8-b614-0fce999cf431"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2f765157-8c7b-4eec-8067-6d77cca2d2d8"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("1a3c3016-8eb6-4ee1-9c69-2074b789ef74"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c1f548d9-cbbc-48f4-b0a9-84565bbdb2b6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1bf39ba8-404e-47b4-8b77-55f5f0209b03"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fe11ccfb-e99a-4b9a-92b7-f721cf35a8d9"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("1c5b16e8-9202-4e4a-8920-d8d3baacc0ff"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("32fb6fdd-ec79-4186-ab48-dc52bb615a7f"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1e4b3aa9-68e5-4169-b10e-cdff092f475a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("228f98a7-4b0a-4c88-ad25-0f17159ffd6b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1e83d41b-fb8e-4615-8176-2f7cac7dd5b2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fd797c32-9e45-426d-ba70-13df5b52d47b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("1ed078ed-69db-42c5-aff0-68f813524222"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b5579fa9-96eb-487e-a6f3-fdbf69b732d2"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("1ffdba46-0e55-4b0c-8d85-2aea50df8c87"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e33fbb17-5ba2-440d-b902-4a00bca90da3"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("20f90ed7-d7ae-4b17-91d6-eab20590e1cb"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e33fbb17-5ba2-440d-b902-4a00bca90da3"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("218a95eb-2c2a-4edb-93c7-b0dd269a4e44"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6bf972e2-3c3f-443a-b620-213a5b5987c9"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("225ff700-6791-4a72-a8cd-f766d27355b9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1b3c6a28-f241-44bd-9a3c-c7324dcaea1f"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("22733ae2-d998-4e16-acd4-6fa71064f5a0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("c376db5b-6c98-4783-9c9e-3f9715194de1"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("232bd64b-a8f9-48e3-aa99-65b45a9cd989"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2e3b394e-a19d-4739-878d-23f120a087a6"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("24209233-8099-4713-bf50-cca2342b5d74"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("86d8a5ce-7dd1-4c12-a18b-3b8cae9b9141"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("25babd8f-7376-4be3-bc91-4e8d6ec7f3e1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d040e013-1da2-451a-8442-8333ba03a3ba"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("26afb137-e988-4aff-8f40-2d2fe07664b8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c7e8c8d1-9bbd-42be-944b-5ac1c6f14c1c"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("26fb7590-d8bb-404c-a5b1-d1e6a5df136c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2e3b394e-a19d-4739-878d-23f120a087a6"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("28545095-8cef-4d5c-821f-a51b2a6276c4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fa850353-6ce0-4a1a-b674-0fe7a0036d4f"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("29743f6e-0381-47f2-b356-6dcd1836b2f0"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b0e18e07-6d90-429d-895b-8722eaf70f5f"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("29e10c7e-0cb7-4eb3-b17f-83230a240924"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("921662b1-17a2-49a0-9a01-46b3f5e263f7"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("2a7821f4-6a52-4a86-bdc3-528e5935033b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("21f463d1-9b18-49c3-ba31-c21fec91574e"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("2ba7b65d-b9af-4126-814c-73700774c7f1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8ae01d4a-132d-44be-b4b6-0026865ada31"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("2ce9e48c-52ab-4d55-96d0-8f66cd68002f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("63b834b0-b00c-4cc4-9a63-00b6be30c1b5"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2d703746-53a9-4baf-8f41-424a0ef3b533"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b1ee230f-e70c-4a0a-bb83-adc76edcaea3"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2d8b5e2b-0340-411b-9f1d-4733cf33116e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9bbe0836-32a5-4d6a-9e67-0e55af28ce57"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2d92c0f6-ffca-4848-976a-b58af51e5d38"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("afed46a5-144a-4bab-9e97-56a0a5311933"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2e035ceb-87c1-4356-bb16-0973f951ff93"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7e81399d-da3d-430e-bcf1-c086519d2628"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("2e2c7dae-efbe-46ce-b00a-e80a02686ddb"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("928b559a-969f-4e0f-89be-76a337b26a4a"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2e65407a-30e0-4027-868f-f2f0a047a85b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b3d2b131-e9dd-4b4b-9bbc-4136838ee162"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("2f03f974-155d-4687-8868-0f1b64b2d307"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("00dd5381-d9e1-4786-95d1-3f6601680bd8"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("2f7551f5-f1ee-455a-b2bb-c54e44f63557"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fd797c32-9e45-426d-ba70-13df5b52d47b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3234d556-2620-4f99-be23-a8a2bacbcdf7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c7e8c8d1-9bbd-42be-944b-5ac1c6f14c1c"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("32d92196-8117-451f-bd03-863de8dbb2f8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("468ef6ba-d784-4180-be31-da4c657b7247"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("3383fbe7-c640-4625-b2ee-9993c58740f5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("df0b050c-c6b9-4502-bce5-ee97dd866628"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("343c6257-c68c-40e2-b768-0e708dbbe1ed"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("feb133e3-3311-496a-aa54-4587b279ed52"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("356c621f-b80e-4fd0-b03e-a10335683c25"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("be3ea9e2-131d-45ad-bd71-367ddf90b50a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("389f3200-9140-498c-a359-950273aac74a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5772abe7-012a-4d67-ade9-6487a34e9a51"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("39c43a50-5234-4b11-a733-f90c67b143a5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("21f463d1-9b18-49c3-ba31-c21fec91574e"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3a5bac02-b8db-4fb0-bef6-920583d94227"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("22068f17-a9d7-4cad-8cc6-d67089b5d6fb"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3ba00f9f-6c01-44e0-806c-6cb3f7658913"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c3d00f7d-d1fb-4993-8354-e3246b55c3fb"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("3c964f18-8444-49be-a000-6ff7e9aaba0f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0df4b32b-64cb-4b8f-8a4f-e12bd193382c"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3cf65d32-9d30-4960-86d9-2fab667ae661"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("928b559a-969f-4e0f-89be-76a337b26a4a"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("3d56a05c-d858-44f4-ad0c-ea3412ce08b4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4deb0089-ea2c-4b1a-8ef9-34ee43e1c41a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3d6601b7-ae3d-4f9b-b706-b397883ab928"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("32fb6fdd-ec79-4186-ab48-dc52bb615a7f"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("3d69a046-2928-4ea3-a5e0-2dff12b8579a"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("612a1109-3375-46a0-890c-24bd54bf20f6"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("400f753a-92ae-4e5c-a401-22b95cdde6fd"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5d39d497-b431-4d53-902d-e5f00d062165"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4176e5f1-d781-45e9-b722-0db5052d4865"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("af7ae26f-b34a-4764-87af-1696f7e44b17"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("42dc8b26-3e1c-4b69-a97c-46809d712c62"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a2cb6fc8-271c-4396-9109-b44abaa4777d"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("43805eaa-2131-4aa7-a150-eacc7a71c6ed"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("428ed039-f2f8-4efa-8bb3-3770a9523981"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("43b11fc6-0eee-4efc-a8f0-cb8aadf57443"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("434a21ed-334f-4b31-867f-4bc2e1fd52f6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("449373bb-07b8-42a2-8528-c83d793d53c4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e466b3ea-bbc7-4ef1-9fee-9873973d6374"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("454f9bf8-8ace-44df-89a5-7dbc4396d7bc"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4c9582f0-3be9-45f4-b16b-e44962b313ef"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("45a50752-b7fd-43fe-a316-5259f6a0a8d5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6ac21cd5-3043-40db-928a-70bdb7026854"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("46d16174-a274-4cdc-ae03-3e468b1ac3d9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b967e634-58fa-43b4-b96c-c1dbc8556bf7"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4880aeda-e387-4c79-8e7b-be18c56bfc90"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("435add81-7b50-4015-88e7-5bd1011f9776"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("49295987-8068-40fe-b37b-3399b43db96e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("28f3df05-3df5-44dc-95f9-2dd28b92f42c"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("49cca45e-f022-44a4-9993-9c8467e4f016"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3f261817-b9f8-4fe1-b824-6b3553fcfe27"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4b3209b8-dd5b-4625-b603-d031ba1d860d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a9aebb71-db7d-462c-a3bd-056af59fea10"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4bd66747-5dcc-41e9-87e6-06918312a80f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4deb0089-ea2c-4b1a-8ef9-34ee43e1c41a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4cd25965-cc92-4789-b0b9-453c223102dd"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1c1580e2-caa8-4509-89c4-4497f7e56b08"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4d267ad4-a26a-4b52-bee4-1b6b4a8cefcd"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0cac7c35-cbcc-48f8-91a9-8c4b9d92711c"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4d9ae1bb-225a-4ba0-a8e0-8842def920ff"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("03d9fc83-71b0-4f8a-b0f0-81495cca0253"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4dc0ed88-5b10-49c6-9d86-140eb4523bb2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e2869cd1-7583-4006-a655-7a899bdb2c82"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("4e01442e-8c94-4707-8d08-6dee6967e782"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2ddab659-3854-40be-86ee-5d01cc9dc924"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4ec84c89-9741-4120-a60f-086a56371183"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6f6257ac-9a1e-4b35-b354-a524acd3dfee"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4efcbc94-4019-415d-883f-fa1d771db29f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6fbed1f9-d9b3-4544-a3bf-9c50dbeff440"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4f69ab6d-ea93-4a76-bf14-45a2dcc82fea"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9295e9e9-772c-411a-bb52-9f87ac617c53"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("4fb859ac-cdb0-4680-8468-a963cb6764fd"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("ed6e77fe-5500-4512-a43c-b40adb14cad3"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("4ffb08e6-1a0d-4ea7-8070-429c4d64979a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6fbed1f9-d9b3-4544-a3bf-9c50dbeff440"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5102c99e-8723-45b8-a3e6-c7fce8f44b3f"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("e2695491-6033-47d7-8636-6be2e0b7ccdb"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("51511f61-4926-4a07-a772-839d77115340"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fdded7d7-97f7-4c37-aaac-37e4e3f32b70"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("527ca9d4-cfe8-4496-afda-b10d155b98be"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b5579fa9-96eb-487e-a6f3-fdbf69b732d2"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("529085f6-7b84-4060-b2c2-632d70f74c43"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6ed3de65-b834-44e6-b9b8-24c35845b76f"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("53356879-d159-4cca-b676-da9aac28d538"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5d39d497-b431-4d53-902d-e5f00d062165"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("534f746b-a84f-4c9e-b567-55a40c59002b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("21fd0e07-e95e-420f-a63c-02436129f123"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("53da6efe-f9d1-4f93-b774-f517979860f0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c3d00f7d-d1fb-4993-8354-e3246b55c3fb"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("5660d98c-ea21-4494-b689-1f9c339a3fd2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("295ebf18-3fa1-47e7-9905-b2704857412e"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("567f3071-394b-4a18-8065-870c45250472"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("45318300-55ee-49bd-85e6-edb266ab663b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5889aa03-be64-4ab3-a7b0-2d53ccb8f0a6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("63b834b0-b00c-4cc4-9a63-00b6be30c1b5"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("593a0c2c-f3a2-4178-8433-e0545daa69cd"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("718347e8-24dd-44c8-9bb7-2c345a7996be"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5a0f6f32-9ab4-416a-86ed-ebb0ad6c1113"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fd5d4b9a-8848-45e1-af34-30e4d18d5679"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5aaa7c5a-0ec1-4300-9d9d-823a59bd0c0a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("45744658-b936-44a4-b208-4b507eff7149"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5bceada1-928c-4f4a-b941-722be0239364"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("27211033-520b-4cf7-a8e0-e9217d039175"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("5c0a7453-c10b-4bdf-a179-141179a76c14"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("9612ab4b-f483-4276-97ca-7e13514e8f2a"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("5d7ad2a8-7c21-4c4b-88ea-00c4b27d3e51"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c1f548d9-cbbc-48f4-b0a9-84565bbdb2b6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5db97679-74b3-4109-83de-a68a9ecefd17"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9a78886b-e9d4-4042-aeb0-48c53f391afb"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5f32ba7d-fa83-4c48-9bf3-6cd691601073"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9bbe0836-32a5-4d6a-9e67-0e55af28ce57"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("5f9eccbd-28d8-4526-ae55-8c84441d0442"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e652c39f-620d-4e2a-82bc-eef81ab9aadf"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("5fd0777f-323b-4b27-a742-519e8a6f22bb"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7d73fc0d-b501-4b10-a46e-41222680e589"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("60282d98-a925-4c6e-9cea-c6432aba4a44"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0b4118c2-1240-4294-97ca-6397385e1088"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("60a5e0c5-0b05-4662-9e58-e7a5cedf2479"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("26fe94b4-8dc2-468e-a17a-3bee36e0ce93"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("62914667-5be4-4d10-973f-dcf73fef796c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("ac19fab1-0fd3-4099-9852-37386073a2c0"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("62daf5e8-be5a-46c0-8228-e5e37d09e05d"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("5f3efbb5-ec4e-4af1-92fa-62a4fbc9dba1"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("62df0650-b93b-4aac-b4ef-7f677e88bb0b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6ac21cd5-3043-40db-928a-70bdb7026854"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("64ff892b-811e-4baa-9d8d-cd1f5dba0960"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b3d2b131-e9dd-4b4b-9bbc-4136838ee162"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("657ee6df-c4c7-4927-93ee-4362becbdd6e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6bf972e2-3c3f-443a-b620-213a5b5987c9"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("66b2804b-783f-4b4d-b7b1-384648b2d0c5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("73d11230-2a26-4323-a03f-4cd6288f61b6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6725da05-3bb0-4254-af3f-81c8290e4ed7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("717d1cac-7fef-49f5-b499-a9c9ae07b10e"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("673695a2-d78c-4094-9171-cb1a9c060120"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6b73e0d6-a9b6-4352-b6c1-2e46dfdcbd2a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("67d6749d-2b2f-42d3-8445-f782b9039602"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("22068f17-a9d7-4cad-8cc6-d67089b5d6fb"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("68b2f786-ca51-4f3d-99a3-87be78f05df2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d044500b-8ab9-43fc-bda0-4d01a68d67e8"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("69183a16-4c2a-4409-a87b-124aa6fb45e6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e291c6c9-efa8-44b3-bec9-f14845cde434"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("69aa07fb-34a3-48ce-b92d-0532f332e8cb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("73825353-fc54-4940-8bdf-732d42babd72"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6ae294a7-f2fa-47e5-a195-9c3c0c504dfc"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3dda6da0-e2ae-4ffd-a7da-80504c21deb4"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6b499653-d10e-455b-a2c8-be18d57f226d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b1ee230f-e70c-4a0a-bb83-adc76edcaea3"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("6c99e7b9-d0f4-4d93-8133-292d50315776"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("454a0a35-8c9d-4249-b2b4-fc2c3bd2d829"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("6cd5c7f1-97ec-4fb7-828b-f28e6cc30fac"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1d707d69-9409-406b-a139-844c1efcf71b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("70aa10f6-ab1a-4bcc-bc59-5645987541eb"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fe11ccfb-e99a-4b9a-92b7-f721cf35a8d9"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("74016483-e3fe-4454-a1bc-19ed27b8889c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("59f46794-f4f6-4d46-94f2-1186c8093f8d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("757c104e-7b1b-4a12-84f6-4b2b59f591f5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("dd0cdafc-1296-41d2-80d9-4a5f8e25b068"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("75e5a732-df1d-4907-8897-4f7e2c36fd84"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4dfa36ca-c546-4d01-a500-c86d838d6acd"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("76e1fef7-792c-4e7a-b216-3a48da686a06"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6788dcd7-38b9-4409-8197-337243649dbf"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("771f7343-44fc-4a5f-9345-9cd776c2b8fc"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("acfb19cc-7625-40e4-a4cd-5eaa302b06e5"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("78be7bad-079d-4081-9409-6667868842de"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d67f6935-336f-48c3-bf30-9c947291eab2"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("7910830b-5022-4276-abe9-a0659f9fe803"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("1472a61f-4059-44e6-9194-dd1a71c3a85d"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("7918529b-24e0-405d-8237-348e48ebdb60"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("01cf7347-48b3-46ac-899c-774ddb818f88"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("7abe45d5-9d77-405c-8358-0f9cbf0408c6"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("be6809dc-e518-4df6-a0dc-0365693b7b06"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("7d1b37dd-756f-4977-91bf-283d70bd89ba"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3dda6da0-e2ae-4ffd-a7da-80504c21deb4"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("7dc112f5-7ca7-401d-8a55-815cba38b74f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ee77ee2d-1657-4d13-b4ca-b4f43ef16565"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("7f7bcbad-6e3e-47ef-8593-33126b0a1f57"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6b73e0d6-a9b6-4352-b6c1-2e46dfdcbd2a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8013fe0d-3326-4397-85ed-c6f0827b13c4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("54fa7b4c-a21d-4f5a-af31-20a757c076da"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("811deabd-ce59-41f6-afbb-80339893baec"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("54d6be5c-3ca1-4cf5-8684-0077be50fd4e"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("813eca4f-4fd3-4ebe-9bf1-10bd32e521db"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("435add81-7b50-4015-88e7-5bd1011f9776"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("8186e913-2541-49fe-b0b6-9f08e5354aa4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("bfa61469-82f6-4109-baab-7157b9e872ed"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("82bb8e98-6a10-487b-9a45-04a0be6eec4a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8ce5405f-05bc-4b54-b667-f3af07cd4d8b"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("85087662-11cb-424e-a9ef-018cab217b17"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0c2474c8-d294-4062-ae37-951872d1d83d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("85c20099-4f46-4bdb-9b7d-c8fa131b6931"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b0e18e07-6d90-429d-895b-8722eaf70f5f"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("87d519ef-346d-42cb-8d61-3e2049693e4e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("d18a6504-45bb-4ed7-9605-8286126c585b"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8874bf6d-c4d4-483a-be37-14792d7fd02f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a2cb6fc8-271c-4396-9109-b44abaa4777d"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("89982f93-7d31-4717-b8b8-3760952a199c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b967e634-58fa-43b4-b96c-c1dbc8556bf7"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8b4b429b-e8e4-499c-aca6-33c062afef4c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("80a6977c-0877-4bc1-bd09-438323d30c7a"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("8c840831-4e7b-4977-8e41-6a6fcf472a42"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4c9582f0-3be9-45f4-b16b-e44962b313ef"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("8cef2972-5764-4849-9312-2ed35beec988"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3f3047bc-ae7d-4060-a86d-2a14f230933b"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("8d711e66-4c87-4200-a49c-2f73c62cd6ac"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a9dd9044-981d-43df-8a2a-9c18eefea542"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("8f5961b1-76c7-4791-9ab5-6d6c04058e93"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("73d11230-2a26-4323-a03f-4cd6288f61b6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("8f8d873c-64de-4d26-81e8-05b9d2b49528"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a9aebb71-db7d-462c-a3bd-056af59fea10"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("8fd7674f-b001-442d-94d0-203e7f0fca72"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f45861ec-97bc-46c4-80d7-613cd002ff0c"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9307cb29-2bc4-445a-b5fa-a9774523da99"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("5dcfe59e-9185-4fbc-a0ff-a813f18deee0"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("93569020-61c1-4ae4-9e93-c209d6bb28b1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("921662b1-17a2-49a0-9a01-46b3f5e263f7"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9443679a-59d8-4c46-a770-e1971323a5dc"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("48458511-e099-47c3-a2e5-a7556f6c5718"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("94ee018a-44d7-4e81-b2a9-394c9d340a5b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2ddab659-3854-40be-86ee-5d01cc9dc924"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("951979aa-f629-48aa-9843-82ac15aa51bc"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("864d7b29-1f20-430b-940a-957bdd8b0e12"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("96fde690-a328-4dbe-b64c-ba530b9a3437"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8720796c-8d1f-45f4-849b-79731c19402e"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("98687278-b549-4e80-8434-eef20241e972"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("855ddbd9-5a8c-42fe-a17e-d29c3a52e5d4"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("98c116d7-e5dd-4c18-88fe-ee631a2575a0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("057595ef-69df-45cf-b78d-8d08dd125de7"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("991da766-12a9-4c5e-9908-565d32b25f61"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d044500b-8ab9-43fc-bda0-4d01a68d67e8"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("99ac1418-0b73-48a0-bc90-bda6076c90ba"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("dd0cdafc-1296-41d2-80d9-4a5f8e25b068"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("9a79748f-cce6-442a-9714-6cf7412f9e2a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("43230963-f6dc-4b85-8070-2c3f4c773a93"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9bb8a3a5-9970-4b5b-8421-ec248fcb4f93"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e97fc920-4cc6-435e-89bc-7b27a612caf6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9bd26b50-4c19-4404-bfcc-6082a488e6d2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("80a6977c-0877-4bc1-bd09-438323d30c7a"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9cb7075d-63f8-47b8-979a-7d6707c623d1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("73825353-fc54-4940-8bdf-732d42babd72"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9cbfb5bf-79c5-4c7a-a75b-56d7f93f060c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("dd95d62c-6b9f-44f7-b4be-2b6021f85a29"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9d241e98-ec3a-4145-bd2d-702286fb5a68"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("526a2d56-6950-4fb4-a3fb-56fef9732520"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9e95a8e7-3a4a-4500-b2f6-1342896b1082"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("feb133e3-3311-496a-aa54-4587b279ed52"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9f1aa60d-9723-4fa0-8b97-4d11c820d0e4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5770d1bf-c2c0-4b85-8a47-a4a5a48beda9"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("9f2c4f0d-790d-46fc-bfb5-d330b387f674"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e291c6c9-efa8-44b3-bec9-f14845cde434"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9f5de468-243c-42df-9bce-1fcffaef0653"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("493206a2-2cdb-4600-a0f7-8dfdd4c3fea3"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("9fed827b-8835-40a7-a361-597e0dc5188e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("a967be53-5e81-4748-809b-ce1a72f6b285"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a09c94f8-48df-438f-94d7-b79c6999334a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0e77b93e-a9d4-4188-89fd-7486be51ed9d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a15c3c33-10be-4201-8dbb-a0c31622e7c0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("b08769b7-0e78-496d-bb02-b98ee99246df"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a15f9a44-108e-48bd-a919-3f07381b43a8"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("91a6bbeb-70e7-414b-bc55-d6450e11efbf"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a1d0f167-6dda-44ab-90ed-b4131ef718a5"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("a38a1245-df4a-44bc-88b5-c187e89d4ae9"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a1e56c6e-0a00-403b-8ffd-7557b0bf37c6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("45318300-55ee-49bd-85e6-edb266ab663b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a1f63fd3-33d6-450d-afed-c34556f1d3ae"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a0f7ce3e-2566-4814-a7bf-5b434984597a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a3758b9f-7943-4342-91d7-5f2336da55d1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d040e013-1da2-451a-8442-8333ba03a3ba"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a684cd1d-ee20-47a0-865b-f75fcb307eef"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("492f95c8-3ee3-4dae-9e30-fd802beb8eea"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a71897c8-f876-46ec-9ac7-cd5e0a13885e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f45861ec-97bc-46c4-80d7-613cd002ff0c"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("a86dd0ad-7012-45a1-ae27-cf7b5a2d1f6a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fa850353-6ce0-4a1a-b674-0fe7a0036d4f"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("a8b82d12-0a64-4d3f-91ff-85f02b2855ed"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4dfa36ca-c546-4d01-a500-c86d838d6acd"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("aae8f1ee-9878-4e97-b63d-2150c69a07a7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("45744658-b936-44a4-b208-4b507eff7149"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("aba3c012-99ef-4282-a4ad-df9d12cfeecb"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("a0d6f8fc-5cca-444a-bc70-50afcac5a1d8"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("ac0299aa-8ce2-4916-ba77-2be23832085f"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("09f81045-a576-47cb-91e7-18ad9fa98004"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("ac74cd09-4745-4e5c-93e7-4e44c466d2b9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7910d72f-6cc7-4903-afe0-13e9814f4b0a"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("ace6fa16-c2c4-4fae-aad1-0f0727dbbc44"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("df009349-3c94-4345-93ed-e593cb88d01b"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b0960519-18b8-4d6f-938c-8623c34cc301"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("27211033-520b-4cf7-a8e0-e9217d039175"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b1e7af87-f37c-4e29-85c5-7ae7b946e15b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6ed3de65-b834-44e6-b9b8-24c35845b76f"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b3a7f56f-c6aa-44b7-99e9-6d229b0d027c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d7411a08-03f3-447d-9ce7-c73ba0a6ccb1"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b486fdd9-c765-4fd5-b25f-98f38b1bf489"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3f261817-b9f8-4fe1-b824-6b3553fcfe27"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b4e78a86-03b6-4589-9b8b-3fb22d1c70b2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4110c5bf-b270-4327-9520-1bdeb7b97d8d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b5881c21-b04a-40a6-9b88-3a6f5216239c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("86d8a5ce-7dd1-4c12-a18b-3b8cae9b9141"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b59a3f62-dd33-47ee-a4d7-2736714f0c12"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("df009349-3c94-4345-93ed-e593cb88d01b"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b5d21197-859f-4112-a76a-78975ee81f9d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f4594468-afdd-4022-84fe-a762572b8a64"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("b5d79750-4004-408c-8bc6-f46318c4125b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f2bfad1f-e89e-4d47-8d69-e8500dd5212c"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("b6d40af4-7f5d-41ee-9e73-662677222661"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("228f98a7-4b0a-4c88-ad25-0f17159ffd6b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("bab6ee41-fb23-4c6d-afc1-946fbc2c1014"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("3a2c9515-7637-421a-8d30-8f5bd14b299d"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("bbdc0955-7607-4d9c-93ce-98d6646bbb91"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("df0b050c-c6b9-4502-bce5-ee97dd866628"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("bc8677ee-1a77-49ea-a2be-7ff5b36dfcaf"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4110c5bf-b270-4327-9520-1bdeb7b97d8d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("bcb633ae-c132-4723-8b5d-aa5ab8b7ba66"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3f3047bc-ae7d-4060-a86d-2a14f230933b"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("bd0aa7c6-a179-4ce4-9c05-237702b5ada8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("be3ea9e2-131d-45ad-bd71-367ddf90b50a"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("bdac2b57-cbd2-4052-a507-850af07ba2da"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7d73fc0d-b501-4b10-a46e-41222680e589"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("bdfd4ca1-7178-40c8-911a-5e309d4b2680"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d52409a3-91e1-4260-8058-46a5af138cec"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("bf4ed37a-955b-44c3-b3d8-fc5c4e0a3197"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("8e460941-0719-43e1-9f75-6daeb3563036"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("bfa839ce-efdc-4b0a-bcf9-62a214f7c144"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("f6ee7340-6f3d-40c2-b7b9-7349713d274e"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("c2ca6132-a063-42b2-8feb-5dba73ddc2a7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f2bfad1f-e89e-4d47-8d69-e8500dd5212c"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("c3534275-0e44-4494-bcc0-506a776dbd7a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0c1bd048-1507-4549-a8b5-9755cdb4dbc4"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("c3aa4009-4bb0-4314-a1b0-fb73d86a4b17"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e97fc920-4cc6-435e-89bc-7b27a612caf6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("c3c1bee0-4e27-469b-9962-0b5578cf3bca"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0df4b32b-64cb-4b8f-8a4f-e12bd193382c"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("c5de37c2-bf41-43aa-ac47-19d46ac58711"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8ce5405f-05bc-4b54-b667-f3af07cd4d8b"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("c6a1bdb0-3ba7-4828-8420-35f2b8ec7802"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("48458511-e099-47c3-a2e5-a7556f6c5718"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("c6eaa84b-2d78-430c-a37f-699f9cd8facc"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("04c34061-8c8d-4636-a286-ed21478dbf9f"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("cd120db6-e0d0-437a-a878-5a6ab25368fb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7e81399d-da3d-430e-bcf1-c086519d2628"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("cdf64df4-5c55-4f94-ba17-6ae460e7ac13"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("bac8a4fd-838c-47c9-89db-9e3cf6829b13"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("ce54b7ee-1d02-4b96-909a-f5e4b45e5148"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1b3c6a28-f241-44bd-9a3c-c7324dcaea1f"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("cf7248a9-c015-4b96-a243-a1c04066cfbe"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("295ebf18-3fa1-47e7-9905-b2704857412e"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d1050754-17f2-4c23-9ead-8344f7158a8c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("dd95d62c-6b9f-44f7-b4be-2b6021f85a29"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d15592fd-18e8-4b35-8f5d-31a40a73cc26"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a9dd9044-981d-43df-8a2a-9c18eefea542"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d2216854-4385-4680-8764-33f706c0e02a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("03d9fc83-71b0-4f8a-b0f0-81495cca0253"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d28cfe83-5d0a-468f-b939-a2f28ba4e69d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9295e9e9-772c-411a-bb52-9f87ac617c53"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d457d6a3-bf01-440a-b283-4fc04bafecb8"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b31b82e0-0ce8-4121-85a1-4d92a7d0f5f3"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d512b4a0-0c18-446a-b61e-629d36698b2d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fd5d4b9a-8848-45e1-af34-30e4d18d5679"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d5826fbf-9420-45c3-8c1e-4c420cdc334d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("21fd0e07-e95e-420f-a63c-02436129f123"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d6642a57-ed6c-4813-9dbd-3593d59de419"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("59f46794-f4f6-4d46-94f2-1186c8093f8d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d6c5e118-7ee1-4ba1-952d-4773f60b2dcb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0cac7c35-cbcc-48f8-91a9-8c4b9d92711c"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d783a514-3fa2-47a8-969b-c37de2341f2c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6f808edb-d8ad-40a6-8d96-b6da6e078c37"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d8092da9-5431-40f8-b37d-5f035f311a0c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("789c04a4-46e4-4e73-8194-44f79b3c9959"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("d826a9ce-d652-48fd-9908-95500aa1ebc1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0e77b93e-a9d4-4188-89fd-7486be51ed9d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d911c66a-585c-4407-8765-cb96b9800b5a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9a78886b-e9d4-4042-aeb0-48c53f391afb"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("d96b3deb-a0a7-4f46-9028-78e5df553027"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b3c64465-5285-4e53-a854-6270faa5a2c7"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("db250555-2d07-4c3e-8efb-fe7440c7174d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("afed46a5-144a-4bab-9e97-56a0a5311933"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("db85dcae-6382-4851-8a01-c21aa940214e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8ae01d4a-132d-44be-b4b6-0026865ada31"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("dc06917d-77fc-4471-a7f9-75cb99f26345"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0b4118c2-1240-4294-97ca-6397385e1088"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("dcc1a3dc-0534-489b-b032-c3c42e5b3c41"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ee77ee2d-1657-4d13-b4ca-b4f43ef16565"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("de27c92f-1472-4071-931f-12f3a19ea821"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("21a6952c-190d-42a6-b96a-e3b26f54b454"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("deda9637-2a65-49b0-9f27-efcad0874732"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("434a21ed-334f-4b31-867f-4bc2e1fd52f6"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e00eee29-9547-40ae-8f57-a102e68bc795"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("855ddbd9-5a8c-42fe-a17e-d29c3a52e5d4"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e0dff080-244c-454e-b753-11ae9f06b2fb"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e2869cd1-7583-4006-a655-7a899bdb2c82"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e1151ef3-f4f0-4ee9-bbf0-fe47e2258893"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6a8a03a1-fe03-4647-a924-e56d26359c30"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e14509e8-3e75-4ec7-8919-bab0aef86b5c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6788dcd7-38b9-4409-8197-337243649dbf"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e16d7ab7-42fd-4fcf-9a88-5642e1fbab80"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1d707d69-9409-406b-a139-844c1efcf71b"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e1b87688-00ec-4120-aefb-d7ac702fad26"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7910d72f-6cc7-4903-afe0-13e9814f4b0a"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e349ff91-2369-4bc7-9260-b89a5c01ecb3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8a5adb20-c467-4472-8d7f-c9e91b78e7c9"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("e3771fde-9734-4933-b62c-348973e8c6f9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2f765157-8c7b-4eec-8067-6d77cca2d2d8"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e5003424-2664-4ee0-8f12-9ef3d177a715"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e466b3ea-bbc7-4ef1-9fee-9873973d6374"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e66d51a0-6a52-432c-a6d9-12add03b7a0d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("54fa7b4c-a21d-4f5a-af31-20a757c076da"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e7178156-a642-4494-8756-b6da90d42a5c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("fdca28f7-21e5-4978-8769-9ec63a5c36c1"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("e7e4b0a1-584e-47ce-b2b5-8099bfdc214b"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("1972af1e-d156-4de5-beea-6b20a63d3183"), null, new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e8efb7e3-e531-438d-b8c7-05caccc421da"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("45be3d60-de2a-46ab-a1a9-d3f5ddf520d6"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("e952ee6d-e33e-4786-abff-9415a6aa422c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("3fea27ab-112f-4f25-a20e-fb94ed065d8e"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("ea9656e2-6fb6-43b1-a9db-8ed3bbdf09c4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("26fe94b4-8dc2-468e-a17a-3bee36e0ce93"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("eb2e3a8b-542f-4f94-8a91-e7744cd9b9e5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6f808edb-d8ad-40a6-8d96-b6da6e078c37"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("ec87f32f-b905-4177-ae32-faeb58a3f137"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("428ed039-f2f8-4efa-8bb3-3770a9523981"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("ede08738-0a0c-4e47-9d81-af8752bdd223"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8a5adb20-c467-4472-8d7f-c9e91b78e7c9"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("ef00b2e4-c378-4e77-9d37-56c60675b260"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("95b1092c-8796-48ca-82bd-2cd14f960dc4"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("f03b2a60-aa8a-460e-8d52-e055a94607ed"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("69b699c8-a787-49aa-884b-7bf3b0c13bd7"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f43a454a-ca81-4e24-9b5c-a4d8db9f126a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0c2474c8-d294-4062-ae37-951872d1d83d"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f4bfd5ea-d1c3-430d-815d-7a026c87a174"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6f6257ac-9a1e-4b35-b354-a524acd3dfee"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f60df462-a831-4060-bafb-c5d0bf653094"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8720796c-8d1f-45f4-849b-79731c19402e"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f738c06a-e911-4db1-ae77-592a5d2791a9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d67f6935-336f-48c3-bf30-9c947291eab2"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f7e16a9e-ec7e-4be6-bce2-2d54f51984a9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b31b82e0-0ce8-4121-85a1-4d92a7d0f5f3"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f8b4aed1-5ac7-4d94-86ad-4525608cf2b7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e0558a25-1b22-4172-be25-033cb02d7238"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("f93750b7-f43b-4fdc-b030-ecfc1e070a1a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0c1bd048-1507-4549-a8b5-9755cdb4dbc4"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("fa5b35f4-a7df-455e-9822-d639870c8903"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("717d1cac-7fef-49f5-b499-a9c9ae07b10e"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("fa6d6b14-a5c6-49c1-b220-c3fdbe50557b"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("6425f8e1-a2fd-438c-a1b0-a7caadab45b9"), null, new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("fae50116-7edb-4dbb-81c0-3f90363e7bf8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("493206a2-2cdb-4600-a0f7-8dfdd4c3fea3"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("fb33ac36-49d6-4477-ae33-56f24dc53ed2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d52409a3-91e1-4260-8058-46a5af138cec"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("fe9da76b-1267-43b3-8605-9ba8386f355b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b3c64465-5285-4e53-a854-6270faa5a2c7"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") },
                    { new Guid("ffcfd4a3-140a-4431-8a57-4d065cd72873"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("468ef6ba-d784-4180-be31-da4c657b7247"), new Guid("2d662146-21b3-476d-8053-9c5994e16637") },
                    { new Guid("ffef8702-ddbc-44ea-8e7c-c4f573b3af41"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5772abe7-012a-4d67-ade9-6487a34e9a51"), new Guid("945454c3-c085-4c27-b596-e55bc17971cd") }
                });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("19674c0d-278d-4951-a0ee-f672075af1d8"), new Guid("4fd7c6e4-d926-4998-8a8e-a8c27423c79a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 3100.0, "OB" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2"), new Guid("4fd7c6e4-d926-4998-8a8e-a8c27423c79a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 3100.0, "OC" });

            migrationBuilder.InsertData(
                table: "ZoneAreas",
                columns: new[] { "Id", "AircraftCabinId", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name" },
                values: new object[] { new Guid("ed1cbb31-a9e6-4c23-a639-ece1d5efb175"), new Guid("4fd7c6e4-d926-4998-8a8e-a8c27423c79a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 2300.0, "OA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("015f1234-5da8-45c2-b203-9b4aa5b6524d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("03a12918-8452-436a-82bb-cd7236f2bc57"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("03c14fa3-e46e-4436-98d8-cdaf845d203f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("04850faa-1326-4b6d-8201-1679cd8e9ba0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("058ecd3c-373d-499e-80ec-ad2485d25d36"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("074be6c3-b348-41b0-a1a3-6169acb64636"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0795abbf-cd3e-4c0d-a7aa-e2357f7cb942"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("07bb93b6-58ac-4614-926c-feb9da3de27c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("09dc1b00-91fb-4ee6-a503-d81ebb224abc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("09e09d97-7a8b-478d-836a-0b52602dd6c6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0a671f41-d362-427a-b1ab-e356e6f76844"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0ae2b89e-1f4b-40ef-8cc7-d377d7cb805f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0b4d6b11-75c3-4792-878d-1ba30572cf21"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0bda7499-5637-4219-93a8-814d1057c1c3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0ddc6830-fb56-4b45-b55b-f17dde3a8755"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1112c443-da18-4b2c-a035-67582b780ef8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("111439c7-4f24-4188-8dac-2cd5c2c5e976"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("11cf9c17-73d4-4756-b460-40b93fec9db9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("139540fa-6727-4de0-aa9a-eae07e2fb788"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("167404bd-6c2e-4cb1-ac64-142cf32109bc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1a00ddec-efbb-4aa8-b614-0fce999cf431"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1a3c3016-8eb6-4ee1-9c69-2074b789ef74"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1bf39ba8-404e-47b4-8b77-55f5f0209b03"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1c5b16e8-9202-4e4a-8920-d8d3baacc0ff"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1e4b3aa9-68e5-4169-b10e-cdff092f475a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1e83d41b-fb8e-4615-8176-2f7cac7dd5b2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1ed078ed-69db-42c5-aff0-68f813524222"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1ffdba46-0e55-4b0c-8d85-2aea50df8c87"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("20f90ed7-d7ae-4b17-91d6-eab20590e1cb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("218a95eb-2c2a-4edb-93c7-b0dd269a4e44"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("225ff700-6791-4a72-a8cd-f766d27355b9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("22733ae2-d998-4e16-acd4-6fa71064f5a0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("232bd64b-a8f9-48e3-aa99-65b45a9cd989"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("24209233-8099-4713-bf50-cca2342b5d74"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("25babd8f-7376-4be3-bc91-4e8d6ec7f3e1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("26afb137-e988-4aff-8f40-2d2fe07664b8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("26fb7590-d8bb-404c-a5b1-d1e6a5df136c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("28545095-8cef-4d5c-821f-a51b2a6276c4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("29743f6e-0381-47f2-b356-6dcd1836b2f0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("29e10c7e-0cb7-4eb3-b17f-83230a240924"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2a7821f4-6a52-4a86-bdc3-528e5935033b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2ba7b65d-b9af-4126-814c-73700774c7f1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2ce9e48c-52ab-4d55-96d0-8f66cd68002f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d703746-53a9-4baf-8f41-424a0ef3b533"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d8b5e2b-0340-411b-9f1d-4733cf33116e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d92c0f6-ffca-4848-976a-b58af51e5d38"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2e035ceb-87c1-4356-bb16-0973f951ff93"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2e2c7dae-efbe-46ce-b00a-e80a02686ddb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2e65407a-30e0-4027-868f-f2f0a047a85b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2f03f974-155d-4687-8868-0f1b64b2d307"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2f7551f5-f1ee-455a-b2bb-c54e44f63557"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3234d556-2620-4f99-be23-a8a2bacbcdf7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("32d92196-8117-451f-bd03-863de8dbb2f8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3383fbe7-c640-4625-b2ee-9993c58740f5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("343c6257-c68c-40e2-b768-0e708dbbe1ed"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("356c621f-b80e-4fd0-b03e-a10335683c25"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("389f3200-9140-498c-a359-950273aac74a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("39c43a50-5234-4b11-a733-f90c67b143a5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3a5bac02-b8db-4fb0-bef6-920583d94227"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3ba00f9f-6c01-44e0-806c-6cb3f7658913"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3c964f18-8444-49be-a000-6ff7e9aaba0f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3cf65d32-9d30-4960-86d9-2fab667ae661"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3d56a05c-d858-44f4-ad0c-ea3412ce08b4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3d6601b7-ae3d-4f9b-b706-b397883ab928"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3d69a046-2928-4ea3-a5e0-2dff12b8579a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("400f753a-92ae-4e5c-a401-22b95cdde6fd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4176e5f1-d781-45e9-b722-0db5052d4865"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("42dc8b26-3e1c-4b69-a97c-46809d712c62"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("43805eaa-2131-4aa7-a150-eacc7a71c6ed"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("43b11fc6-0eee-4efc-a8f0-cb8aadf57443"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("449373bb-07b8-42a2-8528-c83d793d53c4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("454f9bf8-8ace-44df-89a5-7dbc4396d7bc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("45a50752-b7fd-43fe-a316-5259f6a0a8d5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("46d16174-a274-4cdc-ae03-3e468b1ac3d9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4880aeda-e387-4c79-8e7b-be18c56bfc90"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("49295987-8068-40fe-b37b-3399b43db96e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("49cca45e-f022-44a4-9993-9c8467e4f016"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4b3209b8-dd5b-4625-b603-d031ba1d860d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4bd66747-5dcc-41e9-87e6-06918312a80f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4cd25965-cc92-4789-b0b9-453c223102dd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4d267ad4-a26a-4b52-bee4-1b6b4a8cefcd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4d9ae1bb-225a-4ba0-a8e0-8842def920ff"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4dc0ed88-5b10-49c6-9d86-140eb4523bb2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4e01442e-8c94-4707-8d08-6dee6967e782"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4eba096d-116b-4c57-830a-eee0e199b43c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4ec84c89-9741-4120-a60f-086a56371183"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4efcbc94-4019-415d-883f-fa1d771db29f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4f69ab6d-ea93-4a76-bf14-45a2dcc82fea"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4fb859ac-cdb0-4680-8468-a963cb6764fd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4ffb08e6-1a0d-4ea7-8070-429c4d64979a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5102c99e-8723-45b8-a3e6-c7fce8f44b3f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("51511f61-4926-4a07-a772-839d77115340"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("527ca9d4-cfe8-4496-afda-b10d155b98be"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("529085f6-7b84-4060-b2c2-632d70f74c43"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("53356879-d159-4cca-b676-da9aac28d538"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("534f746b-a84f-4c9e-b567-55a40c59002b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("53da6efe-f9d1-4f93-b774-f517979860f0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5660d98c-ea21-4494-b689-1f9c339a3fd2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("567f3071-394b-4a18-8065-870c45250472"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5889aa03-be64-4ab3-a7b0-2d53ccb8f0a6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("593a0c2c-f3a2-4178-8433-e0545daa69cd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5a0f6f32-9ab4-416a-86ed-ebb0ad6c1113"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5aaa7c5a-0ec1-4300-9d9d-823a59bd0c0a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5bceada1-928c-4f4a-b941-722be0239364"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5c0a7453-c10b-4bdf-a179-141179a76c14"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5d7ad2a8-7c21-4c4b-88ea-00c4b27d3e51"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5db97679-74b3-4109-83de-a68a9ecefd17"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5f32ba7d-fa83-4c48-9bf3-6cd691601073"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5f9eccbd-28d8-4526-ae55-8c84441d0442"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5fd0777f-323b-4b27-a742-519e8a6f22bb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("60282d98-a925-4c6e-9cea-c6432aba4a44"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("60a5e0c5-0b05-4662-9e58-e7a5cedf2479"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("62914667-5be4-4d10-973f-dcf73fef796c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("62daf5e8-be5a-46c0-8228-e5e37d09e05d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("62df0650-b93b-4aac-b4ef-7f677e88bb0b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("64ff892b-811e-4baa-9d8d-cd1f5dba0960"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("657ee6df-c4c7-4927-93ee-4362becbdd6e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("66b2804b-783f-4b4d-b7b1-384648b2d0c5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6725da05-3bb0-4254-af3f-81c8290e4ed7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("673695a2-d78c-4094-9171-cb1a9c060120"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("67d6749d-2b2f-42d3-8445-f782b9039602"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("68b2f786-ca51-4f3d-99a3-87be78f05df2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("69183a16-4c2a-4409-a87b-124aa6fb45e6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("69aa07fb-34a3-48ce-b92d-0532f332e8cb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6ae294a7-f2fa-47e5-a195-9c3c0c504dfc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6b499653-d10e-455b-a2c8-be18d57f226d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6c99e7b9-d0f4-4d93-8133-292d50315776"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6cd5c7f1-97ec-4fb7-828b-f28e6cc30fac"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("70aa10f6-ab1a-4bcc-bc59-5645987541eb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("74016483-e3fe-4454-a1bc-19ed27b8889c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("757c104e-7b1b-4a12-84f6-4b2b59f591f5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("75e5a732-df1d-4907-8897-4f7e2c36fd84"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("76e1fef7-792c-4e7a-b216-3a48da686a06"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("771f7343-44fc-4a5f-9345-9cd776c2b8fc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("78be7bad-079d-4081-9409-6667868842de"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7910830b-5022-4276-abe9-a0659f9fe803"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7918529b-24e0-405d-8237-348e48ebdb60"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7abe45d5-9d77-405c-8358-0f9cbf0408c6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7d1b37dd-756f-4977-91bf-283d70bd89ba"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7dc112f5-7ca7-401d-8a55-815cba38b74f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7f7bcbad-6e3e-47ef-8593-33126b0a1f57"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8013fe0d-3326-4397-85ed-c6f0827b13c4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("811deabd-ce59-41f6-afbb-80339893baec"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("813eca4f-4fd3-4ebe-9bf1-10bd32e521db"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8186e913-2541-49fe-b0b6-9f08e5354aa4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("82bb8e98-6a10-487b-9a45-04a0be6eec4a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("85087662-11cb-424e-a9ef-018cab217b17"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("85c20099-4f46-4bdb-9b7d-c8fa131b6931"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("87d519ef-346d-42cb-8d61-3e2049693e4e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8874bf6d-c4d4-483a-be37-14792d7fd02f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("89982f93-7d31-4717-b8b8-3760952a199c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8b4b429b-e8e4-499c-aca6-33c062afef4c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8c840831-4e7b-4977-8e41-6a6fcf472a42"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8cef2972-5764-4849-9312-2ed35beec988"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8d711e66-4c87-4200-a49c-2f73c62cd6ac"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8f5961b1-76c7-4791-9ab5-6d6c04058e93"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8f8d873c-64de-4d26-81e8-05b9d2b49528"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8fd7674f-b001-442d-94d0-203e7f0fca72"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9307cb29-2bc4-445a-b5fa-a9774523da99"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("93569020-61c1-4ae4-9e93-c209d6bb28b1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("93eb7660-d08e-42fd-89c1-379171c14b86"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9443679a-59d8-4c46-a770-e1971323a5dc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("94ee018a-44d7-4e81-b2a9-394c9d340a5b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("951979aa-f629-48aa-9843-82ac15aa51bc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("96fde690-a328-4dbe-b64c-ba530b9a3437"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("98687278-b549-4e80-8434-eef20241e972"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("98c116d7-e5dd-4c18-88fe-ee631a2575a0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("991da766-12a9-4c5e-9908-565d32b25f61"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("99ac1418-0b73-48a0-bc90-bda6076c90ba"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9a79748f-cce6-442a-9714-6cf7412f9e2a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9bb8a3a5-9970-4b5b-8421-ec248fcb4f93"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9bd26b50-4c19-4404-bfcc-6082a488e6d2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9cb7075d-63f8-47b8-979a-7d6707c623d1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9cbfb5bf-79c5-4c7a-a75b-56d7f93f060c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9d241e98-ec3a-4145-bd2d-702286fb5a68"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9e95a8e7-3a4a-4500-b2f6-1342896b1082"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9f1aa60d-9723-4fa0-8b97-4d11c820d0e4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9f2c4f0d-790d-46fc-bfb5-d330b387f674"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9f5de468-243c-42df-9bce-1fcffaef0653"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9fed827b-8835-40a7-a361-597e0dc5188e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a09c94f8-48df-438f-94d7-b79c6999334a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a15c3c33-10be-4201-8dbb-a0c31622e7c0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a15f9a44-108e-48bd-a919-3f07381b43a8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a1d0f167-6dda-44ab-90ed-b4131ef718a5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a1e56c6e-0a00-403b-8ffd-7557b0bf37c6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a1f63fd3-33d6-450d-afed-c34556f1d3ae"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a3758b9f-7943-4342-91d7-5f2336da55d1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a684cd1d-ee20-47a0-865b-f75fcb307eef"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a71897c8-f876-46ec-9ac7-cd5e0a13885e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a86dd0ad-7012-45a1-ae27-cf7b5a2d1f6a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a8b82d12-0a64-4d3f-91ff-85f02b2855ed"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("aae8f1ee-9878-4e97-b63d-2150c69a07a7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("aba3c012-99ef-4282-a4ad-df9d12cfeecb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ac0299aa-8ce2-4916-ba77-2be23832085f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ac74cd09-4745-4e5c-93e7-4e44c466d2b9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ace6fa16-c2c4-4fae-aad1-0f0727dbbc44"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b0960519-18b8-4d6f-938c-8623c34cc301"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b1e7af87-f37c-4e29-85c5-7ae7b946e15b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b3a7f56f-c6aa-44b7-99e9-6d229b0d027c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b486fdd9-c765-4fd5-b25f-98f38b1bf489"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b4e78a86-03b6-4589-9b8b-3fb22d1c70b2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b5881c21-b04a-40a6-9b88-3a6f5216239c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b59a3f62-dd33-47ee-a4d7-2736714f0c12"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b5d21197-859f-4112-a76a-78975ee81f9d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b5d79750-4004-408c-8bc6-f46318c4125b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b6d40af4-7f5d-41ee-9e73-662677222661"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bab6ee41-fb23-4c6d-afc1-946fbc2c1014"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bbdc0955-7607-4d9c-93ce-98d6646bbb91"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bc8677ee-1a77-49ea-a2be-7ff5b36dfcaf"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bcb633ae-c132-4723-8b5d-aa5ab8b7ba66"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bd0aa7c6-a179-4ce4-9c05-237702b5ada8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bdac2b57-cbd2-4052-a507-850af07ba2da"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bdfd4ca1-7178-40c8-911a-5e309d4b2680"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bf4ed37a-955b-44c3-b3d8-fc5c4e0a3197"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bfa839ce-efdc-4b0a-bcf9-62a214f7c144"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c2ca6132-a063-42b2-8feb-5dba73ddc2a7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c3534275-0e44-4494-bcc0-506a776dbd7a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c3aa4009-4bb0-4314-a1b0-fb73d86a4b17"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c3c1bee0-4e27-469b-9962-0b5578cf3bca"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c5de37c2-bf41-43aa-ac47-19d46ac58711"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c6a1bdb0-3ba7-4828-8420-35f2b8ec7802"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c6eaa84b-2d78-430c-a37f-699f9cd8facc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cd120db6-e0d0-437a-a878-5a6ab25368fb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cdf64df4-5c55-4f94-ba17-6ae460e7ac13"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ce54b7ee-1d02-4b96-909a-f5e4b45e5148"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cf7248a9-c015-4b96-a243-a1c04066cfbe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d1050754-17f2-4c23-9ead-8344f7158a8c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d15592fd-18e8-4b35-8f5d-31a40a73cc26"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d2216854-4385-4680-8764-33f706c0e02a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d28cfe83-5d0a-468f-b939-a2f28ba4e69d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d457d6a3-bf01-440a-b283-4fc04bafecb8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d512b4a0-0c18-446a-b61e-629d36698b2d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d5826fbf-9420-45c3-8c1e-4c420cdc334d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d6642a57-ed6c-4813-9dbd-3593d59de419"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d6c5e118-7ee1-4ba1-952d-4773f60b2dcb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d783a514-3fa2-47a8-969b-c37de2341f2c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d8092da9-5431-40f8-b37d-5f035f311a0c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d826a9ce-d652-48fd-9908-95500aa1ebc1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d911c66a-585c-4407-8765-cb96b9800b5a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d96b3deb-a0a7-4f46-9028-78e5df553027"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("db250555-2d07-4c3e-8efb-fe7440c7174d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("db85dcae-6382-4851-8a01-c21aa940214e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dc06917d-77fc-4471-a7f9-75cb99f26345"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dcc1a3dc-0534-489b-b032-c3c42e5b3c41"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("de27c92f-1472-4071-931f-12f3a19ea821"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("deda9637-2a65-49b0-9f27-efcad0874732"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e00eee29-9547-40ae-8f57-a102e68bc795"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e0dff080-244c-454e-b753-11ae9f06b2fb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e1151ef3-f4f0-4ee9-bbf0-fe47e2258893"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e14509e8-3e75-4ec7-8919-bab0aef86b5c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e16d7ab7-42fd-4fcf-9a88-5642e1fbab80"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e1b87688-00ec-4120-aefb-d7ac702fad26"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e349ff91-2369-4bc7-9260-b89a5c01ecb3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e3771fde-9734-4933-b62c-348973e8c6f9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e5003424-2664-4ee0-8f12-9ef3d177a715"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e66d51a0-6a52-432c-a6d9-12add03b7a0d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e7178156-a642-4494-8756-b6da90d42a5c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e7e4b0a1-584e-47ce-b2b5-8099bfdc214b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e8efb7e3-e531-438d-b8c7-05caccc421da"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e952ee6d-e33e-4786-abff-9415a6aa422c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ea9656e2-6fb6-43b1-a9db-8ed3bbdf09c4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("eb2e3a8b-542f-4f94-8a91-e7744cd9b9e5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ec87f32f-b905-4177-ae32-faeb58a3f137"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ede08738-0a0c-4e47-9d81-af8752bdd223"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ef00b2e4-c378-4e77-9d37-56c60675b260"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f03b2a60-aa8a-460e-8d52-e055a94607ed"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f43a454a-ca81-4e24-9b5c-a4d8db9f126a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f4bfd5ea-d1c3-430d-815d-7a026c87a174"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f60df462-a831-4060-bafb-c5d0bf653094"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f738c06a-e911-4db1-ae77-592a5d2791a9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f7e16a9e-ec7e-4be6-bce2-2d54f51984a9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f8b4aed1-5ac7-4d94-86ad-4525608cf2b7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f93750b7-f43b-4fdc-b030-ecfc1e070a1a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fa5b35f4-a7df-455e-9822-d639870c8903"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fa6d6b14-a5c6-49c1-b220-c3fdbe50557b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fae50116-7edb-4dbb-81c0-3f90363e7bf8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fb33ac36-49d6-4477-ae33-56f24dc53ed2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fe9da76b-1267-43b3-8605-9ba8386f355b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ffcfd4a3-140a-4431-8a57-4d065cd72873"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ffef8702-ddbc-44ea-8e7c-c4f573b3af41"));

            migrationBuilder.DeleteData(
                table: "SeatLayouts",
                keyColumn: "Id",
                keyValue: new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("19674c0d-278d-4951-a0ee-f672075af1d8"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2"));

            migrationBuilder.DeleteData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("ed1cbb31-a9e6-4c23-a639-ece1d5efb175"));

            migrationBuilder.DeleteData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("4fd7c6e4-d926-4998-8a8e-a8c27423c79a"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("00dd5381-d9e1-4786-95d1-3f6601680bd8"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("01cf7347-48b3-46ac-899c-774ddb818f88"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("04c34061-8c8d-4636-a286-ed21478dbf9f"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("057595ef-69df-45cf-b78d-8d08dd125de7"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("09f81045-a576-47cb-91e7-18ad9fa98004"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("1472a61f-4059-44e6-9194-dd1a71c3a85d"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("1972af1e-d156-4de5-beea-6b20a63d3183"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("1d6a2bde-55b0-49c1-b84f-08c6c3db7c39"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("28f3df05-3df5-44dc-95f9-2dd28b92f42c"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("3a2c9515-7637-421a-8d30-8f5bd14b299d"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("3fea27ab-112f-4f25-a20e-fb94ed065d8e"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("492f95c8-3ee3-4dae-9e30-fd802beb8eea"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("5181cf79-78cc-4c11-911d-d6f049d1a510"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("526a2d56-6950-4fb4-a3fb-56fef9732520"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("5dcfe59e-9185-4fbc-a0ff-a813f18deee0"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("5f3efbb5-ec4e-4af1-92fa-62a4fbc9dba1"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("612a1109-3375-46a0-890c-24bd54bf20f6"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("6425f8e1-a2fd-438c-a1b0-a7caadab45b9"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("69b699c8-a787-49aa-884b-7bf3b0c13bd7"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("789c04a4-46e4-4e73-8194-44f79b3c9959"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("864d7b29-1f20-430b-940a-957bdd8b0e12"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("8e460941-0719-43e1-9f75-6daeb3563036"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("91a6bbeb-70e7-414b-bc55-d6450e11efbf"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("9612ab4b-f483-4276-97ca-7e13514e8f2a"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("9d8985ca-18b6-4534-a3fd-43cdf7c106b4"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("a0d6f8fc-5cca-444a-bc70-50afcac5a1d8"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("a38a1245-df4a-44bc-88b5-c187e89d4ae9"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("a3f8011a-97cb-4281-98fe-c9d9c4b6c658"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("a967be53-5e81-4748-809b-ce1a72f6b285"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("ac19fab1-0fd3-4099-9852-37386073a2c0"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("acfb19cc-7625-40e4-a4cd-5eaa302b06e5"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("b08769b7-0e78-496d-bb02-b98ee99246df"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("bac8a4fd-838c-47c9-89db-9e3cf6829b13"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("be6809dc-e518-4df6-a0dc-0365693b7b06"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("c376db5b-6c98-4783-9c9e-3f9715194de1"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("d18a6504-45bb-4ed7-9605-8286126c585b"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("e2695491-6033-47d7-8636-6be2e0b7ccdb"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("ed6e77fe-5500-4512-a43c-b40adb14cad3"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6ee7340-6f3d-40c2-b7b9-7349713d274e"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("fdca28f7-21e5-4978-8769-9ec63a5c36c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03d9fc83-71b0-4f8a-b0f0-81495cca0253"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b4118c2-1240-4294-97ca-6397385e1088"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c1bd048-1507-4549-a8b5-9755cdb4dbc4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c2474c8-d294-4062-ae37-951872d1d83d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0cac7c35-cbcc-48f8-91a9-8c4b9d92711c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0df4b32b-64cb-4b8f-8a4f-e12bd193382c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e77b93e-a9d4-4188-89fd-7486be51ed9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b3c6a28-f241-44bd-9a3c-c7324dcaea1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c1580e2-caa8-4509-89c4-4497f7e56b08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d707d69-9409-406b-a139-844c1efcf71b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21a6952c-190d-42a6-b96a-e3b26f54b454"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21f463d1-9b18-49c3-ba31-c21fec91574e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21fd0e07-e95e-420f-a63c-02436129f123"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22068f17-a9d7-4cad-8cc6-d67089b5d6fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("228f98a7-4b0a-4c88-ad25-0f17159ffd6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26fe94b4-8dc2-468e-a17a-3bee36e0ce93"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27211033-520b-4cf7-a8e0-e9217d039175"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("295ebf18-3fa1-47e7-9905-b2704857412e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ddab659-3854-40be-86ee-5d01cc9dc924"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e3b394e-a19d-4739-878d-23f120a087a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f765157-8c7b-4eec-8067-6d77cca2d2d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32fb6fdd-ec79-4186-ab48-dc52bb615a7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3dda6da0-e2ae-4ffd-a7da-80504c21deb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f261817-b9f8-4fe1-b824-6b3553fcfe27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f3047bc-ae7d-4060-a86d-2a14f230933b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4110c5bf-b270-4327-9520-1bdeb7b97d8d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("428ed039-f2f8-4efa-8bb3-3770a9523981"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43230963-f6dc-4b85-8070-2c3f4c773a93"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("434a21ed-334f-4b31-867f-4bc2e1fd52f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("435add81-7b50-4015-88e7-5bd1011f9776"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45318300-55ee-49bd-85e6-edb266ab663b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("454a0a35-8c9d-4249-b2b4-fc2c3bd2d829"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45744658-b936-44a4-b208-4b507eff7149"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45be3d60-de2a-46ab-a1a9-d3f5ddf520d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("468ef6ba-d784-4180-be31-da4c657b7247"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48458511-e099-47c3-a2e5-a7556f6c5718"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("493206a2-2cdb-4600-a0f7-8dfdd4c3fea3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c9582f0-3be9-45f4-b16b-e44962b313ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4deb0089-ea2c-4b1a-8ef9-34ee43e1c41a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4dfa36ca-c546-4d01-a500-c86d838d6acd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54d6be5c-3ca1-4cf5-8684-0077be50fd4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54fa7b4c-a21d-4f5a-af31-20a757c076da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5770d1bf-c2c0-4b85-8a47-a4a5a48beda9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5772abe7-012a-4d67-ade9-6487a34e9a51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59f46794-f4f6-4d46-94f2-1186c8093f8d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d39d497-b431-4d53-902d-e5f00d062165"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63b834b0-b00c-4cc4-9a63-00b6be30c1b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6788dcd7-38b9-4409-8197-337243649dbf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6a8a03a1-fe03-4647-a924-e56d26359c30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ac21cd5-3043-40db-928a-70bdb7026854"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b73e0d6-a9b6-4352-b6c1-2e46dfdcbd2a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6bf972e2-3c3f-443a-b620-213a5b5987c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ed3de65-b834-44e6-b9b8-24c35845b76f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f6257ac-9a1e-4b35-b354-a524acd3dfee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f808edb-d8ad-40a6-8d96-b6da6e078c37"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fbed1f9-d9b3-4544-a3bf-9c50dbeff440"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("717d1cac-7fef-49f5-b499-a9c9ae07b10e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("718347e8-24dd-44c8-9bb7-2c345a7996be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73825353-fc54-4940-8bdf-732d42babd72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73d11230-2a26-4323-a03f-4cd6288f61b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7910d72f-6cc7-4903-afe0-13e9814f4b0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d73fc0d-b501-4b10-a46e-41222680e589"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e81399d-da3d-430e-bcf1-c086519d2628"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80a6977c-0877-4bc1-bd09-438323d30c7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("855ddbd9-5a8c-42fe-a17e-d29c3a52e5d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86d8a5ce-7dd1-4c12-a18b-3b8cae9b9141"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8720796c-8d1f-45f4-849b-79731c19402e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a5adb20-c467-4472-8d7f-c9e91b78e7c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ae01d4a-132d-44be-b4b6-0026865ada31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ce5405f-05bc-4b54-b667-f3af07cd4d8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("921662b1-17a2-49a0-9a01-46b3f5e263f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("928b559a-969f-4e0f-89be-76a337b26a4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9295e9e9-772c-411a-bb52-9f87ac617c53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95b1092c-8796-48ca-82bd-2cd14f960dc4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a78886b-e9d4-4042-aeb0-48c53f391afb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bbe0836-32a5-4d6a-9e67-0e55af28ce57"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0f7ce3e-2566-4814-a7bf-5b434984597a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2cb6fc8-271c-4396-9109-b44abaa4777d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9aebb71-db7d-462c-a3bd-056af59fea10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9dd9044-981d-43df-8a2a-9c18eefea542"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af7ae26f-b34a-4764-87af-1696f7e44b17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afed46a5-144a-4bab-9e97-56a0a5311933"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0e18e07-6d90-429d-895b-8722eaf70f5f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1ee230f-e70c-4a0a-bb83-adc76edcaea3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b31b82e0-0ce8-4121-85a1-4d92a7d0f5f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3c64465-5285-4e53-a854-6270faa5a2c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3d2b131-e9dd-4b4b-9bbc-4136838ee162"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5579fa9-96eb-487e-a6f3-fdbf69b732d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b967e634-58fa-43b4-b96c-c1dbc8556bf7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be3ea9e2-131d-45ad-bd71-367ddf90b50a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bfa61469-82f6-4109-baab-7157b9e872ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1f548d9-cbbc-48f4-b0a9-84565bbdb2b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3d00f7d-d1fb-4993-8354-e3246b55c3fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7e8c8d1-9bbd-42be-944b-5ac1c6f14c1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d040e013-1da2-451a-8442-8333ba03a3ba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d044500b-8ab9-43fc-bda0-4d01a68d67e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d52409a3-91e1-4260-8058-46a5af138cec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d67f6935-336f-48c3-bf30-9c947291eab2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7411a08-03f3-447d-9ce7-c73ba0a6ccb1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd0cdafc-1296-41d2-80d9-4a5f8e25b068"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd95d62c-6b9f-44f7-b4be-2b6021f85a29"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df009349-3c94-4345-93ed-e593cb88d01b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df0b050c-c6b9-4502-bce5-ee97dd866628"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0558a25-1b22-4172-be25-033cb02d7238"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e2869cd1-7583-4006-a655-7a899bdb2c82"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e291c6c9-efa8-44b3-bec9-f14845cde434"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e33fbb17-5ba2-440d-b902-4a00bca90da3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e466b3ea-bbc7-4ef1-9fee-9873973d6374"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e652c39f-620d-4e2a-82bc-eef81ab9aadf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e97fc920-4cc6-435e-89bc-7b27a612caf6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee77ee2d-1657-4d13-b4ca-b4f43ef16565"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2bfad1f-e89e-4d47-8d69-e8500dd5212c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f45861ec-97bc-46c4-80d7-613cd002ff0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4594468-afdd-4022-84fe-a762572b8a64"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa850353-6ce0-4a1a-b674-0fe7a0036d4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd5d4b9a-8848-45e1-af34-30e4d18d5679"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd797c32-9e45-426d-ba70-13df5b52d47b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fdded7d7-97f7-4c37-aaac-37e4e3f32b70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe11ccfb-e99a-4b9a-92b7-f721cf35a8d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("feb133e3-3311-496a-aa54-4587b279ed52"));

            migrationBuilder.DeleteData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("c79ca836-0e98-4804-98a5-eb20605ca368"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("0816bf93-fbfe-49ab-a260-b65b9a103659"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("0862c4a4-d2b3-43e7-b257-039447e64983"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("1bca6e23-55e5-4ef8-b31a-c9514381d82f"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("32ea293f-2b5b-4a3f-a821-cf2a25de754e"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("4698a608-103e-4166-afe1-c99257c8b44d"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("538c9eb2-bdfb-480a-9080-56c3b099b4c5"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("5f658532-5f68-48fc-84e5-fa7f7441d71c"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("630980b3-4851-45c9-b324-b5888107882a"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("af6f8cbf-7d77-4c74-a838-4352788b5643"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("d4d904e9-aff6-4f94-8007-6cedebdb7490"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("ede1aafe-51d1-437f-b755-e0b31c923aad"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("ede2607b-591b-461f-b8f3-faa6f138d258"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("f2fc4660-598f-43d3-8a07-cf0488bd37b2"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("f95af152-4270-48d4-9190-48f01c8239d5"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("0acce13b-4b0c-43e3-855a-7899c9de1ed0"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("0bf37374-c2f3-4569-9ca2-396584675bba"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("138a77c3-8371-4a9d-ad6a-48044e61ca2e"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("1a2153a7-2a47-459f-b7d0-3b6360cb7bbb"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("21a3b94d-102b-4b00-ad2c-b82eb0850bbc"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("255e1a3f-6de3-4f3f-8e55-6d86448d7e49"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("274816a9-bee1-487c-a173-0227cbcd39e8"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("2c175271-34f1-4ef3-adaa-176e528d0c54"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("2d747796-3345-4a49-aca7-246f1d986f6e"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("2da995ca-4a08-432a-8481-003d2048ffe8"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("349a398a-8e31-4129-ad75-9aa74e7a52e4"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("358c2d48-3035-4b9a-88a5-0dc81357c9bb"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3c88c62b-7880-4174-8365-a8368a4b5657"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3d67def6-3a2b-4a75-9360-0878bcc2cc97"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3f5c9d82-6159-4e53-a3d7-9c3d85413b8d"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("44c9bb32-446b-4c6e-a010-dc76d3d92616"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("489e640c-6494-4859-a44b-64fca2260602"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("4f7b5755-bd3e-4f20-b280-6fef70e88839"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("568f3ac1-6144-48a9-81f6-6d57239ed042"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5cdcaaf4-8887-467e-a402-9080a513bfa1"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5f9a3602-23b1-4104-a50a-bebc33d28c41"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6429c12a-5f46-4bfd-bba3-57abddbe9d91"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("64fc2883-c4ba-45c5-ad6b-6a7bec785bb7"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6fa761dc-4cfa-45d4-a1ae-10d0fb7b5fd2"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("76ec8fd3-1ed6-467a-bb9e-168718fd3c5e"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("7e2bd102-47c8-42ff-94de-ca8cf28d4c6a"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("831a46c2-306e-4f65-8832-f00755485f78"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("88b12932-af37-48d5-9887-1063d9a4e5ae"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("9386ff22-f9f2-4763-82cf-a42f0037954e"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("95743000-546e-4419-b2ba-0625d8d3e7a9"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("95e7038e-b248-4902-8c0f-87e543493096"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("9cf91d9f-3783-45bd-af82-3c8c3bb7786f"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ab59ac68-aca5-417d-894a-087d3377ca7d"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ad52dc04-fce9-4678-a8aa-298411cbecf4"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("b856b30c-6d28-43ae-bdcb-0acf59d65bd1"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c9dd3b22-b66d-40a5-9a90-c7e05e712f7e"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cb35e33c-b59a-4cef-9671-0b0fd9377bc4"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("db37bde8-b7cc-40b1-9be9-2ac7c73e9527"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("fbdba069-7a00-473e-af14-5508b4f88ac8"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ffe20315-17ce-4f7a-b74a-4041a833d6ca"));

            migrationBuilder.DeleteData(
                table: "AircraftLayouts",
                keyColumn: "Id",
                keyValue: new Guid("87da2cd2-afc4-4258-b67e-003283224206"));

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
    }
}
