using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavingThrows_Proficiencies_ProficiencyId",
                table: "SavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Proficiencies_ProficiencyId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ProficiencyId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_SavingThrows_ProficiencyId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "Acrobatics",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AnimalHandling",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Arcana",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Athletics",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Deception",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Insight",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Intimidation",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Investigation",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Medicine",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Nature",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Perception",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Performance",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Persuasion",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ProficiencyId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SleightOfHand",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Stealth",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Survival",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ChaSave",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "ConSave",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "DexSave",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "IntelSave",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "ProficiencyId",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "StrSave",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "WisSave",
                table: "SavingThrows");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SavingThrows",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "SavingThrowsId",
                table: "Proficiencies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SkillsId",
                table: "Proficiencies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Proficiencies_SavingThrowsId",
                table: "Proficiencies",
                column: "SavingThrowsId");

            migrationBuilder.CreateIndex(
                name: "IX_Proficiencies_SkillsId",
                table: "Proficiencies",
                column: "SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_SavingThrows_SavingThrowsId",
                table: "Proficiencies",
                column: "SavingThrowsId",
                principalTable: "SavingThrows",
                principalColumn: "SavingThrowsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proficiencies_Skills_SkillsId",
                table: "Proficiencies",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "SkillsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_SavingThrows_SavingThrowsId",
                table: "Proficiencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Proficiencies_Skills_SkillsId",
                table: "Proficiencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficiencies_SavingThrowsId",
                table: "Proficiencies");

            migrationBuilder.DropIndex(
                name: "IX_Proficiencies_SkillsId",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SavingThrows");

            migrationBuilder.DropColumn(
                name: "SavingThrowsId",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "Proficiencies");

            migrationBuilder.AddColumn<bool>(
                name: "Acrobatics",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AnimalHandling",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Arcana",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Athletics",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deception",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "History",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Insight",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Intimidation",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Investigation",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Medicine",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Nature",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Perception",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Performance",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Persuasion",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ProficiencyId",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Religion",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SleightOfHand",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Stealth",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Survival",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ChaSave",
                table: "SavingThrows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ConSave",
                table: "SavingThrows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DexSave",
                table: "SavingThrows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IntelSave",
                table: "SavingThrows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ProficiencyId",
                table: "SavingThrows",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "StrSave",
                table: "SavingThrows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WisSave",
                table: "SavingThrows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ProficiencyId",
                table: "Skills",
                column: "ProficiencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_ProficiencyId",
                table: "SavingThrows",
                column: "ProficiencyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SavingThrows_Proficiencies_ProficiencyId",
                table: "SavingThrows",
                column: "ProficiencyId",
                principalTable: "Proficiencies",
                principalColumn: "ProficiencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Proficiencies_ProficiencyId",
                table: "Skills",
                column: "ProficiencyId",
                principalTable: "Proficiencies",
                principalColumn: "ProficiencyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
