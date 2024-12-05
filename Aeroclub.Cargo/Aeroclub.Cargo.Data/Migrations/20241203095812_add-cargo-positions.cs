using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class addcargopositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "1db668fa-26e4-4baa-b281-835f2e955852");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "24c0beb0-5146-4b85-b01f-7622f09aa451");

            migrationBuilder.InsertData(
                table: "CargoPositions",
                columns: new[] { "Id", "Breadth", "CargoPositionType", "Created", "CreatedBy", "CurrentVolume", "CurrentWeight", "FlightLeg", "Height", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Length", "MaxVolume", "MaxWeight", "Name", "OverheadCompartmentId", "Priority", "SeatId", "ZoneAreaId" },
                values: new object[,]
                {
                    { new Guid("0d0be16f-335c-49a0-b508-d900a70a8be8"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b4", null, 2.0, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("45b12bb6-7c8b-4887-8c5c-2f8c56145325"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b3", null, 2.0, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("4ce61b93-dc28-41a8-ab3a-aec67ef5092a"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b1", null, 2.0, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("4f451841-d756-4e4d-ac01-50c19f4bd04f"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b4", null, 2.0, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("54367c98-923b-4b22-b9fd-d5e5c533b62b"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b2", null, 2.0, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("58ecce33-b495-4dcd-bf78-4e96e5c1908c"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b4", null, 2.0, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("5e9fc132-8994-4cbe-928a-8c32b33b0253"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b3", null, 2.0, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("6c4154ee-c4df-410e-b6f1-e3e16fc1dde3"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b6", null, 2.0, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("7860ecaa-0c60-43af-a9a0-54769eafcf56"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b1", null, 2.0, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("7a765636-a8f0-45db-95d3-d743e2e421dd"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b2", null, 2.0, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("7ab936b1-9b1f-47dd-8c6f-c3cdcb5f8623"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b2", null, 2.0, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("b28c6f4e-bf19-49e4-ba79-3fc73bc77d2a"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b5", null, 2.0, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("b370a508-39dd-45e6-af2b-9588d1f544fd"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b5", null, 2.0, null, new Guid("1bfe1a97-4bac-48ff-8570-284658b725d4") },
                    { new Guid("c07cdcac-3007-4aa0-af30-7ba78c190884"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b6", null, 2.0, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("c0f5d553-d528-4b7b-9a4d-d4cac44a70f1"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b5", null, 2.0, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("d3757ef8-5d96-4b72-abd5-ce955ac83e95"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b1", null, 2.0, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") },
                    { new Guid("e4c2dc2d-a5b7-4693-b68c-e87cd1703155"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b6", null, 2.0, null, new Guid("22019ea9-d91a-4b95-835d-80b9659133cf") },
                    { new Guid("e7a6dbb8-e4e9-4312-97e4-4aa3cae236a2"), 5.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, 0.0, 1.0, 5.0, true, false, null, null, 10.0, 500000.0, 1000.0, "b3", null, 2.0, null, new Guid("da2cb73f-23d0-48c3-969e-16b788a31a0b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("0d0be16f-335c-49a0-b508-d900a70a8be8"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("45b12bb6-7c8b-4887-8c5c-2f8c56145325"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4ce61b93-dc28-41a8-ab3a-aec67ef5092a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("4f451841-d756-4e4d-ac01-50c19f4bd04f"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("54367c98-923b-4b22-b9fd-d5e5c533b62b"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("58ecce33-b495-4dcd-bf78-4e96e5c1908c"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("5e9fc132-8994-4cbe-928a-8c32b33b0253"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("6c4154ee-c4df-410e-b6f1-e3e16fc1dde3"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7860ecaa-0c60-43af-a9a0-54769eafcf56"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7a765636-a8f0-45db-95d3-d743e2e421dd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("7ab936b1-9b1f-47dd-8c6f-c3cdcb5f8623"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b28c6f4e-bf19-49e4-ba79-3fc73bc77d2a"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("b370a508-39dd-45e6-af2b-9588d1f544fd"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c07cdcac-3007-4aa0-af30-7ba78c190884"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("c0f5d553-d528-4b7b-9a4d-d4cac44a70f1"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("d3757ef8-5d96-4b72-abd5-ce955ac83e95"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e4c2dc2d-a5b7-4693-b68c-e87cd1703155"));

            migrationBuilder.DeleteData(
                table: "CargoPositions",
                keyColumn: "Id",
                keyValue: new Guid("e7a6dbb8-e4e9-4312-97e4-4aa3cae236a2"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "91cf18cb-2b2a-4379-8d19-21f2fa6ef789");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "af6293e1-f86b-42d5-a295-d0342344efa1");
        }
    }
}
