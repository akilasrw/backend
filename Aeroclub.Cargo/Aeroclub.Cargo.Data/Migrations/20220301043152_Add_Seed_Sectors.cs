using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Seed_Sectors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Created", "CreatedBy", "DestinationAirportCode", "DestinationAirportId", "DestinationAirportName", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OriginAirportCode", "OriginAirportId", "OriginAirportName", "SectorType" },
                values: new object[,]
                {
                    { new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", (byte)1 },
                    { new Guid("826b781d-8682-492b-8777-be5562e203b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YHZ", new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"), "Halifax Stanfield International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", (byte)1 },
                    { new Guid("8ae55489-4677-411a-802e-b74f5885f893"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport", (byte)1 },
                    { new Guid("e35fe0fc-6e76-405b-8abb-a8eadc228795"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YHZ", new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"), "Halifax Stanfield International Airport", (byte)1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"));

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("826b781d-8682-492b-8777-be5562e203b1"));

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("8ae55489-4677-411a-802e-b74f5885f893"));

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("e35fe0fc-6e76-405b-8abb-a8eadc228795"));
        }
    }
}
