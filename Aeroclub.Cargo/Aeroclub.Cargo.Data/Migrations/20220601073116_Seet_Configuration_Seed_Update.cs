using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Seet_Configuration_Seed_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "4ddd965a-08c5-41bf-9f4f-6acba59fd6ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "4722e9b8-626b-4886-8244-fdc85476af6e");

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3a9484f7-b074-42e7-980f-c435f1637e1b"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3cac6b12-f9a9-4a8f-9f26-ec0c510f8cb3"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("458da1a4-15ea-471e-9c0c-49d3a4ffe7fc"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5d1e4e65-466b-4a27-af41-ce7d55617353"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("61218d5e-987b-4078-bce3-93e46d771d70"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6175acf7-2dfe-4670-80c8-ed02a605b0e2"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6af12a15-d5d3-4ed6-b015-cae2a43de479"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("76fc17fa-1cee-4ad3-94ef-6d9d5ae8131a"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("8ab00536-4a4e-4bde-82dc-28c08343f88a"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("90f940d6-b7ad-4fa3-892a-5ed6fb894662"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c5ea9a98-44f0-4379-ae26-37a892a2bb04"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c7b27cc1-2510-4ee2-a84c-3d7416833c23"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c8d4a560-e9d8-49c9-a7c0-3f706d2791fd"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cd5ff7b8-4d02-4ee7-85ba-94da08073709"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("def86f27-bb76-4fe2-8763-3acb6f0f32ca"),
                column: "MaxWeight",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"),
                column: "MaxWeight",
                value: 50.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "770ce484-bdd2-4687-be4e-41c64a1f49cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "4713840e-b502-4d9c-ab5c-fc2c12d559d8");

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3a9484f7-b074-42e7-980f-c435f1637e1b"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("3cac6b12-f9a9-4a8f-9f26-ec0c510f8cb3"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("458da1a4-15ea-471e-9c0c-49d3a4ffe7fc"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("5d1e4e65-466b-4a27-af41-ce7d55617353"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("61218d5e-987b-4078-bce3-93e46d771d70"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6175acf7-2dfe-4670-80c8-ed02a605b0e2"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("6af12a15-d5d3-4ed6-b015-cae2a43de479"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("76fc17fa-1cee-4ad3-94ef-6d9d5ae8131a"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("8ab00536-4a4e-4bde-82dc-28c08343f88a"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("90f940d6-b7ad-4fa3-892a-5ed6fb894662"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c5ea9a98-44f0-4379-ae26-37a892a2bb04"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c7b27cc1-2510-4ee2-a84c-3d7416833c23"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("c8d4a560-e9d8-49c9-a7c0-3f706d2791fd"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("cd5ff7b8-4d02-4ee7-85ba-94da08073709"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("def86f27-bb76-4fe2-8763-3acb6f0f32ca"),
                column: "MaxWeight",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "SeatConfigurations",
                keyColumn: "Id",
                keyValue: new Guid("f69223eb-6cff-4026-8353-f0499eff4cf4"),
                column: "MaxWeight",
                value: 0.0);
        }
    }
}
