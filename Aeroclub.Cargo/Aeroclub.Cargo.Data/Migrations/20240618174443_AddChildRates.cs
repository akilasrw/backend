using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class AddChildRates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChildRateCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildRateCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildRateCategories_SubRateCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "SubRateCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "a831c1ce-3e3f-4ad7-9e58-46365214ddde");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "996c0966-807a-4b2a-b692-79bac9ceeb39");

            migrationBuilder.InsertData(
                table: "ChildRateCategories",
                columns: new[] { "Id", "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("0818f5c0-3151-4585-9b99-e5bf655a742a"), new Guid("b76e546b-50e5-4a88-8a1a-4fa485b845e0"), "SECURED SHIPMENTS" },
                    { new Guid("11e831a1-68f8-47ea-9d1c-32c90202b92f"), new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "SPECIAL OPENING OF CENTRES" },
                    { new Guid("1a65d1d4-cdb6-4f11-849f-90542b621746"), new Guid("49d5d81a-5a16-42b6-909c-917de89efb63"), "AWB ISSUING BY AFKL (AF or KL)" },
                    { new Guid("1b4265c0-90f4-47a7-a8d8-31dfec3ec15f"), new Guid("adf8d68a-7af5-49a7-bd7e-d5096a6d3d6d"), "IMPORT HANDOVER CHARGES" },
                    { new Guid("21fbd3f2-735c-4e56-86fe-67b32e1e5266"), new Guid("adf8d68a-7af5-49a7-bd7e-d5096a6d3d6d"), "PROOF OF DELIVERY (P.O.D.)" },
                    { new Guid("292b3e9b-5f7a-46f0-a8b3-3a116a0bf6f2"), new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "STORAGE FEES" },
                    { new Guid("2c00f7a0-4b1f-4da4-916b-3f8829f6700c"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "STORAGE FEES including EXPRESS product" },
                    { new Guid("2e88b5d8-df28-41d1-b46f-6dfe4e9e235d"), new Guid("f12d77b4-2c5b-4c15-81d4-e67cb9a65847"), "FIXED CHARGE" },
                    { new Guid("416f1f1e-4b05-4607-9e7a-4a416fe5a5b0"), new Guid("a46a62bc-2b2d-4a95-9170-b6ea9cb1d1ec"), "PIVOT WEIGHT" },
                    { new Guid("4c9456ce-1013-4b54-93bf-7f625b7ebe59"), new Guid("49d5d81a-5a16-42b6-909c-917de89efb63"), "DISBURSEMENT FEES" },
                    { new Guid("4cf2bf89-78fb-43a7-9a5b-0de974a6cdd8"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "PERISHABLES TERMINAL HANDLING FEE" },
                    { new Guid("5c79243c-16a2-4bf7-bd8e-aa29f1417808"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "STOPPED IN TRANSIT SHIPMENTS" },
                    { new Guid("5d02ec69-6f31-4f49-a101-d60f7856690b"), new Guid("43d8d8b8-732b-4b24-8e1d-4e3b78767b7c"), "NON CONFORM DANGEROUS GOODS" },
                    { new Guid("5d180c4d-1a90-4e82-b37f-011b5dbd0a0f"), new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "DIRECT PICK-UP - DPU" },
                    { new Guid("5f265175-ffcc-4bf4-876a-9c5043a9aacc"), new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "INTERNAL DELIVERY" },
                    { new Guid("69287538-ff9f-417e-9e1c-1797599d5248"), new Guid("43d8d8b8-732b-4b24-8e1d-4e3b78767b7c"), "DANGEROUS GOODS CHARGES � LIGHT �" },
                    { new Guid("6f76e90c-4cd0-4f4e-bccf-0b6f4518d1d1"), new Guid("a46a62bc-2b2d-4a95-9170-b6ea9cb1d1ec"), "CHECK-LIST FEES" },
                    { new Guid("7b1f42c8-9d5b-4e9d-a7b8-04bae2b892bc"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "DTA (Direct To Agent) DIRECT DELIVERY SERVICE" },
                    { new Guid("8b10ea2a-1ff8-4df7-8d7e-c2f16d97bb02"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "UNIT LOAD DEVICE CHARGES" },
                    { new Guid("8f2e86a1-8c7b-40c7-80d7-6d8ee2c5b968"), new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "SHIPMENT NOT READY FOR CARRIAGE" },
                    { new Guid("8f3a5821-cd7b-4172-a1a7-cf7b073b0641"), new Guid("5e8f8129-4f3e-4821-8c8a-feb1715d6157"), "EXPORT CONTROL SYSTEM (ECS)" },
                    { new Guid("8fc65d06-48ae-4561-83bf-59c7c730b4b7"), new Guid("5e8f8129-4f3e-4821-8c8a-feb1715d6157"), "T1 HANDLING FEES" },
                    { new Guid("94f53f4f-eaa0-44bc-94c2-48e7eaf8e8a6"), new Guid("a46a62bc-2b2d-4a95-9170-b6ea9cb1d1ec"), "CONTAINERS FEES" },
                    { new Guid("95f97b97-ec63-4a35-b1a7-8e764c5c3c9a"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "DESTRUCTION FEE" },
                    { new Guid("a11f3c71-7990-4e82-81b0-692f2e8b01a5"), new Guid("49d5d81a-5a16-42b6-909c-917de89efb63"), "NON-BOOKED EXPRESS AWB" },
                    { new Guid("a2b956d3-ecdc-4e4b-8b6e-1e11847fda59"), new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "IMPROPERLY LOADED ULD � RECONTOURING" },
                    { new Guid("a332f91a-721e-4b9a-a3e3-bcd474a2f252"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "URGENT BREAK DOWN" },
                    { new Guid("b2b7ab59-44b6-4757-8d88-bcda78174c61"), new Guid("49d5d81a-5a16-42b6-909c-917de89efb63"), "DOCUMENT AMMENDEMENTS C.C.A." },
                    { new Guid("b2f239e8-6e4e-4673-a7a8-5a5ba3f620dc"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "DEMURRAGE FEE" },
                    { new Guid("b94f6213-e5f3-41a2-9c9e-4aaf2ec4292e"), new Guid("b76e546b-50e5-4a88-8a1a-4fa485b845e0"), "DOG SECURITY INSPECTION" },
                    { new Guid("be4c0414-41a7-4ef8-875e-2a937d4416b2"), new Guid("f9e1f7e9-5d5c-4ba0-98b5-91889fbac282"), "FIX RATE" },
                    { new Guid("c515b6f0-ec85-4c17-b1aa-4765a4a15023"), new Guid("f12d77b4-2c5b-4c15-81d4-e67cb9a65847"), "FUNERAL CHAMBER FEE" },
                    { new Guid("c7c5f4f3-9b13-4a9b-8978-5a9ae7c53c60"), new Guid("f9e1f7e9-5d5c-4ba0-98b5-91889fbac282"), "FRAIS DE MISE � DISPOSITION" },
                    { new Guid("ca0f0f27-4a9a-4f35-b470-1c09d8f46b63"), new Guid("49d5d81a-5a16-42b6-909c-917de89efb63"), "FIXED FEES (INCLUDING STAMP DUTY, FOR ALL PRODUCTS EXCLUDING EXPRESS)" },
                    { new Guid("caebd6ef-3ef0-434e-9a32-54c9b0a8892e"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "B.U.P. BREAK DOWN" },
                    { new Guid("d063c933-8c0e-4557-8b6f-48f3ab4e3d3d"), new Guid("49d5d81a-5a16-42b6-909c-917de89efb63"), "PAPER AWB FEE" },
                    { new Guid("d1dfc468-dc9b-4745-bf85-0ac7e10490b4"), new Guid("5e8f8129-4f3e-4821-8c8a-feb1715d6157"), "PROCESSING FEES (for private person)" },
                    { new Guid("e8e823d5-5b34-4095-98e2-1c070bc13612"), new Guid("feef71f5-4a5e-4a3c-a1be-7c5995702e50"), "LOADING/UNLOADING" },
                    { new Guid("ee3478a5-57a3-41ed-8c9c-801b38506f3f"), new Guid("b76e546b-50e5-4a88-8a1a-4fa485b845e0"), "NON-SECURED SHIPMENTS" },
                    { new Guid("ef7c2138-bba3-48b6-bbbd-6f61a3fa13f8"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "REWEIGHING" }
                });

            migrationBuilder.InsertData(
                table: "ChildRateCategories",
                columns: new[] { "Id", "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("f0d8c994-69ff-4751-8e4c-5e2c71c33d38"), new Guid("5e8f8129-4f3e-4821-8c8a-feb1715d6157"), "HOUSE AIR WAYBILL DATA TRANSMISSION" },
                    { new Guid("f383ae0b-6f1d-4852-9335-678f52c1f8c1"), new Guid("43d8d8b8-732b-4b24-8e1d-4e3b78767b7c"), "DANGEROUS GOODS CHARGES" },
                    { new Guid("f587d3e2-0b16-4d69-b2f0-21e3c8ab76c2"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "COLD ROOM STORAGE FEE" },
                    { new Guid("f5a27c7c-5341-4417-bd4f-18f9a5a0bf9a"), new Guid("6c8d5c28-aba7-426f-90db-5f6b9f4b8ff1"), "TEMPORARY WAREHOUSE STORAGE FEE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildRateCategories_CategoryID",
                table: "ChildRateCategories",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildRateCategories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6062fc9c-6298-43b2-99f5-d56077ab813f"),
                column: "ConcurrencyStamp",
                value: "4b43e73c-f4a4-4e6d-83e5-5e2c721da170");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fabea9-7111-4e8d-b0a4-16e55ad6106f"),
                column: "ConcurrencyStamp",
                value: "d767f23c-8422-4d8c-ad89-d0fbd3a312ec");
        }
    }
}
