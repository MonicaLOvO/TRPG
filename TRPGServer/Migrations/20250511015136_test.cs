using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRPGServer.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Dics_DiceId",
                table: "CharacterItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassItems_Dics_DiceId",
                table: "ClassItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Dics_GameType_TypeId",
                table: "Dics");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_Dics_DiceId",
                table: "RoomCharacterItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dics",
                table: "Dics");

            migrationBuilder.RenameTable(
                name: "Dics",
                newName: "Dice");

            migrationBuilder.RenameIndex(
                name: "IX_Dics_TypeId",
                table: "Dice",
                newName: "IX_Dice_TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dice",
                table: "Dice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Dice_DiceId",
                table: "CharacterItems",
                column: "DiceId",
                principalTable: "Dice",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassItems_Dice_DiceId",
                table: "ClassItems",
                column: "DiceId",
                principalTable: "Dice",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dice_GameType_TypeId",
                table: "Dice",
                column: "TypeId",
                principalTable: "GameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_Dice_DiceId",
                table: "RoomCharacterItem",
                column: "DiceId",
                principalTable: "Dice",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Dice_DiceId",
                table: "CharacterItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassItems_Dice_DiceId",
                table: "ClassItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Dice_GameType_TypeId",
                table: "Dice");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCharacterItem_Dice_DiceId",
                table: "RoomCharacterItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dice",
                table: "Dice");

            migrationBuilder.RenameTable(
                name: "Dice",
                newName: "Dics");

            migrationBuilder.RenameIndex(
                name: "IX_Dice_TypeId",
                table: "Dics",
                newName: "IX_Dics_TypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dics",
                table: "Dics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Dics_DiceId",
                table: "CharacterItems",
                column: "DiceId",
                principalTable: "Dics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassItems_Dics_DiceId",
                table: "ClassItems",
                column: "DiceId",
                principalTable: "Dics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dics_GameType_TypeId",
                table: "Dics",
                column: "TypeId",
                principalTable: "GameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCharacterItem_Dics_DiceId",
                table: "RoomCharacterItem",
                column: "DiceId",
                principalTable: "Dics",
                principalColumn: "Id");
        }
    }
}
