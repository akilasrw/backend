using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Sctor_Seed_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "fec51702-5787-47a9-b510-fa34f016dc6b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "6b521716-ba70-4d08-9cbf-5c104cb8a86c");

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Created", "CreatedBy", "DestinationAirportCode", "DestinationAirportId", "DestinationAirportName", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OriginAirportCode", "OriginAirportId", "OriginAirportName", "SectorType" },
                values: new object[,]
                {
                    { new Guid("02f207cd-fc55-4115-ad86-ff3f50f7a49b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport", (byte)1 },
                    { new Guid("fcf72511-4dfc-412d-9fe4-c01473648907"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport", (byte)1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("02f207cd-fc55-4115-ad86-ff3f50f7a49b"));

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("fcf72511-4dfc-412d-9fe4-c01473648907"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "4c54f222-f449-4654-9e05-13a89236eb1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "8eb13f30-7b30-44c2-830a-787f2eae42da");
        }
    }
}
