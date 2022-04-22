using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Change_ColumnName_As_PackageItemCategory_In_PackageItem_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PackageItemType",
                table: "PackageItems",
                newName: "PackageItemCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PackageItemCategory",
                table: "PackageItems",
                newName: "PackageItemType");
        }
    }
}
