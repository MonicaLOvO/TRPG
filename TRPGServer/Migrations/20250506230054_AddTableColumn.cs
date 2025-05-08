using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRPGServer.Migrations
{
    /// <inheritdoc />
    public partial class AddTableColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "TemplateDetail",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomTemplateId",
                table: "TemplateDetail",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TemplateDetail",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "VisiableToPlayer",
                table: "TemplateDetail",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Story",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Story",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Story",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "RoomTemplate",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "RoomTemplate",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "VisiableToPlayer",
                table: "RoomTemplate",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "RoomRule",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "RoomRule",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "RoomLog",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "RoomLog",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "RoomLog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "RoomLog",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "RoomChat",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "RoomChat",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "RoomChat",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "RoomChat",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "RoomCharacterStatus",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomCharacterStatus",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "RoomCharacterStatus",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "RoomCharacterStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "RoomCharacterItem",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomCharacterItem",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "DiceId",
                table: "RoomCharacterItem",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "RoomCharacterItem",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "RoomCharacterItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "RoomCharacterItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "APP",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ActorId",
                table: "RoomCharacter",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CON",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DEX",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomCharacter",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "EDU",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Era",
                table: "RoomCharacter",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "RoomCharacter",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "INT",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "RoomCharacter",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "LUCK",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MP",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mov",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RoomCharacter",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "RoomCharacter",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "POW",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "RoomCharacter",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "SAN",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SIZ",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STR",
                table: "RoomCharacter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "RoomActor",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "RoomActor",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "RoomActor",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Room",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ActorId",
                table: "Note",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Note",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Note",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Side",
                table: "Dics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Dics",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "ClassStatus",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ClassStatus",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "ClassStatus",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "ClassStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "ClassItems",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ClassItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "DiceId",
                table: "ClassItems",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "ClassItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ClassItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "ClassItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "APP",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CON",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DEX",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ClassBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "EDU",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Era",
                table: "ClassBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "ClassBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "INT",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "ClassBase",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "LUCK",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MP",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mov",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ClassBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "ClassBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "POW",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAN",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SIZ",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STR",
                table: "ClassBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "CharacterStatus",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CharacterStatus",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "CharacterStatus",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "CharacterStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "CharacterItems",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CharacterItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "DiceId",
                table: "CharacterItems",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "CharacterItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CharacterItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "CharacterItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "APP",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "CharacterBase",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CON",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DEX",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CharacterBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "EDU",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Era",
                table: "CharacterBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "CharacterBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "INT",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "CharacterBase",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "LUCK",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MP",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mov",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CharacterBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "CharacterBase",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "POW",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAN",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SIZ",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STR",
                table: "CharacterBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Account",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Account",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Account",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GameType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateDetail_RoomTemplateId",
                table: "TemplateDetail",
                column: "RoomTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_ImageId",
                table: "Story",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_RoomId",
                table: "Story",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTemplate_RoomId",
                table: "RoomTemplate",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomRule_RoomId",
                table: "RoomRule",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomLog_RoomId",
                table: "RoomLog",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomChat_RoomId",
                table: "RoomChat",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacterStatus_CharacterId",
                table: "RoomCharacterStatus",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacterItem_CharacterId",
                table: "RoomCharacterItem",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacterItem_DiceId",
                table: "RoomCharacterItem",
                column: "DiceId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacter_ActorId",
                table: "RoomCharacter",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacter_ImageId",
                table: "RoomCharacter",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacter_RoomId",
                table: "RoomCharacter",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomActor_AccountId",
                table: "RoomActor",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomActor_RoomId",
                table: "RoomActor",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_CreatorId",
                table: "Room",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_ActorId",
                table: "Note",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Dics_TypeId",
                table: "Dics",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStatus_CharacterId",
                table: "ClassStatus",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassItems_CharacterId",
                table: "ClassItems",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassItems_DiceId",
                table: "ClassItems",
                column: "DiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassBase_ImageId",
                table: "ClassBase",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStatus_CharacterId",
                table: "CharacterStatus",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItems_CharacterId",
                table: "CharacterItems",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItems_DiceId",
                table: "CharacterItems",
                column: "DiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterBase_AccountId",
                table: "CharacterBase",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterBase_ImageId",
                table: "CharacterBase",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBase_Account_AccountId",
                table: "CharacterBase",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBase_Image_ImageId",
                table: "CharacterBase",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_CharacterBase_CharacterId",
                table: "CharacterItems",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Dics_DiceId",
                table: "CharacterItems",
                column: "DiceId",
                principalTable: "Dics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStatus_CharacterBase_CharacterId",
                table: "CharacterStatus",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassBase_Image_ImageId",
                table: "ClassBase",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassItems_CharacterBase_CharacterId",
                table: "ClassItems",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassItems_Dics_DiceId",
                table: "ClassItems",
                column: "DiceId",
                principalTable: "Dics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStatus_CharacterBase_CharacterId",
                table: "ClassStatus",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dics_GameType_TypeId",
                table: "Dics",
                column: "TypeId",
                principalTable: "GameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Note_RoomActor_ActorId",
                table: "Note",
                column: "ActorId",
                principalTable: "RoomActor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Account_CreatorId",
                table: "Room",
                column: "CreatorId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomActor_Account_AccountId",
                table: "RoomActor",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomActor_Room_RoomId",
                table: "RoomActor",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacter_Image_ImageId",
                table: "RoomCharacter",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacter_RoomActor_ActorId",
                table: "RoomCharacter",
                column: "ActorId",
                principalTable: "RoomActor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacter_Room_RoomId",
                table: "RoomCharacter",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_CharacterBase_CharacterId",
                table: "RoomCharacterItem",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_Dics_DiceId",
                table: "RoomCharacterItem",
                column: "DiceId",
                principalTable: "Dics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterStatus_CharacterBase_CharacterId",
                table: "RoomCharacterStatus",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomChat_Room_RoomId",
                table: "RoomChat",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomLog_Room_RoomId",
                table: "RoomLog",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomRule_Room_RoomId",
                table: "RoomRule",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTemplate_Room_RoomId",
                table: "RoomTemplate",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Story_Image_ImageId",
                table: "Story",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Story_Room_RoomId",
                table: "Story",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateDetail_RoomTemplate_RoomTemplateId",
                table: "TemplateDetail",
                column: "RoomTemplateId",
                principalTable: "RoomTemplate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBase_Account_AccountId",
                table: "CharacterBase");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBase_Image_ImageId",
                table: "CharacterBase");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_CharacterBase_CharacterId",
                table: "CharacterItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Dics_DiceId",
                table: "CharacterItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStatus_CharacterBase_CharacterId",
                table: "CharacterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassBase_Image_ImageId",
                table: "ClassBase");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassItems_CharacterBase_CharacterId",
                table: "ClassItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassItems_Dics_DiceId",
                table: "ClassItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStatus_CharacterBase_CharacterId",
                table: "ClassStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Dics_GameType_TypeId",
                table: "Dics");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_RoomActor_ActorId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Account_CreatorId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomActor_Account_AccountId",
                table: "RoomActor");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomActor_Room_RoomId",
                table: "RoomActor");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacter_Image_ImageId",
                table: "RoomCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacter_RoomActor_ActorId",
                table: "RoomCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacter_Room_RoomId",
                table: "RoomCharacter");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_CharacterBase_CharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_Dics_DiceId",
                table: "RoomCharacterItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterStatus_CharacterBase_CharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomChat_Room_RoomId",
                table: "RoomChat");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomLog_Room_RoomId",
                table: "RoomLog");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomRule_Room_RoomId",
                table: "RoomRule");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomTemplate_Room_RoomId",
                table: "RoomTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_Story_Image_ImageId",
                table: "Story");

            migrationBuilder.DropForeignKey(
                name: "FK_Story_Room_RoomId",
                table: "Story");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateDetail_RoomTemplate_RoomTemplateId",
                table: "TemplateDetail");

            migrationBuilder.DropTable(
                name: "GameType");

            migrationBuilder.DropIndex(
                name: "IX_TemplateDetail_RoomTemplateId",
                table: "TemplateDetail");

            migrationBuilder.DropIndex(
                name: "IX_Story_ImageId",
                table: "Story");

            migrationBuilder.DropIndex(
                name: "IX_Story_RoomId",
                table: "Story");

            migrationBuilder.DropIndex(
                name: "IX_RoomTemplate_RoomId",
                table: "RoomTemplate");

            migrationBuilder.DropIndex(
                name: "IX_RoomRule_RoomId",
                table: "RoomRule");

            migrationBuilder.DropIndex(
                name: "IX_RoomLog_RoomId",
                table: "RoomLog");

            migrationBuilder.DropIndex(
                name: "IX_RoomChat_RoomId",
                table: "RoomChat");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacterStatus_CharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacterItem_CharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacterItem_DiceId",
                table: "RoomCharacterItem");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacter_ActorId",
                table: "RoomCharacter");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacter_ImageId",
                table: "RoomCharacter");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacter_RoomId",
                table: "RoomCharacter");

            migrationBuilder.DropIndex(
                name: "IX_RoomActor_AccountId",
                table: "RoomActor");

            migrationBuilder.DropIndex(
                name: "IX_RoomActor_RoomId",
                table: "RoomActor");

            migrationBuilder.DropIndex(
                name: "IX_Room_CreatorId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Note_ActorId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Dics_TypeId",
                table: "Dics");

            migrationBuilder.DropIndex(
                name: "IX_ClassStatus_CharacterId",
                table: "ClassStatus");

            migrationBuilder.DropIndex(
                name: "IX_ClassItems_CharacterId",
                table: "ClassItems");

            migrationBuilder.DropIndex(
                name: "IX_ClassItems_DiceId",
                table: "ClassItems");

            migrationBuilder.DropIndex(
                name: "IX_ClassBase_ImageId",
                table: "ClassBase");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStatus_CharacterId",
                table: "CharacterStatus");

            migrationBuilder.DropIndex(
                name: "IX_CharacterItems_CharacterId",
                table: "CharacterItems");

            migrationBuilder.DropIndex(
                name: "IX_CharacterItems_DiceId",
                table: "CharacterItems");

            migrationBuilder.DropIndex(
                name: "IX_CharacterBase_AccountId",
                table: "CharacterBase");

            migrationBuilder.DropIndex(
                name: "IX_CharacterBase_ImageId",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "TemplateDetail");

            migrationBuilder.DropColumn(
                name: "RoomTemplateId",
                table: "TemplateDetail");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TemplateDetail");

            migrationBuilder.DropColumn(
                name: "VisiableToPlayer",
                table: "TemplateDetail");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RoomTemplate");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "RoomTemplate");

            migrationBuilder.DropColumn(
                name: "VisiableToPlayer",
                table: "RoomTemplate");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "RoomRule");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RoomRule");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "RoomLog");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RoomLog");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "RoomLog");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "RoomLog");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "RoomChat");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RoomChat");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "RoomChat");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "RoomChat");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomCharacterStatus");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "RoomCharacterStatus");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "RoomCharacterStatus");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "DiceId",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "APP",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "CON",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "DEX",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "EDU",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Era",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "INT",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "LUCK",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "MP",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Mov",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "POW",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "SAN",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "SIZ",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "STR",
                table: "RoomCharacter");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "RoomActor");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "RoomActor");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RoomActor");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Side",
                table: "Dics");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Dics");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "ClassStatus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ClassStatus");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "ClassStatus");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ClassStatus");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "DiceId",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "APP",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "CON",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "DEX",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "EDU",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Era",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "INT",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "LUCK",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "MP",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Mov",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "POW",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "SAN",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "SIZ",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "STR",
                table: "ClassBase");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "CharacterStatus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CharacterStatus");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "CharacterStatus");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "CharacterStatus");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "CharacterItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CharacterItems");

            migrationBuilder.DropColumn(
                name: "DiceId",
                table: "CharacterItems");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "CharacterItems");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CharacterItems");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "CharacterItems");

            migrationBuilder.DropColumn(
                name: "APP",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "CON",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "DEX",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "EDU",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Era",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "INT",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "LUCK",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "MP",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Mov",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "POW",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "SAN",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "SIZ",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "STR",
                table: "CharacterBase");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Account");
        }
    }
}
