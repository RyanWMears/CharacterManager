using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_SavingThrows_SavingThrowsId",
                table: "Proficiencies");

            migrationBuilder.RenameColumn(
                name: "SavingThrowsId",
                table: "SavingThrows",
                newName: "SavingThrowId");

            migrationBuilder.RenameColumn(
                name: "SavingThrowsId",
                table: "Proficiencies",
                newName: "SavingThrowsSavingThrowId");

            migrationBuilder.RenameIndex(
                name: "IX_Proficiencies_SavingThrowsId",
                table: "Proficiencies",
                newName: "IX_Proficiencies_SavingThrowsSavingThrowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_SavingThrows_SavingThrowsSavingThrowId",
                table: "Proficiencies",
                column: "SavingThrowsSavingThrowId",
                principalTable: "SavingThrows",
                principalColumn: "SavingThrowId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_SavingThrows_SavingThrowsSavingThrowId",
                table: "Proficiencies");

            migrationBuilder.RenameColumn(
                name: "SavingThrowId",
                table: "SavingThrows",
                newName: "SavingThrowsId");

            migrationBuilder.RenameColumn(
                name: "SavingThrowsSavingThrowId",
                table: "Proficiencies",
                newName: "SavingThrowsId");

            migrationBuilder.RenameIndex(
                name: "IX_Proficiencies_SavingThrowsSavingThrowId",
                table: "Proficiencies",
                newName: "IX_Proficiencies_SavingThrowsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_SavingThrows_SavingThrowsId",
                table: "Proficiencies",
                column: "SavingThrowsId",
                principalTable: "SavingThrows",
                principalColumn: "SavingThrowsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
