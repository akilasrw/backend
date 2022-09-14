using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Remove_Data_from_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("7286adb4-1da0-4547-ac8d-c3ea5f45c2a9"));

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
                keyValue: new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"));

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

            migrationBuilder.DeleteData(
                table: "FlightSectors",
                keyColumns: new[] { "FlightId", "SectorId" },
                keyValues: new object[] { new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"), new Guid("8ae55489-4677-411a-802e-b74f5885f893") });

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("476b22e2-9782-4617-b68f-594c8841c497"));

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("a3f78ff1-ff33-4a7f-a667-6fc993295888"));

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("f6696ac5-2d2a-41a4-afe9-7f41b89e5e52"));

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("02f207cd-fc55-4115-ad86-ff3f50f7a49b"));

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
                keyValue: new Guid("e35fe0fc-6e76-405b-8abb-a8eadc228795"));

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("fcf72511-4dfc-412d-9fe4-c01473648907"));

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"));

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("8ae55489-4677-411a-802e-b74f5885f893"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "f6cdfbda-e13f-4405-b9ef-bb0e14dd77e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "e5e7a33e-a6c4-4d43-aaea-05f9801c4d70");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleManagements_AircraftId",
                table: "FlightScheduleManagements",
                column: "AircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightScheduleManagements_FlightId",
                table: "FlightScheduleManagements",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleManagements_Aircrafts_AircraftId",
                table: "FlightScheduleManagements",
                column: "AircraftId",
                principalTable: "Aircrafts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightScheduleManagements_Flights_FlightId",
                table: "FlightScheduleManagements",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleManagements_Aircrafts_AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightScheduleManagements_Flights_FlightId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleManagements_AircraftId",
                table: "FlightScheduleManagements");

            migrationBuilder.DropIndex(
                name: "IX_FlightScheduleManagements_FlightId",
                table: "FlightScheduleManagements");

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AircraftLayoutId", "AircraftSubType", "AircraftType", "ConfigurationType", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RegNo", "SeatLayoutId", "Status" },
                values: new object[] { new Guid("7286adb4-1da0-4547-ac8d-c3ea5f45c2a9"), new Guid("6c921671-64df-42fb-bb09-291e392156fd"), (short)0, (short)0, (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), "A320", new Guid("8577256e-6277-4ed5-a933-5fe3e07fadf6"), (short)0 });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Code", "CountryId", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Lat", "Lon", "Name" },
                values: new object[,]
                {
                    { new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"), "YHZ", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Halifax Stanfield International Airport" },
                    { new Guid("827791b4-c923-49b5-8426-e0c0a6a4c96a"), "YQM", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Greater Moncton Roméo LeBlanc International Airport" },
                    { new Guid("95ea7820-ceed-4311-82fd-557e2d1ed436"), "YUL", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Montréal–Trudeau International Airport" },
                    { new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "YEG", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Edmonton International Airport" },
                    { new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "SGN", new Guid("e8cc3768-ad4f-49e7-89b2-7c9429d4391a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Tan Son Nhat International Airport" },
                    { new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "HAN", new Guid("e8cc3768-ad4f-49e7-89b2-7c9429d4391a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Noi Bai International Airport" },
                    { new Guid("c2ac04ca-db7d-4138-8416-bbdc9236a751"), "YQX", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Gander International Airport" },
                    { new Guid("dd784758-7438-41bf-8a8a-c9f79b03ffff"), "YFC", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Fredericton International Airport" },
                    { new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "YYC", new Guid("4d24d56c-8bd2-4942-b9a4-66911f9d2496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, "Calgary International Airport" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a8d8f6aa-deb7-4498-8b53-94fe397ec010");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "21a0b938-8d53-4e59-9752-bb8e15256447");

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Created", "CreatedBy", "DestinationAirportCode", "DestinationAirportId", "DestinationAirportName", "FlightNumber", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OriginAirportCode", "OriginAirportId", "OriginAirportName" },
                values: new object[,]
                {
                    { new Guid("476b22e2-9782-4617-b68f-594c8841c497"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport", "QI0298", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport" },
                    { new Guid("a3f78ff1-ff33-4a7f-a667-6fc993295888"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport", "QH1415", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport" },
                    { new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", "AC-100", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport" },
                    { new Guid("f6696ac5-2d2a-41a4-afe9-7f41b89e5e52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport", "AC-101", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport" }
                });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Created", "CreatedBy", "DestinationAirportCode", "DestinationAirportId", "DestinationAirportName", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "OriginAirportCode", "OriginAirportId", "OriginAirportName", "SectorType" },
                values: new object[,]
                {
                    { new Guid("02f207cd-fc55-4115-ad86-ff3f50f7a49b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport", (byte)1 },
                    { new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", (byte)1 },
                    { new Guid("826b781d-8682-492b-8777-be5562e203b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YHZ", new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"), "Halifax Stanfield International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", (byte)1 },
                    { new Guid("8ae55489-4677-411a-802e-b74f5885f893"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YYC", new Guid("f11ddc4f-6d03-4866-972f-1af421c8104d"), "Calgary International Airport", (byte)1 },
                    { new Guid("e35fe0fc-6e76-405b-8abb-a8eadc228795"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "YEG", new Guid("9f18b9e5-6ae4-429d-8bcb-10c895ff64fe"), "Edmonton International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "YHZ", new Guid("2bc5fba0-e25e-4f65-9965-ecb901250b78"), "Halifax Stanfield International Airport", (byte)1 },
                    { new Guid("fcf72511-4dfc-412d-9fe4-c01473648907"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "HAN", new Guid("c1390386-aaaa-4db3-b1a7-0780ced0336b"), "Noi Bai International Airport", true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "SGN", new Guid("bd4487bd-65fd-4ce7-9d00-a8b8d517b680"), "Tan Son Nhat International Airport", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "FlightSectors",
                columns: new[] { "FlightId", "SectorId", "ArrivalDateTime", "DepartureDateTime", "Sequence" },
                values: new object[] { new Guid("d611308d-7af3-4950-8f05-bb70af55f4d8"), new Guid("8ae55489-4677-411a-802e-b74f5885f893"), null, null, (byte)1 });
        }
    }
}
