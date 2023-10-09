using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SupportAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "252d0070-bf65-4fc5-bbed-246f1eacd215");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33c71dd8-fb53-4967-b162-6cbd7c7c2426");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "513b0828-85c1-492d-87e1-82d8cdc2b60c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5d1f87a3-bce6-4bda-ae9b-8d2329c30745");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "66a597ce-11b8-46bd-82aa-c66be0eaebe7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "75e52ee6-19a5-487d-bf88-206492c07b40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a16d2b08-a38f-466f-a77d-ebb8925e96dd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "afeb8a81-bb14-4e01-be0a-b76178706207");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c3cc282e-5fea-4c77-bba8-a1feaaccabc5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c50c9bd1-7edd-467b-9dfa-3ad81c2b3bf6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cc304533-a665-4d3a-8e72-f0d468db10f2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d778a514-dd74-475e-9d3e-eca34f2ca64a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e5cb49a2-48ab-4cea-bc63-d7a852dab249");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eb6194ea-db64-4707-bd5f-943c177e3eaa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f1d69969-769c-4026-8576-1b68084fe53c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f2725869-d0ca-4e1a-b727-8b6703f03500");

            migrationBuilder.AddColumn<Guid>(
                name: "ChatId",
                table: "Messages",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ChatId",
                table: "Messages");

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

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Messages");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discriminator", "IsOnline", "Seniority", "TeamId" },
                values: new object[,]
                {
                    { "252d0070-bf65-4fc5-bbed-246f1eacd215", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "33c71dd8-fb53-4967-b162-6cbd7c7c2426", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "513b0828-85c1-492d-87e1-82d8cdc2b60c", "Agent", false, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "5d1f87a3-bce6-4bda-ae9b-8d2329c30745", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "66a597ce-11b8-46bd-82aa-c66be0eaebe7", "Agent", false, 1, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "75e52ee6-19a5-487d-bf88-206492c07b40", "Agent", false, 0, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "a16d2b08-a38f-466f-a77d-ebb8925e96dd", "Agent", false, 2, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "afeb8a81-bb14-4e01-be0a-b76178706207", "Agent", false, 0, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "c3cc282e-5fea-4c77-bba8-a1feaaccabc5", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "c50c9bd1-7edd-467b-9dfa-3ad81c2b3bf6", "Agent", false, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "cc304533-a665-4d3a-8e72-f0d468db10f2", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "d778a514-dd74-475e-9d3e-eca34f2ca64a", "Agent", false, 1, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") },
                    { "e5cb49a2-48ab-4cea-bc63-d7a852dab249", "Agent", false, 0, new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec") },
                    { "eb6194ea-db64-4707-bd5f-943c177e3eaa", "Agent", false, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "f1d69969-769c-4026-8576-1b68084fe53c", "Agent", false, 1, new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e") },
                    { "f2725869-d0ca-4e1a-b727-8b6703f03500", "Agent", false, 3, new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5") }
                });
        }
    }
}
