using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Add_UserRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a217db55-21d3-4dda-a99a-7724e7fcee0c"), new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a217db55-21d3-4dda-a99a-7724e7fcee0c"), new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f") });
        }
    }
}
