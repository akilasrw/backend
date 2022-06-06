using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Airport_Flight_Seed_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Code", "CountryId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Lat", "Lon", "Name" },
                values: new object[,]
                {
                    { new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "SGN", new Guid("e8cc3768-ad4f-49e7-89b2-7c9429d4391a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Tan Son Nhat International Airport" },
                    { new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "HAN", new Guid("e8cc3768-ad4f-49e7-89b2-7c9429d4391a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Noi Bai International Airport" }
                });

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

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Created", "CreatedBy", "DestinationAirportCode", "DestinationAirportId", "DestinationAirportName", "FlightNumber", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OriginAirportCode", "OriginAirportId", "OriginAirportName" },
                values: new object[,]
                {
                    { new Guid("476b22e2-9782-4617-b68f-594c8841c497"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport", "QI0298", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport" },
                    { new Guid("a3f78ff1-ff33-4a7f-a667-6fc993295888"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport", "QH1415", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"));

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("476b22e2-9782-4617-b68f-594c8841c497"));

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("a3f78ff1-ff33-4a7f-a667-6fc993295888"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "3a84388e-53ea-414c-ad18-0a5697dfd1a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "0a4ec2ef-c811-4e52-8941-3dd6f4d7ff7a");
        }
    }
}
