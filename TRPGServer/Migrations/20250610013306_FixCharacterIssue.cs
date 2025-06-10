using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRPGServer.Migrations
{
    /// <inheritdoc />
    public partial class FixCharacterIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassItems_CharacterBase_CharacterId",
                table: "ClassItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStatus_CharacterBase_CharacterId",
                table: "ClassStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_CharacterBase_CharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterStatus_CharacterBase_CharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterStatus_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacterStatus_CharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacterItem_CharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropIndex(
                name: "IX_ClassStatus_CharacterId",
                table: "ClassStatus");

            migrationBuilder.DropIndex(
                name: "IX_ClassItems_CharacterId",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "ClassStatus");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "ClassItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomCharacterId",
                table: "RoomCharacterStatus",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomCharacterId",
                table: "RoomCharacterItem",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "SourseId",
                table: "RoomCharacter",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterItem",
                column: "RoomCharacterId",
                principalTable: "RoomCharacter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterStatus_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterStatus",
                column: "RoomCharacterId",
                principalTable: "RoomCharacter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterStatus_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropColumn(
                name: "SourseId",
                table: "RoomCharacter");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomCharacterId",
                table: "RoomCharacterStatus",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "RoomCharacterStatus",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomCharacterId",
                table: "RoomCharacterItem",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "RoomCharacterItem",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "ClassStatus",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "ClassItems",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacterStatus_CharacterId",
                table: "RoomCharacterStatus",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacterItem_CharacterId",
                table: "RoomCharacterItem",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStatus_CharacterId",
                table: "ClassStatus",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassItems_CharacterId",
                table: "ClassItems",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassItems_CharacterBase_CharacterId",
                table: "ClassItems",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStatus_CharacterBase_CharacterId",
                table: "ClassStatus",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_CharacterBase_CharacterId",
                table: "RoomCharacterItem",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterItem",
                column: "RoomCharacterId",
                principalTable: "RoomCharacter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterStatus_CharacterBase_CharacterId",
                table: "RoomCharacterStatus",
                column: "CharacterId",
                principalTable: "CharacterBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterStatus_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterStatus",
                column: "RoomCharacterId",
                principalTable: "RoomCharacter",
                principalColumn: "Id");
        }
    }
}
