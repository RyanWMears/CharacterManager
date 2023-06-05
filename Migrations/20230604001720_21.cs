using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassSkills",
                table: "ClassSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassSkills",
                table: "ClassSkills",
                columns: new[] { "ClassId", "SkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSkills_SkillId",
                table: "ClassSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSkills_Classes_ClassId",
                table: "ClassSkills",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSkills_Skills_SkillId",
                table: "ClassSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSkills_Classes_ClassId",
                table: "ClassSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSkills_Skills_SkillId",
                table: "ClassSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassSkills",
                table: "ClassSkills");

            migrationBuilder.DropIndex(
                name: "IX_ClassSkills_SkillId",
                table: "ClassSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassSkills",
                table: "ClassSkills",
                column: "ClassSkillId");
        }
    }
}
