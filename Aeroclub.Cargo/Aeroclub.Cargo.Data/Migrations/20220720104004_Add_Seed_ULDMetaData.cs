using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_ULDMetaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ULDMetaDatas",
                columns: new[] { "Id", "Created", "CreatedBy", "Height", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Length", "Weight", "Width" },
                values: new object[,]
                {
                    { new Guid("030bcece-6f0b-4c33-9b67-cb669cfd9a04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 3628.0, 224.0 },
                    { new Guid("11c6c149-d702-4cdf-b842-50ec5300b656"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 2948.0, 224.0 },
                    { new Guid("38495a67-7336-412d-a221-3267a284af64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 2948.0, 224.0 },
                    { new Guid("4a6fba20-86e8-479c-9d2c-80b7c269c657"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 3628.0, 224.0 },
                    { new Guid("4d79fb54-bf18-4391-9bfd-a5153a3c10c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 1814.0, 224.0 },
                    { new Guid("4e7eab62-f35f-4a60-8ac2-5d4d093e00c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 1814.0, 224.0 },
                    { new Guid("b90b9436-56bc-4254-b625-2ac7d4b8080e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 2948.0, 224.0 },
                    { new Guid("c4629465-bc25-4384-ae21-db57ac5b440b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 2948.0, 224.0 },
                    { new Guid("eb2d2df7-00af-4ad9-8964-e76bf7aa089d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 2948.0, 224.0 },
                    { new Guid("f648e6e3-156a-4bcb-b57b-60585895a7df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 163.0, true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 318.0, 2948.0, 224.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("030bcece-6f0b-4c33-9b67-cb669cfd9a04"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("11c6c149-d702-4cdf-b842-50ec5300b656"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("38495a67-7336-412d-a221-3267a284af64"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("4a6fba20-86e8-479c-9d2c-80b7c269c657"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("4d79fb54-bf18-4391-9bfd-a5153a3c10c5"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("4e7eab62-f35f-4a60-8ac2-5d4d093e00c4"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("b90b9436-56bc-4254-b625-2ac7d4b8080e"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("c4629465-bc25-4384-ae21-db57ac5b440b"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("eb2d2df7-00af-4ad9-8964-e76bf7aa089d"));

            migrationBuilder.DeleteData(
                table: "ULDMetaDatas",
                keyColumn: "Id",
                keyValue: new Guid("f648e6e3-156a-4bcb-b57b-60585895a7df"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "41c1ce2b-37f5-4ea7-abb2-91a8f1f545f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "9655934f-0df7-42de-b46c-5c328fe78146");
        }
    }
}
