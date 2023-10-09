using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SupportAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "123b3625-e965-4bdd-99c5-b5d8c346cd75");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24bb36a8-d98f-4d90-83c5-a86a7c1287bd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37231e48-80d6-4003-b809-2cfff75f1573");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42c7a71a-23fa-4620-94a1-538d01eee12b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "95c25b46-dd5f-459a-9abd-aa53a546fd12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "95d5ba96-d9d8-4159-af92-965d2e42c56c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ae474024-aa1d-4aa3-83d1-9154a2a7028e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c546976c-ac25-4f8e-bb1c-d450e4be149f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cd91b628-8a22-4581-91f4-1f67f87b83e6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d20f7ae0-cdea-4d35-ae99-6ebe20a69733");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d3af35de-eebc-4966-a443-5a70dd21d44f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d4077d2b-281e-4ac8-a631-7c33acb5a8c9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d875a149-daee-48c7-adef-82d792963994");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ecc90153-6e62-490c-b130-934ac75d1ced");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f6df3a11-a0be-4656-81f8-25d8d0700fed");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fa73bd41-1589-4da9-a060-6a86745f2dd4");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Messages",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Messages",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Messages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "IsOnline", "Seniority", "TeamId" },
                values: new object[,]
                {
                    { "123b3625-e965-4bdd-99c5-b5d8c346cd75", "Agent", false, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "24bb36a8-d98f-4d90-83c5-a86a7c1287bd", "Agent", false, 0, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "37231e48-80d6-4003-b809-2cfff75f1573", "Agent", false, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "42c7a71a-23fa-4620-94a1-538d01eee12b", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "95c25b46-dd5f-459a-9abd-aa53a546fd12", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "95d5ba96-d9d8-4159-af92-965d2e42c56c", "Agent", false, 2, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "ae474024-aa1d-4aa3-83d1-9154a2a7028e", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "c546976c-ac25-4f8e-bb1c-d450e4be149f", "Agent", false, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "cd91b628-8a22-4581-91f4-1f67f87b83e6", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "d20f7ae0-cdea-4d35-ae99-6ebe20a69733", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "d3af35de-eebc-4966-a443-5a70dd21d44f", "Agent", false, 3, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "d4077d2b-281e-4ac8-a631-7c33acb5a8c9", "Agent", false, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "d875a149-daee-48c7-adef-82d792963994", "Agent", false, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "ecc90153-6e62-490c-b130-934ac75d1ced", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "f6df3a11-a0be-4656-81f8-25d8d0700fed", "Agent", false, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "fa73bd41-1589-4da9-a060-6a86745f2dd4", "Agent", false, 0, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
