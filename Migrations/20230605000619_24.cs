using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassLanguage");

            migrationBuilder.DropTable(
                name: "ClassSkill");

            migrationBuilder.DropColumn(
                name: "ClassSkillId",
                table: "ClassSkills");

            migrationBuilder.CreateTable(
                name: "ClassSavingThrows",
                columns: table => new
                {
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SavingThrowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSavingThrows", x => new { x.ClassId, x.SavingThrowId });
                    table.ForeignKey(
                        name: "FK_ClassSavingThrows_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSavingThrows_SavingThrows_SavingThrowId",
                        column: x => x.SavingThrowId,
                        principalTable: "SavingThrows",
                        principalColumn: "SavingThrowsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceLanguages",
                columns: table => new
                {
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceLanguages", x => new { x.RaceId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_RaceLanguages_Languages_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceLanguages_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSavingThrows_SavingThrowId",
                table: "ClassSavingThrows",
                column: "SavingThrowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSavingThrows");

            migrationBuilder.DropTable(
                name: "RaceLanguages");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassSkillId",
                table: "ClassSkills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ClassLanguage",
                columns: table => new
                {
                    ClassLanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLanguage", x => x.ClassLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "ClassSkill",
                columns: table => new
                {
                    ClassesClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillsSkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSkill", x => new { x.ClassesClassId, x.SkillsSkillId });
                    table.ForeignKey(
                        name: "FK_ClassSkill_Classes_ClassesClassId",
                        column: x => x.ClassesClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSkill_Skills_SkillsSkillId",
                        column: x => x.SkillsSkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSkill_SkillsSkillId",
                table: "ClassSkill",
                column: "SkillsSkillId");
        }
    }
}
