using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRPGServer.Migrations
{
    /// <inheritdoc />
    public partial class AddNameColumnToRoomTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Account_CreatorId",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Room",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Room_CreatorId",
                table: "Room",
                newName: "IX_Room_AccountId");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomCharacterId",
                table: "RoomCharacterStatus",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomCharacterId",
                table: "RoomCharacterItem",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Room",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassBaseId",
                table: "ClassStatus",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassBaseId",
                table: "ClassItems",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacterStatus_RoomCharacterId",
                table: "RoomCharacterStatus",
                column: "RoomCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCharacterItem_RoomCharacterId",
                table: "RoomCharacterItem",
                column: "RoomCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStatus_ClassBaseId",
                table: "ClassStatus",
                column: "ClassBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassItems_ClassBaseId",
                table: "ClassItems",
                column: "ClassBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassItems_ClassBase_ClassBaseId",
                table: "ClassItems",
                column: "ClassBaseId",
                principalTable: "ClassBase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStatus_ClassBase_ClassBaseId",
                table: "ClassStatus",
                column: "ClassBaseId",
                principalTable: "ClassBase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Account_AccountId",
                table: "Room",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterItem",
                column: "RoomCharacterId",
                principalTable: "RoomCharacter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterStatus_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterStatus",
                column: "RoomCharacterId",
                principalTable: "RoomCharacter",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassItems_ClassBase_ClassBaseId",
                table: "ClassItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStatus_ClassBase_ClassBaseId",
                table: "ClassStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Account_AccountId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterStatus_RoomCharacter_RoomCharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacterStatus_RoomCharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropIndex(
                name: "IX_RoomCharacterItem_RoomCharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropIndex(
                name: "IX_ClassStatus_ClassBaseId",
                table: "ClassStatus");

            migrationBuilder.DropIndex(
                name: "IX_ClassItems_ClassBaseId",
                table: "ClassItems");

            migrationBuilder.DropColumn(
                name: "RoomCharacterId",
                table: "RoomCharacterStatus");

            migrationBuilder.DropColumn(
                name: "RoomCharacterId",
                table: "RoomCharacterItem");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "ClassBaseId",
                table: "ClassStatus");

            migrationBuilder.DropColumn(
                name: "ClassBaseId",
                table: "ClassItems");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Room",
                newName: "CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Room_AccountId",
                table: "Room",
                newName: "IX_Room_CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Account_CreatorId",
                table: "Room",
                column: "CreatorId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
