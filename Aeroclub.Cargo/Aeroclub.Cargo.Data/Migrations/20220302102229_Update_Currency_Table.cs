using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Currency_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3921fefc-6553-44fd-9e1d-ebbe9336dfd5"),
                columns: new[] { "Code", "Name", "Symbol" },
                values: new object[] { "AED", "UAE Dirham", "د.إ" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("69ad7020-d123-4089-a15e-c65dafffc7ce"),
                columns: new[] { "Code", "Name", "Symbol" },
                values: new object[] { "ALL", "Lek", "L" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ecf57a23-5eb2-444e-9bae-17a0da010587"),
                column: "Name",
                value: "US Dollar");

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Symbol" },
                values: new object[,]
                {
                    { new Guid("013518cd-3efa-47a0-a4ee-b65af47b8085"), "ERN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Nakfa", "Nfk" },
                    { new Guid("0193fbe5-1cf9-4a8c-bdfd-c6e8ac52c265"), "NOK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Norwegian Krone", "kr" },
                    { new Guid("0242ddf8-b5fb-47cc-bbaf-9447b2bb617d"), "TOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pa’anga", "T$" },
                    { new Guid("03218f47-cad9-49f5-8df3-99d889c3e7f7"), "JOD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Jordanian Dinar", "د.ا" },
                    { new Guid("0507516a-b3a6-4853-97e5-a5115b547c89"), "GMD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Dalasi", "D" },
                    { new Guid("05273da8-36a2-4e2d-b4dd-5f8e51a9d133"), "EGP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Egyptian Pound", "£" },
                    { new Guid("05a73978-2bf4-489c-a443-119ff93ae41e"), "GHS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cedi", "₵" },
                    { new Guid("06eae394-e230-48b5-b49a-d0df9e9dc83a"), "VUV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Vatu", "Vt" },
                    { new Guid("075f5efa-86b7-4e3b-9e94-ace45456502a"), "LYD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Libyan Dinar", "ل.د" },
                    { new Guid("07b3d397-c5d1-4f08-ae67-4e7d70022494"), "HRK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Croatian Kuna", "Kn" },
                    { new Guid("08c1db27-af88-4e55-9119-b2487c02f9c8"), "ISK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Iceland Krona", "Kr" },
                    { new Guid("08e5907a-c661-4130-8e9e-4a4608d70e18"), "INR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Indian Rupee", "₹" },
                    { new Guid("0d7a6c0d-493a-4cf3-93dc-cea60a1e80ab"), "NAD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Namibia Dollar", "$" },
                    { new Guid("0dfe6c21-5262-4d28-b527-ff5bdba8523e"), "MMK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kyat", "K" },
                    { new Guid("101a17b0-84d4-4172-a263-8202f8ad8685"), "AMD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Armenian Dram", "Դ" },
                    { new Guid("10abeb74-b34d-4c4f-8f0f-f98a77d46d0a"), "KHR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Riel", "៛" },
                    { new Guid("128e700c-d38b-4611-a541-508757e76c0d"), "YER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Yemeni Rial", "﷼" },
                    { new Guid("12a5cd34-342d-4eaa-bb50-e25a1512169f"), "PHP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Philippine Peso", "₱" },
                    { new Guid("12d340d2-7ec5-4410-85bf-e1b660c53ea2"), "TTD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Trinidad and Tobago Dollar", "$" },
                    { new Guid("1c7b838d-648e-4cd6-9d71-bb08fcb6e56e"), "BIF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Burundi Franc", "₣" },
                    { new Guid("1d1cff2e-9609-4fc1-b647-d499948d7bdc"), "ZMW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Zambian Kwacha", "ZK" },
                    { new Guid("1d86b997-a16d-4e4b-bf47-031ff44074e9"), "ARS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Argentine Peso", "$" },
                    { new Guid("221bec73-6e28-421b-a857-0e68f6621e19"), "BGN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bulgarian Lev", "лв" },
                    { new Guid("2432cbf2-7193-454d-8d92-c49a32d8af37"), "XAF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "East Caribbean Dollar", "₣" },
                    { new Guid("26a51fd0-30d1-4060-9b88-4b1c9340596c"), "BDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Taka", "৳" },
                    { new Guid("282d42ba-8763-4356-a967-7aa06c1710d8"), "CNY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Yuan", "¥" },
                    { new Guid("3066047f-3491-4b4e-b23c-5fbd2faa3733"), "XCD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "CFA Franc BCEAO", "$" },
                    { new Guid("32a2ee36-bad3-48c3-8bfc-44a1df4f8e9a"), "ETB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ethiopian Birr", "ብር" },
                    { new Guid("32d368eb-a339-49e0-9ee4-4dbca54811cb"), "SZL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lilangeni", "L" },
                    { new Guid("3301f910-cc11-480a-b771-573b11a326be"), "PLN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "PZloty", "zł" },
                    { new Guid("361b8d8d-b602-4642-8040-eaf373fff4fd"), "OMR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Rial Omani", "ر.ع." },
                    { new Guid("384aaf27-315c-428e-8d13-8a52dde32e5a"), "TWD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Taiwan Dollar", "$" },
                    { new Guid("3aa5aa65-88b5-4e82-aea4-0903d9dbfbda"), "BBD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Barbados Dollar", "$" },
                    { new Guid("3c0624b3-1884-4f89-af71-2f8567c273e8"), "MOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pataca", "P" },
                    { new Guid("3c86f9e4-e188-4d3d-8d14-52eb94930a4e"), "KGS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Som", "Лв" },
                    { new Guid("3e967e7b-c502-425d-be8e-3167bc2e1f16"), "CLP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Chilean Peso", "$" },
                    { new Guid("405fa24f-5350-467b-955d-4fe8b1d19bea"), "KWD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kuwaiti Dinar", "د.ك" },
                    { new Guid("4818df0d-438a-4812-b1eb-53aea480466d"), "SAR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saudi Riyal", "ر.س" },
                    { new Guid("4dba6584-36c3-4296-9ce8-6b02790cd34a"), "SOS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Somali Shilling", "Sh" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Symbol" },
                values: new object[,]
                {
                    { new Guid("4f25ebd9-5a79-46ff-8a71-211e2f0b7b11"), "BZD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Belize Dollar", "$" },
                    { new Guid("501e67ac-404b-4f97-8172-401b055959d5"), "TMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Manat", "m" },
                    { new Guid("578b8359-6cd6-46ce-b3d6-b73692694bb5"), "BRL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Brazilian Real", "R$" },
                    { new Guid("5793d68c-3894-4af3-9b7f-7d0ad724a7f1"), "HUF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Forint", "Ft" },
                    { new Guid("591752f1-8871-44aa-97fa-ae40762c54cf"), "HTG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Gourde", "G" },
                    { new Guid("5a5ae944-1ee4-46d7-ae2c-f01d645e8a53"), "MUR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mauritius Rupee", "Rs" },
                    { new Guid("5c2535d7-ab4a-419a-90de-104427a5740d"), "STN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Dobra", "Db" },
                    { new Guid("5d9fe5fa-51f5-4f48-9de1-b84c90558d3e"), "IRR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Iranian Rial", "﷼" },
                    { new Guid("5dac84a3-3472-4b5a-9147-cb3c0f933154"), "CVE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cape Verde Escudo", "$" },
                    { new Guid("5e53666d-7b5d-44bc-85bf-0d97f2ab9ae5"), "VEF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bolivar Fuerte", "Bs F" },
                    { new Guid("5e596f50-b2de-4551-bf62-4b5e50f56089"), "TZS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tanzanian Shilling", "Sh" },
                    { new Guid("5e88adce-744b-4ec7-a06c-e6b699875015"), "GEL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lari", "ლ" },
                    { new Guid("5ec38fc0-6bf5-45ce-8568-cc50ed012556"), "QAR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Qatari Rial", "ر.ق" },
                    { new Guid("66885926-8c7c-4fc9-9c34-b312c8504746"), "IDR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Rupiah", "Rp" },
                    { new Guid("6694022c-ff9f-47d3-9055-ff0294bbaba3"), "PEN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Nuevo Sol", "S/." },
                    { new Guid("71f55ab0-79b2-4339-855d-c83dcb9de1f0"), "TJS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Somoni", "ЅМ" },
                    { new Guid("74096b11-2645-4297-884e-a848c176e866"), "PGK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kinal", "K" },
                    { new Guid("746ea0bd-99c6-436c-b6da-c710fddea68e"), "BYN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Belarusian Ruble", "Br" },
                    { new Guid("76afcd98-8f74-442c-9fb9-4cb7c9ec7d3d"), "KPW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "North Korean Won", "₩" },
                    { new Guid("76f0cbc8-f832-43a4-9902-1feef21ef02c"), "MYR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Malaysian Ringgit", "RM" },
                    { new Guid("79d15283-8a17-44b6-a9d0-7d24a2bf084f"), "CZK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Czech Koruna", "Kč" },
                    { new Guid("7b791a00-0076-4031-b823-ed110e47bee4"), "MGA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Malagasy Ariary", "Ar" },
                    { new Guid("7c68dd4e-45e4-4cda-a0b7-15baecc4e32c"), "RON", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Leu", "RON" },
                    { new Guid("80b2de7c-6185-41ae-b4bb-7a760c51e4b9"), "SHP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Helena Pound", "£" },
                    { new Guid("81d13692-3cb5-498f-9aa6-0a32e1282381"), "DJF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Djibouti Franc", "₣" },
                    { new Guid("85f6e220-39d8-4422-b313-3898d7cafbb7"), "KRW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "South Korean Won", "₩" },
                    { new Guid("8747b578-0ff8-444b-a863-7dbf7529629a"), "TND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tunisian Dinar", "د.ت" },
                    { new Guid("889d3e01-8281-4c32-b18e-8ed788943576"), "GNF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guinea Franc", "₣" },
                    { new Guid("8a78895f-c7bc-4dcf-ae6e-8911b4f8d558"), "NGN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Naira", "₦" },
                    { new Guid("8df9ad03-089a-42fb-a713-f6f595b440b4"), "PKR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pakistan Rupee", "Rs" },
                    { new Guid("8e25ed6f-629a-4d97-8501-b03e3d28da72"), "DOP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Dominican Peso", "$" },
                    { new Guid("8ed442f5-e431-40b8-8c3c-b5e89c7b6993"), "CHF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Swiss Franc", "₣" },
                    { new Guid("8ef38f15-05ca-4c3d-8c56-9a080b9ba098"), "KES", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kenyan Shilling", "Sh" },
                    { new Guid("97a61f01-a8f9-40d5-8e9a-1f616f89cf27"), "ZWL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Zimbabwe Dollar", "$" },
                    { new Guid("97c80cfa-8cf1-424d-a155-d034df992397"), "SYP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Syrian Pound", "ل.س" },
                    { new Guid("99f9857e-a71b-41dd-bc2e-d47702f470db"), "ILS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "New Israeli Shekel", "₪" },
                    { new Guid("9c875973-f62d-4d35-9155-b7ea8c7a826b"), "MWK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kwacha", "MK" },
                    { new Guid("9f0ebe3f-24d7-4d2b-bfa5-fc0037b831b3"), "LKR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Sri Lanka Rupee", "Rs" },
                    { new Guid("9f5d925e-d89f-40c6-ab9b-5548fac28ff5"), "BOB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Boliviano", "Bs." },
                    { new Guid("9f87e4f7-3607-4f43-aa9f-f4d8e43c41a6"), "GIP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Gibraltar Pound", "£" },
                    { new Guid("9ffd682e-c7a1-47e9-974f-ecb31c6eb4df"), "ZAR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Rand", "R" },
                    { new Guid("a03a89ce-45a3-46cc-a1e6-cc4bc797a655"), "CRC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Costa Rican Colon", "₡" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Symbol" },
                values: new object[,]
                {
                    { new Guid("a1912d8b-073f-47c2-ab77-89a5eaf23bf4"), "TRY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Turkish Lira", "₤" },
                    { new Guid("a2c570e5-80fa-4f50-9af5-68cbe6188b10"), "LAK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kip", "₭" },
                    { new Guid("a2e1236e-4d80-4350-aa90-42b370fcb1b4"), "MAD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Moroccan Dirham", "د.م." },
                    { new Guid("a454f85c-9403-48f8-bc33-40501fe6de91"), "CDF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Congolese Franc", "₣" },
                    { new Guid("a504507e-6d11-410b-a4a0-85f8d755bebf"), "EUR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Euro", "€" },
                    { new Guid("a8c6b5f4-9656-40ea-bb1c-7bbc86d23e15"), "MRU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ouguiya", "UM" },
                    { new Guid("ac466d6d-55de-42d9-b77b-34184e312c1a"), "SDG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Sudanese Pound", "£" },
                    { new Guid("ac66b137-9ec4-452f-8667-a6b238d82024"), "NZD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "New Zealand Dollar", "$" },
                    { new Guid("acdbb548-3b9e-4fa8-9f17-456882b5a71d"), "RSD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Serbian Dinar", "din" },
                    { new Guid("adafe32f-37d1-47e4-b26a-907edefc16f6"), "MVR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Rufiyaa", "ރ." },
                    { new Guid("af8436c9-151f-484b-a651-ef925a375663"), "MDL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Moldovan Leu", "L" },
                    { new Guid("b06dcd5d-1926-4d25-b4bf-30d779b122d3"), "NIO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cordoba Oro", "C$" },
                    { new Guid("b1aeef12-8283-4b12-8ca8-ebcd2c56d7cb"), "IQD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Iraqi Dinar", "ع.د" },
                    { new Guid("b1f430c6-feb2-4946-a3e9-27ad7b87400a"), "SCR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Seychelles Rupee", "Rs" },
                    { new Guid("b2508958-74f3-4b61-ad1b-df4dd0ff2862"), "UZS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Uzbekistan Sum", "so'm" },
                    { new Guid("b418a84f-d0fe-4943-a4dc-8581123270db"), "DKK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Danish Krone", "kr" },
                    { new Guid("b6e8e61f-777c-4752-a45f-23bfa5bf4618"), "BHD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bahraini Dinar", "ب.د" },
                    { new Guid("b84c9976-bea4-4aba-9ee2-867a79db0c53"), "RUB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Russian Ruble", "p." },
                    { new Guid("b95a6e29-7b17-4374-af0a-6412bb1190d4"), "JPY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Yen", "¥" },
                    { new Guid("ba0624b8-e7ea-4da5-b420-6044edf0446e"), "UAH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Hryvnia", "₴" },
                    { new Guid("bb792a62-5351-439a-8cd7-775fafb3f978"), "CAD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Canadian Dollar", "$" },
                    { new Guid("bbe37f0e-0cd9-414e-b1c7-1c2fa30e3127"), "LBP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lebanese Pound", "ل.ل" },
                    { new Guid("bf0bcb94-53c8-4f12-b724-d9e2c25f2b7b"), "MKD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Denar", "ден" },
                    { new Guid("bf7cac9c-f72d-4be7-8b02-7349b3653ff6"), "KYD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cayman Islands Dollar", "$" },
                    { new Guid("bfa33c84-c0f6-4c2e-9730-3723216970ef"), "SRD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Suriname Dollar", "$" },
                    { new Guid("c51169f1-8b36-4dbb-ab16-526790555968"), "BAM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Konvertibilna Marka", "КМ" },
                    { new Guid("c571ef54-dd9a-48f3-ab65-f72397622ad6"), "SBD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Solomon Islands Dollar", "$" },
                    { new Guid("c6034341-eeb3-44c5-91e0-eafe8ff89852"), "SEK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Swedish Krona", "kr" },
                    { new Guid("c6d2892a-ede9-4ced-bfdb-86927482af27"), "GTQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Quetzal", "Q" },
                    { new Guid("c9633b85-fdc6-4a23-a5bd-5c16f6ea59e9"), "MZN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Metical", "MTn" },
                    { new Guid("cca9ead4-389f-4c7c-9d28-7f3e3e37ee5d"), "XPF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "CFP Franc", "₣" },
                    { new Guid("cd450b89-1028-4b0d-b88e-8c45df121a72"), "HNL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lempira", "L" },
                    { new Guid("cdcc6cda-469a-4edc-891e-87429e98a686"), "SLL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Leone", "Le" },
                    { new Guid("d0aafed7-b98e-4a2c-8d7d-ed3aee300d80"), "NPR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Nepalese Rupee", "Rs" },
                    { new Guid("d24d7a51-44aa-4218-bb57-8bf2bac4b559"), "MXN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mexican Peso", "$" },
                    { new Guid("d284c9e8-1d6e-4d16-a50f-8cdb32e1aeb7"), "VND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Dong", "₫" },
                    { new Guid("d463441c-d344-4dfb-9e9d-4baa2d85e015"), "PAB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Balboa", "B/." },
                    { new Guid("d4c99f56-8355-4549-8f06-a323fae6fc14"), "BMD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bermudian Dollar", "$" },
                    { new Guid("d6bbc115-4506-42b2-8335-14e2ed521dca"), "AWG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Aruban Guilder/Florin", "ƒ" },
                    { new Guid("d808adf8-36ed-4c74-bb6e-ddab0e079e65"), "BND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Brunei Dollar", "$" },
                    { new Guid("d8cc7379-bb05-4aa6-b8c6-be732f2346ed"), "THB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Baht", "฿" },
                    { new Guid("db57e6a2-9e27-4f4c-817a-c73ba702a4ab"), "SGD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Singapore Dollar", "$" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Symbol" },
                values: new object[,]
                {
                    { new Guid("dce91fee-d470-462b-be7a-fc7c1ed17f4c"), "UYU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Peso Uruguayo", "$" },
                    { new Guid("df1e8083-b39c-4a99-b809-1617a1acc5c4"), "MNT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tugrik", "₮" },
                    { new Guid("e0d0ba47-d094-487a-b531-2faa6120ea06"), "DZD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Algerian Dinar", "د.ج" },
                    { new Guid("e1c886c2-6ad9-43f3-93b2-93313e2eef3c"), "BTN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ngultrum", "Nu." },
                    { new Guid("e1eda86a-a609-4a9a-a96e-e42f700c37a3"), "LRD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Liberian Dollar", "$" },
                    { new Guid("e693483b-b3ae-4e73-b2c5-e67ed4403091"), "KZT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tenge", "〒" },
                    { new Guid("e8621b22-291d-41b3-acf6-23eea91735f4"), "FKP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Falkland Islands Pound", "£" },
                    { new Guid("ebd73833-4e5e-4924-a2f2-a88ed964214e"), "COP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Colombian Peso", "$" },
                    { new Guid("ec1e79a6-9122-48ab-ab67-afaaec588a9b"), "BWP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pula", "P" },
                    { new Guid("f0ead796-0f47-4a50-ade3-27617e61cde8"), "AUD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Australian Dollar", "$" },
                    { new Guid("f1ce196c-2451-4df1-b0d8-9bb1dee3235a"), "JMD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Jamaican Dollar", "$" },
                    { new Guid("f1e60653-7199-41bf-82ec-ef20f313c0f1"), "GBP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pound Sterling", "£" },
                    { new Guid("f6313a43-07e4-49c5-9026-a34e9facfe75"), "AOA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kwanza", "Kz" },
                    { new Guid("f680ca8e-6c85-4be8-b32e-14382f35c9b0"), "LSL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Loti", "L" },
                    { new Guid("f7054ffb-c317-40bf-9f56-2944808825fa"), "HKD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Hong Kong Dollar", "$" },
                    { new Guid("f7138b1d-a65b-4f81-9e3d-256ebe3b7705"), "FJD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Fiji Dollar", "$" },
                    { new Guid("f7836c16-e6ff-49ac-8c5e-15fd2973804d"), "AZN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Azerbaijanian Manat", "ман" },
                    { new Guid("f86549a2-8804-4883-bb0f-11890fbd543c"), "RWF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Rwanda Franc", "₣" },
                    { new Guid("f8d9b318-b4ff-4976-a489-7881c5680e2f"), "CUP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cuban Peso", "$" },
                    { new Guid("f9a5b288-6a73-435e-af81-7cb11828a68e"), "WST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tala", "T" },
                    { new Guid("fabef5eb-0c50-432e-aedc-4791a34a2c5e"), "GYD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guyana Dollar", "$" },
                    { new Guid("fc3e5c7a-f170-463b-a1bc-884513cdc781"), "UGX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Uganda Shilling", "Sh" },
                    { new Guid("fdf2c9ce-8ea5-4149-87a3-f4bb3a2d8b61"), "BSD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bahamian Dollar", "$" },
                    { new Guid("fe4f5863-343d-4126-9cc5-1c1578c6e0cd"), "PYG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guarani", "₲" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("013518cd-3efa-47a0-a4ee-b65af47b8085"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0193fbe5-1cf9-4a8c-bdfd-c6e8ac52c265"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0242ddf8-b5fb-47cc-bbaf-9447b2bb617d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("03218f47-cad9-49f5-8df3-99d889c3e7f7"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0507516a-b3a6-4853-97e5-a5115b547c89"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("05273da8-36a2-4e2d-b4dd-5f8e51a9d133"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("05a73978-2bf4-489c-a443-119ff93ae41e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("06eae394-e230-48b5-b49a-d0df9e9dc83a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("075f5efa-86b7-4e3b-9e94-ace45456502a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("07b3d397-c5d1-4f08-ae67-4e7d70022494"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("08c1db27-af88-4e55-9119-b2487c02f9c8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("08e5907a-c661-4130-8e9e-4a4608d70e18"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0d7a6c0d-493a-4cf3-93dc-cea60a1e80ab"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0dfe6c21-5262-4d28-b527-ff5bdba8523e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("101a17b0-84d4-4172-a263-8202f8ad8685"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("10abeb74-b34d-4c4f-8f0f-f98a77d46d0a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("128e700c-d38b-4611-a541-508757e76c0d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("12a5cd34-342d-4eaa-bb50-e25a1512169f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("12d340d2-7ec5-4410-85bf-e1b660c53ea2"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1c7b838d-648e-4cd6-9d71-bb08fcb6e56e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1d1cff2e-9609-4fc1-b647-d499948d7bdc"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1d86b997-a16d-4e4b-bf47-031ff44074e9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("221bec73-6e28-421b-a857-0e68f6621e19"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("2432cbf2-7193-454d-8d92-c49a32d8af37"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("26a51fd0-30d1-4060-9b88-4b1c9340596c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("282d42ba-8763-4356-a967-7aa06c1710d8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3066047f-3491-4b4e-b23c-5fbd2faa3733"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("32a2ee36-bad3-48c3-8bfc-44a1df4f8e9a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("32d368eb-a339-49e0-9ee4-4dbca54811cb"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3301f910-cc11-480a-b771-573b11a326be"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("361b8d8d-b602-4642-8040-eaf373fff4fd"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("384aaf27-315c-428e-8d13-8a52dde32e5a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3aa5aa65-88b5-4e82-aea4-0903d9dbfbda"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3c0624b3-1884-4f89-af71-2f8567c273e8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3c86f9e4-e188-4d3d-8d14-52eb94930a4e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3e967e7b-c502-425d-be8e-3167bc2e1f16"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("405fa24f-5350-467b-955d-4fe8b1d19bea"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("4818df0d-438a-4812-b1eb-53aea480466d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("4dba6584-36c3-4296-9ce8-6b02790cd34a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("4f25ebd9-5a79-46ff-8a71-211e2f0b7b11"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("501e67ac-404b-4f97-8172-401b055959d5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("578b8359-6cd6-46ce-b3d6-b73692694bb5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5793d68c-3894-4af3-9b7f-7d0ad724a7f1"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("591752f1-8871-44aa-97fa-ae40762c54cf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5a5ae944-1ee4-46d7-ae2c-f01d645e8a53"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5c2535d7-ab4a-419a-90de-104427a5740d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5d9fe5fa-51f5-4f48-9de1-b84c90558d3e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5dac84a3-3472-4b5a-9147-cb3c0f933154"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5e53666d-7b5d-44bc-85bf-0d97f2ab9ae5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5e596f50-b2de-4551-bf62-4b5e50f56089"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5e88adce-744b-4ec7-a06c-e6b699875015"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5ec38fc0-6bf5-45ce-8568-cc50ed012556"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("66885926-8c7c-4fc9-9c34-b312c8504746"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6694022c-ff9f-47d3-9055-ff0294bbaba3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("71f55ab0-79b2-4339-855d-c83dcb9de1f0"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("74096b11-2645-4297-884e-a848c176e866"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("746ea0bd-99c6-436c-b6da-c710fddea68e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("76afcd98-8f74-442c-9fb9-4cb7c9ec7d3d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("76f0cbc8-f832-43a4-9902-1feef21ef02c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("79d15283-8a17-44b6-a9d0-7d24a2bf084f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7b791a00-0076-4031-b823-ed110e47bee4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7c68dd4e-45e4-4cda-a0b7-15baecc4e32c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("80b2de7c-6185-41ae-b4bb-7a760c51e4b9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("81d13692-3cb5-498f-9aa6-0a32e1282381"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("85f6e220-39d8-4422-b313-3898d7cafbb7"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8747b578-0ff8-444b-a863-7dbf7529629a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("889d3e01-8281-4c32-b18e-8ed788943576"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8a78895f-c7bc-4dcf-ae6e-8911b4f8d558"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8df9ad03-089a-42fb-a713-f6f595b440b4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8e25ed6f-629a-4d97-8501-b03e3d28da72"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8ed442f5-e431-40b8-8c3c-b5e89c7b6993"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("8ef38f15-05ca-4c3d-8c56-9a080b9ba098"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("97a61f01-a8f9-40d5-8e9a-1f616f89cf27"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("97c80cfa-8cf1-424d-a155-d034df992397"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("99f9857e-a71b-41dd-bc2e-d47702f470db"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("9c875973-f62d-4d35-9155-b7ea8c7a826b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("9f0ebe3f-24d7-4d2b-bfa5-fc0037b831b3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("9f5d925e-d89f-40c6-ab9b-5548fac28ff5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("9f87e4f7-3607-4f43-aa9f-f4d8e43c41a6"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("9ffd682e-c7a1-47e9-974f-ecb31c6eb4df"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a03a89ce-45a3-46cc-a1e6-cc4bc797a655"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a1912d8b-073f-47c2-ab77-89a5eaf23bf4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a2c570e5-80fa-4f50-9af5-68cbe6188b10"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a2e1236e-4d80-4350-aa90-42b370fcb1b4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a454f85c-9403-48f8-bc33-40501fe6de91"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a504507e-6d11-410b-a4a0-85f8d755bebf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a8c6b5f4-9656-40ea-bb1c-7bbc86d23e15"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ac466d6d-55de-42d9-b77b-34184e312c1a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ac66b137-9ec4-452f-8667-a6b238d82024"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("acdbb548-3b9e-4fa8-9f17-456882b5a71d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("adafe32f-37d1-47e4-b26a-907edefc16f6"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("af8436c9-151f-484b-a651-ef925a375663"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b06dcd5d-1926-4d25-b4bf-30d779b122d3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b1aeef12-8283-4b12-8ca8-ebcd2c56d7cb"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b1f430c6-feb2-4946-a3e9-27ad7b87400a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b2508958-74f3-4b61-ad1b-df4dd0ff2862"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b418a84f-d0fe-4943-a4dc-8581123270db"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b6e8e61f-777c-4752-a45f-23bfa5bf4618"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b84c9976-bea4-4aba-9ee2-867a79db0c53"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b95a6e29-7b17-4374-af0a-6412bb1190d4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ba0624b8-e7ea-4da5-b420-6044edf0446e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bb792a62-5351-439a-8cd7-775fafb3f978"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bbe37f0e-0cd9-414e-b1c7-1c2fa30e3127"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bf0bcb94-53c8-4f12-b724-d9e2c25f2b7b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bf7cac9c-f72d-4be7-8b02-7349b3653ff6"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bfa33c84-c0f6-4c2e-9730-3723216970ef"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c51169f1-8b36-4dbb-ab16-526790555968"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c571ef54-dd9a-48f3-ab65-f72397622ad6"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c6034341-eeb3-44c5-91e0-eafe8ff89852"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c6d2892a-ede9-4ced-bfdb-86927482af27"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c9633b85-fdc6-4a23-a5bd-5c16f6ea59e9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cca9ead4-389f-4c7c-9d28-7f3e3e37ee5d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cd450b89-1028-4b0d-b88e-8c45df121a72"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cdcc6cda-469a-4edc-891e-87429e98a686"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d0aafed7-b98e-4a2c-8d7d-ed3aee300d80"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d24d7a51-44aa-4218-bb57-8bf2bac4b559"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d284c9e8-1d6e-4d16-a50f-8cdb32e1aeb7"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d463441c-d344-4dfb-9e9d-4baa2d85e015"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d4c99f56-8355-4549-8f06-a323fae6fc14"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d6bbc115-4506-42b2-8335-14e2ed521dca"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d808adf8-36ed-4c74-bb6e-ddab0e079e65"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d8cc7379-bb05-4aa6-b8c6-be732f2346ed"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("db57e6a2-9e27-4f4c-817a-c73ba702a4ab"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("dce91fee-d470-462b-be7a-fc7c1ed17f4c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("df1e8083-b39c-4a99-b809-1617a1acc5c4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e0d0ba47-d094-487a-b531-2faa6120ea06"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e1c886c2-6ad9-43f3-93b2-93313e2eef3c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e1eda86a-a609-4a9a-a96e-e42f700c37a3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e693483b-b3ae-4e73-b2c5-e67ed4403091"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e8621b22-291d-41b3-acf6-23eea91735f4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ebd73833-4e5e-4924-a2f2-a88ed964214e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ec1e79a6-9122-48ab-ab67-afaaec588a9b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f0ead796-0f47-4a50-ade3-27617e61cde8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f1ce196c-2451-4df1-b0d8-9bb1dee3235a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f1e60653-7199-41bf-82ec-ef20f313c0f1"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f6313a43-07e4-49c5-9026-a34e9facfe75"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f680ca8e-6c85-4be8-b32e-14382f35c9b0"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f7054ffb-c317-40bf-9f56-2944808825fa"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f7138b1d-a65b-4f81-9e3d-256ebe3b7705"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f7836c16-e6ff-49ac-8c5e-15fd2973804d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f86549a2-8804-4883-bb0f-11890fbd543c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f8d9b318-b4ff-4976-a489-7881c5680e2f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f9a5b288-6a73-435e-af81-7cb11828a68e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fabef5eb-0c50-432e-aedc-4791a34a2c5e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fc3e5c7a-f170-463b-a1bc-884513cdc781"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fdf2c9ce-8ea5-4149-87a3-f4bb3a2d8b61"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fe4f5863-343d-4126-9cc5-1c1578c6e0cd"));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3921fefc-6553-44fd-9e1d-ebbe9336dfd5"),
                columns: new[] { "Code", "Name", "Symbol" },
                values: new object[] { "ALL", "Lek", "Lek" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("69ad7020-d123-4089-a15e-c65dafffc7ce"),
                columns: new[] { "Code", "Name", "Symbol" },
                values: new object[] { "ARS", "Peso", "$" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ecf57a23-5eb2-444e-9bae-17a0da010587"),
                column: "Name",
                value: "United States Dollar");
        }
    }
}
