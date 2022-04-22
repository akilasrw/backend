using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_AirportSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Code", "CountryId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Lat", "Lon", "Name" },
                values: new object[,]
                {
                    { new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"), "YHZ", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Halifax Stanfield International Airport" },
                    { new Guid("827791b4-c923-49b5-8426-e0c0a6a4c96a"), "YQM", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Greater Moncton Roméo LeBlanc International Airport" },
                    { new Guid("95ea7820-ceed-4311-82fd-557e2d1ed436"), "YUL", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Montréal–Trudeau International Airport" },
                    { new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "YEG", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Edmonton International Airport" },
                    { new Guid("c2ac04ca-db7d-4138-8416-bbdc9236a751"), "YQX", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Gander International Airport" },
                    { new Guid("dd784758-7438-41bf-8a8a-c9f79b03ffff"), "YFC", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Fredericton International Airport" },
                    { new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "YYC", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0m, 0m, "Calgary International Airport" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("827791b4-c923-49b5-8426-e0c0a6a4c96a"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("95ea7820-ceed-4311-82fd-557e2d1ed436"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c2ac04ca-db7d-4138-8416-bbdc9236a751"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("dd784758-7438-41bf-8a8a-c9f79b03ffff"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"));
        }
    }
}
