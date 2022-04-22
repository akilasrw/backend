using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroclub.Cargo.Data.Migrations
{
    public partial class Update_Country_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("007490a3-3aff-4704-92de-a9ff215c9786"), "SRB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Serbia" },
                    { new Guid("0379790f-9d3e-446e-9729-8baa649c0fdb"), "BFA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Burkina Faso" },
                    { new Guid("03ed178a-8a03-427d-b5e2-6c3d2b5e960f"), "SGP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Singapore" },
                    { new Guid("06a57ceb-dc13-43dd-bdd3-5f5af2acb28a"), "ETH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ethiopia" },
                    { new Guid("06f6b99d-43ef-4ab6-ba6c-3c2961e3f49a"), "KGZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kyrgyzstan" },
                    { new Guid("0701879b-de90-454c-ba4e-8613307f24f8"), "PRI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Puerto Rico" },
                    { new Guid("0744a496-27e0-489f-ad9d-e21415fd0f39"), "TTO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Trinidad and Tobago" },
                    { new Guid("07ee848c-3324-4c5d-96e3-b989783c8d2e"), "NIU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Niue" },
                    { new Guid("09131b81-f6d5-41e0-9e1a-5b2f22d93fb6"), "ESH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Western Sahara" },
                    { new Guid("09bfe7b1-98c3-44a6-8854-fd55937c8a16"), "GNB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guinea-Bissau" },
                    { new Guid("0abf19b6-65f5-4dc4-9adf-6747b86ab7be"), "ARG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Argentina" },
                    { new Guid("0affb432-24c5-4353-b649-9ae0c0aa7cd0"), "ZAF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "South Africa" },
                    { new Guid("0bc9a159-2351-45d3-891d-22b01df4289b"), "HTI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Haiti" },
                    { new Guid("0c0664b4-86ed-4069-885a-f79dbd408ebb"), "CYM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cayman Islands" },
                    { new Guid("0e2c05e5-b9dd-4cc8-b79f-a7d0e7cf2cc8"), "BEN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Benin" },
                    { new Guid("0e2fe529-a95c-48f5-b126-7ed2b00f4123"), "NZL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "New Zealand" },
                    { new Guid("0e9c5ccb-f8d4-42e3-986d-0449b913ae8d"), "SAU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saudi Arabia" },
                    { new Guid("0f70f234-eee7-4ccc-9017-244a1b70558e"), "MAF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Martin (French part)" },
                    { new Guid("12742110-ffcc-447a-a1cb-080cbc6a82e4"), "TZA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tanzania, United Republic of" },
                    { new Guid("12a35c31-d359-4512-b5ad-d18554efd0c5"), "BVT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bouvet Island" },
                    { new Guid("12c95134-dfd9-4133-90c2-8469232c8880"), "URY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Uruguay" },
                    { new Guid("1352c28c-6f76-48ce-a09a-dc85e04698df"), "TKM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Turkmenistan" },
                    { new Guid("1481bb05-6a70-40ea-aa6e-a2c119baaba4"), "ATA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Antarctica" },
                    { new Guid("164494df-08cc-4608-8b8d-54577044192b"), "IDN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Indonesia" },
                    { new Guid("1749a1b6-d1d6-47f5-8a0d-730348fb14ab"), "SHN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Helena, Ascension and Tristan da Cunha" },
                    { new Guid("1762ed6a-d954-4385-8373-723dcf78ccdd"), "JAM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Jamaica" },
                    { new Guid("188b9730-ba3d-47d3-b892-b76bce81b73f"), "CHN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "China" },
                    { new Guid("19db30c1-f639-4980-96dc-d7009ca9c17c"), "KIR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kiribati" },
                    { new Guid("19e88b0c-6a21-4404-a9b3-a7351cc7820d"), "PLW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Palau" },
                    { new Guid("1a40742b-db41-41c8-9716-d636dec114cf"), "MEX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mexico" },
                    { new Guid("1a95056e-de08-40c6-bed6-dd9cf47a2021"), "MLT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Malta" },
                    { new Guid("1ab871d3-0c39-402a-9c2c-b9317d38d4f3"), "SMR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "San Marino" },
                    { new Guid("1ae08def-6a38-486f-934d-009b55b4fbfb"), "GRD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Grenada" },
                    { new Guid("1bac0194-b11c-4718-8b45-8495b9eefdb8"), "CRI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Costa Rica" },
                    { new Guid("1c52f038-4e78-4df3-abb4-f1339f945b02"), "DMA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Dominica" },
                    { new Guid("1ca64b7e-1e7a-4218-9a5b-dd9f2e294fd8"), "UGA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Uganda" },
                    { new Guid("1d789580-5ad3-489d-aba4-e134febc896f"), "KNA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Kitts and Nevis" },
                    { new Guid("1e37183f-a30b-4e8a-995c-e101e0ba76bd"), "VCT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Vincent and the Grenadines" },
                    { new Guid("1e5f4f2c-d4de-4307-889c-8f22220ac52f"), "CCK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cocos (Keeling) Islands" },
                    { new Guid("1ef0d50e-8eed-4283-8e4e-53f266e0e743"), "MNP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Northern Mariana Islands" },
                    { new Guid("1fe1097a-df37-4ba8-8780-907344e27749"), "NPL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Nepal" },
                    { new Guid("203b8cf7-d679-4ffe-8264-7c7f0f6846b5"), "ECU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ecuador" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("2120097a-7482-42bd-a3a1-914a92f6fc4e"), "MKD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Republic of North Macedonia" },
                    { new Guid("22eb66a9-8e87-461f-8f02-da0f698a2348"), "CZE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Czechia" },
                    { new Guid("2558672f-a283-4ad6-a542-8ca335f7ec3d"), "PRY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Paraguay" },
                    { new Guid("259a23c3-c736-4aea-8aaa-34ce04d34a43"), "TGO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Togo" },
                    { new Guid("2630173f-1f99-462d-8935-19aa5bc80392"), "BTN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bhutan" },
                    { new Guid("28439598-d622-4a12-b95f-97f71a43aaa1"), "GNQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Equatorial Guinea" },
                    { new Guid("28803583-bbb2-48e6-a9ab-aebdc8569ee1"), "GUM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guam" },
                    { new Guid("2aa5c8a1-cc6d-4294-a7bf-277c08bb9f19"), "IRN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Iran" },
                    { new Guid("2ade10ab-47d6-4d51-af38-5abcdb467397"), "GIB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Gibraltar" },
                    { new Guid("2bd766c6-ec09-4e9b-ade2-2361f1652e85"), "GHA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ghana" },
                    { new Guid("2c65c038-637a-4051-8c45-76e3a2256fa9"), "BLZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Belize" },
                    { new Guid("2d84b613-60bf-41a1-b3e0-63dfbe9d77e5"), "SSD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "South Sudan" },
                    { new Guid("2f0d2e7f-8e57-410a-a1fa-5163cf216e69"), "GMB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Gambia" },
                    { new Guid("2fcbe0e0-f03f-4f40-aa46-68dfda0bc199"), "CUW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Curaçao" },
                    { new Guid("31320069-32f5-451a-adff-e6e67466472c"), "THA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Thailand" },
                    { new Guid("32408407-845f-49d3-84e3-a21264decad7"), "SEN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Senegal" },
                    { new Guid("3256f69d-d067-42b3-925e-ca5ee79b9d5d"), "LIE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Liechtenstein" },
                    { new Guid("32fb8804-b60a-425a-b22e-665cee5c0e20"), "HMD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Heard Island and McDonald Islands" },
                    { new Guid("3304a1ae-e479-4368-9ecf-73f849ebfd19"), "DOM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Dominican Republic" },
                    { new Guid("332cdc02-2704-4ca7-9c51-8028e5536c0d"), "EGY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Egypt" },
                    { new Guid("33372068-b847-4fb5-9754-0e6a1bba4746"), "MAC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Macao" },
                    { new Guid("334193bb-6cae-4dfd-904c-b560a6465401"), "TCD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Chad" },
                    { new Guid("34e4c89c-3e46-4509-b5ca-3a4b05b2a926"), "FRA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "France" },
                    { new Guid("37b80fa9-57ff-4c50-bfcc-0be74ab3abe1"), "SWE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Sweden" },
                    { new Guid("396bc4b1-c9db-4c7a-9313-f2ab5dd128cc"), "PYF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "French Polynesia" },
                    { new Guid("39c425ec-85fc-4172-92f0-9bb0fe044414"), "LUX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Luxembourg" },
                    { new Guid("3bfb6aa0-984c-4045-af03-60b9bf69c614"), "SVK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Slovakia" },
                    { new Guid("3ca77ca4-2a0a-456d-af6c-afc456080800"), "TLS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Timor-Leste" },
                    { new Guid("3dd42ba5-8978-4c27-a59a-ede1d8f1c3da"), "PNG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Papua New Guinea" },
                    { new Guid("3e482d32-880b-429d-b1b9-81af13c69345"), "DJI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Djibouti" },
                    { new Guid("3e63f4fb-be25-4c00-b50d-ecd98f0a466b"), "MUS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mauritius" },
                    { new Guid("3f465ab0-5ba0-4553-b210-c8e85db267ab"), "NLD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Netherlands" },
                    { new Guid("3ff4ec94-2f5e-47d6-a608-1a24fdf9315a"), "BGD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bangladesh" },
                    { new Guid("41469743-84a6-4f95-bf5c-8b378655c890"), "GLP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guadeloupe" },
                    { new Guid("43f20622-ca0e-4bb3-b1a3-fa7d0de2438d"), "BMU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bermuda" },
                    { new Guid("45447320-2c38-45e3-bad8-54ffdaea3719"), "ESP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Spain" },
                    { new Guid("48972828-d081-4d0a-b4fd-83e485c4eff4"), "NRU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Nauru" },
                    { new Guid("48bb93e6-26c7-4ce9-a496-fa67ff134ea9"), "LBY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Libya" },
                    { new Guid("48ee54e2-fab4-42e3-b867-d5a0cda8799c"), "SDN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Sudan" },
                    { new Guid("4a9ddb71-4c34-45cd-8c19-824e290ac681"), "KHM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cambodia" },
                    { new Guid("4b4b4be1-329a-48eb-94a1-4ed36a2ac857"), "DEU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Germany" },
                    { new Guid("4c02f00e-be81-45ba-a7b9-60cab735d1f4"), "BRA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Brazil" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("4cd9b676-a604-4b90-8168-bb4d5100b13c"), "BEL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Belgium" },
                    { new Guid("4d9841ed-4ecc-4326-921c-64bdc41de9b7"), "TUN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tunisia" },
                    { new Guid("4fd16746-7297-443c-bb72-bcf59520d0af"), "ITA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Italy" },
                    { new Guid("50ba9bfc-cdcb-4b72-9c78-185b42988fdc"), "TUV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tuvalu" },
                    { new Guid("548c761a-adfd-424b-b690-f977c50d8f5f"), "MNG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mongolia" },
                    { new Guid("563bd9b4-44f3-4f53-a6bd-3ee6c8a23c52"), "ABW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Aruba" },
                    { new Guid("588d2c93-c9e8-4d09-9cd2-3a47efcb45cd"), "GGY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guernsey" },
                    { new Guid("599069d9-5b7d-4084-96c1-227fb0194221"), "BWA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Botswana" },
                    { new Guid("59c56e92-3e42-48b5-93c3-65958e354d73"), "ZMB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Zambia" },
                    { new Guid("5a104614-183a-4405-9a38-d31bb00c8fd5"), "AND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Andorra" },
                    { new Guid("5b309f82-83ef-4d09-b9ba-d406dd55c7dd"), "LSO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lesotho" },
                    { new Guid("5cd5b6a1-3b64-4b2f-a831-3988c34b5259"), "PSE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Palestine, State of" },
                    { new Guid("5d170fab-6946-4be9-b819-9ecd4a051482"), "CAF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Central African Republic" },
                    { new Guid("5dca9f20-ad85-44ae-9f92-054529f534f6"), "AZE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Azerbaijan" },
                    { new Guid("5e0f75f3-c1f8-42eb-818a-cf4eb863fbc5"), "CHE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Switzerland" },
                    { new Guid("5e490e15-b173-4e30-8a94-53eb05576a69"), "BES", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bonaire, Sint Eustatius and Saba" },
                    { new Guid("5e836a27-0783-473e-8354-75855f8724d0"), "MCO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Monaco" },
                    { new Guid("5fba1dd4-a31f-4a86-aa08-7234097ca725"), "FIN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Finland" },
                    { new Guid("5fd44873-24ba-4e3d-a7d8-ebfd811679a8"), "RUS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Russian Federation" },
                    { new Guid("608ba99f-baaf-41e4-83ba-05924412f488"), "LAO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lao People's Democratic Republic" },
                    { new Guid("61bde008-1776-43d2-8853-d643f994bb34"), "COK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cook Islands" },
                    { new Guid("646cce15-95f5-4f87-be7c-d844e2e0387e"), "MTQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Martinique" },
                    { new Guid("67874e4f-0e9a-4ec2-bffd-ea5c9a7012fb"), "KWT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kuwait" },
                    { new Guid("6868a8aa-1bc4-4ba2-acf1-7ede7ec7d51e"), "PCN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pitcairn" },
                    { new Guid("68ebd19a-4eef-4c91-a7c8-be3b0c4f1fab"), "SGS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "South Georgia and the South Sandwich Islands" },
                    { new Guid("699c74c3-c306-47a7-a87c-af5d358dfd53"), "CPV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cabo Verde" },
                    { new Guid("69e69091-1efe-4769-8643-9b430f51e8f1"), "NAM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Namibia" },
                    { new Guid("6a72074b-c241-43fc-ba44-930fbc5612c4"), "YEM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Yemen" },
                    { new Guid("6b1818a5-ce64-4a3d-9139-e9e0a2103da3"), "COD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Congo (the Democratic Republic of the)" },
                    { new Guid("6be035f9-7f51-4b95-8968-6202d26e792d"), "NOR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Norway" },
                    { new Guid("6c38fdbe-6866-4dc5-8fbc-5d1b47ff58b1"), "MNE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Montenegro" },
                    { new Guid("6cff3f97-3ea9-4a01-93cc-76d09eddba62"), "ASM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "American Samoa" },
                    { new Guid("6e9213dc-36d2-4a1b-b082-04b3ab12743a"), "GIN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guinea" },
                    { new Guid("6e9ce70a-6820-4df3-9356-1788efa32172"), "SOM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Somalia" },
                    { new Guid("6edf8e9a-0e93-4bbd-be09-28279c469664"), "MOZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mozambique" },
                    { new Guid("6fa2538e-6962-48e2-a8da-76e74fbccad7"), "TWN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Taiwan" },
                    { new Guid("725f89ce-dad8-44f6-8516-e82b63be3b42"), "REU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Réunion" },
                    { new Guid("743d46de-4966-49c6-bb4b-5c4d147d7cc2"), "AIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Anguilla" },
                    { new Guid("751dfe46-4f8f-4ef6-af27-feabe9e0979c"), "PRT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Portugal" },
                    { new Guid("75b1d0fa-b6ea-494d-a662-467f4b2e0e89"), "MYT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mayotte" },
                    { new Guid("76a1821f-d600-4923-8987-924c751acac2"), "FSM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Micronesia" },
                    { new Guid("775fd1d0-4928-4fab-bbf6-6226d7b26da6"), "VGB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Virgin Islands (British)" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("7941387a-b31a-4cc9-8a1e-214a0d9987c6"), "BRB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Barbados" },
                    { new Guid("797a29f8-f2c0-4659-9954-7c3b46513ed5"), "MWI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Malawi" },
                    { new Guid("7a220e89-2c58-480d-8bdd-fcf6436df94e"), "CXR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Christmas Island" },
                    { new Guid("7bb75a2f-a934-4c53-b201-d98c25bced4c"), "COM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Comoros" },
                    { new Guid("7caf69a3-41e1-423c-a2fd-9b24ce64168b"), "GTM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guatemala" },
                    { new Guid("7ce7e5c2-259a-44c6-a3bf-3688d0cc55c1"), "GRL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Greenland" },
                    { new Guid("7d2e927a-39e3-47e0-97df-ac5bff375986"), "MDA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Moldova" },
                    { new Guid("7dd79823-f689-43c0-998f-732aa4e51ebd"), "CMR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cameroon" },
                    { new Guid("7dde4cbf-5680-4aca-a1ae-b68d49c99f35"), "KOR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Korea (the Republic of)" },
                    { new Guid("7eb70c04-f83a-4455-8ef5-ad5861cf93f7"), "UZB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Uzbekistan" },
                    { new Guid("7eea6f36-7e1c-42d4-a209-480933f6b14b"), "NGA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Nigeria" },
                    { new Guid("804e3923-50fb-43cc-a909-93736b5067c3"), "SPM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Pierre and Miquelon" },
                    { new Guid("81da9a76-4275-468f-b47c-afa056a93436"), "ZWE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Zimbabwe" },
                    { new Guid("82b960e9-77fc-4a30-bfea-89a26fe81d00"), "IMN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Isle of Man" },
                    { new Guid("839df96f-96d4-4718-98e8-ff82adbcad67"), "ISR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Israel" },
                    { new Guid("84b74b5a-6b67-4c5b-b620-85cd9b762283"), "MSR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Montserrat" },
                    { new Guid("85c11a4f-e327-4026-b6e3-5863641dcbdf"), "MYS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Malaysia" },
                    { new Guid("869a9f57-65c0-40b7-8b8f-cdec2be25f3b"), "TJK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tajikistan" },
                    { new Guid("886c5b25-1064-42cd-bf3b-c8fa452960cb"), "PAN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Panama" },
                    { new Guid("892b182b-b2c5-4629-9e4b-19e61072b7ba"), "MDG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Madagascar" },
                    { new Guid("8c269f45-dad0-4aae-b522-bd2de462d74c"), "BHR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bahrain" },
                    { new Guid("8cff6faa-b4e5-46d2-831d-ecc37614ded5"), "COG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Congo" },
                    { new Guid("8d1d4d5d-c283-4399-9b79-3088601d76aa"), "WLF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Wallis and Futuna" },
                    { new Guid("8e822db7-db15-4e17-afc7-03302fca2af5"), "RWA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Rwanda" },
                    { new Guid("8eea3b5a-4fa1-4bd0-afd5-8c84603ae5fd"), "CUB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cuba" },
                    { new Guid("8f41504a-9fe6-4495-9fa0-9816a0961698"), "KEN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kenya" },
                    { new Guid("8fa43023-9c81-43ad-b738-e7bbd7aa2d41"), "NCL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "New Caledonia" },
                    { new Guid("907e5ff5-1777-4e13-8dee-a6a04f136e04"), "FLK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Falkland Islands (the) [Malvinas]" },
                    { new Guid("91ed6f16-3ead-4e5f-8a34-c8e3090220f8"), "BRN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Brunei Darussalam" },
                    { new Guid("923eb268-a4f7-467a-90ea-4e8fce41aaeb"), "ALA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Åland Islands" },
                    { new Guid("9354b631-7a08-4014-9fd0-2f8af5977e0c"), "USA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "United States of America" },
                    { new Guid("9354bb3b-e939-4177-8213-d20532230d0b"), "SLV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "El Salvador" },
                    { new Guid("9369bd87-f713-439c-994d-6da8e6b1d7e7"), "BHS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bahamas" },
                    { new Guid("938d073e-545c-4ca7-8ee4-279bffa62335"), "JPN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Japan" },
                    { new Guid("974ffe2c-d954-4000-84a0-d076add27e07"), "IRL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ireland" },
                    { new Guid("97599c69-0425-4a38-950d-52cbbcfdcbe1"), "ISL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Iceland" },
                    { new Guid("99c85b54-6995-4474-9ad2-a435af2f14e8"), "LVA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Latvia" },
                    { new Guid("9ba6165b-2051-4916-a151-a7b0a41d22b5"), "GBR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "United Kingdom of Great Britain and Northern Ireland" },
                    { new Guid("9c31c3e5-3ed0-46b8-857c-7c9e328590a9"), "GRC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Greece" },
                    { new Guid("9c6c8c35-a4b5-4af4-867f-706e5ddab0f1"), "MLI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mali" },
                    { new Guid("9cf93973-2f6b-4d3a-b5d0-5851b98ccb75"), "DNK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Denmark" },
                    { new Guid("9db0b083-fc26-4580-a874-e4863c4fcd55"), "STP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Sao Tome and Principe" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("9e281147-6987-4358-b0cb-dcd00c1a8495"), "BLR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Belarus" },
                    { new Guid("9eab9b50-6fc6-4809-b75e-c66f79b5a00e"), "HRV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Croatia" },
                    { new Guid("a00335c3-91c3-406b-a936-288359290c69"), "GEO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Georgia" },
                    { new Guid("a2dcb332-2ca5-44df-8d04-4c86976681bd"), "AUT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Austria" },
                    { new Guid("a42713ff-af7d-40a6-9a9f-2bdf72e6e2f9"), "AGO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Angola" },
                    { new Guid("a511689a-9f05-4ff3-af94-c33f2cf2c39d"), "SUR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Suriname" },
                    { new Guid("a632eb13-6706-4ef4-9fbc-fbc4ab87da1a"), "GUF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "French Guiana" },
                    { new Guid("a73291f0-0b17-48da-9128-b7c68d087e0d"), "ROU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Romania" },
                    { new Guid("a7cce24c-353f-460b-86c2-0fbde42c36c8"), "VAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Holy See" },
                    { new Guid("a88cb59b-e9e2-4b23-adab-ce13c37d9648"), "ERI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Eritrea" },
                    { new Guid("ace81a0b-e0d1-40ed-b5a9-d88c6258d81f"), "BLM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Barthélemy" },
                    { new Guid("ae152f14-59c1-4249-b366-9266df1cbf4c"), "SLE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Sierra Leone" },
                    { new Guid("afa392a6-3b48-4234-8fcc-99748c5b51bc"), "COL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Colombia" },
                    { new Guid("b00c7dbd-1d9e-47c3-a071-5f660f8cacb3"), "NIC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Nicaragua" },
                    { new Guid("b1af3082-9f02-4047-8bab-a38598218d83"), "DZA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Algeria" },
                    { new Guid("b20d0104-4fee-44fb-998d-4c4ef427c589"), "POL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Poland" },
                    { new Guid("b2473cd6-d948-4c72-9e7c-968b7a8236ed"), "GAB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Gabon" },
                    { new Guid("b3680d5c-a324-4722-8359-005d227d470c"), "MAR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Morocco" },
                    { new Guid("b4fd9ee5-380a-4f49-b849-758ea506eeae"), "NFK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Norfolk Island" },
                    { new Guid("b5029def-6a1f-4a3e-bc68-5a1e0e9f2b86"), "IRQ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Iraq" },
                    { new Guid("b5a3f75a-b3cf-4a9d-b811-a2320e845d48"), "LBR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Liberia" },
                    { new Guid("b5a62c03-cf0a-447c-ace8-5d627e705ebb"), "ATG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Antigua and Barbuda" },
                    { new Guid("b5d506dd-fb4f-455c-9ec2-4bd0969f9c14"), "TKL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tokelau" },
                    { new Guid("b6376b42-b4a1-4ad9-abe4-5fecfd0871f5"), "BIH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bosnia and Herzegovina" },
                    { new Guid("b77b7f46-3bb8-4457-9719-01f1e8d13010"), "BOL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bolivia" },
                    { new Guid("bf6a0c46-960a-4360-a53d-c2e61d2380c9"), "ARM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Armenia" },
                    { new Guid("bf9a9e60-68b2-49ba-970a-66e24f4bea2f"), "CIV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Côte d'Ivoire" },
                    { new Guid("c0419a04-6170-4b77-afd0-e99db49783c5"), "QAT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Qatar" },
                    { new Guid("c0d82186-e7fa-4911-bbf1-7dffa6f9ac59"), "LBN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lebanon" },
                    { new Guid("c20f8093-77ea-4e7c-bdfa-7e80ebc06b57"), "PRK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Korea (the Democratic People's Republic of)" },
                    { new Guid("c23b019e-93c2-4800-a861-1d2fd6996b56"), "FJI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Fiji" },
                    { new Guid("c2efc69d-351e-4ed1-b8b8-d60e3024673d"), "TCA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Turks and Caicos Islands" },
                    { new Guid("c45b72a8-ac43-43c2-b799-fb2388a69eae"), "FRO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Faroe Islands" },
                    { new Guid("c65248cc-f376-4736-8513-e8654765be87"), "AFG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Afghanistan" },
                    { new Guid("c6eb4c96-de30-4ad2-ba31-ff317f06f2f0"), "JOR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Jordan" },
                    { new Guid("c712cd74-4cc4-4731-a30a-7e2abeeef81b"), "PHL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Philippines" },
                    { new Guid("c74ebb55-2e5a-4e54-868f-175e266785e3"), "MHL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Marshall Islands" },
                    { new Guid("c88d8e32-669e-4721-a4d5-36ad48820be1"), "MDV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Maldives" },
                    { new Guid("c9789e49-0b19-4bda-a31c-014d860dc77b"), "SWZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Eswatini" },
                    { new Guid("ca956b1b-c7ad-4107-af40-e1f62804df20"), "CHL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Chile" },
                    { new Guid("cafb32d5-8b3e-432f-9168-2ad58d5695b7"), "SYR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Syrian Arab Republic" },
                    { new Guid("cb64b710-ee85-45e0-b3b3-ee3e842882fe"), "BDI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Burundi" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("cbf4e6cc-016f-48ed-85e2-aad1d3bfa354"), "VUT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Vanuatu" },
                    { new Guid("cd074a6d-f8f0-4c5d-bb38-0ce740ce8ccf"), "HND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Honduras" },
                    { new Guid("cdb01d36-080f-4f05-9f51-7e33061c04ef"), "UMI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "United States Minor Outlying Islands" },
                    { new Guid("cfb5645b-b3b1-4b0d-8290-952c94463cb8"), "PER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Peru" },
                    { new Guid("d07becd4-a89f-478a-aaf2-1f4c30e19c50"), "SJM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Svalbard and Jan Mayen" },
                    { new Guid("d1989d46-0266-4ada-9782-a4e066fef982"), "EST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Estonia" },
                    { new Guid("d1eb4b50-a9db-4761-af73-3ac7be7a2adf"), "AUS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Australia" },
                    { new Guid("d4001861-5bee-4a72-90a5-06057ca1fee4"), "WSM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Samoa" },
                    { new Guid("d7748f1f-32da-46f5-9ad7-d52815a4963a"), "KAZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Kazakhstan" },
                    { new Guid("d7ba4e2c-ad95-4e1d-820a-6375dd8d12df"), "SVN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Slovenia" },
                    { new Guid("d818b49c-a79d-4c50-8b9d-377efa3a4fe7"), "VEN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Venezuela (Bolivarian Republic of)" },
                    { new Guid("d8349952-54bd-41c3-adff-e2447f449d33"), "UKR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Ukraine" },
                    { new Guid("d9398f33-dc81-406f-93fb-5b35981de16c"), "CYP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Cyprus" },
                    { new Guid("dc04f3a8-bd04-4c8e-9dec-5bfd7dbbeb1f"), "IOT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "British Indian Ocean Territory" },
                    { new Guid("dc218f8e-8e5e-469a-a1bf-c396b4361c8b"), "PAK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Pakistan" },
                    { new Guid("e29c6dad-5f0f-4bde-b8e7-5bf5035521cb"), "TON", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Tonga" },
                    { new Guid("e30fc284-63e6-4d32-bf27-9a6c4a7eabad"), "ATF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "French Southern Territories" },
                    { new Guid("e3e17210-55ef-4f12-8b0b-64b3e082ee34"), "HUN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Hungary" },
                    { new Guid("e49e2d04-7564-4978-ae69-6dde29d94757"), "JEY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Jersey" },
                    { new Guid("e6600e32-cb16-4270-a4e3-026b45f6de04"), "GUY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Guyana" },
                    { new Guid("e7f90a64-c637-4d10-8897-012956f8aea7"), "SXM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Sint Maarten (Dutch part)" },
                    { new Guid("e8cc3768-ad4f-49e7-89b2-7c9429d4391a"), "VNM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Viet Nam" },
                    { new Guid("ea018c8f-61ae-42e0-acd4-0fee5764d97a"), "BGR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Bulgaria" },
                    { new Guid("ead4c689-dc05-4a59-bb24-dcd5efe74597"), "ALB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Albania" },
                    { new Guid("ece130ce-eefd-4b79-bf94-6f11b179d2bf"), "TUR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Turkey" },
                    { new Guid("eed272e0-cfdb-42c9-944c-2788c7f02789"), "HKG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Hong Kong" },
                    { new Guid("eed88491-4392-47de-9df7-f40841c5ec25"), "SYC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Seychelles" },
                    { new Guid("f197b730-0bb0-4f0b-9180-adea0a36c303"), "VIR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Virgin Islands (U.S.)" },
                    { new Guid("f1d8c692-2dc2-4f6f-8621-6b46c1ff2110"), "ARE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "United Arab Emirates" },
                    { new Guid("f4341286-e333-4d84-be5f-b4d5dfa947d8"), "LCA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Saint Lucia" },
                    { new Guid("f61c6012-7bef-4d96-ae38-2fa3cf467316"), "SLB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Solomon Islands" },
                    { new Guid("f83a68d2-ef0d-4636-94d2-4afdaaeb4038"), "MRT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Mauritania" },
                    { new Guid("fb8978ee-51e0-44ca-b0e3-039a7e49e10f"), "LTU", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Lithuania" },
                    { new Guid("fea27c4c-7d16-4e99-91d8-378746d803c2"), "MMR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Myanmar" },
                    { new Guid("fef9384f-3898-4e81-bfa3-08ac48ec10c6"), "OMN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Oman" },
                    { new Guid("ffe5b53a-7b04-467b-8a8c-61e0ac817d21"), "NER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), true, false, null, new Guid("00000000-0000-0000-0000-000000000000"), "Niger" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("007490a3-3aff-4704-92de-a9ff215c9786"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0379790f-9d3e-446e-9729-8baa649c0fdb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03ed178a-8a03-427d-b5e2-6c3d2b5e960f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06a57ceb-dc13-43dd-bdd3-5f5af2acb28a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06f6b99d-43ef-4ab6-ba6c-3c2961e3f49a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0701879b-de90-454c-ba4e-8613307f24f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0744a496-27e0-489f-ad9d-e21415fd0f39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07ee848c-3324-4c5d-96e3-b989783c8d2e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09131b81-f6d5-41e0-9e1a-5b2f22d93fb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09bfe7b1-98c3-44a6-8854-fd55937c8a16"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0abf19b6-65f5-4dc4-9adf-6747b86ab7be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0affb432-24c5-4353-b649-9ae0c0aa7cd0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bc9a159-2351-45d3-891d-22b01df4289b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c0664b4-86ed-4069-885a-f79dbd408ebb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e2c05e5-b9dd-4cc8-b79f-a7d0e7cf2cc8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e2fe529-a95c-48f5-b126-7ed2b00f4123"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e9c5ccb-f8d4-42e3-986d-0449b913ae8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f70f234-eee7-4ccc-9017-244a1b70558e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12742110-ffcc-447a-a1cb-080cbc6a82e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12a35c31-d359-4512-b5ad-d18554efd0c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12c95134-dfd9-4133-90c2-8469232c8880"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1352c28c-6f76-48ce-a09a-dc85e04698df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1481bb05-6a70-40ea-aa6e-a2c119baaba4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("164494df-08cc-4608-8b8d-54577044192b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1749a1b6-d1d6-47f5-8a0d-730348fb14ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1762ed6a-d954-4385-8373-723dcf78ccdd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("188b9730-ba3d-47d3-b892-b76bce81b73f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19db30c1-f639-4980-96dc-d7009ca9c17c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19e88b0c-6a21-4404-a9b3-a7351cc7820d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a40742b-db41-41c8-9716-d636dec114cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a95056e-de08-40c6-bed6-dd9cf47a2021"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ab871d3-0c39-402a-9c2c-b9317d38d4f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ae08def-6a38-486f-934d-009b55b4fbfb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bac0194-b11c-4718-8b45-8495b9eefdb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c52f038-4e78-4df3-abb4-f1339f945b02"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ca64b7e-1e7a-4218-9a5b-dd9f2e294fd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d789580-5ad3-489d-aba4-e134febc896f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e37183f-a30b-4e8a-995c-e101e0ba76bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e5f4f2c-d4de-4307-889c-8f22220ac52f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ef0d50e-8eed-4283-8e4e-53f266e0e743"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1fe1097a-df37-4ba8-8780-907344e27749"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("203b8cf7-d679-4ffe-8264-7c7f0f6846b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2120097a-7482-42bd-a3a1-914a92f6fc4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22eb66a9-8e87-461f-8f02-da0f698a2348"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2558672f-a283-4ad6-a542-8ca335f7ec3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("259a23c3-c736-4aea-8aaa-34ce04d34a43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2630173f-1f99-462d-8935-19aa5bc80392"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28439598-d622-4a12-b95f-97f71a43aaa1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28803583-bbb2-48e6-a9ab-aebdc8569ee1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2aa5c8a1-cc6d-4294-a7bf-277c08bb9f19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ade10ab-47d6-4d51-af38-5abcdb467397"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2bd766c6-ec09-4e9b-ade2-2361f1652e85"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c65c038-637a-4051-8c45-76e3a2256fa9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d84b613-60bf-41a1-b3e0-63dfbe9d77e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f0d2e7f-8e57-410a-a1fa-5163cf216e69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fcbe0e0-f03f-4f40-aa46-68dfda0bc199"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31320069-32f5-451a-adff-e6e67466472c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32408407-845f-49d3-84e3-a21264decad7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3256f69d-d067-42b3-925e-ca5ee79b9d5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32fb8804-b60a-425a-b22e-665cee5c0e20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3304a1ae-e479-4368-9ecf-73f849ebfd19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("332cdc02-2704-4ca7-9c51-8028e5536c0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33372068-b847-4fb5-9754-0e6a1bba4746"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("334193bb-6cae-4dfd-904c-b560a6465401"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34e4c89c-3e46-4509-b5ca-3a4b05b2a926"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37b80fa9-57ff-4c50-bfcc-0be74ab3abe1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("396bc4b1-c9db-4c7a-9313-f2ab5dd128cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39c425ec-85fc-4172-92f0-9bb0fe044414"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bfb6aa0-984c-4045-af03-60b9bf69c614"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ca77ca4-2a0a-456d-af6c-afc456080800"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3dd42ba5-8978-4c27-a59a-ede1d8f1c3da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e482d32-880b-429d-b1b9-81af13c69345"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e63f4fb-be25-4c00-b50d-ecd98f0a466b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f465ab0-5ba0-4553-b210-c8e85db267ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ff4ec94-2f5e-47d6-a608-1a24fdf9315a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41469743-84a6-4f95-bf5c-8b378655c890"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43f20622-ca0e-4bb3-b1a3-fa7d0de2438d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45447320-2c38-45e3-bad8-54ffdaea3719"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48972828-d081-4d0a-b4fd-83e485c4eff4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48bb93e6-26c7-4ce9-a496-fa67ff134ea9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48ee54e2-fab4-42e3-b867-d5a0cda8799c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a9ddb71-4c34-45cd-8c19-824e290ac681"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b4b4be1-329a-48eb-94a1-4ed36a2ac857"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c02f00e-be81-45ba-a7b9-60cab735d1f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4cd9b676-a604-4b90-8168-bb4d5100b13c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d9841ed-4ecc-4326-921c-64bdc41de9b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4fd16746-7297-443c-bb72-bcf59520d0af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50ba9bfc-cdcb-4b72-9c78-185b42988fdc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("548c761a-adfd-424b-b690-f977c50d8f5f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("563bd9b4-44f3-4f53-a6bd-3ee6c8a23c52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("588d2c93-c9e8-4d09-9cd2-3a47efcb45cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("599069d9-5b7d-4084-96c1-227fb0194221"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59c56e92-3e42-48b5-93c3-65958e354d73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5a104614-183a-4405-9a38-d31bb00c8fd5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b309f82-83ef-4d09-b9ba-d406dd55c7dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5cd5b6a1-3b64-4b2f-a831-3988c34b5259"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d170fab-6946-4be9-b819-9ecd4a051482"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5dca9f20-ad85-44ae-9f92-054529f534f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e0f75f3-c1f8-42eb-818a-cf4eb863fbc5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e490e15-b173-4e30-8a94-53eb05576a69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e836a27-0783-473e-8354-75855f8724d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fba1dd4-a31f-4a86-aa08-7234097ca725"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fd44873-24ba-4e3d-a7d8-ebfd811679a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("608ba99f-baaf-41e4-83ba-05924412f488"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61bde008-1776-43d2-8853-d643f994bb34"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("646cce15-95f5-4f87-be7c-d844e2e0387e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67874e4f-0e9a-4ec2-bffd-ea5c9a7012fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6868a8aa-1bc4-4ba2-acf1-7ede7ec7d51e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("68ebd19a-4eef-4c91-a7c8-be3b0c4f1fab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("699c74c3-c306-47a7-a87c-af5d358dfd53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69e69091-1efe-4769-8643-9b430f51e8f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a72074b-c241-43fc-ba44-930fbc5612c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b1818a5-ce64-4a3d-9139-e9e0a2103da3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6be035f9-7f51-4b95-8968-6202d26e792d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c38fdbe-6866-4dc5-8fbc-5d1b47ff58b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6cff3f97-3ea9-4a01-93cc-76d09eddba62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e9213dc-36d2-4a1b-b082-04b3ab12743a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e9ce70a-6820-4df3-9356-1788efa32172"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6edf8e9a-0e93-4bbd-be09-28279c469664"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fa2538e-6962-48e2-a8da-76e74fbccad7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("725f89ce-dad8-44f6-8516-e82b63be3b42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("743d46de-4966-49c6-bb4b-5c4d147d7cc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("751dfe46-4f8f-4ef6-af27-feabe9e0979c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("75b1d0fa-b6ea-494d-a662-467f4b2e0e89"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76a1821f-d600-4923-8987-924c751acac2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("775fd1d0-4928-4fab-bbf6-6226d7b26da6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7941387a-b31a-4cc9-8a1e-214a0d9987c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("797a29f8-f2c0-4659-9954-7c3b46513ed5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a220e89-2c58-480d-8bdd-fcf6436df94e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7bb75a2f-a934-4c53-b201-d98c25bced4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7caf69a3-41e1-423c-a2fd-9b24ce64168b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ce7e5c2-259a-44c6-a3bf-3688d0cc55c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7d2e927a-39e3-47e0-97df-ac5bff375986"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dd79823-f689-43c0-998f-732aa4e51ebd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dde4cbf-5680-4aca-a1ae-b68d49c99f35"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7eb70c04-f83a-4455-8ef5-ad5861cf93f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7eea6f36-7e1c-42d4-a209-480933f6b14b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("804e3923-50fb-43cc-a909-93736b5067c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81da9a76-4275-468f-b47c-afa056a93436"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82b960e9-77fc-4a30-bfea-89a26fe81d00"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("839df96f-96d4-4718-98e8-ff82adbcad67"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84b74b5a-6b67-4c5b-b620-85cd9b762283"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85c11a4f-e327-4026-b6e3-5863641dcbdf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("869a9f57-65c0-40b7-8b8f-cdec2be25f3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("886c5b25-1064-42cd-bf3b-c8fa452960cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("892b182b-b2c5-4629-9e4b-19e61072b7ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c269f45-dad0-4aae-b522-bd2de462d74c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cff6faa-b4e5-46d2-831d-ecc37614ded5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d1d4d5d-c283-4399-9b79-3088601d76aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e822db7-db15-4e17-afc7-03302fca2af5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8eea3b5a-4fa1-4bd0-afd5-8c84603ae5fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f41504a-9fe6-4495-9fa0-9816a0961698"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fa43023-9c81-43ad-b738-e7bbd7aa2d41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("907e5ff5-1777-4e13-8dee-a6a04f136e04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91ed6f16-3ead-4e5f-8a34-c8e3090220f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("923eb268-a4f7-467a-90ea-4e8fce41aaeb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9354b631-7a08-4014-9fd0-2f8af5977e0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9354bb3b-e939-4177-8213-d20532230d0b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9369bd87-f713-439c-994d-6da8e6b1d7e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("938d073e-545c-4ca7-8ee4-279bffa62335"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("974ffe2c-d954-4000-84a0-d076add27e07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97599c69-0425-4a38-950d-52cbbcfdcbe1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99c85b54-6995-4474-9ad2-a435af2f14e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ba6165b-2051-4916-a151-a7b0a41d22b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c31c3e5-3ed0-46b8-857c-7c9e328590a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c6c8c35-a4b5-4af4-867f-706e5ddab0f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9cf93973-2f6b-4d3a-b5d0-5851b98ccb75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9db0b083-fc26-4580-a874-e4863c4fcd55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e281147-6987-4358-b0cb-dcd00c1a8495"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9eab9b50-6fc6-4809-b75e-c66f79b5a00e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a00335c3-91c3-406b-a936-288359290c69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2dcb332-2ca5-44df-8d04-4c86976681bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a42713ff-af7d-40a6-9a9f-2bdf72e6e2f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a511689a-9f05-4ff3-af94-c33f2cf2c39d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a632eb13-6706-4ef4-9fbc-fbc4ab87da1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a73291f0-0b17-48da-9128-b7c68d087e0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7cce24c-353f-460b-86c2-0fbde42c36c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a88cb59b-e9e2-4b23-adab-ce13c37d9648"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ace81a0b-e0d1-40ed-b5a9-d88c6258d81f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae152f14-59c1-4249-b366-9266df1cbf4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afa392a6-3b48-4234-8fcc-99748c5b51bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b00c7dbd-1d9e-47c3-a071-5f660f8cacb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1af3082-9f02-4047-8bab-a38598218d83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b20d0104-4fee-44fb-998d-4c4ef427c589"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2473cd6-d948-4c72-9e7c-968b7a8236ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3680d5c-a324-4722-8359-005d227d470c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4fd9ee5-380a-4f49-b849-758ea506eeae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5029def-6a1f-4a3e-bc68-5a1e0e9f2b86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5a3f75a-b3cf-4a9d-b811-a2320e845d48"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5a62c03-cf0a-447c-ace8-5d627e705ebb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5d506dd-fb4f-455c-9ec2-4bd0969f9c14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6376b42-b4a1-4ad9-abe4-5fecfd0871f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b77b7f46-3bb8-4457-9719-01f1e8d13010"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf6a0c46-960a-4360-a53d-c2e61d2380c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf9a9e60-68b2-49ba-970a-66e24f4bea2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0419a04-6170-4b77-afd0-e99db49783c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0d82186-e7fa-4911-bbf1-7dffa6f9ac59"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c20f8093-77ea-4e7c-bdfa-7e80ebc06b57"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c23b019e-93c2-4800-a861-1d2fd6996b56"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2efc69d-351e-4ed1-b8b8-d60e3024673d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c45b72a8-ac43-43c2-b799-fb2388a69eae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c65248cc-f376-4736-8513-e8654765be87"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6eb4c96-de30-4ad2-ba31-ff317f06f2f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c712cd74-4cc4-4731-a30a-7e2abeeef81b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c74ebb55-2e5a-4e54-868f-175e266785e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c88d8e32-669e-4721-a4d5-36ad48820be1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9789e49-0b19-4bda-a31c-014d860dc77b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca956b1b-c7ad-4107-af40-e1f62804df20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cafb32d5-8b3e-432f-9168-2ad58d5695b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb64b710-ee85-45e0-b3b3-ee3e842882fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cbf4e6cc-016f-48ed-85e2-aad1d3bfa354"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd074a6d-f8f0-4c5d-bb38-0ce740ce8ccf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdb01d36-080f-4f05-9f51-7e33061c04ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cfb5645b-b3b1-4b0d-8290-952c94463cb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d07becd4-a89f-478a-aaf2-1f4c30e19c50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1989d46-0266-4ada-9782-a4e066fef982"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1eb4b50-a9db-4761-af73-3ac7be7a2adf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4001861-5bee-4a72-90a5-06057ca1fee4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7748f1f-32da-46f5-9ad7-d52815a4963a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d7ba4e2c-ad95-4e1d-820a-6375dd8d12df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d818b49c-a79d-4c50-8b9d-377efa3a4fe7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8349952-54bd-41c3-adff-e2447f449d33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9398f33-dc81-406f-93fb-5b35981de16c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc04f3a8-bd04-4c8e-9dec-5bfd7dbbeb1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc218f8e-8e5e-469a-a1bf-c396b4361c8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e29c6dad-5f0f-4bde-b8e7-5bf5035521cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e30fc284-63e6-4d32-bf27-9a6c4a7eabad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3e17210-55ef-4f12-8b0b-64b3e082ee34"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e49e2d04-7564-4978-ae69-6dde29d94757"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e6600e32-cb16-4270-a4e3-026b45f6de04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7f90a64-c637-4d10-8897-012956f8aea7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8cc3768-ad4f-49e7-89b2-7c9429d4391a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea018c8f-61ae-42e0-acd4-0fee5764d97a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ead4c689-dc05-4a59-bb24-dcd5efe74597"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ece130ce-eefd-4b79-bf94-6f11b179d2bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eed272e0-cfdb-42c9-944c-2788c7f02789"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eed88491-4392-47de-9df7-f40841c5ec25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f197b730-0bb0-4f0b-9180-adea0a36c303"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1d8c692-2dc2-4f6f-8621-6b46c1ff2110"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4341286-e333-4d84-be5f-b4d5dfa947d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f61c6012-7bef-4d96-ae38-2fa3cf467316"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f83a68d2-ef0d-4636-94d2-4afdaaeb4038"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb8978ee-51e0-44ca-b0e3-039a7e49e10f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fea27c4c-7d16-4e99-91d8-378746d803c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fef9384f-3898-4e81-bfa3-08ac48ec10c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffe5b53a-7b04-467b-8a8c-61e0ac817d21"));
        }
    }
}
