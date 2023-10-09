using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SupportAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TeamName = table.Column<string>(type: "text", nullable: false),
                    MaxCapacity = table.Column<int>(type: "integer", nullable: false),
                    IsOverflow = table.Column<bool>(type: "boolean", nullable: false),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: false),
                    IsNightShift = table.Column<bool>(type: "boolean", nullable: false),
                    StartAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FinishAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Seniority = table.Column<int>(type: "integer", nullable: true),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: true),
                    AccountId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<string>(type: "text", nullable: false),
                    AgentId = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    OpenedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ClosedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Users_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    AuthorId = table.Column<string>(type: "text", nullable: false),
                    IsSentByAgent = table.Column<bool>(type: "boolean", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    SentAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "FinishAt", "IsNightShift", "IsOnline", "IsOverflow", "MaxCapacity", "StartAt", "TeamName" },
                values: new object[,]
                {
                    { new Guid("1199495b-9684-4ab3-84f3-d6ff04ac8d83"), new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, 0, new DateTime(2023, 12, 31, 6, 0, 0, 0, DateTimeKind.Unspecified), "Overflow Team" },
                    { new Guid("675d7017-f2f6-4460-9405-36bcf16fbc1e"), new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), false, false, false, 0, new DateTime(2023, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), "Team B" },
                    { new Guid("e491ffff-b197-4cdf-859c-a103bdf63fc5"), new DateTime(2023, 12, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), false, false, false, 0, new DateTime(2023, 12, 31, 6, 0, 0, 0, DateTimeKind.Unspecified), "Team A" },
                    { new Guid("e6f027fb-2f6d-4f45-8d95-a53f1e813bec"), new DateTime(2023, 12, 31, 6, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, 0, new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), "Team C" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Chats_AgentId",
                table: "Chats",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_CustomerId",
                table: "Chats",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TeamId",
                table: "Users",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
