using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Change_Table_Name_ULD_Metadata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDs_ULDMetaData_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ULDMetaData",
                table: "ULDMetaData");

            migrationBuilder.RenameTable(
                name: "ULDMetaData",
                newName: "ULDMetaDatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ULDMetaDatas",
                table: "ULDMetaDatas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDs_ULDMetaDatas_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId",
                principalTable: "ULDMetaDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ULDs_ULDMetaDatas_ULDMetaDataId",
                table: "ULDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ULDMetaDatas",
                table: "ULDMetaDatas");

            migrationBuilder.RenameTable(
                name: "ULDMetaDatas",
                newName: "ULDMetaData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ULDMetaData",
                table: "ULDMetaData",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ULDs_ULDMetaData_ULDMetaDataId",
                table: "ULDs",
                column: "ULDMetaDataId",
                principalTable: "ULDMetaData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
