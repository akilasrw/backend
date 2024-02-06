﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class UpdateItemStatusTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemStatus_PackageItems_PackageItemId",
                table: "ItemStatus");

            migrationBuilder.DropIndex(
                name: "IX_ItemStatus_PackageItemId",
                table: "ItemStatus");

            migrationBuilder.DropColumn(
                name: "PackageItemId",
                table: "ItemStatus");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "ded718d6-c318-4811-b6ce-3245da08a336");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "f7c88918-5f13-4b8b-b974-3b3d975fe6c5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PackageItemId",
                table: "ItemStatus",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "987be87e-4c0c-4090-8e86-80a4a92e2fb7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "11ef3630-80c3-472a-8077-5e50bb10b3e0");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatus_PackageItemId",
                table: "ItemStatus",
                column: "PackageItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemStatus_PackageItems_PackageItemId",
                table: "ItemStatus",
                column: "PackageItemId",
                principalTable: "PackageItems",
                principalColumn: "Id");
        }
    }
}
