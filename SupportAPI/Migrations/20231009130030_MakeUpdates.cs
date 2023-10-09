using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SupportAPI.Migrations
{
    /// <inheritdoc />
    public partial class MakeUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "00a3151a-d1e1-407f-8136-387c1a2ec905");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "013f277e-7fc1-44ee-a91f-ffbb50ba4865");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0d1e3269-f508-49f9-a3ca-daaf3f746ca7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13767a1e-fede-4546-a13f-bb1ad270d7eb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21010193-2943-494d-9a05-7214ca9d3b26");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22ef2691-2a94-42a9-8089-867a1a4b2cb1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23c61fec-8327-42af-a8d3-db90b698b19e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3123a1e5-2d96-4511-9a49-10adffdaec34");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3f7af996-1f5d-450b-957f-64a7a65ea64d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5e654f44-fbd6-45af-8905-74f36a3d6ba4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a71e3f3f-f187-42af-8554-301267485a6a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b7aafd67-7cd4-43d3-aba3-1fa737190668");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ddf77590-b50f-42a9-b1e3-b69508fb52fa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5458084-a853-4064-aa2a-28128dd626e6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f596ba69-f080-41ae-8040-45392468392a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8bde202-3f29-4887-b0cb-c6dfb3dfb080");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "IsOnline", "Seniority", "TeamId" },
                values: new object[,]
                {
                    { "0c0ac714-f4c2-42fe-9c45-e1de3d7f5f06", "Agent", true, 0, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "14f1c3f5-8d43-4903-ad23-ccc2d865a034", "Agent", true, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "45bc8d19-32a0-46c1-b8d0-7686b60cb5d0", "Agent", true, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "6152df35-d4c8-4683-94fe-18565d85a4d7", "Agent", true, 0, new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83") },
                    { "69657f86-adb6-4e61-94a8-2b91ddd02a68", "Agent", true, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "7775923e-6f5b-44a1-8590-46b2e4d05c6a", "Agent", true, 0, new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83") },
                    { "7be9216a-4db7-4e3a-9504-1c096503e4c7", "Agent", true, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "7cb4ff35-2ec5-456f-9876-c8b3a187215c", "Agent", true, 0, new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83") },
                    { "7d398b03-357b-4570-a915-56c59cde0f12", "Agent", true, 3, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "85ef3836-c36e-46f9-8707-e389288e55e9", "Agent", true, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "aa8454cc-2638-4eab-9510-351a2c49d146", "Agent", true, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "e21584d7-e58f-4e3a-92b3-969b64e490a8", "Agent", true, 0, new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83") },
                    { "f03adb73-248e-449e-bf68-fb27de807579", "Agent", true, 0, new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83") },
                    { "f1288a5b-1e1f-4d66-ab81-e9515bceeed7", "Agent", true, 0, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "f48ea0f3-b6ec-4d76-ac76-28430cd91955", "Agent", true, 0, new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83") },
                    { "ff486a52-2ea7-4392-84a2-903e093b942a", "Agent", true, 2, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0c0ac714-f4c2-42fe-9c45-e1de3d7f5f06");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14f1c3f5-8d43-4903-ad23-ccc2d865a034");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45bc8d19-32a0-46c1-b8d0-7686b60cb5d0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6152df35-d4c8-4683-94fe-18565d85a4d7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69657f86-adb6-4e61-94a8-2b91ddd02a68");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7775923e-6f5b-44a1-8590-46b2e4d05c6a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7be9216a-4db7-4e3a-9504-1c096503e4c7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7cb4ff35-2ec5-456f-9876-c8b3a187215c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7d398b03-357b-4570-a915-56c59cde0f12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "85ef3836-c36e-46f9-8707-e389288e55e9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aa8454cc-2638-4eab-9510-351a2c49d146");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e21584d7-e58f-4e3a-92b3-969b64e490a8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f03adb73-248e-449e-bf68-fb27de807579");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f1288a5b-1e1f-4d66-ab81-e9515bceeed7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f48ea0f3-b6ec-4d76-ac76-28430cd91955");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ff486a52-2ea7-4392-84a2-903e093b942a");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "IsOnline", "Seniority", "TeamId" },
                values: new object[,]
                {
                    { "00a3151a-d1e1-407f-8136-387c1a2ec905", "Agent", true, 2, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "013f277e-7fc1-44ee-a91f-ffbb50ba4865", "Agent", true, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "0d1e3269-f508-49f9-a3ca-daaf3f746ca7", "Agent", true, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "13767a1e-fede-4546-a13f-bb1ad270d7eb", "Agent", true, 0, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "21010193-2943-494d-9a05-7214ca9d3b26", "Agent", true, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "22ef2691-2a94-42a9-8089-867a1a4b2cb1", "Agent", true, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "23c61fec-8327-42af-a8d3-db90b698b19e", "Agent", true, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "3123a1e5-2d96-4511-9a49-10adffdaec34", "Agent", true, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "3f7af996-1f5d-450b-957f-64a7a65ea64d", "Agent", true, 0, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "5e654f44-fbd6-45af-8905-74f36a3d6ba4", "Agent", true, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "a71e3f3f-f187-42af-8554-301267485a6a", "Agent", true, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "b7aafd67-7cd4-43d3-aba3-1fa737190668", "Agent", true, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "ddf77590-b50f-42a9-b1e3-b69508fb52fa", "Agent", true, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "f5458084-a853-4064-aa2a-28128dd626e6", "Agent", true, 3, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "f596ba69-f080-41ae-8040-45392468392a", "Agent", true, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "f8bde202-3f29-4887-b0cb-c6dfb3dfb080", "Agent", true, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") }
                });
        }
    }
}
