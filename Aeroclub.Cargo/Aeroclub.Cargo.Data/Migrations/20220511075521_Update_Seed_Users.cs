using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Seed_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9e8b079e-991c-4f75-8384-6f840a7b973c", "bookingadmin@yopmail.com", "Booking", "Admin", null, null, null, null, "bookingadmin@yopmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "VerificationToken" },
                values: new object[] { new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"), 0, "422d6be3-7563-4698-861d-f592351435b6", "backofficeadmin@yopmail.com", true, "Back Office", "Admin", false, null, null, null, "$2a$12$fwVMxgyrBXCohpga0rUVGuVqZ7mUS2k7C5fj28MemdVp9kxhA019a", null, false, null, false, "backofficeadmin@yopmail.com", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "", "samp@yopmail.com", "Sam", "Perera", "", "", "", "", "samp@yopmail.com" });
        }
    }
}
