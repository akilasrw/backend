using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_Aircraft_Layout_B7879 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("4fd7c6e4-d926-4998-8a8e-a8c27423c79a"),
                column: "MaxWeight",
                value: 11500.0);

            migrationBuilder.UpdateData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("c79ca836-0e98-4804-98a5-eb20605ca368"),
                column: "MaxWeight",
                value: 11500.0);

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

            migrationBuilder.InsertData(
                table: "OverheadLayouts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsBaseLayout", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, null, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsFullRowOccupied", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "MaxWeight", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("056e3c88-b1ed-46c1-8a24-c1d7e680c414"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)55, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("063aa7de-fc86-450f-9a80-635c724240fe"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)38, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("0a0b9666-5214-4250-973b-386b0e0531ed"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)62, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("0a167a42-fb25-4679-adaf-c698c22b2c5e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)43, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("0a88e142-c9d2-47b9-b6b3-3391e8e95d88"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)31, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("0ac67ba8-2c8a-42db-9883-bc4603ef2dcf"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)38, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("113d6dbd-be39-4597-a7f8-1dd0dd041c56"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)59, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("18f679ec-8b2f-4353-9b8a-4dc3ab25c459"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)51, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("1baafe05-b6ff-4d26-85af-88d96870f47a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)36, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("1c305dfe-d592-42f0-9ada-3c579434b6d5"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)60, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("1c57c1fb-b25f-4caa-967a-b2e5a92abdea"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)50, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("1f5a5daa-9cea-46ee-aa37-40d9be4f5b69"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)41, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("20952002-5945-4615-aed0-74a5c6319d91"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)45, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("20a3cab2-5b82-4270-a811-a11d8f2f089a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)37, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("231712ef-9eeb-49ae-bfba-4fc60a05ef50"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)42, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("26043bd8-cd44-400f-90e4-4f091557cf23"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)31, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("2711b67f-c994-4408-b4e4-72845d757216"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)51, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("28c40b53-7210-40ef-bf01-c70471e0fb61"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)37, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("28f78eaf-3925-46d7-b1cf-7a952f14b925"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)41, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("292bf006-c41c-4b8d-a07c-5fc4890e4e5c"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)55, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("318fdc93-e81a-44fe-8266-4e5a619b9826"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)40, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("344a96bc-a7e2-46ae-acba-16dee8fb4336"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)63, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("35a7621b-0550-412c-944a-781391f25948"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)60, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("3b280c1d-e39e-48d6-b14f-994ea0ce0776"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)40, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("3d675813-de3c-49ff-8979-64a769efcb37"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)31, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("4087dc0b-00d8-4c4b-a053-631906e07d8d"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)52, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("42b949dd-33c9-4a60-9a46-a97302c1d979"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)56, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("482d3f43-a722-4da0-9105-9ce11203e841"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)35, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("4882b330-9701-4c00-8cc8-189cf518e1a3"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)50, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("494e0ff1-1337-42ab-8d1b-f5b2dc652121"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)38, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("5280754f-7f64-464d-b0bf-58cb959c2990"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)40, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("55abdb92-c684-4e83-ad70-1033b6f53d33"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)32, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("5bc6319e-acae-4043-a850-c7dbf51a19f3"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)54, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("5c8573be-d7d6-446c-b3a4-bfc623581dc5"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)53, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("5e996939-6278-45e8-88a6-6209cfae9f5d"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)34, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("628819c7-5a6e-4236-9fd7-7dbe8c221366"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)61, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("69d4f326-7424-45fc-8029-cdbcc870b9ba"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)35, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") }
                });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsFullRowOccupied", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "MaxWeight", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("6b1aec18-663e-4856-8799-bf3fa43175e1"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)53, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("6c087ef7-1259-4209-a491-c2b608d8c991"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)58, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("6de60e0b-27df-4e0c-8a57-b6ca9e2dec04"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)52, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("771fd627-1f56-47c4-a9dc-8a875ea3199d"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)56, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("78e8e517-6a0a-4ca4-8f97-c6ec4ccecfab"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)54, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("7aec60c9-dea5-4bbb-b176-d9c8532f345c"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)46, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("7d4446c6-c7ad-48f9-95be-e6658c3b1bb2"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)36, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("7e4505e8-51df-4a11-b55d-ea7bae3c7fca"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)57, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("80692a94-7d4b-480f-8947-21fa8a977d49"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)57, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("80f6d2f4-d30b-48f5-bbb8-19471b967952"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)46, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("8268bb0b-77bd-4b6b-a32f-39b309a89dd9"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)58, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("85b212c8-6d5e-4497-a47e-3c05ddae56a4"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)33, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("88d82e0b-7531-4ace-833a-7cf0c3ab1abb"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)34, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("89264880-ae19-41f1-957e-92109d80d9a7"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)44, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("8cdd14bf-c36f-434a-a0a8-e094760348ab"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)43, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("8e7b967f-4637-453f-9760-2ed1e70e5593"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)39, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("94d54718-2841-4047-92d1-85ac9961b1ea"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)51, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("968d6a79-246b-4f09-9432-398f8c319110"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)44, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("9d2d9678-1a81-44dc-aece-a977dc2921e5"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)48, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("9fed3f90-8553-41c9-8412-7c10e3544a7d"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)59, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("a2ded28f-509d-45e8-bddd-eca33a13159a"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)48, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("a750fb92-563c-4f8e-b170-3941e16b56f2"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)61, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("a8c0c21d-a38b-4275-b077-b82f9438dc38"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)39, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("aa372ee6-8748-474a-b819-c25585b7c5e1"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)42, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("ab356d44-8aab-4beb-b895-e55ec9d3015c"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)45, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("abc5e480-6d7b-41b5-adc5-c5c931d71a44"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)47, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("aea5ca75-eedd-4014-93e4-09ce79f3b673"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)33, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("b015e294-5763-47e3-b940-d3169db97b8e"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)52, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("b0aee100-0f81-487a-a116-92c2e0d9f6d2"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)41, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("be6d050f-5aee-498a-8861-feb127f9c30b"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)49, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("bf080781-1402-4954-87cd-49d0b08a7a14"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)49, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("bf78f71f-48ce-45e8-aea1-c4fe42c5fada"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)37, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("c4457bb6-6a96-4e56-8ebe-d5cc8e5c6ceb"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)43, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("c7a6b125-ac03-466c-af47-ca6313e15494"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)50, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("ce7e012c-be36-4d30-a3d2-d8ac99813c49"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)33, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("cf8a1b52-dfaf-4efe-a24d-3fd613344ecb"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)53, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("d5ed9749-d7e6-40ea-8dd3-a5c80779c8e8"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)58, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("d5fe9fe4-f10e-48fd-9440-2cc20034ab77"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)45, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("d76bfe31-cf1a-4d5c-9595-de402bd451e4"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)55, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("d7761a8b-54a6-4f18-941a-442707badedf"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)57, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("de620652-3f87-4f08-bd59-30a4f3e0e083"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)61, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("de84c898-746f-4db8-8565-0391f8711124"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)54, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") }
                });

            migrationBuilder.InsertData(
                table: "SeatConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsFullRowOccupied", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "MaxWeight", "RowNumber", "SeatConfigurationType", "SeatLayoutId" },
                values: new object[,]
                {
                    { new Guid("e0af8cdb-8e05-44fe-a06c-42fbc6faf2f9"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)60, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("e5f23359-2ee8-4716-a89e-c518ec6efda5"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)56, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("ea66fe9d-029f-4c17-b3d4-19e86be144c4"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)35, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("ee7afd1a-4ab1-480c-8483-27bb4f6d86b6"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)48, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("ef327cf5-5167-461b-8446-fd587e76d3e6"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)59, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f0cabc9c-9eb1-4df3-a80a-b8b760ba8258"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)36, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f1a98de2-7794-4868-9a39-cd3bb79ceb21"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)39, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f205aaf2-d057-48f4-9ca5-eb1842647ea7"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)42, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f2d97938-e857-47bc-8473-637815800ec5"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)44, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f422fd35-20dc-47d3-9f33-5ddba2cebbf8"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)49, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f63acdf8-a0a6-4f14-a1e4-59be8e6e5df3"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 50.0, (short)34, (byte)3, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f84cdc6f-a60c-44b0-82b2-7c0e2e3d672f"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)32, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") },
                    { new Guid("f9ee8d25-065f-40ff-b691-ddfe1c5fda4b"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, (short)32, (byte)2, new Guid("13c968a3-c9e0-410c-b1ee-8f8f6e32ea3e") }
                });

            migrationBuilder.UpdateData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("19674c0d-278d-4951-a0ee-f672075af1d8"),
                column: "MaxWeight",
                value: 4100.0);

            migrationBuilder.UpdateData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2"),
                column: "MaxWeight",
                value: 4200.0);

            migrationBuilder.UpdateData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("ed1cbb31-a9e6-4c23-a639-ece1d5efb175"),
                columns: new[] { "CurrentWeight", "MaxWeight" },
                values: new object[] { 3200.0, 3200.0 });

            migrationBuilder.InsertData(
                table: "OverheadCompartments",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[,]
                {
                    { new Guid("13f71c23-b599-402a-8a25-8a4fc0678fe7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 7 },
                    { new Guid("16047f4a-e38b-4cf9-9245-8d1426198dbf"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 1 },
                    { new Guid("197faf7f-feaa-40a6-b8b0-c414309f9719"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 4 },
                    { new Guid("1cad0800-a720-466a-9e1a-89a3671177e9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 11 },
                    { new Guid("2516c270-a5d5-4551-9412-615c82902962"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 6 },
                    { new Guid("502bb6dc-1f11-4cec-8fdf-f6fa144ef2b2"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 6 },
                    { new Guid("53da8a9f-ea90-4e6e-b379-98330f4b4cce"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 8 },
                    { new Guid("56d9f235-3a2b-416b-9694-96a0d5363dfa"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 5 },
                    { new Guid("5887fdd8-7a8d-4922-90f1-7d249beac12e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 3 },
                    { new Guid("598cb313-252f-4e44-bdad-8a4ba7ac0f7a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 11 },
                    { new Guid("5f866475-19d2-422b-8d89-4c6f083c0ee5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 10 },
                    { new Guid("61785a51-43d7-471e-a5c1-1dc926f1078f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 3 },
                    { new Guid("62fe319a-6c39-40c6-a8aa-3381072fa3a4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 9 },
                    { new Guid("70c09f4d-51b9-4a3e-a115-d0786ff61585"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 5 },
                    { new Guid("7f740975-d048-4dc1-a82a-a599a5cc808c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 7 },
                    { new Guid("8a580aa1-3c17-4254-adf5-6a00f7684320"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 1 },
                    { new Guid("8bf99391-a663-4a5b-9bbe-2b6a53348ec7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 4 },
                    { new Guid("939ae7a6-24f3-49a9-958f-19c3c18f7b9a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 2 },
                    { new Guid("c5dc8694-6ad7-469e-90e4-43e240d23504"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 10 },
                    { new Guid("d5c24a79-1ae5-43dc-bad4-063466166be3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 2 },
                    { new Guid("e3b470fc-4099-4a97-9931-43ffab9aa014"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 9 },
                    { new Guid("f62f2d96-e8ed-4056-9c87-c9e05d460021"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 8 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("001aca7a-ed2e-42c2-9ea4-689b1df6dc3f"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("d5ed9749-d7e6-40ea-8dd3-a5c80779c8e8"), "58A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("01cd7af6-fb93-431c-828b-97f6245ca368"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)33, new Guid("85b212c8-6d5e-4497-a47e-3c05ddae56a4"), "33C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("01d73435-909d-4b49-bb8a-bf4da8c5586f"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("494e0ff1-1337-42ab-8d1b-f5b2dc652121"), "38C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("02b288d9-4ac4-4cc3-8532-a92ad4daa733"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("bf080781-1402-4954-87cd-49d0b08a7a14"), "49B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("02b9d1af-d852-468c-8a13-facbfdca0108"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)32, new Guid("55abdb92-c684-4e83-ad70-1033b6f53d33"), "32F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0321a7ca-b22b-455e-90b7-61b4344f2ef4"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)63, new Guid("344a96bc-a7e2-46ae-acba-16dee8fb4336"), "63D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("03db8ec3-b4e6-4ccd-8295-f7bf6159e3cc"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("20952002-5945-4615-aed0-74a5c6319d91"), "45D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("053d37eb-3ac0-4d2a-8512-a4fa4f5c960e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)31, new Guid("0a88e142-c9d2-47b9-b6b3-3391e8e95d88"), "31A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("054f7037-bf9a-485e-aba4-2fb6b3752fcc"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("5280754f-7f64-464d-b0bf-58cb959c2990"), "40E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("05761598-bfcf-43c1-be76-4cfedc3f2469"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("c7a6b125-ac03-466c-af47-ca6313e15494"), "50D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("08edf71d-f70f-4fde-a69c-8d7f74e8e5a7"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("28f78eaf-3925-46d7-b1cf-7a952f14b925"), "41E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("09c3b3bb-7738-490d-9a83-1bd7ed0bb7de"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("8268bb0b-77bd-4b6b-a32f-39b309a89dd9"), "58H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("09fd853c-e3be-4415-a2f7-ef562542e684"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("113d6dbd-be39-4597-a7f8-1dd0dd041c56"), "59F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0a01cd79-5179-4eda-b16d-859a7ca005a8"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("1baafe05-b6ff-4d26-85af-88d96870f47a"), "36E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0b2f7488-8930-442a-899d-48c9cdda345c"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("ef327cf5-5167-461b-8446-fd587e76d3e6"), "59C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0b8cd886-9d69-429e-b2cf-aee59884538c"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("f1a98de2-7794-4868-9a39-cd3bb79ceb21"), "39A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0c2160c1-c3ab-499d-b149-2def35c25670"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("2711b67f-c994-4408-b4e4-72845d757216"), "51E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0d3fa4a3-2877-4e63-bcea-d743198d4fc1"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("bf080781-1402-4954-87cd-49d0b08a7a14"), "49C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0e816d9e-719e-43f2-a065-a51747e2c637"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("94d54718-2841-4047-92d1-85ac9961b1ea"), "51B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1089b230-896d-42e9-8797-4277f851e832"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("3b280c1d-e39e-48d6-b14f-994ea0ce0776"), "40H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("1146bfb6-e479-48cf-83f9-d62814c58593"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)33, new Guid("85b212c8-6d5e-4497-a47e-3c05ddae56a4"), "33A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("124e9e6b-b8bc-4e1a-954d-13d4b1ad86a4"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)32, new Guid("55abdb92-c684-4e83-ad70-1033b6f53d33"), "32D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("12893112-0583-42bd-bd58-f9adc577aee6"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("f63acdf8-a0a6-4f14-a1e4-59be8e6e5df3"), "34B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("141e8876-7e93-426b-8b10-6dd3b69354fe"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("063aa7de-fc86-450f-9a80-635c724240fe"), "38F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("14493811-34db-4f57-948e-71386573967b"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("cf8a1b52-dfaf-4efe-a24d-3fd613344ecb"), "53D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("14b899b0-35a2-4388-96cb-423d071dffd4"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("4882b330-9701-4c00-8cc8-189cf518e1a3"), "50A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("15290099-ae03-4fb5-9f9b-8112dd35f691"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("42b949dd-33c9-4a60-9a46-a97302c1d979"), "56I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("152db039-c629-4a50-9004-80d80999811c"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("78e8e517-6a0a-4ca4-8f97-c6ec4ccecfab"), "54B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("158be4e7-02ac-438d-9a2a-315c81f9fdbd"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)61, new Guid("628819c7-5a6e-4236-9fd7-7dbe8c221366"), "61F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("15f741ec-66ac-4eb5-80b2-c4b094b6b6e6"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("482d3f43-a722-4da0-9105-9ce11203e841"), "35C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("16018cfd-4c01-449e-9e07-2966410d9211"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("ab356d44-8aab-4beb-b895-e55ec9d3015c"), "45A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("162311a3-9f95-45dd-80ff-c1977f9c3556"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("be6d050f-5aee-498a-8861-feb127f9c30b"), "49F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1864aefd-322e-4911-a03a-a4008c1c604b"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("9d2d9678-1a81-44dc-aece-a977dc2921e5"), "48G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("19786cff-aa2a-4a12-a045-51dc74d1e820"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("1baafe05-b6ff-4d26-85af-88d96870f47a"), "36F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("19d610a5-9fe1-40b6-a193-039922978be8"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("b0aee100-0f81-487a-a116-92c2e0d9f6d2"), "41G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("19d9d47d-413e-47ed-a4c8-552fa35f7876"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)62, new Guid("0a0b9666-5214-4250-973b-386b0e0531ed"), "62E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1b8dc613-c4fd-4ce5-bf8c-071e31475d67"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("6c087ef7-1259-4209-a491-c2b608d8c991"), "58D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1cf286eb-4651-4799-b900-3d2c86a3ab9c"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("28f78eaf-3925-46d7-b1cf-7a952f14b925"), "41D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1f8255aa-42bb-499f-bb33-29513622e95a"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("18f679ec-8b2f-4353-9b8a-4dc3ab25c459"), "51I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("210b0adf-b940-4e92-b090-921e74ebc1a6"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("e5f23359-2ee8-4716-a89e-c518ec6efda5"), "56D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2147837b-7036-4b5c-b817-9b85539c56d9"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)62, new Guid("0a0b9666-5214-4250-973b-386b0e0531ed"), "62D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("21f62bed-abcb-43df-b865-98ad6c7191d6"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("292bf006-c41c-4b8d-a07c-5fc4890e4e5c"), "55H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("22a1c2af-034f-4df0-9055-08fb0dfce5c7"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)32, new Guid("f9ee8d25-065f-40ff-b691-ddfe1c5fda4b"), "32I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("240e0b92-b7f9-4ff6-8a96-77505e646b14"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("8e7b967f-4637-453f-9760-2ed1e70e5593"), "39D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("24589532-36be-44ed-a7c2-8fe667476f05"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("bf78f71f-48ce-45e8-aea1-c4fe42c5fada"), "37H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("247f0824-ea3c-4d5a-8bd4-9bea886ee8a3"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)61, new Guid("628819c7-5a6e-4236-9fd7-7dbe8c221366"), "61D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("27d92835-4254-4ec5-9010-1d6a33ac7b01"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("968d6a79-246b-4f09-9432-398f8c319110"), "44D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("29403e39-eefe-4fb9-8d01-3519a7f6d131"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)61, new Guid("628819c7-5a6e-4236-9fd7-7dbe8c221366"), "61E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("29813703-2d8d-44a9-b255-7e90f92a910e"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("35a7621b-0550-412c-944a-781391f25948"), "60C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2ab3e73f-ab99-4f4c-b959-41e40f10cbfe"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("94d54718-2841-4047-92d1-85ac9961b1ea"), "51A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2c040898-203d-4868-ba53-67aa25fa9ab6"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("2711b67f-c994-4408-b4e4-72845d757216"), "51F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2c3e9456-e03a-4158-b7aa-32c743fc7a3d"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("3b280c1d-e39e-48d6-b14f-994ea0ce0776"), "40G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2c83c506-915a-4ba2-932d-44e74af62e10"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("1f5a5daa-9cea-46ee-aa37-40d9be4f5b69"), "41A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2d2900e1-2055-4bc6-a22e-f8ced06c8b11"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("d76bfe31-cf1a-4d5c-9595-de402bd451e4"), "55E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2d40dfee-5890-47c9-bade-2d6ae6617176"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("0a167a42-fb25-4679-adaf-c698c22b2c5e"), "43C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("33064e46-3dce-4d4a-9696-33cbdafe5070"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("78e8e517-6a0a-4ca4-8f97-c6ec4ccecfab"), "54A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("33fcbe37-6aff-4a34-8b39-3bc14d2827d8"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("28c40b53-7210-40ef-bf01-c70471e0fb61"), "37A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("33fec5a0-9bcc-49e8-88c2-070a7d2ed169"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("d7761a8b-54a6-4f18-941a-442707badedf"), "57B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3482f74f-c049-464d-8b6c-46bebad2ab18"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("d76bfe31-cf1a-4d5c-9595-de402bd451e4"), "55D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("36c7ef44-0aae-476d-9118-5c2373501054"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("1c57c1fb-b25f-4caa-967a-b2e5a92abdea"), "50G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("37af49b1-5fb2-4a3d-b6c1-f0020ad5548b"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("b0aee100-0f81-487a-a116-92c2e0d9f6d2"), "41H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("38ee0f0a-8fbb-4bd5-83b6-860c386474e1"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("e5f23359-2ee8-4716-a89e-c518ec6efda5"), "56E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("3beb3eea-9433-4df8-aa91-e30754df1190"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("6c087ef7-1259-4209-a491-c2b608d8c991"), "58F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3dc4d7ae-9e25-434d-8058-af67c2eb3c2d"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("cf8a1b52-dfaf-4efe-a24d-3fd613344ecb"), "53E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3e13781e-1913-4321-8bc5-84378759e3aa"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)47, new Guid("abc5e480-6d7b-41b5-adc5-c5c931d71a44"), "47B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("406b08f2-63c9-45e9-8d97-6dbc1bec661e"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("063aa7de-fc86-450f-9a80-635c724240fe"), "38D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("40d4835c-ac71-40de-96a6-22f15130554d"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("e0af8cdb-8e05-44fe-a06c-42fbc6faf2f9"), "60I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4159555d-795a-4d8a-b55b-b8bac5a90f39"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)31, new Guid("0a88e142-c9d2-47b9-b6b3-3391e8e95d88"), "31C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("418a04d8-daf9-4962-931d-a4de1df8a1d0"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("494e0ff1-1337-42ab-8d1b-f5b2dc652121"), "38A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("41fcb91b-62ce-4f93-ac68-8a6cb00cad9d"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("c4457bb6-6a96-4e56-8ebe-d5cc8e5c6ceb"), "43F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4232fb31-1ca4-4902-b865-6b6c360572b6"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("42b949dd-33c9-4a60-9a46-a97302c1d979"), "56H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("425f1465-7b98-4341-9bc5-5729d2ad35d5"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("f63acdf8-a0a6-4f14-a1e4-59be8e6e5df3"), "34C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("45b1c9cf-5756-4e73-85e8-bb30a4db8914"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("35a7621b-0550-412c-944a-781391f25948"), "60A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("45e85b0a-d540-4f35-aa09-36dcfab582ec"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("5e996939-6278-45e8-88a6-6209cfae9f5d"), "34I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4671ce29-fa8e-402a-bdc6-92a0d79aea8c"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("f2d97938-e857-47bc-8473-637815800ec5"), "44B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("46e2c10a-944a-4282-835b-e2af5a42c07e"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("d5fe9fe4-f10e-48fd-9440-2cc20034ab77"), "45G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("47832ef5-9f6e-49f0-8f7e-b01fdc4b8638"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)31, new Guid("26043bd8-cd44-400f-90e4-4f091557cf23"), "31F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("48a67e4f-9ff4-4253-90ff-7ca383dbeba2"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)62, new Guid("0a0b9666-5214-4250-973b-386b0e0531ed"), "62F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("49b8a21b-f4de-4a34-a356-1ab43eaf9cac"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)32, new Guid("f84cdc6f-a60c-44b0-82b2-7c0e2e3d672f"), "32A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4aa67f51-a49a-40f6-91ff-e98ed9b5ff72"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)61, new Guid("de620652-3f87-4f08-bd59-30a4f3e0e083"), "61G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4b107bb4-0b38-4f66-87f1-725a564c6768"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)31, new Guid("3d675813-de3c-49ff-8979-64a769efcb37"), "31I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4b8cda97-9a47-4a9c-a156-f3ddf2f57092"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("ab356d44-8aab-4beb-b895-e55ec9d3015c"), "45B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4e3258fa-2ba0-402a-8756-68f0cccbec7e"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("a8c0c21d-a38b-4275-b077-b82f9438dc38"), "39H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("50249ed2-42c2-49d4-b32f-2f78d8ae2997"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("1c57c1fb-b25f-4caa-967a-b2e5a92abdea"), "50I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("509b5922-99ee-47a9-bd7b-f79b9d29975f"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("ea66fe9d-029f-4c17-b3d4-19e86be144c4"), "35G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("51355fdf-ee3e-4f3c-be5f-696f424e0260"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("771fd627-1f56-47c4-a9dc-8a875ea3199d"), "56C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("517823df-9671-4fcb-8433-a86232f6718b"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("1f5a5daa-9cea-46ee-aa37-40d9be4f5b69"), "41C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("53db724f-4ca1-4695-9ee0-9b8acd14beb5"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("4087dc0b-00d8-4c4b-a053-631906e07d8d"), "52C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("554d4ca6-24ba-4343-8037-fa69b0c5deb8"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("1c305dfe-d592-42f0-9ada-3c579434b6d5"), "60E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("55decc4e-ed9c-4d5f-8c67-260f386c139a"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("b015e294-5763-47e3-b940-d3169db97b8e"), "52D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("56caf218-9b10-4306-bb24-d17608abed69"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("3b280c1d-e39e-48d6-b14f-994ea0ce0776"), "40I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("570495ba-f442-4808-a69b-d60c00dacf4f"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("1baafe05-b6ff-4d26-85af-88d96870f47a"), "36D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("58c1b068-e40d-4e69-a279-8e9917ebb28b"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("5e996939-6278-45e8-88a6-6209cfae9f5d"), "34H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("58cdd8e9-884f-47b7-88f4-b1b2821d874a"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("5bc6319e-acae-4043-a850-c7dbf51a19f3"), "54F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5a1507f5-93ce-4821-abb6-2e7d7c3e0be4"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("be6d050f-5aee-498a-8861-feb127f9c30b"), "49D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5a17d01a-fcb0-4539-b92f-aa319e69c5bb"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)31, new Guid("26043bd8-cd44-400f-90e4-4f091557cf23"), "31D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5a41392d-b48a-499d-b9c4-6bc18d21b7df"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("20a3cab2-5b82-4270-a811-a11d8f2f089a"), "37F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5ac44bce-4372-4c88-a062-2b5424f6db7e"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("b015e294-5763-47e3-b940-d3169db97b8e"), "52F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5adb947f-f98d-4ead-9528-0d597f746c69"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("f1a98de2-7794-4868-9a39-cd3bb79ceb21"), "39B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5b8080e8-80e2-4599-b42e-86d769a092a2"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("20952002-5945-4615-aed0-74a5c6319d91"), "45E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5bf7493a-c2e4-45f3-ad9a-c0d48b5cf98d"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("20a3cab2-5b82-4270-a811-a11d8f2f089a"), "37E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5d85a22d-7f97-43dd-8aa5-89fa128c2e9b"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("292bf006-c41c-4b8d-a07c-5fc4890e4e5c"), "55I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5f1bc312-abdf-4a9e-b37f-17a1301fb6ca"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("231712ef-9eeb-49ae-bfba-4fc60a05ef50"), "42D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5f24cfb7-8b34-495a-bf4e-10e396798e8d"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("9fed3f90-8553-41c9-8412-7c10e3544a7d"), "59H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("5fdc1766-81e5-43a3-a203-7d07d1c0c2da"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("d5fe9fe4-f10e-48fd-9440-2cc20034ab77"), "45I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6036a008-e448-4a9b-b91a-9adc6fd03e0f"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)31, new Guid("26043bd8-cd44-400f-90e4-4f091557cf23"), "31E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("60ae4bde-6ffc-43ab-af83-d670b988c519"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("c4457bb6-6a96-4e56-8ebe-d5cc8e5c6ceb"), "43E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("60e814eb-0ad2-4cd0-8316-9d2d2a654e16"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("a2ded28f-509d-45e8-bddd-eca33a13159a"), "48F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("60ec154e-88a5-4d8d-bbde-2c79b8c2fdb9"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("6b1aec18-663e-4856-8799-bf3fa43175e1"), "53A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("61477a73-a424-4ac0-95e7-88718ebbaf27"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("1f5a5daa-9cea-46ee-aa37-40d9be4f5b69"), "41B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6178573b-fb3d-44e0-9955-0a38222aa391"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("bf78f71f-48ce-45e8-aea1-c4fe42c5fada"), "37I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("619c4b3c-4845-4acc-b017-1898a1d9a987"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("4882b330-9701-4c00-8cc8-189cf518e1a3"), "50B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("62f9d6e2-5189-4349-a926-917995a9e443"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("292bf006-c41c-4b8d-a07c-5fc4890e4e5c"), "55G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("641b3c0f-5822-4cbc-b76d-a9f1ca8e2f56"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("b0aee100-0f81-487a-a116-92c2e0d9f6d2"), "41I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("653c75af-4e9b-45c4-bf41-6ef7c12ed8d7"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("ab356d44-8aab-4beb-b895-e55ec9d3015c"), "45C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("65daaff1-a375-4659-a875-5f7ab2e42697"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)33, new Guid("aea5ca75-eedd-4014-93e4-09ce79f3b673"), "33F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("683b48f6-aa20-4663-9bfd-d7174ed93eac"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("494e0ff1-1337-42ab-8d1b-f5b2dc652121"), "38B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6933c76f-1338-4e54-b1d8-89896ecaac4f"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("69d4f326-7424-45fc-8029-cdbcc870b9ba"), "35F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("699a64de-eb3b-418c-b1a7-81674a48b450"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("aa372ee6-8748-474a-b819-c25585b7c5e1"), "42H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6a41648f-2da6-41d6-a60a-d2a4cf642d72"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("063aa7de-fc86-450f-9a80-635c724240fe"), "38E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6b2b6951-6ccd-4930-b15b-fa475658c901"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("8268bb0b-77bd-4b6b-a32f-39b309a89dd9"), "58I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6e450fc9-13a9-4b71-b58d-1bc885b8214a"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("6de60e0b-27df-4e0c-8a57-b6ca9e2dec04"), "52G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6e5ffc79-9f7b-40bc-ad36-b4b6ae967e05"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("80692a94-7d4b-480f-8947-21fa8a977d49"), "57H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6f6833af-1db3-4310-8f7c-0fcc1863c78f"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("968d6a79-246b-4f09-9432-398f8c319110"), "44E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6fea1bd9-b3a2-45b3-a9b4-fea6d31cc98f"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("7d4446c6-c7ad-48f9-95be-e6658c3b1bb2"), "36B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7198e8f8-3f04-41ab-bcc1-65067e77920c"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)47, new Guid("abc5e480-6d7b-41b5-adc5-c5c931d71a44"), "47A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("727828f7-72c1-4c88-883e-ad1244a08577"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("7e4505e8-51df-4a11-b55d-ea7bae3c7fca"), "57D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("73999d10-7ec4-4ed0-a260-5e80cb32127c"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("89264880-ae19-41f1-957e-92109d80d9a7"), "44I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7487cab4-5d39-4a47-bc85-5d9edf682538"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("6de60e0b-27df-4e0c-8a57-b6ca9e2dec04"), "52I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("74e9395b-c031-45ad-9749-ae76fd120915"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("1c305dfe-d592-42f0-9ada-3c579434b6d5"), "60D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("75111469-4339-4b07-be28-85bf5f87eda5"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("8268bb0b-77bd-4b6b-a32f-39b309a89dd9"), "58G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7575d1ab-186d-4767-8abf-ae7823bf2657"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("f0cabc9c-9eb1-4df3-a80a-b8b760ba8258"), "36H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("75954116-3e6b-4b89-97df-06db9b9f2df7"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("a8c0c21d-a38b-4275-b077-b82f9438dc38"), "39I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("764895a8-8235-4bfa-a52b-001cf4266ac9"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("056e3c88-b1ed-46c1-8a24-c1d7e680c414"), "55A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("76d48d65-7b0d-471e-a281-6b9c30463110"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("de84c898-746f-4db8-8565-0391f8711124"), "54I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7715ef60-9573-40db-8240-7a624aeb4f34"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("8cdd14bf-c36f-434a-a0a8-e094760348ab"), "43H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7781e159-3846-409c-8606-208d54891c23"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("ef327cf5-5167-461b-8446-fd587e76d3e6"), "59B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("77fa7649-34ef-45b0-980e-a2ccbb46034b"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("7e4505e8-51df-4a11-b55d-ea7bae3c7fca"), "57E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("78650d54-dec0-4c16-bab8-c8ce2b6d4325"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("f422fd35-20dc-47d3-9f33-5ddba2cebbf8"), "49I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7887edd3-5fd3-47cc-ac6e-921ee2dab4c0"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)32, new Guid("f9ee8d25-065f-40ff-b691-ddfe1c5fda4b"), "32G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("79b905ce-5753-47ce-848c-c26e82475c76"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("5280754f-7f64-464d-b0bf-58cb959c2990"), "40D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7a2d689b-fd97-427c-abcf-97eded8d5cf1"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("113d6dbd-be39-4597-a7f8-1dd0dd041c56"), "59D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7b3e7d3d-98a7-4f6c-84c5-c43a6f73b36a"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("318fdc93-e81a-44fe-8266-4e5a619b9826"), "40A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7be1caa4-bc2f-4ff7-a347-9dde0dcca7c4"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("c7a6b125-ac03-466c-af47-ca6313e15494"), "50F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8047ea19-6263-4340-853b-e50db6635016"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("89264880-ae19-41f1-957e-92109d80d9a7"), "44G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("80e976f7-1d61-4a30-8d8c-94ca99118250"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("f205aaf2-d057-48f4-9ca5-eb1842647ea7"), "42C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("81f3c86a-688c-4c2a-ba79-dc9963295f4a"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("f422fd35-20dc-47d3-9f33-5ddba2cebbf8"), "49H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("821c6b13-bef3-4f8a-bd9b-a9a9ad692247"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)46, new Guid("7aec60c9-dea5-4bbb-b176-d9c8532f345c"), "46C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("82426b76-c4f2-4afe-b485-2c5bf6285f2a"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)33, new Guid("ce7e012c-be36-4d30-a3d2-d8ac99813c49"), "33I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("83120cba-ec02-4214-8bc6-d5079c8fdd9d"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)61, new Guid("de620652-3f87-4f08-bd59-30a4f3e0e083"), "61I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("84023e47-8558-483c-8642-a803826e9666"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("f1a98de2-7794-4868-9a39-cd3bb79ceb21"), "39C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8492cee7-0781-4d2b-9138-23e1b44e703f"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("968d6a79-246b-4f09-9432-398f8c319110"), "44F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("85b5fcfe-57ae-4d14-820b-158fc1052dd7"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("6b1aec18-663e-4856-8799-bf3fa43175e1"), "53C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("85c6f6a9-bde5-492a-842c-0b79bbc86ca6"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("d5ed9749-d7e6-40ea-8dd3-a5c80779c8e8"), "58B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("876654d2-9ac2-439f-a9cd-7f0a9adc4b4c"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("80692a94-7d4b-480f-8947-21fa8a977d49"), "57I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8821d7f9-2889-4f59-9638-5e062cbbfaa7"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("f2d97938-e857-47bc-8473-637815800ec5"), "44A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("889037e9-79d1-46b0-a469-f7b3122ae4ae"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("5280754f-7f64-464d-b0bf-58cb959c2990"), "40F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8a2d5ebc-56bf-4ecf-8569-f781997e5932"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("d76bfe31-cf1a-4d5c-9595-de402bd451e4"), "55F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8a857b32-e8e3-43e9-9e0f-6c7da5118cac"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("18f679ec-8b2f-4353-9b8a-4dc3ab25c459"), "51G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8aa134bf-acd0-4340-8619-88f0f58df241"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)61, new Guid("a750fb92-563c-4f8e-b170-3941e16b56f2"), "61C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8b8d3274-173a-4650-8015-792915373baf"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("35a7621b-0550-412c-944a-781391f25948"), "60B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8c0643a0-f95e-443a-b722-2f9ed30d51a0"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)63, new Guid("344a96bc-a7e2-46ae-acba-16dee8fb4336"), "63F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8c93237c-83bc-4b85-acce-1c5c6c562dde"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("771fd627-1f56-47c4-a9dc-8a875ea3199d"), "56B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8e0dbf9a-3ad9-4c0a-99ac-a22d6c0dc0dc"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("ee7afd1a-4ab1-480c-8483-27bb4f6d86b6"), "48B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8e264a50-1046-44ae-8b4c-88f383e66b07"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)33, new Guid("aea5ca75-eedd-4014-93e4-09ce79f3b673"), "33D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8f9dedc8-e948-4a90-aff7-19964ded59eb"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("9d2d9678-1a81-44dc-aece-a977dc2921e5"), "48H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("91397e4a-50ec-47df-988c-17e7df1cad63"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("4882b330-9701-4c00-8cc8-189cf518e1a3"), "50C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("936c2d91-5bfd-4454-98bc-8d90c3eb057c"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("0ac67ba8-2c8a-42db-9883-bc4603ef2dcf"), "38G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("977607e1-fd39-49e3-b3d5-76e9934d2d91"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("ea66fe9d-029f-4c17-b3d4-19e86be144c4"), "35I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9877bfec-b85e-4190-8c56-bb18a556f9a4"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("f0cabc9c-9eb1-4df3-a80a-b8b760ba8258"), "36I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("999c25a9-7df4-4221-a78b-ad7437491883"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("c4457bb6-6a96-4e56-8ebe-d5cc8e5c6ceb"), "43D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9d1e2cd9-4efd-4a46-87d1-4c3d6bae1afe"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("88d82e0b-7531-4ace-833a-7cf0c3ab1abb"), "34F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9e7f5a16-ece3-43e8-847f-28b8df69eac8"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("4087dc0b-00d8-4c4b-a053-631906e07d8d"), "52A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9f0bd11d-c7ef-473d-8e2a-671bc0c2d37e"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)46, new Guid("80f6d2f4-d30b-48f5-bbb8-19471b967952"), "46E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9fea2c8c-20fa-40a3-851b-cc5f4c622451"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)32, new Guid("f84cdc6f-a60c-44b0-82b2-7c0e2e3d672f"), "32C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9ff030f6-20e8-4f1c-b908-72754966cb83"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("be6d050f-5aee-498a-8861-feb127f9c30b"), "49E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a1b3d3e1-f5a4-4936-8bbd-23b5f32280ce"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("89264880-ae19-41f1-957e-92109d80d9a7"), "44H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a2b4aff4-90b4-4843-b4b8-7ecb9d2a1d9c"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("5c8573be-d7d6-446c-b3a4-bfc623581dc5"), "53H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a323cf95-a747-4832-9750-54e5c88cd70b"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("ee7afd1a-4ab1-480c-8483-27bb4f6d86b6"), "48C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a47a5159-baf8-4aa5-9a84-63efc4853136"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("9d2d9678-1a81-44dc-aece-a977dc2921e5"), "48I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a49c02f1-b7dc-4e79-bc05-2c6698efa924"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)63, new Guid("344a96bc-a7e2-46ae-acba-16dee8fb4336"), "63E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a63d468c-1e16-4375-94df-f10909ccf99c"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("a2ded28f-509d-45e8-bddd-eca33a13159a"), "48D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a845a4b2-4c74-4f18-b5ed-8660f34d09af"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("0ac67ba8-2c8a-42db-9883-bc4603ef2dcf"), "38I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a8865cd3-c612-4cef-a1d5-8a050693a65c"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("8e7b967f-4637-453f-9760-2ed1e70e5593"), "39E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a9cf1fdb-b811-4db6-87c0-95bdcdc75c4f"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)44, new Guid("f2d97938-e857-47bc-8473-637815800ec5"), "44C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("aa3ce092-3163-46fa-99a6-1acf034ea265"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)31, new Guid("3d675813-de3c-49ff-8979-64a769efcb37"), "31G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ab9ae5d8-08f9-4f21-9dbf-eb763c74408e"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("88d82e0b-7531-4ace-833a-7cf0c3ab1abb"), "34D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("abd1964c-4aca-423c-91a3-f421e0f4edd5"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("28c40b53-7210-40ef-bf01-c70471e0fb61"), "37C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("abdd3f21-c8d2-4420-a923-3504483d4d53"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("ee7afd1a-4ab1-480c-8483-27bb4f6d86b6"), "48A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("af19ba6c-5baf-49b6-bf71-da83352dbb30"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("1c305dfe-d592-42f0-9ada-3c579434b6d5"), "60F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b0db9034-df1b-4b82-92e9-73776acfb016"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)33, new Guid("aea5ca75-eedd-4014-93e4-09ce79f3b673"), "33E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b15e5dd5-f505-4e7a-bb9d-f195e7233706"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("aa372ee6-8748-474a-b819-c25585b7c5e1"), "42G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b2a55c59-bf11-464f-ab98-359e7448734b"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("ef327cf5-5167-461b-8446-fd587e76d3e6"), "59A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b367e84e-2dc5-4ac8-9055-35a01c445647"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("2711b67f-c994-4408-b4e4-72845d757216"), "51D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b3c9a9ad-d4e5-4c85-b1d8-0b10d0ed096b"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("482d3f43-a722-4da0-9105-9ce11203e841"), "35A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b44e2de8-24d9-4f3f-894b-8a132afb30a2"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("de84c898-746f-4db8-8565-0391f8711124"), "54H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b6aa73c4-5bbe-44aa-acbb-c2489ac921e5"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("056e3c88-b1ed-46c1-8a24-c1d7e680c414"), "55C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b7f61da8-6686-4236-9fc4-3d61f20064bb"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("f63acdf8-a0a6-4f14-a1e4-59be8e6e5df3"), "34A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bb7de537-c65b-4ace-82ec-31e7f39bdc4a"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("80692a94-7d4b-480f-8947-21fa8a977d49"), "57G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("bc19200a-e148-49a1-96a2-688c14549b74"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("94d54718-2841-4047-92d1-85ac9961b1ea"), "51C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("bcf5f4f7-4f82-4b44-ae82-215c2c2f8433"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("b015e294-5763-47e3-b940-d3169db97b8e"), "52E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("bd62026d-c026-4f7b-ab95-dd7489ca4dbe"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("78e8e517-6a0a-4ca4-8f97-c6ec4ccecfab"), "54C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("bd626c2e-ef4a-463c-b85f-9785ebaa0465"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("e5f23359-2ee8-4716-a89e-c518ec6efda5"), "56F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("bed2b92a-501a-4ac5-9443-47d678cee5ed"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("f422fd35-20dc-47d3-9f33-5ddba2cebbf8"), "49G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c00b5a38-787d-458c-aff4-9ccc510ea888"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("d7761a8b-54a6-4f18-941a-442707badedf"), "57C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c1bbb2c5-f38c-490b-a23a-805cefbbd5cb"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)49, new Guid("bf080781-1402-4954-87cd-49d0b08a7a14"), "49A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c1f82df5-1671-4fbb-ae54-36c3bdc83cf7"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("e0af8cdb-8e05-44fe-a06c-42fbc6faf2f9"), "60G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c28b53e7-f0cd-4f5b-9f26-627a5d1342da"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("8cdd14bf-c36f-434a-a0a8-e094760348ab"), "43G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c2c39aa2-f104-474c-86a0-ed792ea173bc"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("0a167a42-fb25-4679-adaf-c698c22b2c5e"), "43A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c40e17be-b2d3-4ee9-8230-e074eeacf2c7"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("8cdd14bf-c36f-434a-a0a8-e094760348ab"), "43I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c438c4db-b016-4931-aeb0-23cf93f8c9e8"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)43, new Guid("0a167a42-fb25-4679-adaf-c698c22b2c5e"), "43B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c522eefc-571a-425a-a8a4-6b1ec2bc81ec"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("8e7b967f-4637-453f-9760-2ed1e70e5593"), "39F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c636857c-45ca-4980-a728-041e80598b5c"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)33, new Guid("ce7e012c-be36-4d30-a3d2-d8ac99813c49"), "33G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ca7b637c-ce81-435e-88f2-09f57c90b3e1"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("6c087ef7-1259-4209-a491-c2b608d8c991"), "58E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d0b761d6-15f7-405f-b429-4b232632a60a"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("7e4505e8-51df-4a11-b55d-ea7bae3c7fca"), "57F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d1c53a7b-b506-42ae-bee3-db374f580a5e"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)46, new Guid("7aec60c9-dea5-4bbb-b176-d9c8532f345c"), "46B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d2c4f8a3-bc06-4870-adcb-5bf771059e59"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)39, new Guid("a8c0c21d-a38b-4275-b077-b82f9438dc38"), "39G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d3a17198-e3ac-4d2c-b720-6c334236d7a8"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("f205aaf2-d057-48f4-9ca5-eb1842647ea7"), "42B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d3b13389-fbdc-4259-b431-6ef6f683664b"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("aa372ee6-8748-474a-b819-c25585b7c5e1"), "42I", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d3d0fced-32b3-4756-8a38-4ae8cd0624f0"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("5e996939-6278-45e8-88a6-6209cfae9f5d"), "34G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d3f6d266-645b-453e-8633-cd2bfe16340c"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)47, new Guid("abc5e480-6d7b-41b5-adc5-c5c931d71a44"), "47C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d6debd83-7d9a-48ae-a3af-4eeca132e212"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("c7a6b125-ac03-466c-af47-ca6313e15494"), "50E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d6fe1e52-9ce1-4969-9b3a-ffab097967b7"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)46, new Guid("80f6d2f4-d30b-48f5-bbb8-19471b967952"), "46F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d7a9cb31-ffd1-46d9-ae27-f896787631c3"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)46, new Guid("7aec60c9-dea5-4bbb-b176-d9c8532f345c"), "46A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d8e13749-3531-427e-87c1-84f48b04fd35"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)46, new Guid("80f6d2f4-d30b-48f5-bbb8-19471b967952"), "46D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d8f3aa54-7b14-4a32-b805-087f9d00813c"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)32, new Guid("55abdb92-c684-4e83-ad70-1033b6f53d33"), "32E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("da924dd0-84a5-45f0-9030-489a93041a92"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("69d4f326-7424-45fc-8029-cdbcc870b9ba"), "35E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("db65b64d-19d9-4121-a8bc-6d0b893bbad0"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("20952002-5945-4615-aed0-74a5c6319d91"), "45F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("dbca03fe-992e-43ee-b17a-568dc1680d3f"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)38, new Guid("0ac67ba8-2c8a-42db-9883-bc4603ef2dcf"), "38H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("dbd36eea-a132-42db-b1ca-4329d8a6a96a"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("cf8a1b52-dfaf-4efe-a24d-3fd613344ecb"), "53F", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOnSeatOccupied", "IsUnderSeatOccupied", "LastModified", "LastModifiedBy", "RowNumber", "SeatConfigurationId", "SeatNumber", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("dc9b6f9b-eb8d-4c43-a059-cb3aa75e8a20"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)51, new Guid("18f679ec-8b2f-4353-9b8a-4dc3ab25c459"), "51H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("dd7f06d5-5da7-4ed9-beec-6a27ea2e24de"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("9fed3f90-8553-41c9-8412-7c10e3544a7d"), "59G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("de564ac9-47f4-4cab-ac05-7d61d336220f"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)41, new Guid("28f78eaf-3925-46d7-b1cf-7a952f14b925"), "41F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("df86d162-cbd9-4d41-9ec2-3eb88627818e"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("42b949dd-33c9-4a60-9a46-a97302c1d979"), "56G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e02623ef-2319-497c-bc4e-f26a7703ce21"), (short)6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("231712ef-9eeb-49ae-bfba-4fc60a05ef50"), "42F", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e02beceb-e15c-4b07-b716-b2c908254f1b"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("9fed3f90-8553-41c9-8412-7c10e3544a7d"), "59I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e08af717-f94a-47fc-b079-71dfad3595f7"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("bf78f71f-48ce-45e8-aea1-c4fe42c5fada"), "37G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e2fb2499-d7a1-4b62-b651-dea9e43bc362"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)48, new Guid("a2ded28f-509d-45e8-bddd-eca33a13159a"), "48E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e4a49fb2-0020-4a58-9b19-d50d76d081d2"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)34, new Guid("88d82e0b-7531-4ace-833a-7cf0c3ab1abb"), "34E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e59ec0fb-f4c0-4fa6-9f91-bcdbaf67e5f0"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("4087dc0b-00d8-4c4b-a053-631906e07d8d"), "52B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e5eb3563-da9b-462f-86e5-8b19eaa48f24"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("318fdc93-e81a-44fe-8266-4e5a619b9826"), "40B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e5ebed87-80d0-4937-8681-664f28a25c79"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)57, new Guid("d7761a8b-54a6-4f18-941a-442707badedf"), "57A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e72fe1d9-7591-4d69-89c7-f1afc644076e"), (short)9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("5c8573be-d7d6-446c-b3a4-bfc623581dc5"), "53I", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e8d5c108-3d26-4d04-969c-438b4a61b51d"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("231712ef-9eeb-49ae-bfba-4fc60a05ef50"), "42E", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e9cb100a-9bc7-4ed1-8923-62a81432a2c4"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("69d4f326-7424-45fc-8029-cdbcc870b9ba"), "35D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e9cbf05e-25c6-421d-be5c-b575d8d7d8de"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("f0cabc9c-9eb1-4df3-a80a-b8b760ba8258"), "36G", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("eb5badd7-dfeb-4e79-aceb-b482900b5722"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("5bc6319e-acae-4043-a850-c7dbf51a19f3"), "54E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("eba58977-c640-4b7c-9d47-96cc3c90eeae"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)50, new Guid("1c57c1fb-b25f-4caa-967a-b2e5a92abdea"), "50H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ecf1d885-2918-41d9-a3e9-a6ef61e29153"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)56, new Guid("771fd627-1f56-47c4-a9dc-8a875ea3199d"), "56A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ed9cbd1f-5d44-48aa-9d7c-d7cb0ffe7f64"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("ea66fe9d-029f-4c17-b3d4-19e86be144c4"), "35H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ee123a1a-2b35-40f9-8f3d-07b610e2fdb3"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("6b1aec18-663e-4856-8799-bf3fa43175e1"), "53B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ee69e72b-a234-4ce3-aacc-21d0512e8717"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)35, new Guid("482d3f43-a722-4da0-9105-9ce11203e841"), "35B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("eeeef80c-8f73-45fc-84a2-b2d135738c7d"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("28c40b53-7210-40ef-bf01-c70471e0fb61"), "37B", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f0df22cf-02ae-4d7e-aa86-8223b74b5428"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)37, new Guid("20a3cab2-5b82-4270-a811-a11d8f2f089a"), "37D", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f38f354e-2daf-4938-a7fc-070c1c7dc3d6"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)40, new Guid("318fdc93-e81a-44fe-8266-4e5a619b9826"), "40C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f3b5217f-e4b0-4316-b610-cb3fd8c14c69"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)53, new Guid("5c8573be-d7d6-446c-b3a4-bfc623581dc5"), "53G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f51190f0-2141-4c8b-b38d-ab4c76430875"), (short)7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("de84c898-746f-4db8-8565-0391f8711124"), "54G", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f66b7ba6-cd89-4084-bf29-78a60363f84d"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)52, new Guid("6de60e0b-27df-4e0c-8a57-b6ca9e2dec04"), "52H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f6f47776-ff1d-4f97-8c6e-e4ba1c07dbf8"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)42, new Guid("f205aaf2-d057-48f4-9ca5-eb1842647ea7"), "42A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f81e8157-967a-4e95-9cf3-290a27ae73ff"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("7d4446c6-c7ad-48f9-95be-e6658c3b1bb2"), "36A", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f8717e94-bbf0-4416-bca1-d18b5a3705a5"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)61, new Guid("a750fb92-563c-4f8e-b170-3941e16b56f2"), "61A", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f8b57c48-fbb0-4354-b2c7-e97dc2134332"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)60, new Guid("e0af8cdb-8e05-44fe-a06c-42fbc6faf2f9"), "60H", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f937c620-6448-41ef-9b4f-73df19c1d9f3"), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)59, new Guid("113d6dbd-be39-4597-a7f8-1dd0dd041c56"), "59E", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fa9d3da5-9820-45f1-8419-10a57f73ea0a"), (short)8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)45, new Guid("d5fe9fe4-f10e-48fd-9440-2cc20034ab77"), "45H", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("fc2600d5-30ec-4246-8596-3d421305f63b"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)58, new Guid("d5ed9749-d7e6-40ea-8dd3-a5c80779c8e8"), "58C", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fda29d45-ae4c-4f09-b46f-efcb985e07fd"), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)54, new Guid("5bc6319e-acae-4043-a850-c7dbf51a19f3"), "54D", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fe4e7f9a-ab0c-43d6-9ab2-a41670d1937b"), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)55, new Guid("056e3c88-b1ed-46c1-8a24-c1d7e680c414"), "55B", new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ff9df34c-0d10-408e-af4f-1a7da4f418d4"), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)36, new Guid("7d4446c6-c7ad-48f9-95be-e6658c3b1bb2"), "36C", new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("00319784-234d-4020-977b-69adc9274b42"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c438c4db-b016-4931-aeb0-23cf93f8c9e8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("00b3c3b6-fcbe-477f-ac1d-222d1c9e4042"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a2b4aff4-90b4-4843-b4b8-7ecb9d2a1d9c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("01155f33-50c7-4b3a-9da2-3cf9a29ddc89"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8492cee7-0781-4d2b-9138-23e1b44e703f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0163ac9f-a352-48a2-9417-4dd44b959018"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("21f62bed-abcb-43df-b865-98ad6c7191d6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("022782ca-ec50-4a59-a36e-26b8f6343f7c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2c3e9456-e03a-4158-b7aa-32c743fc7a3d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("02fb4c0c-a321-4676-9dfe-c1b9f2f0dec2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d3b13389-fbdc-4259-b431-6ef6f683664b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("031d479f-62ee-4894-878e-6c6480744550"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("bcf5f4f7-4f82-4b44-ae82-215c2c2f8433"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("03af8162-25dd-413a-968c-821600dd9191"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9877bfec-b85e-4190-8c56-bb18a556f9a4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("04726cae-9058-4b51-830d-374baa3872ae"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a9cf1fdb-b811-4db6-87c0-95bdcdc75c4f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("04b78845-a650-4ed5-818b-477b78b7541b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("40d4835c-ac71-40de-96a6-22f15130554d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("05283ba6-68ae-4802-acee-ca4fdc084250"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("570495ba-f442-4808-a69b-d60c00dacf4f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("05ccca39-256b-476b-8529-34412eea8b67"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c28b53e7-f0cd-4f5b-9f26-627a5d1342da"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("05d54959-a1da-4c7d-8fce-9a3fe7aeb22e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("15290099-ae03-4fb5-9f9b-8112dd35f691"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("05f88fbc-1f06-48d6-8b0f-9b9a0643e55b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("eeeef80c-8f73-45fc-84a2-b2d135738c7d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("06afd40b-c7b6-4732-984f-f196d3eef224"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3beb3eea-9433-4df8-aa91-e30754df1190"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0748b3d5-6b0e-4f3c-98b1-7a3124166250"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7be1caa4-bc2f-4ff7-a347-9dde0dcca7c4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0772e051-9ff4-4235-9a30-572525e034c9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("48a67e4f-9ff4-4253-90ff-7ca383dbeba2"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("07c15fd0-f8d9-48ff-a56b-41434b78f4f5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e9cb100a-9bc7-4ed1-8923-62a81432a2c4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("084686d1-25b7-4008-8503-f6a63a66f8db"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("509b5922-99ee-47a9-bd7b-f79b9d29975f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("085472f4-904d-484c-ae05-21d1d3bc986e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("74e9395b-c031-45ad-9749-ae76fd120915"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("08f15385-a8da-4f19-9a8f-b1c35df2ee61"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("af19ba6c-5baf-49b6-bf71-da83352dbb30"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("09aa9b27-eb31-4116-bb2c-4f2ebaf8d3fd"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("38ee0f0a-8fbb-4bd5-83b6-860c386474e1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("09f724b9-7b75-4b41-85f9-2da971aa453a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c438c4db-b016-4931-aeb0-23cf93f8c9e8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0a0c0a68-a560-4541-bc81-0a992d180cb7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("14b899b0-35a2-4388-96cb-423d071dffd4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0a524365-30b9-47e2-af2d-5c25d747862e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("12893112-0583-42bd-bd58-f9adc577aee6"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0a5fd51b-2b21-4658-ad62-c4e75de8c27c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3482f74f-c049-464d-8b6c-46bebad2ab18"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0ae1faef-7ffd-440c-ba83-f3787752e1d9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("054f7037-bf9a-485e-aba4-2fb6b3752fcc"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0b0e40d2-7ee0-4113-80f3-284a4cee4041"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f38f354e-2daf-4938-a7fc-070c1c7dc3d6"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0b181c2c-b7a1-4803-8c9c-e495ed965394"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("41fcb91b-62ce-4f93-ac68-8a6cb00cad9d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0c6193f2-f8d6-4271-9b81-4fa17ca2e323"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0a01cd79-5179-4eda-b16d-859a7ca005a8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0c687b95-1924-494a-8329-16f551318af6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d8f3aa54-7b14-4a32-b805-087f9d00813c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0c9781ef-f98d-4d6a-a117-9ebda27215e0"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("425f1465-7b98-4341-9bc5-5729d2ad35d5"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0daa2b4c-2d4c-43ab-add6-5ca91ec7c964"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ed9cbd1f-5d44-48aa-9d7c-d7cb0ffe7f64"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0e603572-8468-4f32-937d-5b48b873883e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8aa134bf-acd0-4340-8619-88f0f58df241"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0ed5e9f0-168d-4db3-bb37-64dda6d68e1d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("76d48d65-7b0d-471e-a281-6b9c30463110"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("0eefac88-3cbd-48f1-be75-73e802f40669"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f66b7ba6-cd89-4084-bf29-78a60363f84d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("102026e5-6bb1-4013-a6a2-95e80aac992d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2147837b-7036-4b5c-b817-9b85539c56d9"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("107774d7-6a1d-4ee8-8f65-df57f016030d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d3f6d266-645b-453e-8633-cd2bfe16340c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("10b23f69-1f84-4366-9a7b-4ad0525c4707"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("27d92835-4254-4ec5-9010-1d6a33ac7b01"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("10c040bb-e415-448b-bc74-8734a81dbfc4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("60ec154e-88a5-4d8d-bbde-2c79b8c2fdb9"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("11487813-edce-473e-8958-022476f3f9bf"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3e13781e-1913-4321-8bc5-84378759e3aa"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1197f533-8a10-4a3b-bdf9-bd203071ec53"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("65daaff1-a375-4659-a875-5f7ab2e42697"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("11ba30b4-d247-4189-b657-a03492afcd1b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f66b7ba6-cd89-4084-bf29-78a60363f84d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1261032d-d4d4-45e8-b6f8-efdeccd4d555"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b3c9a9ad-d4e5-4c85-b1d8-0b10d0ed096b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("12632b8f-b195-49a8-af30-9ef60cb42785"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("16018cfd-4c01-449e-9e07-2966410d9211"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1279b19a-6239-4489-b804-9cf0f7b2a0ea"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a845a4b2-4c74-4f18-b5ed-8660f34d09af"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("132c21ab-f2d2-4dee-9b01-3441ae01c2de"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8047ea19-6263-4340-853b-e50db6635016"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("145f96a0-2c35-4c56-995b-a2cfc1ce3f2d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f6f47776-ff1d-4f97-8c6e-e4ba1c07dbf8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("15113540-2f54-48a7-8f2f-b17e5c897bee"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8c0643a0-f95e-443a-b722-2f9ed30d51a0"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1513c90f-ca08-4fb4-af58-11063fd1fc0b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8e264a50-1046-44ae-8b4c-88f383e66b07"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("158b1402-985e-49d6-9c82-cdc1e728c4f5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("eba58977-c640-4b7c-9d47-96cc3c90eeae"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("15c9023e-a3c5-4838-b14a-129cbb7d45ef"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0e816d9e-719e-43f2-a065-a51747e2c637"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("16108ee7-b0b1-4d19-8367-75a8f4d85b13"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("09fd853c-e3be-4415-a2f7-ef562542e684"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("168aa32c-0543-46b7-b4ea-aaa4f67e385e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("08edf71d-f70f-4fde-a69c-8d7f74e8e5a7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("16934160-e707-446b-9713-aa3d1a23f2a1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("406b08f2-63c9-45e9-8d97-6dbc1bec661e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("16a08e0c-7dcf-495e-bae7-00bbe51b1c8a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9d1e2cd9-4efd-4a46-87d1-4c3d6bae1afe"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("16ce2a46-88df-41d0-8092-6b6b07628a02"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4b8cda97-9a47-4a9c-a156-f3ddf2f57092"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("17304db2-dd01-4252-8514-722f3d823778"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0c2160c1-c3ab-499d-b149-2def35c25670"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1758056f-19bf-4b34-b3df-4a8e64ed9aa6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2c83c506-915a-4ba2-932d-44e74af62e10"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("187dbb94-de71-45c9-9e6d-53883868f760"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0b8cd886-9d69-429e-b2cf-aee59884538c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("18c2b5ad-bfe5-4fb9-bb96-0c9aa6cb22fe"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d8e13749-3531-427e-87c1-84f48b04fd35"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("18c79d15-7b6b-4fbd-8bdb-f0b232873ec8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8f9dedc8-e948-4a90-aff7-19964ded59eb"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("18d424fa-72cf-4b24-acca-39ada6497ca8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1b8dc613-c4fd-4ce5-bf8c-071e31475d67"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("19a27dd8-31c3-428b-b231-e2cf31d1b2e1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e59ec0fb-f4c0-4fa6-9f91-bcdbaf67e5f0"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("19ceb901-b967-43ce-bb73-1ab257ed2f32"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("dc9b6f9b-eb8d-4c43-a059-cb3aa75e8a20"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1a6bbdb5-1a96-42fa-8854-c01ba3531f6c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("764895a8-8235-4bfa-a52b-001cf4266ac9"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1ab0b928-1315-4be1-a678-a8aca1638fb4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("162311a3-9f95-45dd-80ff-c1977f9c3556"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1b3fd643-d4e0-4b1d-898f-4e788a3e6bf8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0a01cd79-5179-4eda-b16d-859a7ca005a8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1b782ae5-caaa-48fe-8184-ea9e16c9fda0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("124e9e6b-b8bc-4e1a-954d-13d4b1ad86a4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1b8dc72d-dde5-4dce-9664-eaf0455f500e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("85b5fcfe-57ae-4d14-820b-158fc1052dd7"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1bed73fb-2577-4676-b5a6-2d49384d88eb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e4a49fb2-0020-4a58-9b19-d50d76d081d2"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1c14a794-695f-4bd8-bc2f-73fc0196b077"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e02623ef-2319-497c-bc4e-f26a7703ce21"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1ca28d53-67f1-4d6a-8dde-e7297a0f71a5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9fea2c8c-20fa-40a3-851b-cc5f4c622451"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1cf70cfe-02a7-4a58-9bab-f050d7fa8aba"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("60e814eb-0ad2-4cd0-8316-9d2d2a654e16"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1d171b52-ff02-46d1-a33e-7ad0e50094af"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("41fcb91b-62ce-4f93-ac68-8a6cb00cad9d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1dce207c-b04a-4685-8c20-32ce53d27a3f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("641b3c0f-5822-4cbc-b76d-a9f1ca8e2f56"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1dee2599-29bb-4354-a2ce-a24ade892687"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2d2900e1-2055-4bc6-a22e-f8ced06c8b11"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1e328574-3d73-4ae0-958d-8458aed83878"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("73999d10-7ec4-4ed0-a260-5e80cb32127c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1e7f5661-cf96-425d-9eeb-cc5bf4ff0d00"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5fdc1766-81e5-43a3-a203-7d07d1c0c2da"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1f523f1e-437e-4717-a6f3-d55fb937f2a3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5d85a22d-7f97-43dd-8aa5-89fa128c2e9b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1f8e8627-5a6c-4bf4-94fb-70932c7f9ac9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("80e976f7-1d61-4a30-8d8c-94ca99118250"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1fe292aa-9de5-46fb-be06-f6bae03ea670"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5a41392d-b48a-499d-b9c4-6bc18d21b7df"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2101c2ac-6a24-42ec-8882-b54570e8c7e2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("054f7037-bf9a-485e-aba4-2fb6b3752fcc"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("213f7961-64f8-4b72-b28d-8feb8eea3100"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5fdc1766-81e5-43a3-a203-7d07d1c0c2da"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("2216247b-01fb-48ca-b366-0846f41c1714"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6f6833af-1db3-4310-8f7c-0fcc1863c78f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("225bd847-ce1f-4a88-89d7-add5532cf81d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1cf286eb-4651-4799-b900-3d2c86a3ab9c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("228830ee-ede5-4553-880e-c5b1ad7db204"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7715ef60-9573-40db-8240-7a624aeb4f34"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("22d0bb87-efd7-49ed-963a-d59f519d8441"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f937c620-6448-41ef-9b4f-73df19c1d9f3"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2343b53a-f314-423f-91b9-ca7ba489d62f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("de564ac9-47f4-4cab-ac05-7d61d336220f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("23808c29-ac1c-4901-b01e-c5b10c2696b2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7198e8f8-3f04-41ab-bcc1-65067e77920c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("23fdad5e-cb50-42c8-ade2-38c1208f97f8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8821d7f9-2889-4f59-9638-5e062cbbfaa7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("24b4d5e6-cf9a-4fb9-9941-5e050f83d8df"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("09c3b3bb-7738-490d-9a83-1bd7ed0bb7de"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("25c86af6-bd34-448e-8031-e64ba1edde96"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ecf1d885-2918-41d9-a3e9-a6ef61e29153"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("27f64b3f-543d-4f4b-9d9b-2515482aa441"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("80e976f7-1d61-4a30-8d8c-94ca99118250"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("28a3abb0-0086-4756-9dcf-1561b51f54b2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d1c53a7b-b506-42ae-bee3-db374f580a5e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("28c17f68-12bb-4825-8297-b7ee6738b553"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("053d37eb-3ac0-4d2a-8512-a4fa4f5c960e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2989cd56-6dc1-4195-8bde-7dced854a690"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c1bbb2c5-f38c-490b-a23a-805cefbbd5cb"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("29b0d94e-994c-4690-8b6a-faed82457be8"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9f0bd11d-c7ef-473d-8e2a-671bc0c2d37e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2aaf73a7-46d0-420d-8bd2-981c627ac80c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("bc19200a-e148-49a1-96a2-688c14549b74"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2ae94709-b9e8-48c5-8bc6-7a4b0d143a64"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("81f3c86a-688c-4c2a-ba79-dc9963295f4a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2d0cae80-9cbc-4ec7-b27d-6f738a196909"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("517823df-9671-4fcb-8433-a86232f6718b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2d330108-01ed-4703-a990-0c2d28916287"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("77fa7649-34ef-45b0-980e-a2ccbb46034b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2d73d064-29d3-47eb-91e4-d3bb58f3451f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e72fe1d9-7591-4d69-89c7-f1afc644076e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2dde101b-e5b6-4e1f-a775-71f7fd5fdd7d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("727828f7-72c1-4c88-883e-ad1244a08577"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2e616bcd-40a7-421a-b3e7-f3a083e1cabb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d2c4f8a3-bc06-4870-adcb-5bf771059e59"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2f5821d0-453f-4fdb-8140-213287f7f358"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("55decc4e-ed9c-4d5f-8c67-260f386c139a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2fd94100-6a1a-458b-8384-69cc3b482bd4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("33fec5a0-9bcc-49e8-88c2-070a7d2ed169"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("304c3eba-9107-4cd0-8ba7-27512d1a3836"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("dbca03fe-992e-43ee-b17a-568dc1680d3f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("30b1b5ed-109a-4d77-a33d-2c07e354fbff"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("727828f7-72c1-4c88-883e-ad1244a08577"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("31b5ee64-18e0-4930-b725-cf662b580ac4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c2c39aa2-f104-474c-86a0-ed792ea173bc"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("31d18bd1-e011-4539-bc3d-dde6ba32c731"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("dbd36eea-a132-42db-b1ca-4329d8a6a96a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3208adb4-5ec1-4345-b0f0-64d5d6941100"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a8865cd3-c612-4cef-a1d5-8a050693a65c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("32a3fa42-481d-432f-abd8-487eef0153d8"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a323cf95-a747-4832-9750-54e5c88cd70b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("32c8cc5e-4b84-4108-9876-4b2553268748"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("406b08f2-63c9-45e9-8d97-6dbc1bec661e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("32eb6b8c-d06d-4e05-a643-6da64dea3361"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1864aefd-322e-4911-a03a-a4008c1c604b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3423bb1e-263b-4c48-912b-3ec71b1278d6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e72fe1d9-7591-4d69-89c7-f1afc644076e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("34694942-6baf-4c85-91cb-b4da47574847"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2d40dfee-5890-47c9-bade-2d6ae6617176"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3609818b-fd95-47cc-a400-52d68cd3ff17"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("05761598-bfcf-43c1-be76-4cfedc3f2469"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("363ecfa0-3567-4c87-83a6-6b03a4bf6f47"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1b8dc613-c4fd-4ce5-bf8c-071e31475d67"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("365fcc2c-da11-4a5b-9300-1aa902ddfdbe"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("158be4e7-02ac-438d-9a2a-315c81f9fdbd"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("36696a7e-fd56-409c-8567-26af61f1e67f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7a2d689b-fd97-427c-abcf-97eded8d5cf1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("36af575d-403d-4419-b30f-023ccfc72a0f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("85c6f6a9-bde5-492a-842c-0b79bbc86ca6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("36ff6fb6-56f9-4c88-83c9-60d6fa5e8e50"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("889037e9-79d1-46b0-a469-f7b3122ae4ae"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("37407483-8a6c-484a-9c5e-8488fbdec830"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("79b905ce-5753-47ce-848c-c26e82475c76"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("375e55e3-bc11-4cd5-b100-e5db86ca8703"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("56caf218-9b10-4306-bb24-d17608abed69"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("37d898f2-746e-476d-9adc-6170c648f4b2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("162311a3-9f95-45dd-80ff-c1977f9c3556"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("380bd5f0-aeff-45cf-b9f9-aaf39fca156f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("60ae4bde-6ffc-43ab-af83-d670b988c519"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3816d767-f5b4-4b6c-a28a-f5d6171cb396"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c1f82df5-1671-4fbb-ae54-36c3bdc83cf7"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("391c23f8-5df9-455c-b045-c7fc8c68353b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("152db039-c629-4a50-9004-80d80999811c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("39993d27-08f2-4275-8714-ade94880f8ab"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b6aa73c4-5bbe-44aa-acbb-c2489ac921e5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3a045def-1a17-4a49-bfa5-9fd425787258"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d3b13389-fbdc-4259-b431-6ef6f683664b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3b8d9dee-7d07-44dc-a867-49e424a4ed5c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("15f741ec-66ac-4eb5-80b2-c4b094b6b6e6"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3c0f8977-a14c-42c8-af81-55972ba4f405"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fc2600d5-30ec-4246-8596-3d421305f63b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3c3641e2-e27a-4a1e-bc3e-fb4a4c7d81f3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c1f82df5-1671-4fbb-ae54-36c3bdc83cf7"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3d2da133-5d53-4e4d-9a2c-13860ae9d64b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e02623ef-2319-497c-bc4e-f26a7703ce21"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3d5b9371-11d0-4466-9e69-cfab25bf431b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d3a17198-e3ac-4d2c-b720-6c334236d7a8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3e610fff-dfe1-4f6c-ad6b-277cb338673e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c40e17be-b2d3-4ee9-8230-e074eeacf2c7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3ea6c9ae-8667-4287-b017-dc009a18ddf1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f0df22cf-02ae-4d7e-aa86-8223b74b5428"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3ec52b3f-e75a-43d8-bb8f-07a8e1206701"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d7a9cb31-ffd1-46d9-ae27-f896787631c3"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3ecc8f5b-e907-4a99-9670-67928e175e0d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f8b57c48-fbb0-4354-b2c7-e97dc2134332"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3f489026-bc28-4704-a576-e82ebf8a8a6e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e5eb3563-da9b-462f-86e5-8b19eaa48f24"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3f64bb91-7f07-41c2-b14b-19415d39d691"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b7f61da8-6686-4236-9fc4-3d61f20064bb"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("402c60a9-2779-4f3b-bf74-0dba1fa139ee"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fda29d45-ae4c-4f09-b46f-efcb985e07fd"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("40743224-aa3e-4370-80f8-bf61315f1e98"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6a41648f-2da6-41d6-a60a-d2a4cf642d72"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4111cdd1-4ab7-42fa-83d6-fe5a69cadc4c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("dc9b6f9b-eb8d-4c43-a059-cb3aa75e8a20"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("420c8e12-d6a2-4b9c-b45e-71f080a6736f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("48a67e4f-9ff4-4253-90ff-7ca383dbeba2"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("42194f76-6f6f-43cb-a5db-590cc4d82573"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4b8cda97-9a47-4a9c-a156-f3ddf2f57092"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("42c61e02-c0b9-4052-a10b-5c9ef05ef728"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("24589532-36be-44ed-a7c2-8fe667476f05"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("431029f7-ac52-40c9-bd1e-03042e3121f7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("56caf218-9b10-4306-bb24-d17608abed69"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("43c727ed-dbac-472a-b6fa-774d868b4294"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b0db9034-df1b-4b82-92e9-73776acfb016"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("442a47d8-3a96-4a9d-9ae5-52603c333e91"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8a857b32-e8e3-43e9-9e0f-6c7da5118cac"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("442e8742-d785-4b44-8375-a7b6b1e5910f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("49b8a21b-f4de-4a34-a356-1ab43eaf9cac"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("450c389e-9949-4dd9-9be6-85396e2dc278"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8e264a50-1046-44ae-8b4c-88f383e66b07"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("457e165a-1a33-4848-b8f0-c54d97eec6d2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("999c25a9-7df4-4221-a78b-ad7437491883"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("45f9fb46-cc74-4e40-9ee2-99ed13199013"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a49c02f1-b7dc-4e79-bc05-2c6698efa924"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("462672a7-75a9-43e9-a1a6-55f080f9ca83"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3dc4d7ae-9e25-434d-8058-af67c2eb3c2d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4686977b-5d28-44cc-94b2-f1be9ce94d4b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("91397e4a-50ec-47df-988c-17e7df1cad63"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("48837c51-c590-4f48-b63c-9f1ffc13d45a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5a17d01a-fcb0-4539-b92f-aa319e69c5bb"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("48ff1ced-0ae9-4279-8b61-9e541ca7883b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("418a04d8-daf9-4962-931d-a4de1df8a1d0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("49f5c508-edc8-492c-a073-0cb14883a410"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("619c4b3c-4845-4acc-b017-1898a1d9a987"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4a00a794-5c3e-4788-a0dd-c4fe4c4c5b7d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("45e85b0a-d540-4f35-aa09-36dcfab582ec"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4a0d5ff4-3820-43ad-b344-771df42db336"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6036a008-e448-4a9b-b91a-9adc6fd03e0f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4a3b7388-6734-4ef9-bcd1-7c48e47de3da"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8f9dedc8-e948-4a90-aff7-19964ded59eb"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4b3a2e57-f166-48db-9c90-2ee5e04daafd"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7b3e7d3d-98a7-4f6c-84c5-c43a6f73b36a"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4c5e9cfb-6c52-49b1-acdf-3f7c0ef434fc"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a47a5159-baf8-4aa5-9a84-63efc4853136"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4c67bdec-a844-4b37-a94c-a301255ccc0d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7b3e7d3d-98a7-4f6c-84c5-c43a6f73b36a"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4c74b93f-1b2e-46e3-a20e-9c6e378530e1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("60ae4bde-6ffc-43ab-af83-d670b988c519"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4cbb99c5-e6d6-4a79-b263-1d097cd8fa82"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d2c4f8a3-bc06-4870-adcb-5bf771059e59"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("4cf6cc19-b8cf-49ae-bc06-8e935c50d438"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a9cf1fdb-b811-4db6-87c0-95bdcdc75c4f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4d03cb74-b582-40a2-b55a-b12d733f4fed"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f51190f0-2141-4c8b-b38d-ab4c76430875"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4d33c50b-fb29-486b-ab1f-6e78edae2fac"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8a2d5ebc-56bf-4ecf-8569-f781997e5932"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4e4bfb2e-a3b3-46bb-a00e-5cd2d1b61da5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("75111469-4339-4b07-be28-85bf5f87eda5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4e65cdc1-ad7c-4db9-9eb5-4b56b959be80"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b6aa73c4-5bbe-44aa-acbb-c2489ac921e5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4e9bdbb9-3ff6-4f0b-be57-c9f06ff87804"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d3d0fced-32b3-4756-8a38-4ae8cd0624f0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4ea0c8f4-f8cf-442a-a34e-1cfa96b50b2b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("554d4ca6-24ba-4343-8037-fa69b0c5deb8"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4fe96b99-bc39-41e2-99c3-fb910119b1a4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d8f3aa54-7b14-4a32-b805-087f9d00813c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4febdc4c-9568-4fab-ac17-97e45c5f5da5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("570495ba-f442-4808-a69b-d60c00dacf4f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("526f0e3a-1cae-4170-8e2d-1de90e34eacf"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f51190f0-2141-4c8b-b38d-ab4c76430875"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("528aa9b7-4aee-4d09-b47a-64589b381122"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e5ebed87-80d0-4937-8681-664f28a25c79"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5295dd0c-a6db-432b-b90a-f35e110a3c10"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b0db9034-df1b-4b82-92e9-73776acfb016"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("52e79363-9835-48f1-98ad-692faa1e6fb9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("02b9d1af-d852-468c-8a13-facbfdca0108"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("53882823-0837-4348-b9c2-f5b46b72b27f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("19786cff-aa2a-4a12-a045-51dc74d1e820"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("53cab1e2-a8f7-44dc-b579-8e2bb2876321"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6e5ffc79-9f7b-40bc-ad36-b4b6ae967e05"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("53ecdde0-ff56-44c3-8ecb-dea4e657fcdd"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8c93237c-83bc-4b85-acce-1c5c6c562dde"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("564d9ea1-2a56-4cc9-b5c1-565f7fe14134"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("eb5badd7-dfeb-4e79-aceb-b482900b5722"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("571cf2ae-68bf-4f64-a3be-7528f328a777"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("40d4835c-ac71-40de-96a6-22f15130554d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("577671d2-ca18-4686-a38d-be7c1af6b45d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("653c75af-4e9b-45c4-bf41-6ef7c12ed8d7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("57e235f5-71b5-403d-bf33-c0ff5d92a6e6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("bd626c2e-ef4a-463c-b85f-9785ebaa0465"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("587b4740-5b59-4ad3-941b-90f3e704891a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e2fb2499-d7a1-4b62-b651-dea9e43bc362"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("58d23130-17dc-4104-9955-311eb1ed4c62"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d6debd83-7d9a-48ae-a3af-4eeca132e212"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5954e9d8-85a2-4f3f-8e8f-20ead6b69c52"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0d3fa4a3-2877-4e63-bcea-d743198d4fc1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("59dad6ae-335c-4e40-bdda-8bee9f1b3870"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("dbca03fe-992e-43ee-b17a-568dc1680d3f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5a344b01-ee64-4ea7-a96f-1b2e6dae2958"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6933c76f-1338-4e54-b1d8-89896ecaac4f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5a573e1e-f093-4c1e-8f90-621440a9dfea"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("60e814eb-0ad2-4cd0-8316-9d2d2a654e16"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5a8bf9f9-b396-48e4-95ff-40cefdb73bda"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4e3258fa-2ba0-402a-8756-68f0cccbec7e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5adbbde1-7e41-4b9d-b958-020b30c11da0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e9cb100a-9bc7-4ed1-8923-62a81432a2c4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5afbb5d7-fac5-4dce-b4ee-92cc93286054"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0b2f7488-8930-442a-899d-48c9cdda345c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5c2eb7fb-0217-45f6-a44e-43736601753e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("19d610a5-9fe1-40b6-a193-039922978be8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5c3bc08b-efe0-450a-b0dd-360db5c59e59"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c40e17be-b2d3-4ee9-8230-e074eeacf2c7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5c842462-f5ce-4d81-b33f-45415a30ec7d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a845a4b2-4c74-4f18-b5ed-8660f34d09af"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5cb72d7b-3c15-466a-ac45-217a84d2b9b0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("df86d162-cbd9-4d41-9ec2-3eb88627818e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5d44f027-0cc1-43bf-aaba-b1510d9875ef"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a2b4aff4-90b4-4843-b4b8-7ecb9d2a1d9c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5dec2af3-6ca6-461e-bab1-bc68f84e1df6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("bed2b92a-501a-4ac5-9443-47d678cee5ed"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5e09f17a-7a74-4a9f-9a71-35e7e1ab3766"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a1b3d3e1-f5a4-4936-8bbd-23b5f32280ce"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5e76eb63-bb1d-4ef7-adbd-06c2047cd0de"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("50249ed2-42c2-49d4-b32f-2f78d8ae2997"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5f007064-2d06-41a7-9d22-06ed1aa1428c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c1bbb2c5-f38c-490b-a23a-805cefbbd5cb"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("60989b3b-db29-4831-aae4-a35e3efaca54"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("58cdd8e9-884f-47b7-88f4-b1b2821d874a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("60e40665-8d43-43f4-9134-2f2a97fe2ab6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("78650d54-dec0-4c16-bab8-c8ce2b6d4325"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("62f19468-0e5c-4ddf-ac74-cce5f58c4f9d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("33064e46-3dce-4d4a-9696-33cbdafe5070"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("63ec2a0b-7d91-4f67-9da8-c312a930a055"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ee69e72b-a234-4ce3-aacc-21d0512e8717"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("64b36eed-33cf-4669-8188-af84244d6f06"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("bd62026d-c026-4f7b-ab95-dd7489ca4dbe"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("652ae705-fe93-432c-a34b-1951b9b14190"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5ac44bce-4372-4c88-a062-2b5424f6db7e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("663146eb-55d5-4dec-8360-ef93371bd33f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f3b5217f-e4b0-4316-b610-cb3fd8c14c69"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6674e6c3-fb66-4317-a9e9-267ec6714c7a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("62f9d6e2-5189-4349-a926-917995a9e443"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("669a3cc3-975e-4ced-bb6a-c399c0a9e39a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e08af717-f94a-47fc-b079-71dfad3595f7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("66d3171d-6f3a-41ea-95c2-aa9e0d36a3b8"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9877bfec-b85e-4190-8c56-bb18a556f9a4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("66e266d4-0e30-4c5a-8d83-be7ddca184ce"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6178573b-fb3d-44e0-9955-0a38222aa391"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("66f346cc-b358-4671-a04e-633d458dc056"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("210b0adf-b940-4e92-b090-921e74ebc1a6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("676d86db-a7d6-495c-a264-a8ad5dd249e1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("977607e1-fd39-49e3-b3d5-76e9934d2d91"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("689faab0-16c3-4ad3-b876-d1d6c9cc6857"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8821d7f9-2889-4f59-9638-5e062cbbfaa7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("68b28e38-4d8c-43ec-875b-54d16398f92c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5f1bc312-abdf-4a9e-b37f-17a1301fb6ca"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("68f5a0d8-4779-44cd-9e01-82ff7fb0c9f4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3482f74f-c049-464d-8b6c-46bebad2ab18"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("69364b67-636a-436b-b89e-0da31f98b023"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("61477a73-a424-4ac0-95e7-88718ebbaf27"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("693e13ba-0f42-4b2c-8fc0-bc4bb0e35c18"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8c0643a0-f95e-443a-b722-2f9ed30d51a0"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("69a8501d-6756-4025-896d-bfa94ff88d0f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("75111469-4339-4b07-be28-85bf5f87eda5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("69ba754d-673b-45fe-b9f7-49a808df93ff"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("df86d162-cbd9-4d41-9ec2-3eb88627818e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6a2985bf-9c5a-48cb-9b52-978aa93393c0"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("001aca7a-ed2e-42c2-9ea4-689b1df6dc3f"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6ab9b921-44e4-47cc-8e65-67a5c668d434"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("03db8ec3-b4e6-4ccd-8295-f7bf6159e3cc"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6b7a341c-2050-400d-8f4d-3499320b9ac8"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2ab3e73f-ab99-4f4c-b959-41e40f10cbfe"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6bd95761-294b-4ea2-a8be-5ae63a404dc3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d3a17198-e3ac-4d2c-b720-6c334236d7a8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6bfec239-8b99-4b39-9d1a-0961eedab577"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7781e159-3846-409c-8606-208d54891c23"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6c60d98f-08e9-4979-9c1a-70887e953dca"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4671ce29-fa8e-402a-bdc6-92a0d79aea8c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6d47acc3-ff72-45f7-9378-fd6c5f0cd97a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fa9d3da5-9820-45f1-8419-10a57f73ea0a"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6d9c4176-c327-419a-91bc-4d96e372a19a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b7f61da8-6686-4236-9fc4-3d61f20064bb"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6dbd6695-aaa0-4d9b-9694-f8d94b17f43e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("29403e39-eefe-4fb9-8d01-3519a7f6d131"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6dd6a125-cf80-4196-89a1-1366aa26af66"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6e450fc9-13a9-4b71-b58d-1bc885b8214a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6e3c9bef-4788-449e-8f88-f453e3809f12"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("37af49b1-5fb2-4a3d-b6c1-f0020ad5548b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6f1c1671-e13d-4f32-8465-3ee27f248458"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("50249ed2-42c2-49d4-b32f-2f78d8ae2997"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6f39f236-09cf-416e-b643-640ee830e4e8"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("053d37eb-3ac0-4d2a-8512-a4fa4f5c960e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6f9e643d-ef96-44a0-b192-8fe26779b09b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("12893112-0583-42bd-bd58-f9adc577aee6"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7007162f-a2cd-4ee7-8883-742cb17ae25c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("60ec154e-88a5-4d8d-bbde-2c79b8c2fdb9"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7085ef6c-a29e-447f-a542-7ae7bcdb0911"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("124e9e6b-b8bc-4e1a-954d-13d4b1ad86a4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("708daa14-eac0-42fe-b111-dce1e44b5f93"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5a1507f5-93ce-4821-abb6-2e7d7c3e0be4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("715be527-b9d8-43a8-8909-a187927ec155"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b44e2de8-24d9-4f3f-894b-8a132afb30a2"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("71a8b765-7902-4d51-9bde-e22a1e405db6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d6debd83-7d9a-48ae-a3af-4eeca132e212"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7210d959-3bdd-4dea-a03e-a0c4759504fa"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("abd1964c-4aca-423c-91a3-f421e0f4edd5"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("72745f3e-51c2-472e-861d-a6b5cb4eb6a1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5adb947f-f98d-4ead-9528-0d597f746c69"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("727be5be-ea91-44c9-9b29-5878ecc7bdc3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("84023e47-8558-483c-8642-a803826e9666"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("73062a3e-4603-42b8-91eb-5aac819b1c40"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f937c620-6448-41ef-9b4f-73df19c1d9f3"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7395556e-7097-4e6f-ad41-e59fdbff4365"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6933c76f-1338-4e54-b1d8-89896ecaac4f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("74102b6e-0877-4a6b-bc54-b377fef7152f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2d2900e1-2055-4bc6-a22e-f8ced06c8b11"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("749f2d84-0a54-4445-b1b7-c34af7e1d122"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f81e8157-967a-4e95-9cf3-290a27ae73ff"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("74c73cec-e58e-4cfe-964e-6a682887f1fe"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f8b57c48-fbb0-4354-b2c7-e97dc2134332"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("75152c3d-e38d-4d64-ba6e-26e7d54901e4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("82426b76-c4f2-4afe-b485-2c5bf6285f2a"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("75242ea7-50cf-45bf-956a-f10dc590b5fa"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("53db724f-4ca1-4695-9ee0-9b8acd14beb5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("757b01c5-a4f5-46dc-88b0-84fd54b569b5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("55decc4e-ed9c-4d5f-8c67-260f386c139a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("764316ee-3691-4de9-bebb-515b26c6bcca"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("247f0824-ea3c-4d5a-8bd4-9bea886ee8a3"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("766f5d44-272d-40a5-a613-d2d49b6c60f2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("683b48f6-aa20-4663-9bfd-d7174ed93eac"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("76a28032-67cc-462b-a450-0cba3e5cae2d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("65daaff1-a375-4659-a875-5f7ab2e42697"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("76b94685-1c11-4d88-a97a-c17f0bdc05a2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4671ce29-fa8e-402a-bdc6-92a0d79aea8c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("76d39328-1725-4c62-b3a6-ba03018fb3ea"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5b8080e8-80e2-4599-b42e-86d769a092a2"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7756913d-e53e-4ee0-a5ad-2fd465014a2d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("821c6b13-bef3-4f8a-bd9b-a9a9ad692247"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("79367e85-f303-4f3e-8614-d67d72acad9b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ee123a1a-2b35-40f9-8f3d-07b610e2fdb3"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7a34e0b2-bc0a-4b77-b594-036a6e49735f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5f1bc312-abdf-4a9e-b37f-17a1301fb6ca"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7adc96cc-6a03-417c-8af8-caffcbf06477"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8b8d3274-173a-4650-8015-792915373baf"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7b176457-7745-490c-951c-8fcfb559c0eb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("889037e9-79d1-46b0-a469-f7b3122ae4ae"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7b4172c2-6467-42ad-b53c-b56c50d62862"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a63d468c-1e16-4375-94df-f10909ccf99c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7b907bd5-accf-4f70-82bf-4c4e7ad6340d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("699a64de-eb3b-418c-b1a7-81674a48b450"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7bcff82c-0049-4ad1-942c-73121dfea769"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("abdd3f21-c8d2-4420-a923-3504483d4d53"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7c2ebbe2-ea8d-4cdd-b22c-c2cac408ae18"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("15290099-ae03-4fb5-9f9b-8112dd35f691"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7c43c4fd-8759-450f-961f-1051f98aa277"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6b2b6951-6ccd-4930-b15b-fa475658c901"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7c66864f-fa19-41b9-b716-f78983dfd8f7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5bf7493a-c2e4-45f3-ad9a-c0d48b5cf98d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7c79fc82-29d8-4c98-acff-89c9460dcdfe"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("82426b76-c4f2-4afe-b485-2c5bf6285f2a"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7c91e69e-74b0-4a4c-822a-dd173cb5ec23"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("36c7ef44-0aae-476d-9118-5c2373501054"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7c9dcd45-1c79-45c3-ba80-e3afd7db1cbd"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2c040898-203d-4868-ba53-67aa25fa9ab6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7cde397c-0d90-4e4d-b817-ad64bbc5f41f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8c93237c-83bc-4b85-acce-1c5c6c562dde"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7d761a5f-2912-42b3-856f-7d986704ee12"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c636857c-45ca-4980-a728-041e80598b5c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7e1a9597-a5a7-4436-ae7e-4f41f1685663"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c522eefc-571a-425a-a8a4-6b1ec2bc81ec"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7f76f550-aa98-466f-9e3b-1429ac0da50d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("33fec5a0-9bcc-49e8-88c2-070a7d2ed169"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7fa7608d-8c16-45da-8b8c-842385d5f49a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c522eefc-571a-425a-a8a4-6b1ec2bc81ec"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7ff1cb9f-ac9b-470b-a77c-50caad9fedf1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e9cbf05e-25c6-421d-be5c-b575d8d7d8de"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("80166a8b-eb5c-401a-8c69-71f1a4e9fd20"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9ff030f6-20e8-4f1c-b908-72754966cb83"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("803fb666-0f70-4651-9d08-6c639d04a515"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7487cab4-5d39-4a47-bc85-5d9edf682538"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("806a70a6-af47-41cf-9d3e-f9ee137f4bac"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("45e85b0a-d540-4f35-aa09-36dcfab582ec"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8072bab4-5880-492e-9359-1cde85190d8e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("247f0824-ea3c-4d5a-8bd4-9bea886ee8a3"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8106fc32-ab29-4796-a87b-5c03a8713d1f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f6f47776-ff1d-4f97-8c6e-e4ba1c07dbf8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("81c8bb4d-5113-47b9-af20-13e6a245420f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e2fb2499-d7a1-4b62-b651-dea9e43bc362"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8309e6f0-9ab1-49e2-99fe-a260f5d9853a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("977607e1-fd39-49e3-b3d5-76e9934d2d91"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("83697aa6-abde-4212-bc62-d02e00b5e3cf"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b15e5dd5-f505-4e7a-bb9d-f195e7233706"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("83802ac7-57fb-42e2-bb5a-cd59d0f02f09"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1146bfb6-e479-48cf-83f9-d62814c58593"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("83ad97c8-c9cf-4531-9bac-a6ac49a62974"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e8d5c108-3d26-4d04-969c-438b4a61b51d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("83cfc65d-a64a-4795-b75e-36b7b81f503f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("58c1b068-e40d-4e69-a279-8e9917ebb28b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("840d366f-9c21-4c58-a261-f4bd4d4c0a6e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1089b230-896d-42e9-8797-4277f851e832"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("845b9d87-e526-4dee-a9c4-9dab35aecebe"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("aa3ce092-3163-46fa-99a6-1acf034ea265"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("84e295be-7315-4e42-a914-d4525d0a6a96"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8a857b32-e8e3-43e9-9e0f-6c7da5118cac"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("85fb2d4e-ba81-4692-b6ef-6a56a48714b4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("46e2c10a-944a-4282-835b-e2af5a42c07e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("865d7e8f-bcb0-4fda-ac79-902d538edb46"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("bed2b92a-501a-4ac5-9443-47d678cee5ed"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("86a8169e-3090-4249-b126-5dc2c0590d2d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ca7b637c-ce81-435e-88f2-09f57c90b3e1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("86ec756d-a3e4-46a1-a3e6-c62297f549c2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("999c25a9-7df4-4221-a78b-ad7437491883"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("88a0fc16-328f-456c-b9a9-38626bd78d36"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4aa67f51-a49a-40f6-91ff-e98ed9b5ff72"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("88de7594-836d-4896-82c9-2645cd917d61"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("dd7f06d5-5da7-4ed9-beec-6a27ea2e24de"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8926f54c-a62b-4331-b81c-007f9c1b18b9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2c040898-203d-4868-ba53-67aa25fa9ab6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("896060f0-1b9c-4184-a26c-628e09feea6b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6fea1bd9-b3a2-45b3-a9b4-fea6d31cc98f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("89e127a8-1ea0-44e2-b22a-187152ba5d54"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c00b5a38-787d-458c-aff4-9ccc510ea888"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8a21c280-1641-4e74-ab72-4dcf38dd4d6c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1089b230-896d-42e9-8797-4277f851e832"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8a746469-fc36-49fe-a7c7-d34141ae9d4d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("c636857c-45ca-4980-a728-041e80598b5c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8a7c40ab-bdcd-4597-9ca8-45ab129608d6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("bd62026d-c026-4f7b-ab95-dd7489ca4dbe"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8ab07ab0-ca2c-4493-896e-7a5ce72c0792"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6f6833af-1db3-4310-8f7c-0fcc1863c78f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8ada472e-9d20-409c-8df3-dae5c1874e4b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e02beceb-e15c-4b07-b716-b2c908254f1b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8b1a8e47-da3b-4ca6-b52c-e929c221cb62"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("01cd7af6-fb93-431c-828b-97f6245ca368"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8c16a1ae-2f89-48bd-90ac-c0347e23ee6c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0321a7ca-b22b-455e-90b7-61b4344f2ef4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8c2103d4-a6ab-4ecc-86fe-1706452c2d33"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fa9d3da5-9820-45f1-8419-10a57f73ea0a"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8c54c308-e5de-4f4b-8070-86a287756d48"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("db65b64d-19d9-4121-a8bc-6d0b893bbad0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8ce48bfb-abff-4c79-9262-4f814a97b9d3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("19786cff-aa2a-4a12-a045-51dc74d1e820"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8ce74bbe-9e1d-4ddb-bc63-40654b1ae249"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("19d9d47d-413e-47ed-a4c8-552fa35f7876"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8db96a6b-15cb-403a-9ee7-f92be05be107"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7781e159-3846-409c-8606-208d54891c23"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8e88d38a-4f99-42fc-a4dd-761e53febb3d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2147837b-7036-4b5c-b817-9b85539c56d9"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8ea54c9a-9c1c-41fc-af42-f8f05676f165"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2d40dfee-5890-47c9-bade-2d6ae6617176"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8f342d84-2da8-4e18-b8ca-dcbafd428731"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e8d5c108-3d26-4d04-969c-438b4a61b51d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8f35376f-ed5b-436b-9063-e6402b6fb58f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1f8255aa-42bb-499f-bb33-29513622e95a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8fcaebe2-dc9e-4df1-b450-d457493a58d3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7575d1ab-186d-4767-8abf-ae7823bf2657"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("902de982-dc44-478f-aae9-b42dbe9bb023"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9e7f5a16-ece3-43e8-847f-28b8df69eac8"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("919968f2-b57d-4297-ade2-f6015c1392c5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5adb947f-f98d-4ead-9528-0d597f746c69"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9236b8c0-eb83-421d-add5-8b3dae0e8ce0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b3c9a9ad-d4e5-4c85-b1d8-0b10d0ed096b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9236e1bc-11b8-4380-92a5-d58456c369f7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("51355fdf-ee3e-4f3c-be5f-696f424e0260"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("92a48de1-179c-4eb9-aa65-7f3beb696e31"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("73999d10-7ec4-4ed0-a260-5e80cb32127c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("93de0849-91b3-496b-9630-b86d8efd5176"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("36c7ef44-0aae-476d-9118-5c2373501054"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("93ecceca-9ebc-40e1-a089-cf013b0fdade"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4aa67f51-a49a-40f6-91ff-e98ed9b5ff72"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("93fa9a21-efc4-4167-96f9-79be1adb6cce"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9e7f5a16-ece3-43e8-847f-28b8df69eac8"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("94e7684c-27b7-463b-9bfa-09c3cec33ac5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b2a55c59-bf11-464f-ab98-359e7448734b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9559e069-2432-4a09-bc9a-27d05229b071"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("38ee0f0a-8fbb-4bd5-83b6-860c386474e1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("95877666-0b9a-4e6f-a2e6-9ef068dfecf3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("01d73435-909d-4b49-bb8a-bf4da8c5586f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("95ad9edb-fc13-456a-89e1-24dd0cb33d16"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("01cd7af6-fb93-431c-828b-97f6245ca368"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("96157e41-bcbf-465d-8f5e-9cc7cc596f4c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("19d610a5-9fe1-40b6-a193-039922978be8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("96b31f27-592b-40f3-a2a9-19bc4a7db566"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("af19ba6c-5baf-49b6-bf71-da83352dbb30"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9776bb04-15a6-4a8c-b762-724e955ffdbe"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("49b8a21b-f4de-4a34-a356-1ab43eaf9cac"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("97bdaf8b-995f-4b4e-9c4d-c24c942a7cf3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7198e8f8-3f04-41ab-bcc1-65067e77920c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("97c72461-b300-4af2-aa41-7e50c951f60b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7be1caa4-bc2f-4ff7-a347-9dde0dcca7c4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("97d6c53a-2473-4936-8cac-ed50bdf228ca"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c00b5a38-787d-458c-aff4-9ccc510ea888"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("98757e1f-9a27-432b-91ae-fd32d75b3fe7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("75954116-3e6b-4b89-97df-06db9b9f2df7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("98b69318-3248-4c17-a574-cf567f530670"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("22a1c2af-034f-4df0-9055-08fb0dfce5c7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("98c40669-cfcb-44fa-97a2-4490c4bf8741"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ff9df34c-0d10-408e-af4f-1a7da4f418d4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("98d20acc-c953-46b9-8590-9d8887fd127f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("29813703-2d8d-44a9-b255-7e90f92a910e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("991e428d-e4ea-4d94-a019-05e944dc4f47"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("da924dd0-84a5-45f0-9030-489a93041a92"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9a16ff84-3710-4dd1-b0d5-69b4f945df73"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("bd626c2e-ef4a-463c-b85f-9785ebaa0465"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9b72121d-ee3a-4f6c-963c-5f794d78bb1c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("de564ac9-47f4-4cab-ac05-7d61d336220f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9c3ea3e2-18ce-4a24-8380-7df60b4fe045"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("21f62bed-abcb-43df-b865-98ad6c7191d6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9c73b8bf-c32d-4fb3-8b5c-dec686035f0c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("08edf71d-f70f-4fde-a69c-8d7f74e8e5a7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9da9c9a4-caa5-485a-9c0b-945cb12871be"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ee123a1a-2b35-40f9-8f3d-07b610e2fdb3"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9eebcb6c-5f30-4d41-963d-0107cb8fe616"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7715ef60-9573-40db-8240-7a624aeb4f34"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9f7a3f9c-4ea5-4ba5-b8a9-9bcbfcf79186"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("bc19200a-e148-49a1-96a2-688c14549b74"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a04bb606-4cae-4720-95de-f16c0abb82d6"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e02beceb-e15c-4b07-b716-b2c908254f1b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a0c672b2-369f-410a-ad96-91312e3221ed"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ecf1d885-2918-41d9-a3e9-a6ef61e29153"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a2050eb9-608d-403e-8dca-38029e1edbea"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ab9ae5d8-08f9-4f21-9dbf-eb763c74408e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a214dd8c-3f4b-4a22-b7f3-8ec2c760c201"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("81f3c86a-688c-4c2a-ba79-dc9963295f4a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a311e538-9692-44a5-a1b4-4f8794c934e7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b367e84e-2dc5-4ac8-9055-35a01c445647"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a3b7afce-04e5-4c40-9a42-35d80387f9e5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("61477a73-a424-4ac0-95e7-88718ebbaf27"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a436dc63-6fb2-492d-a26b-f52a768ece8c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("16018cfd-4c01-449e-9e07-2966410d9211"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a45bd51d-12b4-4116-b10b-d5ed559df1f0"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b44e2de8-24d9-4f3f-894b-8a132afb30a2"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a4629dd3-c70d-4657-a01b-b3dd2130a544"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("47832ef5-9f6e-49f0-8f7e-b01fdc4b8638"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a4dc9d6d-919e-44bc-b584-920afc011a4c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("425f1465-7b98-4341-9bc5-5729d2ad35d5"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a599378e-07b8-417e-af0b-9d6d654bc8e1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("85b5fcfe-57ae-4d14-820b-158fc1052dd7"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a5bdfbec-c45b-4591-a7c2-747f1ee74391"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("58c1b068-e40d-4e69-a279-8e9917ebb28b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a8b755a5-a8e0-4610-baad-d11bc23d1e15"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6e450fc9-13a9-4b71-b58d-1bc885b8214a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a949246d-c4f8-4951-bcc2-14d9997033ea"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("01d73435-909d-4b49-bb8a-bf4da8c5586f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("aa40d10e-0819-4109-99cd-19594d7d9d42"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("da924dd0-84a5-45f0-9030-489a93041a92"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ab0b3efb-4523-47c9-988e-0f9a44044b44"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9f0bd11d-c7ef-473d-8e2a-671bc0c2d37e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("acc32560-5f49-430f-9132-9ae5b6d1f68a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("dbd36eea-a132-42db-b1ca-4329d8a6a96a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ad3205a1-3eb8-483f-a185-9bc3fdefa897"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("09c3b3bb-7738-490d-9a83-1bd7ed0bb7de"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("adc334cb-add9-43fe-838d-366e0cd6a774"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7887edd3-5fd3-47cc-ac6e-921ee2dab4c0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("aeb0e101-78b4-4e17-bc67-a3e4a11c523c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("83120cba-ec02-4214-8bc6-d5079c8fdd9d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("aeff2d92-8f81-4498-83b7-727ee1a4fc6e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("240e0b92-b7f9-4ff6-8a96-77505e646b14"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("af031484-cf7c-4573-bdaf-8497d6c258a4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ee69e72b-a234-4ce3-aacc-21d0512e8717"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("af28b2e0-1157-45d0-aa3f-b3a258464280"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5a17d01a-fcb0-4539-b92f-aa319e69c5bb"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("af73ad02-b353-41da-95f0-918d7be8b64c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c28b53e7-f0cd-4f5b-9f26-627a5d1342da"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("af7b9d4c-58d0-4d44-b5a8-807f49e50388"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d7a9cb31-ffd1-46d9-ae27-f896787631c3"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("afa98d13-c497-462f-96a8-4fa52a357993"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("bb7de537-c65b-4ace-82ec-31e7f39bdc4a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b0e0933d-ac35-4c4b-b63d-1f43a1f6baf9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("b2a55c59-bf11-464f-ab98-359e7448734b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("b13631b7-1c06-4288-8e05-6473a5fd210a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a323cf95-a747-4832-9750-54e5c88cd70b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b2b9d54b-7bd3-47b8-a003-1fcb97a22678"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d6fe1e52-9ce1-4969-9b3a-ffab097967b7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b2c3c1e2-6a6b-43c0-ae0b-ea0b4d924506"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("210b0adf-b940-4e92-b090-921e74ebc1a6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b2ee131b-f691-4166-bd33-e8af5356531d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6e5ffc79-9f7b-40bc-ad36-b4b6ae967e05"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b2f48cac-0c33-47cf-93f6-cc8def97fdc4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4e3258fa-2ba0-402a-8756-68f0cccbec7e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b45b194f-de13-4fc9-89db-169af1be8907"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6b2b6951-6ccd-4930-b15b-fa475658c901"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b4ce98f5-c849-4a24-81ee-af0ca32520ba"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("abd1964c-4aca-423c-91a3-f421e0f4edd5"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b512981b-7e02-4f41-8271-82deeb4269f2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("77fa7649-34ef-45b0-980e-a2ccbb46034b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b56c237e-926e-4d39-9f84-6dc72854a4e1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7575d1ab-186d-4767-8abf-ae7823bf2657"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b5e8d4f0-4c1e-4a1d-9dd5-0641d52d193e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ed9cbd1f-5d44-48aa-9d7c-d7cb0ffe7f64"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b5eb5b28-1737-4244-a9df-e1e807bf8b37"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("83120cba-ec02-4214-8bc6-d5079c8fdd9d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b7bda64a-c62d-46c5-933d-ee5c6ef9bd56"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("240e0b92-b7f9-4ff6-8a96-77505e646b14"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b8214bd6-d1a6-4a42-8152-85b2c43d573e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5a41392d-b48a-499d-b9c4-6bc18d21b7df"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b82dcdfb-dca4-43fc-807a-3c32d5b76eb1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a63d468c-1e16-4375-94df-f10909ccf99c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b862b56e-ccbb-44ea-bf2e-06b82f8b3bdc"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f8717e94-bbf0-4416-bca1-d18b5a3705a5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b8ac1e1e-c188-470e-b6e4-368e15b3381e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("eb5badd7-dfeb-4e79-aceb-b482900b5722"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b9571ceb-317e-4347-aa56-a33ef1ebb8fc"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("e08af717-f94a-47fc-b079-71dfad3595f7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b99634dc-cfaf-4a04-b957-96dabeae99e3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("abdd3f21-c8d2-4420-a923-3504483d4d53"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b99c3c83-d8eb-42aa-9635-f371a1b2a748"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6fea1bd9-b3a2-45b3-a9b4-fea6d31cc98f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b9a361b7-58aa-48a8-9a77-f3718a1eeda0"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("9fea2c8c-20fa-40a3-851b-cc5f4c622451"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b9da1d06-e986-4d94-a897-534deb895478"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6178573b-fb3d-44e0-9955-0a38222aa391"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bb64faf2-4353-427f-95e9-40db53afb041"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a1b3d3e1-f5a4-4936-8bbd-23b5f32280ce"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bb7927f6-d473-4db3-b755-a1578524b2bc"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5b8080e8-80e2-4599-b42e-86d769a092a2"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bb8527fb-518e-49fc-8294-02caa54dd4c5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ff9df34c-0d10-408e-af4f-1a7da4f418d4"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bd7cc26d-0e7f-49f1-9f9c-8c938ed45808"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b15e5dd5-f505-4e7a-bb9d-f195e7233706"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bdb4edd6-f36b-49f4-bd3f-6f516a1c4940"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("683b48f6-aa20-4663-9bfd-d7174ed93eac"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bdbcce20-354f-43be-957a-121f830e55d6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8047ea19-6263-4340-853b-e50db6635016"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("be0015fc-2ea8-4d13-b1aa-128b1d3baece"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("6036a008-e448-4a9b-b91a-9adc6fd03e0f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bec42b18-2b33-4c2b-88df-01dd64f0807d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("75954116-3e6b-4b89-97df-06db9b9f2df7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bed1fb0e-e7ef-4f37-ae0f-82bb7fb2b485"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("ab9ae5d8-08f9-4f21-9dbf-eb763c74408e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c0357009-0785-4875-98f0-c4544f3980b2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5a1507f5-93ce-4821-abb6-2e7d7c3e0be4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c07d2d99-010e-4b8c-845d-6a6cb700141d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("47832ef5-9f6e-49f0-8f7e-b01fdc4b8638"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c1a5528c-2d13-4da1-b0e6-790606596ded"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("76d48d65-7b0d-471e-a281-6b9c30463110"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c1b1decf-5057-4e4a-a327-b7b6d7808337"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("19d9d47d-413e-47ed-a4c8-552fa35f7876"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c2aec9f8-4bf7-4199-8c25-c51213f45f34"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("33064e46-3dce-4d4a-9696-33cbdafe5070"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c44e0ad0-4814-460c-a9b6-804485386a15"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("24589532-36be-44ed-a7c2-8fe667476f05"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c53117b8-5527-45fb-96e5-19a17259694d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8e0dbf9a-3ad9-4c0a-99ac-a22d6c0dc0dc"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c55719ec-5171-4e0c-a575-4382e085d609"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("936c2d91-5bfd-4454-98bc-8d90c3eb057c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c5c95849-ffc9-419c-9ca9-d4599a2bfc6f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e4a49fb2-0020-4a58-9b19-d50d76d081d2"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c69bce39-ec67-4127-8d8e-5990e7121c2d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0c2160c1-c3ab-499d-b149-2def35c25670"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c7250e7c-ed89-4252-a5a6-553875b4b2a2"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("653c75af-4e9b-45c4-bf41-6ef7c12ed8d7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c74ad52a-32ea-4fd9-a675-26041b80626f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8b8d3274-173a-4650-8015-792915373baf"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("c7803ad9-bc07-46f2-92a1-77b1ff4ea42d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9ff030f6-20e8-4f1c-b908-72754966cb83"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c7a8f393-d9b0-4e46-b4ca-60831cc74636"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e5ebed87-80d0-4937-8681-664f28a25c79"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c87a1f92-de6b-401f-bef8-27447abd5acc"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0b8cd886-9d69-429e-b2cf-aee59884538c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c8a1d82b-a385-4de3-bdb6-9725f4fa6244"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("9d1e2cd9-4efd-4a46-87d1-4c3d6bae1afe"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c8beaec2-f678-4b0d-8178-1216f588196d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("02b288d9-4ac4-4cc3-8532-a92ad4daa733"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c96eac71-1508-4b09-aed7-3c1ae121a67f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("84023e47-8558-483c-8642-a803826e9666"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ca433f26-fa38-4c37-b39e-ef8ad3841206"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("dd7f06d5-5da7-4ed9-beec-6a27ea2e24de"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ca7bc769-07e6-485d-90be-5ef5692f6724"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("45b1c9cf-5756-4e73-85e8-bb30a4db8914"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("cb6dfc4d-e7ce-494e-a786-9c936341e883"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e5eb3563-da9b-462f-86e5-8b19eaa48f24"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("cc9cc24b-590d-4ab0-95a2-eec7d5456e74"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("58cdd8e9-884f-47b7-88f4-b1b2821d874a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("cee75af6-6ca4-43ed-acd9-76613eceb805"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5bf7493a-c2e4-45f3-ad9a-c0d48b5cf98d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("cf2fd016-0282-49cb-b922-fd96eea9ff01"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e9cbf05e-25c6-421d-be5c-b575d8d7d8de"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("cf91c4a5-a50c-4a9e-b9bf-dfa17ee34232"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("001aca7a-ed2e-42c2-9ea4-689b1df6dc3f"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d1d7fcea-5669-4683-b32b-ac50ffc7658e"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fda29d45-ae4c-4f09-b46f-efcb985e07fd"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d2351124-97a3-43d7-a98f-937a843977a4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("5f24cfb7-8b34-495a-bf4e-10e396798e8d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d2c11e2d-f0ae-4ecc-9c2c-3b5d293594ef"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d6fe1e52-9ce1-4969-9b3a-ffab097967b7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d3d5337e-c832-4110-a8de-ad00c72abf0e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("15f741ec-66ac-4eb5-80b2-c4b094b6b6e6"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d47ad465-7501-43cc-b0ef-71fca518c3a8"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("b367e84e-2dc5-4ac8-9055-35a01c445647"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d48c9af6-311e-4cfc-8e07-c44031f8baf1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("936c2d91-5bfd-4454-98bc-8d90c3eb057c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d5021dd2-48d1-4d63-894e-58bff6adc5ae"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a47a5159-baf8-4aa5-9a84-63efc4853136"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d50d441e-d0db-4138-b78a-a3ee8a622aa7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("37af49b1-5fb2-4a3d-b6c1-f0020ad5548b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d5ae6a67-ffcc-4752-8a76-e85e7c740f6d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1cf286eb-4651-4799-b900-3d2c86a3ab9c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d6167ed1-eaf6-4901-859a-c3496cc17b10"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("62f9d6e2-5189-4349-a926-917995a9e443"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d6670adf-caf2-46ef-b19a-a6f29a3153c7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("05761598-bfcf-43c1-be76-4cfedc3f2469"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d746ba13-5cf1-41b9-a061-fab7f9adb13f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4159555d-795a-4d8a-b55b-b8bac5a90f39"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d777426c-b221-45df-93dd-b9026ee9d037"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("c2c39aa2-f104-474c-86a0-ed792ea173bc"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d7a8c15d-388e-42cb-8b0b-beac223c33f4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("158be4e7-02ac-438d-9a2a-315c81f9fdbd"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d7bfe306-afc6-4b64-8c71-f73cd0ab96bd"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("22a1c2af-034f-4df0-9055-08fb0dfce5c7"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d7d5104a-4cf8-43e7-8da9-d10f8cfcf57e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d3d0fced-32b3-4756-8a38-4ae8cd0624f0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d825773a-d32e-4e6b-8057-62ad6c083cb2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("418a04d8-daf9-4962-931d-a4de1df8a1d0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d8bf79ca-33dc-48f5-89bf-ce7cbea3dbcf"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("14493811-34db-4f57-948e-71386573967b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d8cf7627-924d-4892-9c16-41eddac5934e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0b2f7488-8930-442a-899d-48c9cdda345c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d8f64e3b-a5d4-43e2-8a36-f1b919269ac3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("821c6b13-bef3-4f8a-bd9b-a9a9ad692247"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d95ccd89-f34a-43ce-9a6f-bfbf6722f9cb"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3dc4d7ae-9e25-434d-8058-af67c2eb3c2d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d9c2b75f-5e4e-485d-bcb3-7f91d9541b2b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("27d92835-4254-4ec5-9010-1d6a33ac7b01"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("da3ea9fe-a4bc-4a7d-b030-4b10b310d9e7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("db65b64d-19d9-4121-a8bc-6d0b893bbad0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("dadcbbb2-4003-4bb2-bfad-9e7d96b14dda"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8a2d5ebc-56bf-4ecf-8569-f781997e5932"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("db875402-192d-4982-a38a-e3dd14d8886c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("141e8876-7e93-426b-8b10-6dd3b69354fe"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("db9dba60-8f57-4d19-a7f7-aeb6cabfa594"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2c3e9456-e03a-4158-b7aa-32c743fc7a3d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("dc18d900-8a4a-4e31-a3f4-a1de85dc9567"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("a49c02f1-b7dc-4e79-bc05-2c6698efa924"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("dc27ad11-3908-491f-8f96-90eef7f49aab"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("53db724f-4ca1-4695-9ee0-9b8acd14beb5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("dc4d8ffb-fe8b-4fdd-9cdb-2588b02b6202"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("03db8ec3-b4e6-4ccd-8295-f7bf6159e3cc"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("dd082974-6f60-475f-b2e6-52cb218e55aa"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f3b5217f-e4b0-4316-b610-cb3fd8c14c69"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("dd8f4b05-efa5-4276-8b80-f30d1d073139"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("3e13781e-1913-4321-8bc5-84378759e3aa"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("de2d98a0-1266-4103-921c-ddc4f60c401b"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("eba58977-c640-4b7c-9d47-96cc3c90eeae"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("df9fdab7-2482-41e7-b540-6a92c7dc0f2a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1864aefd-322e-4911-a03a-a4008c1c604b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("dfd945f8-ce85-4217-bf0a-39b37ada2e89"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5f24cfb7-8b34-495a-bf4e-10e396798e8d"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e00e0fc9-8e56-4b6c-bf8d-edbf3920f45a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("14b899b0-35a2-4388-96cb-423d071dffd4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e0432f74-4585-4506-88e4-ee593f2e5c5c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("33fcbe37-6aff-4a34-8b39-3bc14d2827d8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e0880673-c200-439f-b646-286552d52995"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("554d4ca6-24ba-4343-8037-fa69b0c5deb8"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e0bdf71d-995a-4d30-86dc-bcad211c71ad"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("a8865cd3-c612-4cef-a1d5-8a050693a65c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e1468bb2-871e-49dc-9df4-1c92031df27f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("eeeef80c-8f73-45fc-84a2-b2d135738c7d"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e319d7bf-3cef-4072-a67f-fdbfba9ed50a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4232fb31-1ca4-4902-b865-6b6c360572b6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e326e834-336b-48b1-a626-60163e69f4fd"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f8717e94-bbf0-4416-bca1-d18b5a3705a5"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e3476da1-76c3-498a-abd6-560b12ad3b55"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("764895a8-8235-4bfa-a52b-001cf4266ac9"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e3a8adef-0d3d-4df8-932c-8f39613630e1"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4232fb31-1ca4-4902-b865-6b6c360572b6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e3d113b0-880f-46c6-b6a1-8b9f0985143b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f0df22cf-02ae-4d7e-aa86-8223b74b5428"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e543e21e-0b43-46ea-88e2-913407d58e44"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("02b9d1af-d852-468c-8a13-facbfdca0108"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e5ae08b3-21a9-451b-a340-c24d152aa101"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("699a64de-eb3b-418c-b1a7-81674a48b450"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e77aaf0f-9f22-47ab-872a-8232f53525d7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("ca7b637c-ce81-435e-88f2-09f57c90b3e1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e7a43b9f-ac7e-469f-8d17-9df5300520d3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("d0b761d6-15f7-405f-b429-4b232632a60a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e7ea120b-8b5e-48ec-b2f5-79f4189d3ec6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("bb7de537-c65b-4ace-82ec-31e7f39bdc4a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e88470fa-a811-453a-a9fd-537ad0b02315"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("51355fdf-ee3e-4f3c-be5f-696f424e0260"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e8a975cd-b35c-4cf0-8aad-81df582e738e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("fe4e7f9a-ab0c-43d6-9ab2-a41670d1937b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e9028ad5-ae3b-4f37-aab6-7c453e2b5aba"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("3beb3eea-9433-4df8-aa91-e30754df1190"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e90dda3f-4572-4e59-8c8e-47f2b82e8b5f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8e0dbf9a-3ad9-4c0a-99ac-a22d6c0dc0dc"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e92d37a4-ae52-4e3a-b59c-4a7d0b23e9ac"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("152db039-c629-4a50-9004-80d80999811c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ead1e12e-6ada-4242-8a2f-55b038b03b43"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("29813703-2d8d-44a9-b255-7e90f92a910e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("eb04c46c-2e5e-42e7-96fe-dd3991771a37"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0e816d9e-719e-43f2-a065-a51747e2c637"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("eb0dee41-1b11-4410-8d6e-4043f1ab4180"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("6a41648f-2da6-41d6-a60a-d2a4cf642d72"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("eb858d38-50a4-4197-9474-67e9be712a2f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("2c83c506-915a-4ba2-932d-44e74af62e10"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ec85df70-975e-46e9-98e2-c7daad75ce34"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("85c6f6a9-bde5-492a-842c-0b79bbc86ca6"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ec90cf93-fe68-4256-8e37-a1a400365e18"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("45b1c9cf-5756-4e73-85e8-bb30a4db8914"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ed1ee5c3-4e9e-4cc9-b2f5-52ebbba3ee17"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("4b107bb4-0b38-4f66-87f1-725a564c6768"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ed4abd34-490d-4f5d-b7d4-e880f82df3ac"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("8492cee7-0781-4d2b-9138-23e1b44e703f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ed84a1f1-40b9-4800-a462-8cb3329096db"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("bcf5f4f7-4f82-4b44-ae82-215c2c2f8433"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ed98186a-a1dc-46f5-bdcd-1e6ed1a1bb34"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5d85a22d-7f97-43dd-8aa5-89fa128c2e9b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("edc2cbe7-96f9-4e2d-b69e-89cfcc017f6f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("f81e8157-967a-4e95-9cf3-290a27ae73ff"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("eded6cbe-7a07-4fd1-bea8-73b541a061bb"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fc2600d5-30ec-4246-8596-3d421305f63b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("eec4f04c-5f59-4279-9a45-585c37030d02"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4b107bb4-0b38-4f66-87f1-725a564c6768"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("efbf8d67-b397-4ed5-81b9-56b8aa9e575e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("09fd853c-e3be-4415-a2f7-ef562542e684"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f068bb0d-48cd-4e71-83ab-3625040fda5b"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("aa3ce092-3163-46fa-99a6-1acf034ea265"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f084dab5-2d1c-4d3c-b8c3-b5cdbb524541"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("641b3c0f-5822-4cbc-b76d-a9f1ca8e2f56"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f0a8baf8-8ba4-4b56-bd08-1662c0c88841"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("876654d2-9ac2-439f-a9cd-7f0a9adc4b4c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("f1b7ecc7-4d63-4358-b314-03a02320b0bb"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("74e9395b-c031-45ad-9749-ae76fd120915"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f1c3fbeb-b29e-45e7-9f92-33f273d35723"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("517823df-9671-4fcb-8433-a86232f6718b"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f40e2b95-b4d2-498b-8068-7dc098ba82b4"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("2ab3e73f-ab99-4f4c-b959-41e40f10cbfe"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f4368bd5-db76-47f1-9607-a87cbc9f6e90"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("14493811-34db-4f57-948e-71386573967b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f4afc3ef-eb9f-436a-b39f-735c9cda55f3"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("46e2c10a-944a-4282-835b-e2af5a42c07e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f4b06894-acc6-4e39-ab60-0aa79616a10f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d8e13749-3531-427e-87c1-84f48b04fd35"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f4cd9751-7a9f-4897-a6e4-0d4cc0997b91"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("7887edd3-5fd3-47cc-ac6e-921ee2dab4c0"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f6242b21-e160-40c7-851b-336782cbeb47"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("4159555d-795a-4d8a-b55b-b8bac5a90f39"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f65ea576-7b84-486f-a4ec-07dc8858bf91"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("29403e39-eefe-4fb9-8d01-3519a7f6d131"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f6744334-48e0-4c8a-b983-e1029250f00e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7487cab4-5d39-4a47-bc85-5d9edf682538"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f6a47e0c-9120-44af-89a4-7a0011f22822"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("0321a7ca-b22b-455e-90b7-61b4344f2ef4"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f707e036-51db-480b-9897-decad744b286"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d1c53a7b-b506-42ae-bee3-db374f580a5e"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f77da57f-5f99-4a3e-99f1-3fe8749991f5"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("8aa134bf-acd0-4340-8619-88f0f58df241"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f855f41d-c5b6-4053-96e8-3e314c1b07ef"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("e59ec0fb-f4c0-4fa6-9f91-bcdbaf67e5f0"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f8df7522-a3fd-4ed2-b0b2-9c4d4e2b7836"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("5ac44bce-4372-4c88-a062-2b5424f6db7e"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f8f17939-9672-4fe8-b97e-71713930b10c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("f38f354e-2daf-4938-a7fc-070c1c7dc3d6"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f91ea76e-3d71-4e63-aed2-acf36df28d40"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("0d3fa4a3-2877-4e63-bcea-d743198d4fc1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f980441e-ab24-4263-b56b-f106c6835bc5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("509b5922-99ee-47a9-bd7b-f79b9d29975f"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("faa42f7b-74c9-40c0-8f8a-61994a8133a3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("78650d54-dec0-4c16-bab8-c8ce2b6d4325"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fb1abb04-401d-489b-a80d-b9ef8a284ddc"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("33fcbe37-6aff-4a34-8b39-3bc14d2827d8"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("fcf48108-67ee-4d54-9383-896ea65d61d7"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("91397e4a-50ec-47df-988c-17e7df1cad63"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fd48e589-ca3b-4944-939b-67e884ad47e9"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("141e8876-7e93-426b-8b10-6dd3b69354fe"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("fda86d11-5165-49ba-87f4-977bbea1488d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("fe4e7f9a-ab0c-43d6-9ab2-a41670d1937b"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fde81f2e-5830-4d62-990d-f24da737ce52"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("79b905ce-5753-47ce-848c-c26e82475c76"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("feac5496-4ea3-4f1e-9c38-91d24cb316c6"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("7a2d689b-fd97-427c-abcf-97eded8d5cf1"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fed58382-e22f-4a7b-9eb4-8cd038961df2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("02b288d9-4ac4-4cc3-8532-a92ad4daa733"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fee53c75-1dcc-4ab0-a42b-bd49c67840b1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("1f8255aa-42bb-499f-bb33-29513622e95a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ff02e615-e11d-4663-9c5e-4ff2197a5d0a"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d0b761d6-15f7-405f-b429-4b232632a60a"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ff328ddb-42f9-42f4-9ce5-eedf932e730d"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("619c4b3c-4845-4acc-b017-1898a1d9a987"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ff859e52-62fb-4706-be1a-6c59c3aa9c6f"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("1146bfb6-e479-48cf-83f9-d62814c58593"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ffb8f5cd-c9f6-4aff-9bc0-f2139ce090b8"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 22.5, "", null, new Guid("876654d2-9ac2-439f-a9cd-7f0a9adc4b4c"), new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ffb9a0c3-ef97-4120-8d0f-dd6709078e9c"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 9.0, "", null, new Guid("d3f6d266-645b-453e-8633-cd2bfe16340c"), new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "OverheadPositions",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadCompartmentId", "Sequence", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("037f5702-952a-4561-9cac-0733054b63a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("53da8a9f-ea90-4e6e-b379-98330f4b4cce"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("083dab0b-9204-4d55-a661-671f85c917a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8bf99391-a663-4a5b-9bbe-2b6a53348ec7"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0ade987f-a5b5-4956-abfa-f738625863d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("53da8a9f-ea90-4e6e-b379-98330f4b4cce"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("101b8520-62da-45ca-8061-86dd0310be93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5c24a79-1ae5-43dc-bad4-063466166be3"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("1626f889-b929-4143-a123-59868c8a1444"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e3b470fc-4099-4a97-9931-43ffab9aa014"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("16b0f9f6-f02b-400c-ac1a-da40a795ddbb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f740975-d048-4dc1-a82a-a599a5cc808c"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("1b2db5f8-2e18-41fd-ae48-7797e218e887"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f62f2d96-e8ed-4056-9c87-c9e05d460021"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("24b257da-371d-4414-a0d3-269d5983b01f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f62f2d96-e8ed-4056-9c87-c9e05d460021"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2665b086-7f1b-4b6d-bfed-0b4ad53bf9f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("598cb313-252f-4e44-bdad-8a4ba7ac0f7a"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("2676851a-7e5b-44bb-a09d-a38044795439"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5887fdd8-7a8d-4922-90f1-7d249beac12e"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "OverheadPositions",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadCompartmentId", "Sequence", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("2d0f359d-349c-41fd-a13e-23cee6a0a037"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1cad0800-a720-466a-9e1a-89a3671177e9"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("3bf13bbc-f129-4566-b0f4-65dbe3d1928c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("13f71c23-b599-402a-8a25-8a4fc0678fe7"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("449de4c9-1d51-4837-be33-2ced4638a0bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8bf99391-a663-4a5b-9bbe-2b6a53348ec7"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("44eb86ce-eef0-4b99-a1f4-5a2082df523c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("56d9f235-3a2b-416b-9694-96a0d5363dfa"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("464986e7-6ed2-4865-8e56-b5b0d9a0985b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5f866475-19d2-422b-8d89-4c6f083c0ee5"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("46cf07dc-2ccb-41c2-8690-e71b0a014be3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("70c09f4d-51b9-4a3e-a115-d0786ff61585"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("47760db8-ab55-46e7-9c68-3d29103ff32a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("598cb313-252f-4e44-bdad-8a4ba7ac0f7a"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("4b01a0c7-84a5-4e70-bc3a-cd0a94728b31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8a580aa1-3c17-4254-adf5-6a00f7684320"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("51e94b4f-30ab-480f-a9e4-e5b8d72dd445"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("16047f4a-e38b-4cf9-9245-8d1426198dbf"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5484e702-faf5-4498-b925-935816e57bb3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("56d9f235-3a2b-416b-9694-96a0d5363dfa"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("57240e2d-bfec-4e6e-9599-3123fd87445e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("62fe319a-6c39-40c6-a8aa-3381072fa3a4"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5e675598-0032-4a7c-9230-edeb63f0fb1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5887fdd8-7a8d-4922-90f1-7d249beac12e"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5ea2547c-9ac6-46d1-bd17-d7eddcb0ddfa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("502bb6dc-1f11-4cec-8fdf-f6fa144ef2b2"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("61c1d3b5-3ade-445d-b9ec-3d667e5bb344"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5c24a79-1ae5-43dc-bad4-063466166be3"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("628cb4fb-cfe4-4da3-8dac-2844c13a40f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e3b470fc-4099-4a97-9931-43ffab9aa014"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("659e2389-dda2-48a6-b9b5-148de4cfe248"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1cad0800-a720-466a-9e1a-89a3671177e9"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6e034fb8-bbb0-4ac4-b2b3-a12134d3e6f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1cad0800-a720-466a-9e1a-89a3671177e9"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("6e6b4716-910d-406c-9e22-bce662ff386c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("502bb6dc-1f11-4cec-8fdf-f6fa144ef2b2"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("70858fe4-d665-4db3-b28d-cff53959cb80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("70c09f4d-51b9-4a3e-a115-d0786ff61585"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("71f686f9-093a-4cd5-8c69-f5b24e6c8d34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("2516c270-a5d5-4551-9412-615c82902962"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7ad0bc5e-b615-422b-8362-1f9ad979534e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("197faf7f-feaa-40a6-b8b0-c414309f9719"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8a64a12a-9638-4c2e-a56b-67cc498cb0fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("197faf7f-feaa-40a6-b8b0-c414309f9719"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8ad1b933-077b-45cb-ae1c-1d2fe4b2937a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("16047f4a-e38b-4cf9-9245-8d1426198dbf"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("8ba036a7-1ccc-4daf-84c6-60e61721ba8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5dc8694-6ad7-469e-90e4-43e240d23504"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8feebf8a-edf4-4a80-9875-b13102d785c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("598cb313-252f-4e44-bdad-8a4ba7ac0f7a"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9366946c-f5b5-40d1-90f5-453917dbe77f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("939ae7a6-24f3-49a9-958f-19c3c18f7b9a"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("94fbc4fe-534a-4f60-b295-f01830405cfb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("939ae7a6-24f3-49a9-958f-19c3c18f7b9a"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("973d14cb-337e-4322-8cf6-879d1186b3c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("61785a51-43d7-471e-a5c1-1dc926f1078f"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9743b1fa-7fd0-4447-b5ed-d6fc509b6e74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f740975-d048-4dc1-a82a-a599a5cc808c"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("9867edcf-fba6-45e3-ad66-edc63c3cb525"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("2516c270-a5d5-4551-9412-615c82902962"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ac403c4b-aed9-43ff-9603-edeed4192453"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("13f71c23-b599-402a-8a25-8a4fc0678fe7"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ae7df75d-6fe8-41e3-a6e5-0b7897376137"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d5c24a79-1ae5-43dc-bad4-063466166be3"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b412e4be-d528-4025-af56-c040a7f48c2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("939ae7a6-24f3-49a9-958f-19c3c18f7b9a"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b5b27942-7477-427c-8fb3-7a27dd4ff11e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("62fe319a-6c39-40c6-a8aa-3381072fa3a4"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("b686cc54-b289-4261-9480-44efd8d7b9e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("61785a51-43d7-471e-a5c1-1dc926f1078f"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b9b49289-c5f3-4089-b044-7e3f7c19eb9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("502bb6dc-1f11-4cec-8fdf-f6fa144ef2b2"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ba1603b4-be00-433f-bd7c-7d91c15a9a06"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5f866475-19d2-422b-8d89-4c6f083c0ee5"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("ba645928-579c-44e2-bbb6-d00eb1c78dbd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("197faf7f-feaa-40a6-b8b0-c414309f9719"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bbf5d302-2431-4377-af04-63cb5bc2e56c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f62f2d96-e8ed-4056-9c87-c9e05d460021"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c51687d6-dd33-4e59-bf8e-dd0cabe46b83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("53da8a9f-ea90-4e6e-b379-98330f4b4cce"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c811e8b7-93ab-440f-8853-012ad1d19d47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("61785a51-43d7-471e-a5c1-1dc926f1078f"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c893ebaa-b08a-44b9-b788-a1644eb351c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5dc8694-6ad7-469e-90e4-43e240d23504"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });

            migrationBuilder.InsertData(
                table: "OverheadPositions",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadCompartmentId", "Sequence", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("cb31ef99-1dff-41b8-b694-f7f6aa14c34d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("62fe319a-6c39-40c6-a8aa-3381072fa3a4"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("cdae8346-47ab-49ed-9049-592ed0cc3e47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("16047f4a-e38b-4cf9-9245-8d1426198dbf"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d33275ec-c896-40c1-8bbf-ac41b47d87ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5887fdd8-7a8d-4922-90f1-7d249beac12e"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("d5d54210-6a7d-46aa-80e8-725b6b81426d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("2516c270-a5d5-4551-9412-615c82902962"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e22ef8ab-7527-4726-9b01-fdb58cd77649"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8a580aa1-3c17-4254-adf5-6a00f7684320"), (short)1, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e350aeb4-501b-4f07-bcb3-567dd8ad0ebc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8bf99391-a663-4a5b-9bbe-2b6a53348ec7"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e78bb52f-a51e-472a-bb35-c7dac0d71852"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e3b470fc-4099-4a97-9931-43ffab9aa014"), (short)1, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("eaaf32b4-c156-4eb1-8462-c3f48d217f27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8a580aa1-3c17-4254-adf5-6a00f7684320"), (short)3, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("eafaf570-849f-426c-91ea-095690abb398"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c5dc8694-6ad7-469e-90e4-43e240d23504"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("eeac924e-c74f-458e-b87b-76975ecb2ffd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7f740975-d048-4dc1-a82a-a599a5cc808c"), (short)2, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f53fced1-227a-4cc0-8ed6-a9d9f71358a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("70c09f4d-51b9-4a3e-a115-d0786ff61585"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("f7863d9b-adaa-4f81-9888-ed1f98249f38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("5f866475-19d2-422b-8d89-4c6f083c0ee5"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f95dc417-589b-4136-839f-2b7666e5722b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("13f71c23-b599-402a-8a25-8a4fc0678fe7"), (short)3, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fdecdb89-1064-422b-a235-f30eedcdf6f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("56d9f235-3a2b-416b-9694-96a0d5363dfa"), (short)2, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("043f779c-b78f-4704-9574-945fe62d8f6c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("24b257da-371d-4414-a0d3-269d5983b01f"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("06801116-2b8a-4b23-81eb-2eb3b69647cc"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("449de4c9-1d51-4837-be33-2ced4638a0bc"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0a3ab6b6-fa4c-473f-8394-323f6a80c55d"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("5ea2547c-9ac6-46d1-bd17-d7eddcb0ddfa"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("0ea0d4b3-e30f-40c1-878d-2e82ad6fa07a"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("5484e702-faf5-4498-b925-935816e57bb3"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("150a637f-ac20-4d57-a4ba-8fcfb8fd6e53"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("8ad1b933-077b-45cb-ae1c-1d2fe4b2937a"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("175b465b-3f79-4503-bf7c-3dcd5fa6f2df"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("61c1d3b5-3ade-445d-b9ec-3d667e5bb344"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("280dca93-4c5d-4db2-82fb-c54fc33e251f"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("c893ebaa-b08a-44b9-b788-a1644eb351c5"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("298c9b9a-b9d7-4553-ab7f-1482dfdcee84"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("083dab0b-9204-4d55-a661-671f85c917a9"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2c4b4976-b318-4224-975e-ec54e7b95fea"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("e22ef8ab-7527-4726-9b01-fdb58cd77649"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("2d26fa57-2cbb-4ef6-a531-84e5ae12f343"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("fdecdb89-1064-422b-a235-f30eedcdf6f8"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("31a413da-9299-4d78-bb46-b71040c99e59"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("9366946c-f5b5-40d1-90f5-453917dbe77f"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3283f14a-e444-4af3-ae45-80c25bc94517"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("464986e7-6ed2-4865-8e56-b5b0d9a0985b"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("346e3c4a-6d0a-420d-b7e8-7cc13f0bbfb5"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("3bf13bbc-f129-4566-b0f4-65dbe3d1928c"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("34cf4f8d-743c-441c-a010-103968149576"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("57240e2d-bfec-4e6e-9599-3123fd87445e"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("34e96c4a-283f-4e9b-ac59-b7e7fd01105e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("f53fced1-227a-4cc0-8ed6-a9d9f71358a2"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("3aef7c03-0ce9-4914-91b0-4abc2d1be147"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("6e034fb8-bbb0-4ac4-b2b3-a12134d3e6f5"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("41a28a9e-ebf1-438a-a539-22dd368f7bd1"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("ae7df75d-6fe8-41e3-a6e5-0b7897376137"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("41ece107-051e-42ab-a0e5-13be34927914"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("037f5702-952a-4561-9cac-0733054b63a7"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("480c923b-31f1-486d-9385-49b911e7555e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("4b01a0c7-84a5-4e70-bc3a-cd0a94728b31"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4dedf2c3-0a7a-485f-aabc-6a8d4534657f"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("7ad0bc5e-b615-422b-8362-1f9ad979534e"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("4edc7465-eb8c-42d5-a90e-c183d76d63d2"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("f95dc417-589b-4136-839f-2b7666e5722b"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("5171a4cb-652e-4fb0-8b36-5cfd49fed3b5"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("51e94b4f-30ab-480f-a9e4-e5b8d72dd445"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("5192a74d-8058-4853-b9e4-a8bdbb450200"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("d5d54210-6a7d-46aa-80e8-725b6b81426d"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("553fc76e-b58b-439a-a5ac-7625736ce64a"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("628cb4fb-cfe4-4da3-8dac-2844c13a40f3"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("59ba844e-1f69-44e6-b9a8-6512eae4402e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("973d14cb-337e-4322-8cf6-879d1186b3c6"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("62b8ee12-b5b3-4068-98bf-afa4fb47a71f"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("2d0f359d-349c-41fd-a13e-23cee6a0a037"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("64f75796-37f8-4c51-aabf-3c14d73e5d14"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("ba645928-579c-44e2-bbb6-d00eb1c78dbd"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6ccf7aee-bac9-4d01-8e01-1d9b6f40d3c3"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("b9b49289-c5f3-4089-b044-7e3f7c19eb9d"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6cda4d88-741a-4408-a4f9-db5390566118"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("b686cc54-b289-4261-9480-44efd8d7b9e9"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("6d14e79c-4c81-404a-8e67-f6f49fb47be4"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("659e2389-dda2-48a6-b9b5-148de4cfe248"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7a33bd1c-39da-4f22-a8d3-79564fbc0873"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("9867edcf-fba6-45e3-ad66-edc63c3cb525"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7ea276cf-be77-463b-8470-204294223242"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("44eb86ce-eef0-4b99-a1f4-5a2082df523c"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7ecf0ba9-d712-443b-b390-9d96e224b2d2"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("8feebf8a-edf4-4a80-9875-b13102d785c5"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("7f3af58f-f301-45a8-997a-b1206966b927"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("101b8520-62da-45ca-8061-86dd0310be93"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("7f8e271d-8494-459b-bcfb-95e12ab02278"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("b412e4be-d528-4025-af56-c040a7f48c2f"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("80f43205-5c1d-4990-b0bb-18321cf66443"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("c51687d6-dd33-4e59-bf8e-dd0cabe46b83"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("871365ee-a1cd-4f1d-8e34-86739806441b"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("ba1603b4-be00-433f-bd7c-7d91c15a9a06"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("8fe22cb1-6dbb-471a-b245-12f7ac84464e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("2665b086-7f1b-4b6d-bfed-0b4ad53bf9f1"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("906bc1b4-4b9b-4c34-aca7-4bf0167ada61"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("eafaf570-849f-426c-91ea-095690abb398"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("906f78c2-004c-4214-9980-44275cb281b4"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("b5b27942-7477-427c-8fb3-7a27dd4ff11e"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("968fe036-a09f-4145-8f6c-b86954347f9d"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("eaaf32b4-c156-4eb1-8462-c3f48d217f27"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("992434b9-fd5a-417f-bca9-d823e49beb38"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("94fbc4fe-534a-4f60-b295-f01830405cfb"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") }
                });

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "CargoPositionType", "Created", "CreatedBy", "CurrentWeight", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "MaxWeight", "Name", "OverheadPositionId", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("99794fb6-6c4b-4d67-bb13-d2314c4956c1"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("f53fced1-227a-4cc0-8ed6-a9d9f71358a2"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("9f325fa3-7e0f-463b-86e2-9cc9902ebf43"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("16b0f9f6-f02b-400c-ac1a-da40a795ddbb"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a4a29df0-4ad4-4054-a847-af258b2282cb"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("c811e8b7-93ab-440f-8853-012ad1d19d47"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("a562303c-1846-4fe5-99ff-f551d1e8f44a"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("6e6b4716-910d-406c-9e22-bce662ff386c"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a6bf6a44-52c6-4f08-80cf-0c8fc316058e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("9743b1fa-7fd0-4447-b5ed-d6fc509b6e74"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("a761f3c0-6374-4f3a-9107-20e0a7a49794"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("e350aeb4-501b-4f07-bcb3-567dd8ad0ebc"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("ad25dfce-d12c-439d-9e29-00ae36eb4348"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("5e675598-0032-4a7c-9230-edeb63f0fb1d"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b47464d7-455b-4eaf-b9b0-30f6cfc67fa9"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("2676851a-7e5b-44bb-a09d-a38044795439"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("b5320e1b-15f6-406d-81eb-0b7dbbeed356"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("70858fe4-d665-4db3-b28d-cff53959cb80"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("bdf97911-3da8-492d-a81d-93acc6d0ce91"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("d33275ec-c896-40c1-8bbf-ac41b47d87ce"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("c61e7f0b-1b1b-4499-88a2-de9db60960fd"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("ac403c4b-aed9-43ff-9603-edeed4192453"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("c7bf454c-a5f6-4ea5-8f1a-cc6aab5ca112"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("47760db8-ab55-46e7-9c68-3d29103ff32a"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("cda2f90d-41ec-4ce8-8ab2-6d25061c0ed4"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("bbf5d302-2431-4377-af04-63cb5bc2e56c"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d64f0173-d2a9-4d7a-b344-a75fcd2f1d30"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("1b2db5f8-2e18-41fd-ae48-7797e218e887"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d8be4187-1ceb-47f3-b104-77e886320870"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("1626f889-b929-4143-a123-59868c8a1444"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("d99d223e-5a2e-4415-a5e0-52544adb6bf3"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("8a64a12a-9638-4c2e-a56b-67cc498cb0fb"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("dacec1cb-6254-4f39-a5b8-6b7999eeaefd"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("cdae8346-47ab-49ed-9049-592ed0cc3e47"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("dde04766-c917-446d-89b1-9a14cbcb7874"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("cb31ef99-1dff-41b8-b694-f7f6aa14c34d"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("de6c8b5f-b0b8-4416-902c-bbc5e8defd2f"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("71f686f9-093a-4cd5-8c69-f5b24e6c8d34"), null, new Guid("19674c0d-278d-4951-a0ee-f672075af1d8") },
                    { new Guid("e16451a1-82fa-48c8-a6ac-c1219623d58c"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("e78bb52f-a51e-472a-bb35-c7dac0d71852"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e16e78d5-d15e-47d5-948d-0a33197d1366"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("0ade987f-a5b5-4956-abfa-f738625863d5"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("e55e91b2-be54-413e-91dd-889d779c9f7f"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("f7863d9b-adaa-4f81-9888-ed1f98249f38"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("f1439edd-ee18-4c12-8995-4b0de11fd791"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("8ba036a7-1ccc-4daf-84c6-60e61721ba8b"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") },
                    { new Guid("fd51b5b1-ec00-4173-8893-027bdb558f9e"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 8.0, "", new Guid("eeac924e-c74f-458e-b87b-76975ecb2ffd"), null, new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("00319784-234d-4020-977b-69adc9274b42"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("00b3c3b6-fcbe-477f-ac1d-222d1c9e4042"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("01155f33-50c7-4b3a-9da2-3cf9a29ddc89"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0163ac9f-a352-48a2-9417-4dd44b959018"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("022782ca-ec50-4a59-a36e-26b8f6343f7c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("02fb4c0c-a321-4676-9dfe-c1b9f2f0dec2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("031d479f-62ee-4894-878e-6c6480744550"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("03af8162-25dd-413a-968c-821600dd9191"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("043f779c-b78f-4704-9574-945fe62d8f6c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("04726cae-9058-4b51-830d-374baa3872ae"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("04b78845-a650-4ed5-818b-477b78b7541b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("05283ba6-68ae-4802-acee-ca4fdc084250"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("05ccca39-256b-476b-8529-34412eea8b67"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("05d54959-a1da-4c7d-8fce-9a3fe7aeb22e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("05f88fbc-1f06-48d6-8b0f-9b9a0643e55b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("06801116-2b8a-4b23-81eb-2eb3b69647cc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("06afd40b-c7b6-4732-984f-f196d3eef224"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0748b3d5-6b0e-4f3c-98b1-7a3124166250"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0772e051-9ff4-4235-9a30-572525e034c9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("07c15fd0-f8d9-48ff-a56b-41434b78f4f5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("084686d1-25b7-4008-8503-f6a63a66f8db"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("085472f4-904d-484c-ae05-21d1d3bc986e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("08f15385-a8da-4f19-9a8f-b1c35df2ee61"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("09aa9b27-eb31-4116-bb2c-4f2ebaf8d3fd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("09f724b9-7b75-4b41-85f9-2da971aa453a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0a0c0a68-a560-4541-bc81-0a992d180cb7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0a3ab6b6-fa4c-473f-8394-323f6a80c55d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0a524365-30b9-47e2-af2d-5c25d747862e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0a5fd51b-2b21-4658-ad62-c4e75de8c27c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0ae1faef-7ffd-440c-ba83-f3787752e1d9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0b0e40d2-7ee0-4113-80f3-284a4cee4041"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0b181c2c-b7a1-4803-8c9c-e495ed965394"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0c6193f2-f8d6-4271-9b81-4fa17ca2e323"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0c687b95-1924-494a-8329-16f551318af6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0c9781ef-f98d-4d6a-a117-9ebda27215e0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0daa2b4c-2d4c-43ab-add6-5ca91ec7c964"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0e603572-8468-4f32-937d-5b48b873883e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0ea0d4b3-e30f-40c1-878d-2e82ad6fa07a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0ed5e9f0-168d-4db3-bb37-64dda6d68e1d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0eefac88-3cbd-48f1-be75-73e802f40669"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("102026e5-6bb1-4013-a6a2-95e80aac992d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("107774d7-6a1d-4ee8-8f65-df57f016030d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("10b23f69-1f84-4366-9a7b-4ad0525c4707"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("10c040bb-e415-448b-bc74-8734a81dbfc4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("11487813-edce-473e-8958-022476f3f9bf"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1197f533-8a10-4a3b-bdf9-bd203071ec53"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("11ba30b4-d247-4189-b657-a03492afcd1b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1261032d-d4d4-45e8-b6f8-efdeccd4d555"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("12632b8f-b195-49a8-af30-9ef60cb42785"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1279b19a-6239-4489-b804-9cf0f7b2a0ea"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("132c21ab-f2d2-4dee-9b01-3441ae01c2de"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("145f96a0-2c35-4c56-995b-a2cfc1ce3f2d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("150a637f-ac20-4d57-a4ba-8fcfb8fd6e53"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("15113540-2f54-48a7-8f2f-b17e5c897bee"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1513c90f-ca08-4fb4-af58-11063fd1fc0b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("158b1402-985e-49d6-9c82-cdc1e728c4f5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("15c9023e-a3c5-4838-b14a-129cbb7d45ef"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("16108ee7-b0b1-4d19-8367-75a8f4d85b13"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("168aa32c-0543-46b7-b4ea-aaa4f67e385e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("16934160-e707-446b-9713-aa3d1a23f2a1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("16a08e0c-7dcf-495e-bae7-00bbe51b1c8a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("16ce2a46-88df-41d0-8092-6b6b07628a02"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("17304db2-dd01-4252-8514-722f3d823778"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1758056f-19bf-4b34-b3df-4a8e64ed9aa6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("175b465b-3f79-4503-bf7c-3dcd5fa6f2df"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("187dbb94-de71-45c9-9e6d-53883868f760"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("18c2b5ad-bfe5-4fb9-bb96-0c9aa6cb22fe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("18c79d15-7b6b-4fbd-8bdb-f0b232873ec8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("18d424fa-72cf-4b24-acca-39ada6497ca8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("19a27dd8-31c3-428b-b231-e2cf31d1b2e1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("19ceb901-b967-43ce-bb73-1ab257ed2f32"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1a6bbdb5-1a96-42fa-8854-c01ba3531f6c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1ab0b928-1315-4be1-a678-a8aca1638fb4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1b3fd643-d4e0-4b1d-898f-4e788a3e6bf8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1b782ae5-caaa-48fe-8184-ea9e16c9fda0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1b8dc72d-dde5-4dce-9664-eaf0455f500e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1bed73fb-2577-4676-b5a6-2d49384d88eb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1c14a794-695f-4bd8-bc2f-73fc0196b077"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1ca28d53-67f1-4d6a-8dde-e7297a0f71a5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1cf70cfe-02a7-4a58-9bab-f050d7fa8aba"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1d171b52-ff02-46d1-a33e-7ad0e50094af"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1dce207c-b04a-4685-8c20-32ce53d27a3f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1dee2599-29bb-4354-a2ce-a24ade892687"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1e328574-3d73-4ae0-958d-8458aed83878"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1e7f5661-cf96-425d-9eeb-cc5bf4ff0d00"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1f523f1e-437e-4717-a6f3-d55fb937f2a3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1f8e8627-5a6c-4bf4-94fb-70932c7f9ac9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("1fe292aa-9de5-46fb-be06-f6bae03ea670"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2101c2ac-6a24-42ec-8882-b54570e8c7e2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("213f7961-64f8-4b72-b28d-8feb8eea3100"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2216247b-01fb-48ca-b366-0846f41c1714"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("225bd847-ce1f-4a88-89d7-add5532cf81d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("228830ee-ede5-4553-880e-c5b1ad7db204"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("22d0bb87-efd7-49ed-963a-d59f519d8441"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2343b53a-f314-423f-91b9-ca7ba489d62f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("23808c29-ac1c-4901-b01e-c5b10c2696b2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("23fdad5e-cb50-42c8-ade2-38c1208f97f8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("24b4d5e6-cf9a-4fb9-9941-5e050f83d8df"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("25c86af6-bd34-448e-8031-e64ba1edde96"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("27f64b3f-543d-4f4b-9d9b-2515482aa441"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("280dca93-4c5d-4db2-82fb-c54fc33e251f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("28a3abb0-0086-4756-9dcf-1561b51f54b2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("28c17f68-12bb-4825-8297-b7ee6738b553"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2989cd56-6dc1-4195-8bde-7dced854a690"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("298c9b9a-b9d7-4553-ab7f-1482dfdcee84"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("29b0d94e-994c-4690-8b6a-faed82457be8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2aaf73a7-46d0-420d-8bd2-981c627ac80c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2ae94709-b9e8-48c5-8bc6-7a4b0d143a64"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2c4b4976-b318-4224-975e-ec54e7b95fea"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d0cae80-9cbc-4ec7-b27d-6f738a196909"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d26fa57-2cbb-4ef6-a531-84e5ae12f343"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d330108-01ed-4703-a990-0c2d28916287"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d73d064-29d3-47eb-91e4-d3bb58f3451f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2dde101b-e5b6-4e1f-a775-71f7fd5fdd7d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2e616bcd-40a7-421a-b3e7-f3a083e1cabb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2f5821d0-453f-4fdb-8140-213287f7f358"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("2fd94100-6a1a-458b-8384-69cc3b482bd4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("304c3eba-9107-4cd0-8ba7-27512d1a3836"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("30b1b5ed-109a-4d77-a33d-2c07e354fbff"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("31a413da-9299-4d78-bb46-b71040c99e59"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("31b5ee64-18e0-4930-b725-cf662b580ac4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("31d18bd1-e011-4539-bc3d-dde6ba32c731"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3208adb4-5ec1-4345-b0f0-64d5d6941100"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3283f14a-e444-4af3-ae45-80c25bc94517"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("32a3fa42-481d-432f-abd8-487eef0153d8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("32c8cc5e-4b84-4108-9876-4b2553268748"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("32eb6b8c-d06d-4e05-a643-6da64dea3361"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3423bb1e-263b-4c48-912b-3ec71b1278d6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("34694942-6baf-4c85-91cb-b4da47574847"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("346e3c4a-6d0a-420d-b7e8-7cc13f0bbfb5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("34cf4f8d-743c-441c-a010-103968149576"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("34e96c4a-283f-4e9b-ac59-b7e7fd01105e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3609818b-fd95-47cc-a400-52d68cd3ff17"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("363ecfa0-3567-4c87-83a6-6b03a4bf6f47"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("365fcc2c-da11-4a5b-9300-1aa902ddfdbe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("36696a7e-fd56-409c-8567-26af61f1e67f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("36af575d-403d-4419-b30f-023ccfc72a0f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("36ff6fb6-56f9-4c88-83c9-60d6fa5e8e50"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("37407483-8a6c-484a-9c5e-8488fbdec830"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("375e55e3-bc11-4cd5-b100-e5db86ca8703"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("37d898f2-746e-476d-9adc-6170c648f4b2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("380bd5f0-aeff-45cf-b9f9-aaf39fca156f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3816d767-f5b4-4b6c-a28a-f5d6171cb396"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("391c23f8-5df9-455c-b045-c7fc8c68353b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("39993d27-08f2-4275-8714-ade94880f8ab"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3a045def-1a17-4a49-bfa5-9fd425787258"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3aef7c03-0ce9-4914-91b0-4abc2d1be147"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3b8d9dee-7d07-44dc-a867-49e424a4ed5c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3c0f8977-a14c-42c8-af81-55972ba4f405"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3c3641e2-e27a-4a1e-bc3e-fb4a4c7d81f3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3d2da133-5d53-4e4d-9a2c-13860ae9d64b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3d5b9371-11d0-4466-9e69-cfab25bf431b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3e610fff-dfe1-4f6c-ad6b-277cb338673e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3ea6c9ae-8667-4287-b017-dc009a18ddf1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3ec52b3f-e75a-43d8-bb8f-07a8e1206701"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3ecc8f5b-e907-4a99-9670-67928e175e0d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3f489026-bc28-4704-a576-e82ebf8a8a6e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("3f64bb91-7f07-41c2-b14b-19415d39d691"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("402c60a9-2779-4f3b-bf74-0dba1fa139ee"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("40743224-aa3e-4370-80f8-bf61315f1e98"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4111cdd1-4ab7-42fa-83d6-fe5a69cadc4c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("41a28a9e-ebf1-438a-a539-22dd368f7bd1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("41ece107-051e-42ab-a0e5-13be34927914"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("420c8e12-d6a2-4b9c-b45e-71f080a6736f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("42194f76-6f6f-43cb-a5db-590cc4d82573"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("42c61e02-c0b9-4052-a10b-5c9ef05ef728"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("431029f7-ac52-40c9-bd1e-03042e3121f7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("43c727ed-dbac-472a-b6fa-774d868b4294"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("442a47d8-3a96-4a9d-9ae5-52603c333e91"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("442e8742-d785-4b44-8375-a7b6b1e5910f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("450c389e-9949-4dd9-9be6-85396e2dc278"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("457e165a-1a33-4848-b8f0-c54d97eec6d2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("45f9fb46-cc74-4e40-9ee2-99ed13199013"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("462672a7-75a9-43e9-a1a6-55f080f9ca83"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4686977b-5d28-44cc-94b2-f1be9ce94d4b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("480c923b-31f1-486d-9385-49b911e7555e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("48837c51-c590-4f48-b63c-9f1ffc13d45a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("48ff1ced-0ae9-4279-8b61-9e541ca7883b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("49f5c508-edc8-492c-a073-0cb14883a410"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4a00a794-5c3e-4788-a0dd-c4fe4c4c5b7d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4a0d5ff4-3820-43ad-b344-771df42db336"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4a3b7388-6734-4ef9-bcd1-7c48e47de3da"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4b3a2e57-f166-48db-9c90-2ee5e04daafd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4c5e9cfb-6c52-49b1-acdf-3f7c0ef434fc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4c67bdec-a844-4b37-a94c-a301255ccc0d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4c74b93f-1b2e-46e3-a20e-9c6e378530e1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4cbb99c5-e6d6-4a79-b263-1d097cd8fa82"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4cf6cc19-b8cf-49ae-bc06-8e935c50d438"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4d03cb74-b582-40a2-b55a-b12d733f4fed"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4d33c50b-fb29-486b-ab1f-6e78edae2fac"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4dedf2c3-0a7a-485f-aabc-6a8d4534657f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4e4bfb2e-a3b3-46bb-a00e-5cd2d1b61da5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4e65cdc1-ad7c-4db9-9eb5-4b56b959be80"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4e9bdbb9-3ff6-4f0b-be57-c9f06ff87804"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4ea0c8f4-f8cf-442a-a34e-1cfa96b50b2b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4edc7465-eb8c-42d5-a90e-c183d76d63d2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4fe96b99-bc39-41e2-99c3-fb910119b1a4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4febdc4c-9568-4fab-ac17-97e45c5f5da5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5171a4cb-652e-4fb0-8b36-5cfd49fed3b5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5192a74d-8058-4853-b9e4-a8bdbb450200"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("526f0e3a-1cae-4170-8e2d-1de90e34eacf"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("528aa9b7-4aee-4d09-b47a-64589b381122"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5295dd0c-a6db-432b-b90a-f35e110a3c10"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("52e79363-9835-48f1-98ad-692faa1e6fb9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("53882823-0837-4348-b9c2-f5b46b72b27f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("53cab1e2-a8f7-44dc-b579-8e2bb2876321"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("53ecdde0-ff56-44c3-8ecb-dea4e657fcdd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("553fc76e-b58b-439a-a5ac-7625736ce64a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("564d9ea1-2a56-4cc9-b5c1-565f7fe14134"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("571cf2ae-68bf-4f64-a3be-7528f328a777"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("577671d2-ca18-4686-a38d-be7c1af6b45d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("57e235f5-71b5-403d-bf33-c0ff5d92a6e6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("587b4740-5b59-4ad3-941b-90f3e704891a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("58d23130-17dc-4104-9955-311eb1ed4c62"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5954e9d8-85a2-4f3f-8e8f-20ead6b69c52"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("59ba844e-1f69-44e6-b9a8-6512eae4402e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("59dad6ae-335c-4e40-bdda-8bee9f1b3870"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5a344b01-ee64-4ea7-a96f-1b2e6dae2958"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5a573e1e-f093-4c1e-8f90-621440a9dfea"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5a8bf9f9-b396-48e4-95ff-40cefdb73bda"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5adbbde1-7e41-4b9d-b958-020b30c11da0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5afbb5d7-fac5-4dce-b4ee-92cc93286054"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5c2eb7fb-0217-45f6-a44e-43736601753e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5c3bc08b-efe0-450a-b0dd-360db5c59e59"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5c842462-f5ce-4d81-b33f-45415a30ec7d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5cb72d7b-3c15-466a-ac45-217a84d2b9b0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5d44f027-0cc1-43bf-aaba-b1510d9875ef"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5dec2af3-6ca6-461e-bab1-bc68f84e1df6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5e09f17a-7a74-4a9f-9a71-35e7e1ab3766"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5e76eb63-bb1d-4ef7-adbd-06c2047cd0de"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5f007064-2d06-41a7-9d22-06ed1aa1428c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("60989b3b-db29-4831-aae4-a35e3efaca54"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("60e40665-8d43-43f4-9134-2f2a97fe2ab6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("62b8ee12-b5b3-4068-98bf-afa4fb47a71f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("62f19468-0e5c-4ddf-ac74-cce5f58c4f9d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("63ec2a0b-7d91-4f67-9da8-c312a930a055"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("64b36eed-33cf-4669-8188-af84244d6f06"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("64f75796-37f8-4c51-aabf-3c14d73e5d14"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("652ae705-fe93-432c-a34b-1951b9b14190"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("663146eb-55d5-4dec-8360-ef93371bd33f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6674e6c3-fb66-4317-a9e9-267ec6714c7a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("669a3cc3-975e-4ced-bb6a-c399c0a9e39a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("66d3171d-6f3a-41ea-95c2-aa9e0d36a3b8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("66e266d4-0e30-4c5a-8d83-be7ddca184ce"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("66f346cc-b358-4671-a04e-633d458dc056"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("676d86db-a7d6-495c-a264-a8ad5dd249e1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("689faab0-16c3-4ad3-b876-d1d6c9cc6857"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("68b28e38-4d8c-43ec-875b-54d16398f92c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("68f5a0d8-4779-44cd-9e01-82ff7fb0c9f4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("69364b67-636a-436b-b89e-0da31f98b023"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("693e13ba-0f42-4b2c-8fc0-bc4bb0e35c18"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("69a8501d-6756-4025-896d-bfa94ff88d0f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("69ba754d-673b-45fe-b9f7-49a808df93ff"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6a2985bf-9c5a-48cb-9b52-978aa93393c0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6ab9b921-44e4-47cc-8e65-67a5c668d434"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6b7a341c-2050-400d-8f4d-3499320b9ac8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6bd95761-294b-4ea2-a8be-5ae63a404dc3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6bfec239-8b99-4b39-9d1a-0961eedab577"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6c60d98f-08e9-4979-9c1a-70887e953dca"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6ccf7aee-bac9-4d01-8e01-1d9b6f40d3c3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6cda4d88-741a-4408-a4f9-db5390566118"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6d14e79c-4c81-404a-8e67-f6f49fb47be4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6d47acc3-ff72-45f7-9378-fd6c5f0cd97a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6d9c4176-c327-419a-91bc-4d96e372a19a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6dbd6695-aaa0-4d9b-9694-f8d94b17f43e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6dd6a125-cf80-4196-89a1-1366aa26af66"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6e3c9bef-4788-449e-8f88-f453e3809f12"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6f1c1671-e13d-4f32-8465-3ee27f248458"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6f39f236-09cf-416e-b643-640ee830e4e8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6f9e643d-ef96-44a0-b192-8fe26779b09b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7007162f-a2cd-4ee7-8883-742cb17ae25c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7085ef6c-a29e-447f-a542-7ae7bcdb0911"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("708daa14-eac0-42fe-b111-dce1e44b5f93"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("715be527-b9d8-43a8-8909-a187927ec155"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("71a8b765-7902-4d51-9bde-e22a1e405db6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7210d959-3bdd-4dea-a03e-a0c4759504fa"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("72745f3e-51c2-472e-861d-a6b5cb4eb6a1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("727be5be-ea91-44c9-9b29-5878ecc7bdc3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("73062a3e-4603-42b8-91eb-5aac819b1c40"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7395556e-7097-4e6f-ad41-e59fdbff4365"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("74102b6e-0877-4a6b-bc54-b377fef7152f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("749f2d84-0a54-4445-b1b7-c34af7e1d122"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("74c73cec-e58e-4cfe-964e-6a682887f1fe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("75152c3d-e38d-4d64-ba6e-26e7d54901e4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("75242ea7-50cf-45bf-956a-f10dc590b5fa"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("757b01c5-a4f5-46dc-88b0-84fd54b569b5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("764316ee-3691-4de9-bebb-515b26c6bcca"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("766f5d44-272d-40a5-a613-d2d49b6c60f2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("76a28032-67cc-462b-a450-0cba3e5cae2d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("76b94685-1c11-4d88-a97a-c17f0bdc05a2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("76d39328-1725-4c62-b3a6-ba03018fb3ea"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7756913d-e53e-4ee0-a5ad-2fd465014a2d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("79367e85-f303-4f3e-8614-d67d72acad9b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7a33bd1c-39da-4f22-a8d3-79564fbc0873"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7a34e0b2-bc0a-4b77-b594-036a6e49735f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7adc96cc-6a03-417c-8af8-caffcbf06477"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7b176457-7745-490c-951c-8fcfb559c0eb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7b4172c2-6467-42ad-b53c-b56c50d62862"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7b907bd5-accf-4f70-82bf-4c4e7ad6340d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7bcff82c-0049-4ad1-942c-73121dfea769"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7c2ebbe2-ea8d-4cdd-b22c-c2cac408ae18"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7c43c4fd-8759-450f-961f-1051f98aa277"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7c66864f-fa19-41b9-b716-f78983dfd8f7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7c79fc82-29d8-4c98-acff-89c9460dcdfe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7c91e69e-74b0-4a4c-822a-dd173cb5ec23"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7c9dcd45-1c79-45c3-ba80-e3afd7db1cbd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7cde397c-0d90-4e4d-b817-ad64bbc5f41f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7d761a5f-2912-42b3-856f-7d986704ee12"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7e1a9597-a5a7-4436-ae7e-4f41f1685663"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7ea276cf-be77-463b-8470-204294223242"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7ecf0ba9-d712-443b-b390-9d96e224b2d2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7f3af58f-f301-45a8-997a-b1206966b927"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7f76f550-aa98-466f-9e3b-1429ac0da50d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7f8e271d-8494-459b-bcfb-95e12ab02278"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7fa7608d-8c16-45da-8b8c-842385d5f49a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7ff1cb9f-ac9b-470b-a77c-50caad9fedf1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("80166a8b-eb5c-401a-8c69-71f1a4e9fd20"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("803fb666-0f70-4651-9d08-6c639d04a515"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("806a70a6-af47-41cf-9d3e-f9ee137f4bac"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8072bab4-5880-492e-9359-1cde85190d8e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("80f43205-5c1d-4990-b0bb-18321cf66443"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8106fc32-ab29-4796-a87b-5c03a8713d1f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("81c8bb4d-5113-47b9-af20-13e6a245420f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8309e6f0-9ab1-49e2-99fe-a260f5d9853a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("83697aa6-abde-4212-bc62-d02e00b5e3cf"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("83802ac7-57fb-42e2-bb5a-cd59d0f02f09"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("83ad97c8-c9cf-4531-9bac-a6ac49a62974"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("83cfc65d-a64a-4795-b75e-36b7b81f503f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("840d366f-9c21-4c58-a261-f4bd4d4c0a6e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("845b9d87-e526-4dee-a9c4-9dab35aecebe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("84e295be-7315-4e42-a914-d4525d0a6a96"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("85fb2d4e-ba81-4692-b6ef-6a56a48714b4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("865d7e8f-bcb0-4fda-ac79-902d538edb46"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("86a8169e-3090-4249-b126-5dc2c0590d2d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("86ec756d-a3e4-46a1-a3e6-c62297f549c2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("871365ee-a1cd-4f1d-8e34-86739806441b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("88a0fc16-328f-456c-b9a9-38626bd78d36"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("88de7594-836d-4896-82c9-2645cd917d61"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8926f54c-a62b-4331-b81c-007f9c1b18b9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("896060f0-1b9c-4184-a26c-628e09feea6b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("89e127a8-1ea0-44e2-b22a-187152ba5d54"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8a21c280-1641-4e74-ab72-4dcf38dd4d6c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8a746469-fc36-49fe-a7c7-d34141ae9d4d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8a7c40ab-bdcd-4597-9ca8-45ab129608d6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ab07ab0-ca2c-4493-896e-7a5ce72c0792"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ada472e-9d20-409c-8df3-dae5c1874e4b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8b1a8e47-da3b-4ca6-b52c-e929c221cb62"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8c16a1ae-2f89-48bd-90ac-c0347e23ee6c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8c2103d4-a6ab-4ecc-86fe-1706452c2d33"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8c54c308-e5de-4f4b-8070-86a287756d48"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ce48bfb-abff-4c79-9262-4f814a97b9d3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ce74bbe-9e1d-4ddb-bc63-40654b1ae249"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8db96a6b-15cb-403a-9ee7-f92be05be107"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8e88d38a-4f99-42fc-a4dd-761e53febb3d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ea54c9a-9c1c-41fc-af42-f8f05676f165"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8f342d84-2da8-4e18-b8ca-dcbafd428731"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8f35376f-ed5b-436b-9063-e6402b6fb58f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8fcaebe2-dc9e-4df1-b450-d457493a58d3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("8fe22cb1-6dbb-471a-b245-12f7ac84464e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("902de982-dc44-478f-aae9-b42dbe9bb023"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("906bc1b4-4b9b-4c34-aca7-4bf0167ada61"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("906f78c2-004c-4214-9980-44275cb281b4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("919968f2-b57d-4297-ade2-f6015c1392c5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9236b8c0-eb83-421d-add5-8b3dae0e8ce0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9236e1bc-11b8-4380-92a5-d58456c369f7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("92a48de1-179c-4eb9-aa65-7f3beb696e31"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("93de0849-91b3-496b-9630-b86d8efd5176"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("93ecceca-9ebc-40e1-a089-cf013b0fdade"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("93fa9a21-efc4-4167-96f9-79be1adb6cce"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("94e7684c-27b7-463b-9bfa-09c3cec33ac5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9559e069-2432-4a09-bc9a-27d05229b071"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("95877666-0b9a-4e6f-a2e6-9ef068dfecf3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("95ad9edb-fc13-456a-89e1-24dd0cb33d16"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("96157e41-bcbf-465d-8f5e-9cc7cc596f4c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("968fe036-a09f-4145-8f6c-b86954347f9d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("96b31f27-592b-40f3-a2a9-19bc4a7db566"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9776bb04-15a6-4a8c-b762-724e955ffdbe"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("97bdaf8b-995f-4b4e-9c4d-c24c942a7cf3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("97c72461-b300-4af2-aa41-7e50c951f60b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("97d6c53a-2473-4936-8cac-ed50bdf228ca"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("98757e1f-9a27-432b-91ae-fd32d75b3fe7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("98b69318-3248-4c17-a574-cf567f530670"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("98c40669-cfcb-44fa-97a2-4490c4bf8741"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("98d20acc-c953-46b9-8590-9d8887fd127f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("991e428d-e4ea-4d94-a019-05e944dc4f47"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("992434b9-fd5a-417f-bca9-d823e49beb38"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("99794fb6-6c4b-4d67-bb13-d2314c4956c1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9a16ff84-3710-4dd1-b0d5-69b4f945df73"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9b72121d-ee3a-4f6c-963c-5f794d78bb1c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9c3ea3e2-18ce-4a24-8380-7df60b4fe045"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9c73b8bf-c32d-4fb3-8b5c-dec686035f0c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9da9c9a4-caa5-485a-9c0b-945cb12871be"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9eebcb6c-5f30-4d41-963d-0107cb8fe616"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9f325fa3-7e0f-463b-86e2-9cc9902ebf43"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("9f7a3f9c-4ea5-4ba5-b8a9-9bcbfcf79186"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a04bb606-4cae-4720-95de-f16c0abb82d6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a0c672b2-369f-410a-ad96-91312e3221ed"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a2050eb9-608d-403e-8dca-38029e1edbea"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a214dd8c-3f4b-4a22-b7f3-8ec2c760c201"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a311e538-9692-44a5-a1b4-4f8794c934e7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a3b7afce-04e5-4c40-9a42-35d80387f9e5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a436dc63-6fb2-492d-a26b-f52a768ece8c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a45bd51d-12b4-4116-b10b-d5ed559df1f0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a4629dd3-c70d-4657-a01b-b3dd2130a544"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a4a29df0-4ad4-4054-a847-af258b2282cb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a4dc9d6d-919e-44bc-b584-920afc011a4c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a562303c-1846-4fe5-99ff-f551d1e8f44a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a599378e-07b8-417e-af0b-9d6d654bc8e1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a5bdfbec-c45b-4591-a7c2-747f1ee74391"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a6bf6a44-52c6-4f08-80cf-0c8fc316058e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a761f3c0-6374-4f3a-9107-20e0a7a49794"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a8b755a5-a8e0-4610-baad-d11bc23d1e15"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("a949246d-c4f8-4951-bcc2-14d9997033ea"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("aa40d10e-0819-4109-99cd-19594d7d9d42"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ab0b3efb-4523-47c9-988e-0f9a44044b44"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("acc32560-5f49-430f-9132-9ae5b6d1f68a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ad25dfce-d12c-439d-9e29-00ae36eb4348"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ad3205a1-3eb8-483f-a185-9bc3fdefa897"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("adc334cb-add9-43fe-838d-366e0cd6a774"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("aeb0e101-78b4-4e17-bc67-a3e4a11c523c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("aeff2d92-8f81-4498-83b7-727ee1a4fc6e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("af031484-cf7c-4573-bdaf-8497d6c258a4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("af28b2e0-1157-45d0-aa3f-b3a258464280"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("af73ad02-b353-41da-95f0-918d7be8b64c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("af7b9d4c-58d0-4d44-b5a8-807f49e50388"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("afa98d13-c497-462f-96a8-4fa52a357993"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b0e0933d-ac35-4c4b-b63d-1f43a1f6baf9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b13631b7-1c06-4288-8e05-6473a5fd210a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b2b9d54b-7bd3-47b8-a003-1fcb97a22678"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b2c3c1e2-6a6b-43c0-ae0b-ea0b4d924506"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b2ee131b-f691-4166-bd33-e8af5356531d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b2f48cac-0c33-47cf-93f6-cc8def97fdc4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b45b194f-de13-4fc9-89db-169af1be8907"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b47464d7-455b-4eaf-b9b0-30f6cfc67fa9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b4ce98f5-c849-4a24-81ee-af0ca32520ba"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b512981b-7e02-4f41-8271-82deeb4269f2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b5320e1b-15f6-406d-81eb-0b7dbbeed356"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b56c237e-926e-4d39-9f84-6dc72854a4e1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b5e8d4f0-4c1e-4a1d-9dd5-0641d52d193e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b5eb5b28-1737-4244-a9df-e1e807bf8b37"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b7bda64a-c62d-46c5-933d-ee5c6ef9bd56"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b8214bd6-d1a6-4a42-8152-85b2c43d573e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b82dcdfb-dca4-43fc-807a-3c32d5b76eb1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b862b56e-ccbb-44ea-bf2e-06b82f8b3bdc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b8ac1e1e-c188-470e-b6e4-368e15b3381e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b9571ceb-317e-4347-aa56-a33ef1ebb8fc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b99634dc-cfaf-4a04-b957-96dabeae99e3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b99c3c83-d8eb-42aa-9635-f371a1b2a748"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b9a361b7-58aa-48a8-9a77-f3718a1eeda0"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b9da1d06-e986-4d94-a897-534deb895478"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bb64faf2-4353-427f-95e9-40db53afb041"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bb7927f6-d473-4db3-b755-a1578524b2bc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bb8527fb-518e-49fc-8294-02caa54dd4c5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bd7cc26d-0e7f-49f1-9f9c-8c938ed45808"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bdb4edd6-f36b-49f4-bd3f-6f516a1c4940"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bdbcce20-354f-43be-957a-121f830e55d6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bdf97911-3da8-492d-a81d-93acc6d0ce91"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("be0015fc-2ea8-4d13-b1aa-128b1d3baece"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bec42b18-2b33-4c2b-88df-01dd64f0807d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("bed1fb0e-e7ef-4f37-ae0f-82bb7fb2b485"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c0357009-0785-4875-98f0-c4544f3980b2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c07d2d99-010e-4b8c-845d-6a6cb700141d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c1a5528c-2d13-4da1-b0e6-790606596ded"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c1b1decf-5057-4e4a-a327-b7b6d7808337"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c2aec9f8-4bf7-4199-8c25-c51213f45f34"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c44e0ad0-4814-460c-a9b6-804485386a15"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c53117b8-5527-45fb-96e5-19a17259694d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c55719ec-5171-4e0c-a575-4382e085d609"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c5c95849-ffc9-419c-9ca9-d4599a2bfc6f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c61e7f0b-1b1b-4499-88a2-de9db60960fd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c69bce39-ec67-4127-8d8e-5990e7121c2d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c7250e7c-ed89-4252-a5a6-553875b4b2a2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c74ad52a-32ea-4fd9-a675-26041b80626f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c7803ad9-bc07-46f2-92a1-77b1ff4ea42d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c7a8f393-d9b0-4e46-b4ca-60831cc74636"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c7bf454c-a5f6-4ea5-8f1a-cc6aab5ca112"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c87a1f92-de6b-401f-bef8-27447abd5acc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c8a1d82b-a385-4de3-bdb6-9725f4fa6244"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c8beaec2-f678-4b0d-8178-1216f588196d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c96eac71-1508-4b09-aed7-3c1ae121a67f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ca433f26-fa38-4c37-b39e-ef8ad3841206"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ca7bc769-07e6-485d-90be-5ef5692f6724"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cb6dfc4d-e7ce-494e-a786-9c936341e883"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cc9cc24b-590d-4ab0-95a2-eec7d5456e74"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cda2f90d-41ec-4ce8-8ab2-6d25061c0ed4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cee75af6-6ca4-43ed-acd9-76613eceb805"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cf2fd016-0282-49cb-b922-fd96eea9ff01"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("cf91c4a5-a50c-4a9e-b9bf-dfa17ee34232"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d1d7fcea-5669-4683-b32b-ac50ffc7658e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d2351124-97a3-43d7-a98f-937a843977a4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d2c11e2d-f0ae-4ecc-9c2c-3b5d293594ef"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d3d5337e-c832-4110-a8de-ad00c72abf0e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d47ad465-7501-43cc-b0ef-71fca518c3a8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d48c9af6-311e-4cfc-8e07-c44031f8baf1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d5021dd2-48d1-4d63-894e-58bff6adc5ae"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d50d441e-d0db-4138-b78a-a3ee8a622aa7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d5ae6a67-ffcc-4752-8a76-e85e7c740f6d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d6167ed1-eaf6-4901-859a-c3496cc17b10"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d64f0173-d2a9-4d7a-b344-a75fcd2f1d30"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d6670adf-caf2-46ef-b19a-a6f29a3153c7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d746ba13-5cf1-41b9-a061-fab7f9adb13f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d777426c-b221-45df-93dd-b9026ee9d037"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d7a8c15d-388e-42cb-8b0b-beac223c33f4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d7bfe306-afc6-4b64-8c71-f73cd0ab96bd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d7d5104a-4cf8-43e7-8da9-d10f8cfcf57e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d825773a-d32e-4e6b-8057-62ad6c083cb2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d8be4187-1ceb-47f3-b104-77e886320870"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d8bf79ca-33dc-48f5-89bf-ce7cbea3dbcf"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d8cf7627-924d-4892-9c16-41eddac5934e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d8f64e3b-a5d4-43e2-8a36-f1b919269ac3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d95ccd89-f34a-43ce-9a6f-bfbf6722f9cb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d99d223e-5a2e-4415-a5e0-52544adb6bf3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d9c2b75f-5e4e-485d-bcb3-7f91d9541b2b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("da3ea9fe-a4bc-4a7d-b030-4b10b310d9e7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dacec1cb-6254-4f39-a5b8-6b7999eeaefd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dadcbbb2-4003-4bb2-bfad-9e7d96b14dda"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("db875402-192d-4982-a38a-e3dd14d8886c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("db9dba60-8f57-4d19-a7f7-aeb6cabfa594"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dc18d900-8a4a-4e31-a3f4-a1de85dc9567"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dc27ad11-3908-491f-8f96-90eef7f49aab"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dc4d8ffb-fe8b-4fdd-9cdb-2588b02b6202"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dd082974-6f60-475f-b2e6-52cb218e55aa"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dd8f4b05-efa5-4276-8b80-f30d1d073139"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dde04766-c917-446d-89b1-9a14cbcb7874"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("de2d98a0-1266-4103-921c-ddc4f60c401b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("de6c8b5f-b0b8-4416-902c-bbc5e8defd2f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("df9fdab7-2482-41e7-b540-6a92c7dc0f2a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("dfd945f8-ce85-4217-bf0a-39b37ada2e89"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e00e0fc9-8e56-4b6c-bf8d-edbf3920f45a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e0432f74-4585-4506-88e4-ee593f2e5c5c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e0880673-c200-439f-b646-286552d52995"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e0bdf71d-995a-4d30-86dc-bcad211c71ad"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e1468bb2-871e-49dc-9df4-1c92031df27f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e16451a1-82fa-48c8-a6ac-c1219623d58c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e16e78d5-d15e-47d5-948d-0a33197d1366"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e319d7bf-3cef-4072-a67f-fdbfba9ed50a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e326e834-336b-48b1-a626-60163e69f4fd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e3476da1-76c3-498a-abd6-560b12ad3b55"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e3a8adef-0d3d-4df8-932c-8f39613630e1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e3d113b0-880f-46c6-b6a1-8b9f0985143b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e543e21e-0b43-46ea-88e2-913407d58e44"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e55e91b2-be54-413e-91dd-889d779c9f7f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e5ae08b3-21a9-451b-a340-c24d152aa101"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e77aaf0f-9f22-47ab-872a-8232f53525d7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e7a43b9f-ac7e-469f-8d17-9df5300520d3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e7ea120b-8b5e-48ec-b2f5-79f4189d3ec6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e88470fa-a811-453a-a9fd-537ad0b02315"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e8a975cd-b35c-4cf0-8aad-81df582e738e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e9028ad5-ae3b-4f37-aab6-7c453e2b5aba"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e90dda3f-4572-4e59-8c8e-47f2b82e8b5f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e92d37a4-ae52-4e3a-b59c-4a7d0b23e9ac"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ead1e12e-6ada-4242-8a2f-55b038b03b43"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("eb04c46c-2e5e-42e7-96fe-dd3991771a37"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("eb0dee41-1b11-4410-8d6e-4043f1ab4180"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("eb858d38-50a4-4197-9474-67e9be712a2f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ec85df70-975e-46e9-98e2-c7daad75ce34"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ec90cf93-fe68-4256-8e37-a1a400365e18"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ed1ee5c3-4e9e-4cc9-b2f5-52ebbba3ee17"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ed4abd34-490d-4f5d-b7d4-e880f82df3ac"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ed84a1f1-40b9-4800-a462-8cb3329096db"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ed98186a-a1dc-46f5-bdcd-1e6ed1a1bb34"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("edc2cbe7-96f9-4e2d-b69e-89cfcc017f6f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("eded6cbe-7a07-4fd1-bea8-73b541a061bb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("eec4f04c-5f59-4279-9a45-585c37030d02"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("efbf8d67-b397-4ed5-81b9-56b8aa9e575e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f068bb0d-48cd-4e71-83ab-3625040fda5b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f084dab5-2d1c-4d3c-b8c3-b5cdbb524541"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f0a8baf8-8ba4-4b56-bd08-1662c0c88841"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f1439edd-ee18-4c12-8995-4b0de11fd791"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f1b7ecc7-4d63-4358-b314-03a02320b0bb"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f1c3fbeb-b29e-45e7-9f92-33f273d35723"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f40e2b95-b4d2-498b-8068-7dc098ba82b4"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f4368bd5-db76-47f1-9607-a87cbc9f6e90"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f4afc3ef-eb9f-436a-b39f-735c9cda55f3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f4b06894-acc6-4e39-ab60-0aa79616a10f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f4cd9751-7a9f-4897-a6e4-0d4cc0997b91"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6242b21-e160-40c7-851b-336782cbeb47"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f65ea576-7b84-486f-a4ec-07dc8858bf91"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6744334-48e0-4c8a-b983-e1029250f00e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f6a47e0c-9120-44af-89a4-7a0011f22822"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f707e036-51db-480b-9897-decad744b286"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f77da57f-5f99-4a3e-99f1-3fe8749991f5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f855f41d-c5b6-4053-96e8-3e314c1b07ef"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f8df7522-a3fd-4ed2-b0b2-9c4d4e2b7836"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f8f17939-9672-4fe8-b97e-71713930b10c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f91ea76e-3d71-4e63-aed2-acf36df28d40"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("f980441e-ab24-4263-b56b-f106c6835bc5"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("faa42f7b-74c9-40c0-8f8a-61994a8133a3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fb1abb04-401d-489b-a80d-b9ef8a284ddc"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fcf48108-67ee-4d54-9383-896ea65d61d7"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fd48e589-ca3b-4944-939b-67e884ad47e9"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fd51b5b1-ec00-4173-8893-027bdb558f9e"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fda86d11-5165-49ba-87f4-977bbea1488d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fde81f2e-5830-4d62-990d-f24da737ce52"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("feac5496-4ea3-4f1e-9c38-91d24cb316c6"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fed58382-e22f-4a7b-9eb4-8cd038961df2"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("fee53c75-1dcc-4ab0-a42b-bd49c67840b1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ff02e615-e11d-4663-9c5e-4ff2197a5d0a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ff328ddb-42f9-42f4-9ce5-eedf932e730d"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ff859e52-62fb-4706-be1a-6c59c3aa9c6f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ffb8f5cd-c9f6-4aff-9bc0-f2139ce090b8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("ffb9a0c3-ef97-4120-8d0f-dd6709078e9c"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("46cf07dc-2ccb-41c2-8690-e71b0a014be3"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("037f5702-952a-4561-9cac-0733054b63a7"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("083dab0b-9204-4d55-a661-671f85c917a9"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("0ade987f-a5b5-4956-abfa-f738625863d5"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("101b8520-62da-45ca-8061-86dd0310be93"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("1626f889-b929-4143-a123-59868c8a1444"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("16b0f9f6-f02b-400c-ac1a-da40a795ddbb"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("1b2db5f8-2e18-41fd-ae48-7797e218e887"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("24b257da-371d-4414-a0d3-269d5983b01f"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("2665b086-7f1b-4b6d-bfed-0b4ad53bf9f1"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("2676851a-7e5b-44bb-a09d-a38044795439"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("2d0f359d-349c-41fd-a13e-23cee6a0a037"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("3bf13bbc-f129-4566-b0f4-65dbe3d1928c"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("449de4c9-1d51-4837-be33-2ced4638a0bc"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("44eb86ce-eef0-4b99-a1f4-5a2082df523c"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("464986e7-6ed2-4865-8e56-b5b0d9a0985b"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("47760db8-ab55-46e7-9c68-3d29103ff32a"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("4b01a0c7-84a5-4e70-bc3a-cd0a94728b31"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("51e94b4f-30ab-480f-a9e4-e5b8d72dd445"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("5484e702-faf5-4498-b925-935816e57bb3"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("57240e2d-bfec-4e6e-9599-3123fd87445e"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("5e675598-0032-4a7c-9230-edeb63f0fb1d"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("5ea2547c-9ac6-46d1-bd17-d7eddcb0ddfa"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("61c1d3b5-3ade-445d-b9ec-3d667e5bb344"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("628cb4fb-cfe4-4da3-8dac-2844c13a40f3"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("659e2389-dda2-48a6-b9b5-148de4cfe248"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("6e034fb8-bbb0-4ac4-b2b3-a12134d3e6f5"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("6e6b4716-910d-406c-9e22-bce662ff386c"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("70858fe4-d665-4db3-b28d-cff53959cb80"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("71f686f9-093a-4cd5-8c69-f5b24e6c8d34"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("7ad0bc5e-b615-422b-8362-1f9ad979534e"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("8a64a12a-9638-4c2e-a56b-67cc498cb0fb"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ad1b933-077b-45cb-ae1c-1d2fe4b2937a"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("8ba036a7-1ccc-4daf-84c6-60e61721ba8b"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("8feebf8a-edf4-4a80-9875-b13102d785c5"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("9366946c-f5b5-40d1-90f5-453917dbe77f"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("94fbc4fe-534a-4f60-b295-f01830405cfb"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("973d14cb-337e-4322-8cf6-879d1186b3c6"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("9743b1fa-7fd0-4447-b5ed-d6fc509b6e74"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("9867edcf-fba6-45e3-ad66-edc63c3cb525"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("ac403c4b-aed9-43ff-9603-edeed4192453"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("ae7df75d-6fe8-41e3-a6e5-0b7897376137"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("b412e4be-d528-4025-af56-c040a7f48c2f"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("b5b27942-7477-427c-8fb3-7a27dd4ff11e"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("b686cc54-b289-4261-9480-44efd8d7b9e9"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("b9b49289-c5f3-4089-b044-7e3f7c19eb9d"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("ba1603b4-be00-433f-bd7c-7d91c15a9a06"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("ba645928-579c-44e2-bbb6-d00eb1c78dbd"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("bbf5d302-2431-4377-af04-63cb5bc2e56c"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("c51687d6-dd33-4e59-bf8e-dd0cabe46b83"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("c811e8b7-93ab-440f-8853-012ad1d19d47"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("c893ebaa-b08a-44b9-b788-a1644eb351c5"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("cb31ef99-1dff-41b8-b694-f7f6aa14c34d"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("cdae8346-47ab-49ed-9049-592ed0cc3e47"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("d33275ec-c896-40c1-8bbf-ac41b47d87ce"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("d5d54210-6a7d-46aa-80e8-725b6b81426d"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("e22ef8ab-7527-4726-9b01-fdb58cd77649"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("e350aeb4-501b-4f07-bcb3-567dd8ad0ebc"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("e78bb52f-a51e-472a-bb35-c7dac0d71852"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("eaaf32b4-c156-4eb1-8462-c3f48d217f27"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("eafaf570-849f-426c-91ea-095690abb398"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("eeac924e-c74f-458e-b87b-76975ecb2ffd"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("f53fced1-227a-4cc0-8ed6-a9d9f71358a2"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("f7863d9b-adaa-4f81-9888-ed1f98249f38"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("f95dc417-589b-4136-839f-2b7666e5722b"));

            migrationBuilder.DeleteData(
                table: "OverheadPositions",
                keyColumn: "Id",
                keyValue: new Guid("fdecdb89-1064-422b-a235-f30eedcdf6f8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("001aca7a-ed2e-42c2-9ea4-689b1df6dc3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01cd7af6-fb93-431c-828b-97f6245ca368"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01d73435-909d-4b49-bb8a-bf4da8c5586f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02b288d9-4ac4-4cc3-8532-a92ad4daa733"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02b9d1af-d852-468c-8a13-facbfdca0108"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0321a7ca-b22b-455e-90b7-61b4344f2ef4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03db8ec3-b4e6-4ccd-8295-f7bf6159e3cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("053d37eb-3ac0-4d2a-8512-a4fa4f5c960e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("054f7037-bf9a-485e-aba4-2fb6b3752fcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05761598-bfcf-43c1-be76-4cfedc3f2469"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08edf71d-f70f-4fde-a69c-8d7f74e8e5a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09c3b3bb-7738-490d-9a83-1bd7ed0bb7de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09fd853c-e3be-4415-a2f7-ef562542e684"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a01cd79-5179-4eda-b16d-859a7ca005a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b2f7488-8930-442a-899d-48c9cdda345c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b8cd886-9d69-429e-b2cf-aee59884538c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c2160c1-c3ab-499d-b149-2def35c25670"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d3fa4a3-2877-4e63-bcea-d743198d4fc1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e816d9e-719e-43f2-a065-a51747e2c637"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1089b230-896d-42e9-8797-4277f851e832"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1146bfb6-e479-48cf-83f9-d62814c58593"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("124e9e6b-b8bc-4e1a-954d-13d4b1ad86a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12893112-0583-42bd-bd58-f9adc577aee6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("141e8876-7e93-426b-8b10-6dd3b69354fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14493811-34db-4f57-948e-71386573967b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14b899b0-35a2-4388-96cb-423d071dffd4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15290099-ae03-4fb5-9f9b-8112dd35f691"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("152db039-c629-4a50-9004-80d80999811c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("158be4e7-02ac-438d-9a2a-315c81f9fdbd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15f741ec-66ac-4eb5-80b2-c4b094b6b6e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16018cfd-4c01-449e-9e07-2966410d9211"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("162311a3-9f95-45dd-80ff-c1977f9c3556"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1864aefd-322e-4911-a03a-a4008c1c604b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19786cff-aa2a-4a12-a045-51dc74d1e820"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19d610a5-9fe1-40b6-a193-039922978be8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19d9d47d-413e-47ed-a4c8-552fa35f7876"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b8dc613-c4fd-4ce5-bf8c-071e31475d67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1cf286eb-4651-4799-b900-3d2c86a3ab9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f8255aa-42bb-499f-bb33-29513622e95a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("210b0adf-b940-4e92-b090-921e74ebc1a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2147837b-7036-4b5c-b817-9b85539c56d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21f62bed-abcb-43df-b865-98ad6c7191d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22a1c2af-034f-4df0-9055-08fb0dfce5c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("240e0b92-b7f9-4ff6-8a96-77505e646b14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24589532-36be-44ed-a7c2-8fe667476f05"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("247f0824-ea3c-4d5a-8bd4-9bea886ee8a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27d92835-4254-4ec5-9010-1d6a33ac7b01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29403e39-eefe-4fb9-8d01-3519a7f6d131"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29813703-2d8d-44a9-b255-7e90f92a910e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ab3e73f-ab99-4f4c-b959-41e40f10cbfe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c040898-203d-4868-ba53-67aa25fa9ab6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c3e9456-e03a-4158-b7aa-32c743fc7a3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c83c506-915a-4ba2-932d-44e74af62e10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d2900e1-2055-4bc6-a22e-f8ced06c8b11"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d40dfee-5890-47c9-bade-2d6ae6617176"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33064e46-3dce-4d4a-9696-33cbdafe5070"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33fcbe37-6aff-4a34-8b39-3bc14d2827d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33fec5a0-9bcc-49e8-88c2-070a7d2ed169"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3482f74f-c049-464d-8b6c-46bebad2ab18"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("36c7ef44-0aae-476d-9118-5c2373501054"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37af49b1-5fb2-4a3d-b6c1-f0020ad5548b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38ee0f0a-8fbb-4bd5-83b6-860c386474e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3beb3eea-9433-4df8-aa91-e30754df1190"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3dc4d7ae-9e25-434d-8058-af67c2eb3c2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3e13781e-1913-4321-8bc5-84378759e3aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("406b08f2-63c9-45e9-8d97-6dbc1bec661e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40d4835c-ac71-40de-96a6-22f15130554d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4159555d-795a-4d8a-b55b-b8bac5a90f39"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("418a04d8-daf9-4962-931d-a4de1df8a1d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("41fcb91b-62ce-4f93-ac68-8a6cb00cad9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4232fb31-1ca4-4902-b865-6b6c360572b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("425f1465-7b98-4341-9bc5-5729d2ad35d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45b1c9cf-5756-4e73-85e8-bb30a4db8914"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45e85b0a-d540-4f35-aa09-36dcfab582ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4671ce29-fa8e-402a-bdc6-92a0d79aea8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46e2c10a-944a-4282-835b-e2af5a42c07e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47832ef5-9f6e-49f0-8f7e-b01fdc4b8638"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48a67e4f-9ff4-4253-90ff-7ca383dbeba2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49b8a21b-f4de-4a34-a356-1ab43eaf9cac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4aa67f51-a49a-40f6-91ff-e98ed9b5ff72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b107bb4-0b38-4f66-87f1-725a564c6768"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b8cda97-9a47-4a9c-a156-f3ddf2f57092"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e3258fa-2ba0-402a-8756-68f0cccbec7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50249ed2-42c2-49d4-b32f-2f78d8ae2997"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("509b5922-99ee-47a9-bd7b-f79b9d29975f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("51355fdf-ee3e-4f3c-be5f-696f424e0260"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("517823df-9671-4fcb-8433-a86232f6718b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53db724f-4ca1-4695-9ee0-9b8acd14beb5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("554d4ca6-24ba-4343-8037-fa69b0c5deb8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55decc4e-ed9c-4d5f-8c67-260f386c139a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("56caf218-9b10-4306-bb24-d17608abed69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("570495ba-f442-4808-a69b-d60c00dacf4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58c1b068-e40d-4e69-a279-8e9917ebb28b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58cdd8e9-884f-47b7-88f4-b1b2821d874a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a1507f5-93ce-4821-abb6-2e7d7c3e0be4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a17d01a-fcb0-4539-b92f-aa319e69c5bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a41392d-b48a-499d-b9c4-6bc18d21b7df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ac44bce-4372-4c88-a062-2b5424f6db7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5adb947f-f98d-4ead-9528-0d597f746c69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b8080e8-80e2-4599-b42e-86d769a092a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bf7493a-c2e4-45f3-ad9a-c0d48b5cf98d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d85a22d-7f97-43dd-8aa5-89fa128c2e9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f1bc312-abdf-4a9e-b37f-17a1301fb6ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f24cfb7-8b34-495a-bf4e-10e396798e8d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fdc1766-81e5-43a3-a203-7d07d1c0c2da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6036a008-e448-4a9b-b91a-9adc6fd03e0f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60ae4bde-6ffc-43ab-af83-d670b988c519"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60e814eb-0ad2-4cd0-8316-9d2d2a654e16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60ec154e-88a5-4d8d-bbde-2c79b8c2fdb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61477a73-a424-4ac0-95e7-88718ebbaf27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6178573b-fb3d-44e0-9955-0a38222aa391"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("619c4b3c-4845-4acc-b017-1898a1d9a987"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62f9d6e2-5189-4349-a926-917995a9e443"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("641b3c0f-5822-4cbc-b76d-a9f1ca8e2f56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("653c75af-4e9b-45c4-bf41-6ef7c12ed8d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65daaff1-a375-4659-a875-5f7ab2e42697"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("683b48f6-aa20-4663-9bfd-d7174ed93eac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6933c76f-1338-4e54-b1d8-89896ecaac4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("699a64de-eb3b-418c-b1a7-81674a48b450"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6a41648f-2da6-41d6-a60a-d2a4cf642d72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b2b6951-6ccd-4930-b15b-fa475658c901"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e450fc9-13a9-4b71-b58d-1bc885b8214a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e5ffc79-9f7b-40bc-ad36-b4b6ae967e05"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f6833af-1db3-4310-8f7c-0fcc1863c78f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fea1bd9-b3a2-45b3-a9b4-fea6d31cc98f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7198e8f8-3f04-41ab-bcc1-65067e77920c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("727828f7-72c1-4c88-883e-ad1244a08577"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73999d10-7ec4-4ed0-a260-5e80cb32127c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7487cab4-5d39-4a47-bc85-5d9edf682538"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74e9395b-c031-45ad-9749-ae76fd120915"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75111469-4339-4b07-be28-85bf5f87eda5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7575d1ab-186d-4767-8abf-ae7823bf2657"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75954116-3e6b-4b89-97df-06db9b9f2df7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("764895a8-8235-4bfa-a52b-001cf4266ac9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76d48d65-7b0d-471e-a281-6b9c30463110"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7715ef60-9573-40db-8240-7a624aeb4f34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7781e159-3846-409c-8606-208d54891c23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77fa7649-34ef-45b0-980e-a2ccbb46034b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78650d54-dec0-4c16-bab8-c8ce2b6d4325"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7887edd3-5fd3-47cc-ac6e-921ee2dab4c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79b905ce-5753-47ce-848c-c26e82475c76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a2d689b-fd97-427c-abcf-97eded8d5cf1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b3e7d3d-98a7-4f6c-84c5-c43a6f73b36a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7be1caa4-bc2f-4ff7-a347-9dde0dcca7c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8047ea19-6263-4340-853b-e50db6635016"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80e976f7-1d61-4a30-8d8c-94ca99118250"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81f3c86a-688c-4c2a-ba79-dc9963295f4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("821c6b13-bef3-4f8a-bd9b-a9a9ad692247"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82426b76-c4f2-4afe-b485-2c5bf6285f2a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83120cba-ec02-4214-8bc6-d5079c8fdd9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84023e47-8558-483c-8642-a803826e9666"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8492cee7-0781-4d2b-9138-23e1b44e703f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85b5fcfe-57ae-4d14-820b-158fc1052dd7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85c6f6a9-bde5-492a-842c-0b79bbc86ca6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("876654d2-9ac2-439f-a9cd-7f0a9adc4b4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8821d7f9-2889-4f59-9638-5e062cbbfaa7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("889037e9-79d1-46b0-a469-f7b3122ae4ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a2d5ebc-56bf-4ecf-8569-f781997e5932"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a857b32-e8e3-43e9-9e0f-6c7da5118cac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8aa134bf-acd0-4340-8619-88f0f58df241"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b8d3274-173a-4650-8015-792915373baf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c0643a0-f95e-443a-b722-2f9ed30d51a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c93237c-83bc-4b85-acce-1c5c6c562dde"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e0dbf9a-3ad9-4c0a-99ac-a22d6c0dc0dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e264a50-1046-44ae-8b4c-88f383e66b07"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f9dedc8-e948-4a90-aff7-19964ded59eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91397e4a-50ec-47df-988c-17e7df1cad63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("936c2d91-5bfd-4454-98bc-8d90c3eb057c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("977607e1-fd39-49e3-b3d5-76e9934d2d91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9877bfec-b85e-4190-8c56-bb18a556f9a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("999c25a9-7df4-4221-a78b-ad7437491883"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d1e2cd9-4efd-4a46-87d1-4c3d6bae1afe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e7f5a16-ece3-43e8-847f-28b8df69eac8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f0bd11d-c7ef-473d-8e2a-671bc0c2d37e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fea2c8c-20fa-40a3-851b-cc5f4c622451"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ff030f6-20e8-4f1c-b908-72754966cb83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1b3d3e1-f5a4-4936-8bbd-23b5f32280ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2b4aff4-90b4-4843-b4b8-7ecb9d2a1d9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a323cf95-a747-4832-9750-54e5c88cd70b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a47a5159-baf8-4aa5-9a84-63efc4853136"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a49c02f1-b7dc-4e79-bc05-2c6698efa924"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a63d468c-1e16-4375-94df-f10909ccf99c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a845a4b2-4c74-4f18-b5ed-8660f34d09af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8865cd3-c612-4cef-a1d5-8a050693a65c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9cf1fdb-b811-4db6-87c0-95bdcdc75c4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa3ce092-3163-46fa-99a6-1acf034ea265"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab9ae5d8-08f9-4f21-9dbf-eb763c74408e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abd1964c-4aca-423c-91a3-f421e0f4edd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abdd3f21-c8d2-4420-a923-3504483d4d53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af19ba6c-5baf-49b6-bf71-da83352dbb30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0db9034-df1b-4b82-92e9-73776acfb016"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b15e5dd5-f505-4e7a-bb9d-f195e7233706"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2a55c59-bf11-464f-ab98-359e7448734b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b367e84e-2dc5-4ac8-9055-35a01c445647"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3c9a9ad-d4e5-4c85-b1d8-0b10d0ed096b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b44e2de8-24d9-4f3f-894b-8a132afb30a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b6aa73c4-5bbe-44aa-acbb-c2489ac921e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7f61da8-6686-4236-9fc4-3d61f20064bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb7de537-c65b-4ace-82ec-31e7f39bdc4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc19200a-e148-49a1-96a2-688c14549b74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bcf5f4f7-4f82-4b44-ae82-215c2c2f8433"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd62026d-c026-4f7b-ab95-dd7489ca4dbe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd626c2e-ef4a-463c-b85f-9785ebaa0465"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bed2b92a-501a-4ac5-9443-47d678cee5ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c00b5a38-787d-458c-aff4-9ccc510ea888"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1bbb2c5-f38c-490b-a23a-805cefbbd5cb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1f82df5-1671-4fbb-ae54-36c3bdc83cf7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c28b53e7-f0cd-4f5b-9f26-627a5d1342da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2c39aa2-f104-474c-86a0-ed792ea173bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c40e17be-b2d3-4ee9-8230-e074eeacf2c7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c438c4db-b016-4931-aeb0-23cf93f8c9e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c522eefc-571a-425a-a8a4-6b1ec2bc81ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c636857c-45ca-4980-a728-041e80598b5c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca7b637c-ce81-435e-88f2-09f57c90b3e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0b761d6-15f7-405f-b429-4b232632a60a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1c53a7b-b506-42ae-bee3-db374f580a5e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2c4f8a3-bc06-4870-adcb-5bf771059e59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3a17198-e3ac-4d2c-b720-6c334236d7a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3b13389-fbdc-4259-b431-6ef6f683664b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3d0fced-32b3-4756-8a38-4ae8cd0624f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3f6d266-645b-453e-8633-cd2bfe16340c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6debd83-7d9a-48ae-a3af-4eeca132e212"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6fe1e52-9ce1-4969-9b3a-ffab097967b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7a9cb31-ffd1-46d9-ae27-f896787631c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8e13749-3531-427e-87c1-84f48b04fd35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8f3aa54-7b14-4a32-b805-087f9d00813c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da924dd0-84a5-45f0-9030-489a93041a92"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db65b64d-19d9-4121-a8bc-6d0b893bbad0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dbca03fe-992e-43ee-b17a-568dc1680d3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dbd36eea-a132-42db-b1ca-4329d8a6a96a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc9b6f9b-eb8d-4c43-a059-cb3aa75e8a20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd7f06d5-5da7-4ed9-beec-6a27ea2e24de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de564ac9-47f4-4cab-ac05-7d61d336220f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df86d162-cbd9-4d41-9ec2-3eb88627818e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e02623ef-2319-497c-bc4e-f26a7703ce21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e02beceb-e15c-4b07-b716-b2c908254f1b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e08af717-f94a-47fc-b079-71dfad3595f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e2fb2499-d7a1-4b62-b651-dea9e43bc362"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4a49fb2-0020-4a58-9b19-d50d76d081d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e59ec0fb-f4c0-4fa6-9f91-bcdbaf67e5f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5eb3563-da9b-462f-86e5-8b19eaa48f24"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5ebed87-80d0-4937-8681-664f28a25c79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e72fe1d9-7591-4d69-89c7-f1afc644076e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8d5c108-3d26-4d04-969c-438b4a61b51d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9cb100a-9bc7-4ed1-8923-62a81432a2c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9cbf05e-25c6-421d-be5c-b575d8d7d8de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb5badd7-dfeb-4e79-aceb-b482900b5722"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eba58977-c640-4b7c-9d47-96cc3c90eeae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ecf1d885-2918-41d9-a3e9-a6ef61e29153"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed9cbd1f-5d44-48aa-9d7c-d7cb0ffe7f64"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee123a1a-2b35-40f9-8f3d-07b610e2fdb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee69e72b-a234-4ce3-aacc-21d0512e8717"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eeeef80c-8f73-45fc-84a2-b2d135738c7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0df22cf-02ae-4d7e-aa86-8223b74b5428"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f38f354e-2daf-4938-a7fc-070c1c7dc3d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f3b5217f-e4b0-4316-b610-cb3fd8c14c69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f51190f0-2141-4c8b-b38d-ab4c76430875"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f66b7ba6-cd89-4084-bf29-78a60363f84d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6f47776-ff1d-4f97-8c6e-e4ba1c07dbf8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f81e8157-967a-4e95-9cf3-290a27ae73ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8717e94-bbf0-4416-bca1-d18b5a3705a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8b57c48-fbb0-4354-b2c7-e97dc2134332"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f937c620-6448-41ef-9b4f-73df19c1d9f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa9d3da5-9820-45f1-8419-10a57f73ea0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc2600d5-30ec-4246-8596-3d421305f63b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fda29d45-ae4c-4f09-b46f-efcb985e07fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe4e7f9a-ab0c-43d6-9ab2-a41670d1937b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff9df34c-0d10-408e-af4f-1a7da4f418d4"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("13f71c23-b599-402a-8a25-8a4fc0678fe7"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("16047f4a-e38b-4cf9-9245-8d1426198dbf"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("197faf7f-feaa-40a6-b8b0-c414309f9719"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("1cad0800-a720-466a-9e1a-89a3671177e9"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("2516c270-a5d5-4551-9412-615c82902962"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("502bb6dc-1f11-4cec-8fdf-f6fa144ef2b2"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("53da8a9f-ea90-4e6e-b379-98330f4b4cce"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("56d9f235-3a2b-416b-9694-96a0d5363dfa"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("5887fdd8-7a8d-4922-90f1-7d249beac12e"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("598cb313-252f-4e44-bdad-8a4ba7ac0f7a"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("5f866475-19d2-422b-8d89-4c6f083c0ee5"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("61785a51-43d7-471e-a5c1-1dc926f1078f"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("62fe319a-6c39-40c6-a8aa-3381072fa3a4"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("70c09f4d-51b9-4a3e-a115-d0786ff61585"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("7f740975-d048-4dc1-a82a-a599a5cc808c"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("8a580aa1-3c17-4254-adf5-6a00f7684320"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("8bf99391-a663-4a5b-9bbe-2b6a53348ec7"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("939ae7a6-24f3-49a9-958f-19c3c18f7b9a"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("c5dc8694-6ad7-469e-90e4-43e240d23504"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("d5c24a79-1ae5-43dc-bad4-063466166be3"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("e3b470fc-4099-4a97-9931-43ffab9aa014"));

            migrationBuilder.DeleteData(
                table: "OverheadCompartments",
                keyColumn: "Id",
                keyValue: new Guid("f62f2d96-e8ed-4056-9c87-c9e05d460021"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("056e3c88-b1ed-46c1-8a24-c1d7e680c414"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("063aa7de-fc86-450f-9a80-635c724240fe"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("0a0b9666-5214-4250-973b-386b0e0531ed"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("0a167a42-fb25-4679-adaf-c698c22b2c5e"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("0a88e142-c9d2-47b9-b6b3-3391e8e95d88"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("0ac67ba8-2c8a-42db-9883-bc4603ef2dcf"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("113d6dbd-be39-4597-a7f8-1dd0dd041c56"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("18f679ec-8b2f-4353-9b8a-4dc3ab25c459"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("1baafe05-b6ff-4d26-85af-88d96870f47a"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("1c305dfe-d592-42f0-9ada-3c579434b6d5"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("1c57c1fb-b25f-4caa-967a-b2e5a92abdea"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("1f5a5daa-9cea-46ee-aa37-40d9be4f5b69"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("20952002-5945-4615-aed0-74a5c6319d91"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("20a3cab2-5b82-4270-a811-a11d8f2f089a"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("231712ef-9eeb-49ae-bfba-4fc60a05ef50"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("26043bd8-cd44-400f-90e4-4f091557cf23"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("2711b67f-c994-4408-b4e4-72845d757216"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("28c40b53-7210-40ef-bf01-c70471e0fb61"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("28f78eaf-3925-46d7-b1cf-7a952f14b925"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("292bf006-c41c-4b8d-a07c-5fc4890e4e5c"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("318fdc93-e81a-44fe-8266-4e5a619b9826"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("344a96bc-a7e2-46ae-acba-16dee8fb4336"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("35a7621b-0550-412c-944a-781391f25948"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3b280c1d-e39e-48d6-b14f-994ea0ce0776"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3d675813-de3c-49ff-8979-64a769efcb37"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("4087dc0b-00d8-4c4b-a053-631906e07d8d"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("42b949dd-33c9-4a60-9a46-a97302c1d979"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("482d3f43-a722-4da0-9105-9ce11203e841"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("4882b330-9701-4c00-8cc8-189cf518e1a3"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("494e0ff1-1337-42ab-8d1b-f5b2dc652121"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5280754f-7f64-464d-b0bf-58cb959c2990"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("55abdb92-c684-4e83-ad70-1033b6f53d33"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5bc6319e-acae-4043-a850-c7dbf51a19f3"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5c8573be-d7d6-446c-b3a4-bfc623581dc5"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5e996939-6278-45e8-88a6-6209cfae9f5d"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("628819c7-5a6e-4236-9fd7-7dbe8c221366"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("69d4f326-7424-45fc-8029-cdbcc870b9ba"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6b1aec18-663e-4856-8799-bf3fa43175e1"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6c087ef7-1259-4209-a491-c2b608d8c991"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6de60e0b-27df-4e0c-8a57-b6ca9e2dec04"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("771fd627-1f56-47c4-a9dc-8a875ea3199d"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("78e8e517-6a0a-4ca4-8f97-c6ec4ccecfab"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("7aec60c9-dea5-4bbb-b176-d9c8532f345c"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("7d4446c6-c7ad-48f9-95be-e6658c3b1bb2"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("7e4505e8-51df-4a11-b55d-ea7bae3c7fca"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("80692a94-7d4b-480f-8947-21fa8a977d49"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("80f6d2f4-d30b-48f5-bbb8-19471b967952"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("8268bb0b-77bd-4b6b-a32f-39b309a89dd9"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("85b212c8-6d5e-4497-a47e-3c05ddae56a4"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("88d82e0b-7531-4ace-833a-7cf0c3ab1abb"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("89264880-ae19-41f1-957e-92109d80d9a7"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("8cdd14bf-c36f-434a-a0a8-e094760348ab"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("8e7b967f-4637-453f-9760-2ed1e70e5593"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("94d54718-2841-4047-92d1-85ac9961b1ea"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("968d6a79-246b-4f09-9432-398f8c319110"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("9d2d9678-1a81-44dc-aece-a977dc2921e5"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("9fed3f90-8553-41c9-8412-7c10e3544a7d"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("a2ded28f-509d-45e8-bddd-eca33a13159a"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("a750fb92-563c-4f8e-b170-3941e16b56f2"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("a8c0c21d-a38b-4275-b077-b82f9438dc38"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("aa372ee6-8748-474a-b819-c25585b7c5e1"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ab356d44-8aab-4beb-b895-e55ec9d3015c"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("abc5e480-6d7b-41b5-adc5-c5c931d71a44"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("aea5ca75-eedd-4014-93e4-09ce79f3b673"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("b015e294-5763-47e3-b940-d3169db97b8e"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("b0aee100-0f81-487a-a116-92c2e0d9f6d2"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("be6d050f-5aee-498a-8861-feb127f9c30b"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("bf080781-1402-4954-87cd-49d0b08a7a14"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("bf78f71f-48ce-45e8-aea1-c4fe42c5fada"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c4457bb6-6a96-4e56-8ebe-d5cc8e5c6ceb"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c7a6b125-ac03-466c-af47-ca6313e15494"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ce7e012c-be36-4d30-a3d2-d8ac99813c49"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cf8a1b52-dfaf-4efe-a24d-3fd613344ecb"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("d5ed9749-d7e6-40ea-8dd3-a5c80779c8e8"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("d5fe9fe4-f10e-48fd-9440-2cc20034ab77"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("d76bfe31-cf1a-4d5c-9595-de402bd451e4"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("d7761a8b-54a6-4f18-941a-442707badedf"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("de620652-3f87-4f08-bd59-30a4f3e0e083"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("de84c898-746f-4db8-8565-0391f8711124"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("e0af8cdb-8e05-44fe-a06c-42fbc6faf2f9"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("e5f23359-2ee8-4716-a89e-c518ec6efda5"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ea66fe9d-029f-4c17-b3d4-19e86be144c4"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ee7afd1a-4ab1-480c-8483-27bb4f6d86b6"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("ef327cf5-5167-461b-8446-fd587e76d3e6"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f0cabc9c-9eb1-4df3-a80a-b8b760ba8258"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f1a98de2-7794-4868-9a39-cd3bb79ceb21"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f205aaf2-d057-48f4-9ca5-eb1842647ea7"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f2d97938-e857-47bc-8473-637815800ec5"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f422fd35-20dc-47d3-9f33-5ddba2cebbf8"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f63acdf8-a0a6-4f14-a1e4-59be8e6e5df3"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f84cdc6f-a60c-44b0-82b2-7c0e2e3d672f"));

            migrationBuilder.DeleteData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f9ee8d25-065f-40ff-b691-ddfe1c5fda4b"));

            migrationBuilder.DeleteData(
                table: "OverheadLayouts",
                keyColumn: "Id",
                keyValue: new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"));

            migrationBuilder.UpdateData(
                table: "AircraftCabins",
                keyColumn: "Id",
                keyValue: new Guid("4fd7c6e4-d926-4998-8a8e-a8c27423c79a"),
                column: "MaxWeight",
                value: 8500.0);

            migrationBuilder.UpdateData(
                table: "AircraftDecks",
                keyColumn: "Id",
                keyValue: new Guid("c79ca836-0e98-4804-98a5-eb20605ca368"),
                column: "MaxWeight",
                value: 8500.0);

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

            migrationBuilder.UpdateData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("19674c0d-278d-4951-a0ee-f672075af1d8"),
                column: "MaxWeight",
                value: 3100.0);

            migrationBuilder.UpdateData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("549d068d-16c6-4268-85f2-cf98eb1618b2"),
                column: "MaxWeight",
                value: 3100.0);

            migrationBuilder.UpdateData(
                table: "ZoneAreas",
                keyColumn: "Id",
                keyValue: new Guid("ed1cbb31-a9e6-4c23-a639-ece1d5efb175"),
                columns: new[] { "CurrentWeight", "MaxWeight" },
                values: new object[] { 0.0, 2300.0 });
        }
    }
}
