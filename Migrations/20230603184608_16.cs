using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_Skills_SkillsId",
                table: "Proficiencies");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "Skills",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "Proficiencies",
                newName: "SkillsSkillId");

            migrationBuilder.RenameIndex(
                name: "IX_Proficiencies_SkillsId",
                table: "Proficiencies",
                newName: "IX_Proficiencies_SkillsSkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_Skills_SkillsSkillId",
                table: "Proficiencies",
                column: "SkillsSkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_Skills_SkillsSkillId",
                table: "Proficiencies");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "Skills",
                newName: "SkillsId");

            migrationBuilder.RenameColumn(
                name: "SkillsSkillId",
                table: "Proficiencies",
                newName: "SkillsId");

            migrationBuilder.RenameIndex(
                name: "IX_Proficiencies_SkillsSkillId",
                table: "Proficiencies",
                newName: "IX_Proficiencies_SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_Skills_SkillsId",
                table: "Proficiencies",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "SkillsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
