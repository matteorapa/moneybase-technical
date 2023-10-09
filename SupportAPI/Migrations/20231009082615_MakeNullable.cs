using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SupportAPI.Migrations
{
    /// <inheritdoc />
    public partial class MakeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_AgentId",
                table: "Chats");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "040b4ef9-a356-4c80-9258-0edfc4671418");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0d440313-9765-4a1b-abc9-4cc5057c734e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "204dc8a8-0308-41ae-a562-5ce41b22d3b6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24452e08-d1ca-4474-8b5f-608d58e940ae");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2cb60dbf-0a43-4c4d-bfd5-e64b0981ada4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35e2da7c-5be5-4fac-bfda-34f16d2ddfae");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3ce43db3-c933-45c1-b0aa-632653be6bf4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "66eec947-5794-4fb0-ad24-0ee911e99db7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8856758a-03b7-4cfc-aabb-c99d81754de5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8963ec5b-a148-4539-9af5-f163df9e81a9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8f0de4b9-55db-44d5-b2ba-026b279ca0e5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a8ac9a8e-536a-406e-ba65-547b85e2ea5d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b127260d-b07b-4c9d-b677-21d289d670a9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cb22d09b-bcc5-4087-ae17-8b530c001053");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e27d471c-8452-4a38-bd74-fe7d202c0949");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f7933949-e974-483c-b0bb-db2357476614");

            migrationBuilder.AlterColumn<string>(
                name: "AgentId",
                table: "Chats",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "IsOnline", "Seniority", "TeamId" },
                values: new object[,]
                {
                    { "123b3625-e965-4bdd-99c5-b5d8c346cd75", "Agent", false, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "24bb36a8-d98f-4d90-83c5-a86a7c1287bd", "Agent", false, 0, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "37231e48-80d6-4003-b809-2cfff75f1573", "Agent", false, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "Discriminator" },
                values: new object[] { "3d2f8c6a-a206-4f99-a2ff-c5206c41741b", new Guid("7100d2c8-918f-4d12-809b-28995482d85d"), "Customer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "IsOnline", "Seniority", "TeamId" },
                values: new object[,]
                {
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
                name: "FK_Chats_Users_AgentId",
                table: "Chats",
                column: "AgentId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_AgentId",
                table: "Chats");

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
                keyValue: "3d2f8c6a-a206-4f99-a2ff-c5206c41741b");

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

            migrationBuilder.AlterColumn<string>(
                name: "AgentId",
                table: "Chats",
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
                    { "040b4ef9-a356-4c80-9258-0edfc4671418", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "0d440313-9765-4a1b-abc9-4cc5057c734e", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "204dc8a8-0308-41ae-a562-5ce41b22d3b6", "Agent", false, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "24452e08-d1ca-4474-8b5f-608d58e940ae", "Agent", false, 0, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "2cb60dbf-0a43-4c4d-bfd5-e64b0981ada4", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "35e2da7c-5be5-4fac-bfda-34f16d2ddfae", "Agent", false, 3, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "3ce43db3-c933-45c1-b0aa-632653be6bf4", "Agent", false, 2, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "66eec947-5794-4fb0-ad24-0ee911e99db7", "Agent", false, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "8856758a-03b7-4cfc-aabb-c99d81754de5", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "8963ec5b-a148-4539-9af5-f163df9e81a9", "Agent", false, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "8f0de4b9-55db-44d5-b2ba-026b279ca0e5", "Agent", false, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "a8ac9a8e-536a-406e-ba65-547b85e2ea5d", "Agent", false, 0, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "b127260d-b07b-4c9d-b677-21d289d670a9", "Agent", false, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "cb22d09b-bcc5-4087-ae17-8b530c001053", "Agent", false, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "e27d471c-8452-4a38-bd74-fe7d202c0949", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "f7933949-e974-483c-b0bb-db2357476614", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_AgentId",
                table: "Chats",
                column: "AgentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
