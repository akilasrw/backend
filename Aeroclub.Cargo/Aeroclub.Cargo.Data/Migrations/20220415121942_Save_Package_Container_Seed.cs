using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Save_Package_Container_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CargoPositionType",
                table: "PackageContainers",
                newName: "PackageItemCategory");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PackageContainerSectors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<double>(
                name: "Width",
                table: "PackageContainers",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Length",
                table: "PackageContainers",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "PackageContainers",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<double>(
                name: "MinWaight",
                table: "PackageContainers",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PackageBoxType",
                table: "PackageContainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PackageContainerType",
                table: "PackageContainers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PackageContainers",
                columns: new[] { "Id", "Created", "CreatedBy", "Height", "IsActive", "IsCustom", "IsDeleted", "LastModified", "LastModifiedBy", "Length", "MaxWaight", "MinWaight", "PackageBoxType", "PackageContainerType", "PackageItemCategory", "Width" },
                values: new object[,]
                {
                    { new Guid("26ea2f00-e28c-4616-8920-eef3fcc16a81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 60.0, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 45.0, 60.0, null, 1, 2, 1, 45.0 },
                    { new Guid("407dc3d4-f0b9-4d9e-b646-d5fed84736e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), null, 44.0, 30.0, 2, null, 1, null },
                    { new Guid("549a33d5-1e32-47e8-9caa-b0eb8827dc17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 60.0, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 140.0, 60.0, null, 1, 5, 1, 45.0 },
                    { new Guid("8d462fb5-7fbc-40ea-8c9e-95b0b1485f48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), null, 29.0, 0.0, 2, null, 1, null },
                    { new Guid("994330b2-cab4-4674-bc06-ee918bb2072e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 23.0, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 56.0, 60.0, null, 1, 3, 1, 24.0 },
                    { new Guid("a65dd21b-07c1-43be-9917-2973ccdb0f82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), null, 99.0, 60.0, 2, null, 1, null },
                    { new Guid("bf0e8db1-fb98-4453-a011-c146931f49c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 23.0, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), 56.0, 30.0, null, 1, 4, 1, 36.0 },
                    { new Guid("c586fb65-a6dc-41c1-b512-593f7e088396"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), null, 59.0, 45.0, 2, null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "PackageContainerSectors",
                columns: new[] { "PackageContainerId", "SectorId", "Id", "Rate" },
                values: new object[,]
                {
                    { new Guid("26ea2f00-e28c-4616-8920-eef3fcc16a81"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("24f68a31-93ae-4ec6-b90d-69311d27b9e4"), 40.0 },
                    { new Guid("407dc3d4-f0b9-4d9e-b646-d5fed84736e5"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("bf5f4989-83a3-468a-afe2-c67439b7f24f"), 35.0 },
                    { new Guid("8d462fb5-7fbc-40ea-8c9e-95b0b1485f48"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("fc4ccb73-8cba-46ea-aebc-0b33edda4ce3"), 20.0 },
                    { new Guid("a65dd21b-07c1-43be-9917-2973ccdb0f82"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("8688b077-eb0b-440a-855b-e2d122c5d5d0"), 55.0 },
                    { new Guid("bf0e8db1-fb98-4453-a011-c146931f49c4"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("71607f97-88ad-4a71-b8f8-7dd6e0713d8a"), 20.0 },
                    { new Guid("c586fb65-a6dc-41c1-b512-593f7e088396"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd"), new Guid("302ee0c9-92c4-4aa2-a1d7-9aaf93e2249f"), 45.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PackageContainerSectors",
                keyColumns: new[] { "PackageContainerId", "SectorId" },
                keyValues: new object[] { new Guid("26ea2f00-e28c-4616-8920-eef3fcc16a81"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd") });

            migrationBuilder.DeleteData(
                table: "PackageContainerSectors",
                keyColumns: new[] { "PackageContainerId", "SectorId" },
                keyValues: new object[] { new Guid("407dc3d4-f0b9-4d9e-b646-d5fed84736e5"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd") });

            migrationBuilder.DeleteData(
                table: "PackageContainerSectors",
                keyColumns: new[] { "PackageContainerId", "SectorId" },
                keyValues: new object[] { new Guid("8d462fb5-7fbc-40ea-8c9e-95b0b1485f48"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd") });

            migrationBuilder.DeleteData(
                table: "PackageContainerSectors",
                keyColumns: new[] { "PackageContainerId", "SectorId" },
                keyValues: new object[] { new Guid("a65dd21b-07c1-43be-9917-2973ccdb0f82"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd") });

            migrationBuilder.DeleteData(
                table: "PackageContainerSectors",
                keyColumns: new[] { "PackageContainerId", "SectorId" },
                keyValues: new object[] { new Guid("bf0e8db1-fb98-4453-a011-c146931f49c4"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd") });

            migrationBuilder.DeleteData(
                table: "PackageContainerSectors",
                keyColumns: new[] { "PackageContainerId", "SectorId" },
                keyValues: new object[] { new Guid("c586fb65-a6dc-41c1-b512-593f7e088396"), new Guid("3d0f3ede-39be-4626-b11f-46cb9dedc8cd") });

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("549a33d5-1e32-47e8-9caa-b0eb8827dc17"));

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("994330b2-cab4-4674-bc06-ee918bb2072e"));

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("26ea2f00-e28c-4616-8920-eef3fcc16a81"));

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("407dc3d4-f0b9-4d9e-b646-d5fed84736e5"));

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("8d462fb5-7fbc-40ea-8c9e-95b0b1485f48"));

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("a65dd21b-07c1-43be-9917-2973ccdb0f82"));

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("bf0e8db1-fb98-4453-a011-c146931f49c4"));

            migrationBuilder.DeleteData(
                table: "PackageContainers",
                keyColumn: "Id",
                keyValue: new Guid("c586fb65-a6dc-41c1-b512-593f7e088396"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PackageContainerSectors");

            migrationBuilder.DropColumn(
                name: "MinWaight",
                table: "PackageContainers");

            migrationBuilder.DropColumn(
                name: "PackageBoxType",
                table: "PackageContainers");

            migrationBuilder.DropColumn(
                name: "PackageContainerType",
                table: "PackageContainers");

            migrationBuilder.RenameColumn(
                name: "PackageItemCategory",
                table: "PackageContainers",
                newName: "CargoPositionType");

            migrationBuilder.AlterColumn<double>(
                name: "Width",
                table: "PackageContainers",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Length",
                table: "PackageContainers",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "PackageContainers",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
