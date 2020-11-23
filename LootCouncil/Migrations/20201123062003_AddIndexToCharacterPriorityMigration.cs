using Microsoft.EntityFrameworkCore.Migrations;

namespace LootCouncil.Migrations
{
    public partial class AddIndexToCharacterPriorityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CharacterPriorities_ItemPriorityId",
                table: "CharacterPriorities");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterPriorities_ItemPriorityId_CharacterId",
                table: "CharacterPriorities",
                columns: new[] { "ItemPriorityId", "CharacterId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CharacterPriorities_ItemPriorityId_CharacterId",
                table: "CharacterPriorities");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterPriorities_ItemPriorityId",
                table: "CharacterPriorities",
                column: "ItemPriorityId");
        }
    }
}
