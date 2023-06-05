using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassSkill",
                table: "ClassSkill");

            migrationBuilder.RenameTable(
                name: "ClassSkill",
                newName: "ClassSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassSkills",
                table: "ClassSkills",
                column: "ClassSkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassSkills",
                table: "ClassSkills");

            migrationBuilder.RenameTable(
                name: "ClassSkills",
                newName: "ClassSkill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassSkill",
                table: "ClassSkill",
                column: "ClassSkillId");
        }
    }
}
