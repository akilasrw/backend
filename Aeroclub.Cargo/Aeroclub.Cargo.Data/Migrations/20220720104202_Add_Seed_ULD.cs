using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_ULD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "9e4f6b1b-a02a-4149-9486-af5c265aa530");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "afec93e8-5d41-4bf2-82d1-8b0dcda573bd");

            migrationBuilder.InsertData(
                table: "ULDs",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "RowNumber", "SerialNumber", "ULDMetaDataId", "ULDType" },
                values: new object[,]
                {
                    { new Guid("0e233c92-cb5c-482c-9307-5af6a032344e"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)7, null, new Guid("c4629465-bc25-4384-ae21-db57ac5b440b"), 0 },
                    { new Guid("243a356e-cfc9-4e4f-8a57-0c460a43e543"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)5, null, new Guid("030bcece-6f0b-4c33-9b67-cb669cfd9a04"), 0 },
                    { new Guid("3218738e-a0ee-4c85-996e-d9aa213a4d31"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)1, null, new Guid("4e7eab62-f35f-4a60-8ac2-5d4d093e00c4"), 0 },
                    { new Guid("4635a2cd-939b-4adf-b465-585a8e779347"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)9, null, new Guid("f648e6e3-156a-4bcb-b57b-60585895a7df"), 0 },
                    { new Guid("5fd0fd46-105b-4bd6-9497-3b43519b51ef"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)4, null, new Guid("b90b9436-56bc-4254-b625-2ac7d4b8080e"), 0 },
                    { new Guid("6918bb04-eaa8-4e23-aff8-d2db960bcea0"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)3, null, new Guid("eb2d2df7-00af-4ad9-8964-e76bf7aa089d"), 0 },
                    { new Guid("6e280ba0-c986-4750-90ab-4d832801c374"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)2, null, new Guid("38495a67-7336-412d-a221-3267a284af64"), 0 },
                    { new Guid("7a950949-d6d8-45d4-ae3a-ce7af7304c17"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)10, null, new Guid("4d79fb54-bf18-4391-9bfd-a5153a3c10c5"), 0 },
                    { new Guid("a3734030-8705-4b1c-8e8f-a48b3d799842"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)8, null, new Guid("11c6c149-d702-4cdf-b842-50ec5300b656"), 0 },
                    { new Guid("c820b286-1edf-4c6d-93f8-45f1f34927d9"), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), (short)6, null, new Guid("4a6fba20-86e8-479c-9d2c-80b7c269c657"), 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("0e233c92-cb5c-482c-9307-5af6a032344e"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("243a356e-cfc9-4e4f-8a57-0c460a43e543"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("3218738e-a0ee-4c85-996e-d9aa213a4d31"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("4635a2cd-939b-4adf-b465-585a8e779347"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("5fd0fd46-105b-4bd6-9497-3b43519b51ef"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("6918bb04-eaa8-4e23-aff8-d2db960bcea0"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("6e280ba0-c986-4750-90ab-4d832801c374"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("7a950949-d6d8-45d4-ae3a-ce7af7304c17"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("a3734030-8705-4b1c-8e8f-a48b3d799842"));

            migrationBuilder.DeleteData(
                table: "ULDs",
                keyColumn: "Id",
                keyValue: new Guid("c820b286-1edf-4c6d-93f8-45f1f34927d9"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "c37980cf-128f-48ac-a7c2-379507996744");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "fbe81fb4-6859-4443-9fd4-a87353ec9a93");
        }
    }
}
