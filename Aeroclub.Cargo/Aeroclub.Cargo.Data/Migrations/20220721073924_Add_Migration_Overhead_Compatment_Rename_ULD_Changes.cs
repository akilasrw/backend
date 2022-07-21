using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Migration_Overhead_Compatment_Rename_ULD_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoPositions_ULDs_ULDId",
                table: "CargoPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OverheadPositions_OverheadCompartments_OverheadCompartmentId",
                table: "OverheadPositions");

            migrationBuilder.DropTable(
                name: "OverheadCompartments");

            migrationBuilder.DropIndex(
                name: "IX_ULDContainerCargoPositions_CargoPositionId",
                table: "ULDContainerCargoPositions");

            migrationBuilder.DropIndex(
                name: "IX_CargoPositions_ULDId",
                table: "CargoPositions");

            migrationBuilder.DropColumn(
                name: "ColumnNumber",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "ULDs");

            migrationBuilder.DropColumn(
                name: "ULDId",
                table: "CargoPositions");

            migrationBuilder.RenameColumn(
                name: "OverheadCompartmentId",
                table: "OverheadPositions",
                newName: "OverheadCompartmentConfigurationId");

            migrationBuilder.RenameIndex(
                name: "IX_OverheadPositions_OverheadCompartmentId",
                table: "OverheadPositions",
                newName: "IX_OverheadPositions_OverheadCompartmentConfigurationId");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "ULDs",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CargoPositionId",
                table: "ULDContainers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColumnNumber",
                table: "ULDContainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RowNumber",
                table: "ULDContainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OverheadCompartmentConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    ColumnNumber = table.Column<int>(type: "int", nullable: false),
                    OverheadLayoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadCompartmentConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadCompartmentConfigurations_OverheadLayouts_OverheadLayoutId",
                        column: x => x.OverheadLayoutId,
                        principalTable: "OverheadLayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "cb5b61b5-8ec7-4b99-9778-92d4088c274c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "d7cc9fa4-2432-464f-9ab7-098043484e63");

            migrationBuilder.InsertData(
                table: "OverheadCompartmentConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[,]
                {
                    { new Guid("0816bf93-fbfe-49ab-a260-b65b9a103659"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 9 },
                    { new Guid("0862c4a4-d2b3-43e7-b257-039447e64983"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 8 },
                    { new Guid("13f71c23-b599-402a-8a25-8a4fc0678fe7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 7 },
                    { new Guid("16047f4a-e38b-4cf9-9245-8d1426198dbf"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 1 },
                    { new Guid("16202785-603d-4261-8057-a35dac9190bc"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 1 },
                    { new Guid("197faf7f-feaa-40a6-b8b0-c414309f9719"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 4 },
                    { new Guid("1bca6e23-55e5-4ef8-b31a-c9514381d82f"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 4 },
                    { new Guid("1cad0800-a720-466a-9e1a-89a3671177e9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 11 },
                    { new Guid("2516c270-a5d5-4551-9412-615c82902962"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 6 },
                    { new Guid("32ea293f-2b5b-4a3f-a821-cf2a25de754e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 4 },
                    { new Guid("4698a608-103e-4166-afe1-c99257c8b44d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 6 },
                    { new Guid("502bb6dc-1f11-4cec-8fdf-f6fa144ef2b2"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 6 },
                    { new Guid("538c9eb2-bdfb-480a-9080-56c3b099b4c5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 9 },
                    { new Guid("53da8a9f-ea90-4e6e-b379-98330f4b4cce"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 8 },
                    { new Guid("56d9f235-3a2b-416b-9694-96a0d5363dfa"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 5 },
                    { new Guid("5887fdd8-7a8d-4922-90f1-7d249beac12e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 3 },
                    { new Guid("598cb313-252f-4e44-bdad-8a4ba7ac0f7a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 11 },
                    { new Guid("5f658532-5f68-48fc-84e5-fa7f7441d71c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 10 },
                    { new Guid("5f866475-19d2-422b-8d89-4c6f083c0ee5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 10 },
                    { new Guid("61785a51-43d7-471e-a5c1-1dc926f1078f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 3 },
                    { new Guid("62fe319a-6c39-40c6-a8aa-3381072fa3a4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 9 },
                    { new Guid("630980b3-4851-45c9-b324-b5888107882a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 8 },
                    { new Guid("70c09f4d-51b9-4a3e-a115-d0786ff61585"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 5 },
                    { new Guid("7f740975-d048-4dc1-a82a-a599a5cc808c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 7 },
                    { new Guid("8a580aa1-3c17-4254-adf5-6a00f7684320"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 1 },
                    { new Guid("8bf99391-a663-4a5b-9bbe-2b6a53348ec7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 4 },
                    { new Guid("8fcbe5b8-5626-4023-87fa-a05cf56df46e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 2 },
                    { new Guid("939ae7a6-24f3-49a9-958f-19c3c18f7b9a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 2 },
                    { new Guid("a1f00792-eaa4-4216-a5ea-ca650ef42078"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 1 },
                    { new Guid("a63dbf79-e791-4e60-8cee-f8cd3d271872"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 2 },
                    { new Guid("af6f8cbf-7d77-4c74-a838-4352788b5643"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 7 },
                    { new Guid("c5dc8694-6ad7-469e-90e4-43e240d23504"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 10 },
                    { new Guid("d4d904e9-aff6-4f94-8007-6cedebdb7490"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 6 },
                    { new Guid("d5c24a79-1ae5-43dc-bad4-063466166be3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 2 },
                    { new Guid("d73021c1-9b4e-4be9-b1d4-8f7428242709"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 3 },
                    { new Guid("e3b470fc-4099-4a97-9931-43ffab9aa014"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 9 },
                    { new Guid("ede1aafe-51d1-437f-b755-e0b31c923aad"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 5 },
                    { new Guid("ede2607b-591b-461f-b8f3-faa6f138d258"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 5 },
                    { new Guid("f20c7153-4ead-4a47-b6c7-2e59288aa983"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 3 },
                    { new Guid("f2fc4660-598f-43d3-8a07-cf0488bd37b2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 10 }
                });

            migrationBuilder.InsertData(
                table: "OverheadCompartmentConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[] { new Guid("f62f2d96-e8ed-4056-9c87-c9e05d460021"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 8 });

            migrationBuilder.InsertData(
                table: "OverheadCompartmentConfigurations",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[] { new Guid("f95af152-4270-48d4-9190-48f01c8239d5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 7 });

            migrationBuilder.CreateIndex(
                name: "IX_ULDContainers_CargoPositionId",
                table: "ULDContainers",
                column: "CargoPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_ULDContainerCargoPositions_CargoPositionId",
                table: "ULDContainerCargoPositions",
                column: "CargoPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadCompartmentConfigurations_OverheadLayoutId",
                table: "OverheadCompartmentConfigurations",
                column: "OverheadLayoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_OverheadPositions_OverheadCompartmentConfigurations_OverheadCompartmentConfigurationId",
                table: "OverheadPositions",
                column: "OverheadCompartmentConfigurationId",
                principalTable: "OverheadCompartmentConfigurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ULDContainers_CargoPositions_CargoPositionId",
                table: "ULDContainers",
                column: "CargoPositionId",
                principalTable: "CargoPositions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OverheadPositions_OverheadCompartmentConfigurations_OverheadCompartmentConfigurationId",
                table: "OverheadPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_ULDContainers_CargoPositions_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropTable(
                name: "OverheadCompartmentConfigurations");

            migrationBuilder.DropIndex(
                name: "IX_ULDContainers_CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropIndex(
                name: "IX_ULDContainerCargoPositions_CargoPositionId",
                table: "ULDContainerCargoPositions");

            migrationBuilder.DropColumn(
                name: "CargoPositionId",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "ColumnNumber",
                table: "ULDContainers");

            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "ULDContainers");

            migrationBuilder.RenameColumn(
                name: "OverheadCompartmentConfigurationId",
                table: "OverheadPositions",
                newName: "OverheadCompartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_OverheadPositions_OverheadCompartmentConfigurationId",
                table: "OverheadPositions",
                newName: "IX_OverheadPositions_OverheadCompartmentId");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "ULDs",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AddColumn<short>(
                name: "ColumnNumber",
                table: "ULDs",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "RowNumber",
                table: "ULDs",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<Guid>(
                name: "ULDId",
                table: "CargoPositions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OverheadCompartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OverheadLayoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColumnNumber = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverheadCompartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverheadCompartments_OverheadLayouts_OverheadLayoutId",
                        column: x => x.OverheadLayoutId,
                        principalTable: "OverheadLayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "OverheadCompartments",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[,]
                {
                    { new Guid("0816bf93-fbfe-49ab-a260-b65b9a103659"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 9 },
                    { new Guid("0862c4a4-d2b3-43e7-b257-039447e64983"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 8 },
                    { new Guid("13f71c23-b599-402a-8a25-8a4fc0678fe7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 7 },
                    { new Guid("16047f4a-e38b-4cf9-9245-8d1426198dbf"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 1 },
                    { new Guid("16202785-603d-4261-8057-a35dac9190bc"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 1 },
                    { new Guid("197faf7f-feaa-40a6-b8b0-c414309f9719"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 4 },
                    { new Guid("1bca6e23-55e5-4ef8-b31a-c9514381d82f"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 4 },
                    { new Guid("1cad0800-a720-466a-9e1a-89a3671177e9"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 11 },
                    { new Guid("2516c270-a5d5-4551-9412-615c82902962"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 6 },
                    { new Guid("32ea293f-2b5b-4a3f-a821-cf2a25de754e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 4 },
                    { new Guid("4698a608-103e-4166-afe1-c99257c8b44d"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 6 },
                    { new Guid("502bb6dc-1f11-4cec-8fdf-f6fa144ef2b2"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 6 },
                    { new Guid("538c9eb2-bdfb-480a-9080-56c3b099b4c5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 9 },
                    { new Guid("53da8a9f-ea90-4e6e-b379-98330f4b4cce"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 8 },
                    { new Guid("56d9f235-3a2b-416b-9694-96a0d5363dfa"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 5 },
                    { new Guid("5887fdd8-7a8d-4922-90f1-7d249beac12e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 3 },
                    { new Guid("598cb313-252f-4e44-bdad-8a4ba7ac0f7a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 11 },
                    { new Guid("5f658532-5f68-48fc-84e5-fa7f7441d71c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 10 },
                    { new Guid("5f866475-19d2-422b-8d89-4c6f083c0ee5"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 10 },
                    { new Guid("61785a51-43d7-471e-a5c1-1dc926f1078f"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 3 },
                    { new Guid("62fe319a-6c39-40c6-a8aa-3381072fa3a4"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 9 },
                    { new Guid("630980b3-4851-45c9-b324-b5888107882a"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 8 },
                    { new Guid("70c09f4d-51b9-4a3e-a115-d0786ff61585"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 5 },
                    { new Guid("7f740975-d048-4dc1-a82a-a599a5cc808c"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 7 },
                    { new Guid("8a580aa1-3c17-4254-adf5-6a00f7684320"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 1 },
                    { new Guid("8bf99391-a663-4a5b-9bbe-2b6a53348ec7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 4 },
                    { new Guid("8fcbe5b8-5626-4023-87fa-a05cf56df46e"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 2 },
                    { new Guid("939ae7a6-24f3-49a9-958f-19c3c18f7b9a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 2 },
                    { new Guid("a1f00792-eaa4-4216-a5ea-ca650ef42078"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 1 },
                    { new Guid("a63dbf79-e791-4e60-8cee-f8cd3d271872"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 2 },
                    { new Guid("af6f8cbf-7d77-4c74-a838-4352788b5643"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 7 },
                    { new Guid("c5dc8694-6ad7-469e-90e4-43e240d23504"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 10 },
                    { new Guid("d4d904e9-aff6-4f94-8007-6cedebdb7490"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 6 },
                    { new Guid("d5c24a79-1ae5-43dc-bad4-063466166be3"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 2 },
                    { new Guid("d73021c1-9b4e-4be9-b1d4-8f7428242709"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 3 },
                    { new Guid("e3b470fc-4099-4a97-9931-43ffab9aa014"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 9 },
                    { new Guid("ede1aafe-51d1-437f-b755-e0b31c923aad"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 5 },
                    { new Guid("ede2607b-591b-461f-b8f3-faa6f138d258"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 5 },
                    { new Guid("f20c7153-4ead-4a47-b6c7-2e59288aa983"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 3 },
                    { new Guid("f2fc4660-598f-43d3-8a07-cf0488bd37b2"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 10 }
                });

            migrationBuilder.InsertData(
                table: "OverheadCompartments",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[] { new Guid("f62f2d96-e8ed-4056-9c87-c9e05d460021"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7f9db66-db55-4987-b0da-fe4107b5565e"), 8 });

            migrationBuilder.InsertData(
                table: "OverheadCompartments",
                columns: new[] { "Id", "ColumnNumber", "Created", "CreatedBy", "IsActive", "IsDeleted", "IsOccupied", "LastModified", "LastModifiedBy", "OverheadLayoutId", "RowNumber" },
                values: new object[] { new Guid("f95af152-4270-48d4-9190-48f01c8239d5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, false, null, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9788468f-8da6-4573-af43-509af9b224b0"), 7 });

            migrationBuilder.CreateIndex(
                name: "IX_ULDContainerCargoPositions_CargoPositionId",
                table: "ULDContainerCargoPositions",
                column: "CargoPositionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CargoPositions_ULDId",
                table: "CargoPositions",
                column: "ULDId");

            migrationBuilder.CreateIndex(
                name: "IX_OverheadCompartments_OverheadLayoutId",
                table: "OverheadCompartments",
                column: "OverheadLayoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoPositions_ULDs_ULDId",
                table: "CargoPositions",
                column: "ULDId",
                principalTable: "ULDs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OverheadPositions_OverheadCompartments_OverheadCompartmentId",
                table: "OverheadPositions",
                column: "OverheadCompartmentId",
                principalTable: "OverheadCompartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
