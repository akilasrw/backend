using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_Table_SystemUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a217db55-21d3-4dda-a99a-7724e7fcee0c"), new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f") });

            migrationBuilder.CreateTable(
                name: "SystemUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaseAirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessPortalLevel = table.Column<byte>(type: "tinyint", nullable: false),
                    UserRole = table.Column<byte>(type: "tinyint", nullable: false),
                    UserStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    CountryId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemUsers_Airports_BaseAirportId",
                        column: x => x.BaseAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemUsers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SystemUsers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemUsers_Countries_CountryId1",
                        column: x => x.CountryId1,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("202af001-200d-421a-b9c3-828e198f4629"),
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Super Admin", "SUPER ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("354fd81a-620d-4567-94f8-bc2cf0cd3ba1"), "6", "Backoffice User", "BACKOFFICE USER" },
                    { new Guid("3a855567-5dd4-49c3-9a81-e1f30aeb73ee"), "7", "Warehouse Admin", "WAREHOUSE ADMIN" },
                    { new Guid("455be845-faf5-41ec-92db-8d427c1b4976"), "3", "Booking Admin", "BOOKING ADMIN" },
                    { new Guid("980e048b-ff16-4496-86b9-1149ff640913"), "4", "Booking User", "BOOKING USER" },
                    { new Guid("bd798930-c07a-4066-9c58-192da5e7af5d"), "5", "Backoffice Admin", "BACKOFFICE ADMIN" },
                    { new Guid("de37198b-4749-4bfb-bc04-49bf9435bbf1"), "8", "Warehouse User", "WAREHOUSE USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("202af001-200d-421a-b9c3-828e198f4629"), new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "db47ec80-203a-478d-8a09-9671d55c1d63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "1271ec29-0977-4535-a963-40e5e8ed65a7");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("455be845-faf5-41ec-92db-8d427c1b4976"), new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f") });

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_AppUserId",
                table: "SystemUsers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_BaseAirportId",
                table: "SystemUsers",
                column: "BaseAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_CountryId",
                table: "SystemUsers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemUsers_CountryId1",
                table: "SystemUsers",
                column: "CountryId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("354fd81a-620d-4567-94f8-bc2cf0cd3ba1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3a855567-5dd4-49c3-9a81-e1f30aeb73ee"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("980e048b-ff16-4496-86b9-1149ff640913"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd798930-c07a-4066-9c58-192da5e7af5d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("de37198b-4749-4bfb-bc04-49bf9435bbf1"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("455be845-faf5-41ec-92db-8d427c1b4976"), new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("202af001-200d-421a-b9c3-828e198f4629"), new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("455be845-faf5-41ec-92db-8d427c1b4976"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("202af001-200d-421a-b9c3-828e198f4629"),
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a217db55-21d3-4dda-a99a-7724e7fcee0c"), new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "3832d160-6744-47b7-82b7-80150a2dfcc4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "894340d9-f1b3-4842-a973-fd99abef99f5");
        }
    }
}
