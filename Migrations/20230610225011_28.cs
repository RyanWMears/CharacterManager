using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbilityScores_Characters_CharacterId",
                table: "AbilityScores");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSavingThrows_Classes_ClassId",
                table: "ClassSavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSavingThrows_SavingThrows_SavingThrowId",
                table: "ClassSavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSkills_Classes_ClassId",
                table: "ClassSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSkills_Skills_SkillId",
                table: "ClassSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceLanguages_Languages_LanguageId",
                table: "RaceLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceLanguages_Races_RaceId",
                table: "RaceLanguages");

            migrationBuilder.DropIndex(
                name: "IX_AbilityScores_CharacterId",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "Charisma",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "Constitution",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "Dexterity",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "AbilityScores");

            migrationBuilder.EnsureSchema(
                name: "join");

            migrationBuilder.RenameTable(
                name: "RaceLanguages",
                newName: "RaceLanguages",
                newSchema: "join");

            migrationBuilder.RenameTable(
                name: "ClassSkills",
                newName: "ClassSkills",
                newSchema: "join");

            migrationBuilder.RenameTable(
                name: "ClassSavingThrows",
                newName: "ClassSavingThrows",
                newSchema: "join");

            migrationBuilder.RenameColumn(
                name: "Wisdom",
                table: "AbilityScores",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "AbilityScoresId",
                table: "AbilityScores",
                newName: "AbilityScoreId");

            migrationBuilder.AddColumn<Guid>(
                name: "AbilityScoreId",
                table: "Races",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AbilityScoreId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AbilityScoreId",
                table: "Feats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "Feats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AbilityScoreId",
                table: "ClassFeats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AbilityScoreId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CharacterId",
                table: "AbilityScores",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "newid()");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassFeatId",
                table: "AbilityScores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FeatId",
                table: "AbilityScores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ItemId",
                table: "AbilityScores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AbilityScores",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "RaceId",
                table: "AbilityScores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AbilityScoreCharacters",
                schema: "join",
                columns: table => new
                {
                    AbilityScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreCharacters", x => new { x.AbilityScoreId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_AbilityScoreCharacters_AbilityScores_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScores",
                        principalColumn: "AbilityScoreId");
                    table.ForeignKey(
                        name: "FK_AbilityScoreCharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId");
                });

            migrationBuilder.CreateTable(
                name: "AbilityScoreClassFeats",
                schema: "join",
                columns: table => new
                {
                    AbilityScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassFeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreClassFeats", x => new { x.AbilityScoreId, x.ClassFeatId });
                    table.ForeignKey(
                        name: "FK_AbilityScoreClassFeats_AbilityScores_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScores",
                        principalColumn: "AbilityScoreId");
                    table.ForeignKey(
                        name: "FK_AbilityScoreClassFeats_ClassFeats_ClassFeatId",
                        column: x => x.ClassFeatId,
                        principalTable: "ClassFeats",
                        principalColumn: "ClassFeatId");
                });

            migrationBuilder.CreateTable(
                name: "AbilityScoreFeats",
                schema: "join",
                columns: table => new
                {
                    AbilityScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreFeats", x => new { x.AbilityScoreId, x.FeatId });
                    table.ForeignKey(
                        name: "FK_AbilityScoreFeats_AbilityScores_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScores",
                        principalColumn: "AbilityScoreId");
                    table.ForeignKey(
                        name: "FK_AbilityScoreFeats_Feats_FeatId",
                        column: x => x.FeatId,
                        principalTable: "Feats",
                        principalColumn: "FeatId");
                });

            migrationBuilder.CreateTable(
                name: "AbilityScoreItems",
                schema: "join",
                columns: table => new
                {
                    AbilityScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreItems", x => new { x.AbilityScoreId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_AbilityScoreItems_AbilityScores_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScores",
                        principalColumn: "AbilityScoreId");
                    table.ForeignKey(
                        name: "FK_AbilityScoreItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "AbilityScoreRaces",
                schema: "join",
                columns: table => new
                {
                    AbilityScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreRaces", x => new { x.AbilityScoreId, x.RaceId });
                    table.ForeignKey(
                        name: "FK_AbilityScoreRaces_AbilityScores_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScores",
                        principalColumn: "AbilityScoreId");
                    table.ForeignKey(
                        name: "FK_AbilityScoreRaces_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Races_AbilityScoreId",
                table: "Races",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AbilityScoreId",
                table: "Items",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_AbilityScoreId",
                table: "Feats",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_CharacterId",
                table: "Feats",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassFeats_AbilityScoreId",
                table: "ClassFeats",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AbilityScoreId",
                table: "Characters",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScoreCharacters_CharacterId",
                schema: "join",
                table: "AbilityScoreCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScoreClassFeats_ClassFeatId",
                schema: "join",
                table: "AbilityScoreClassFeats",
                column: "ClassFeatId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScoreFeats_FeatId",
                schema: "join",
                table: "AbilityScoreFeats",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScoreItems_ItemId",
                schema: "join",
                table: "AbilityScoreItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScoreRaces_RaceId",
                schema: "join",
                table: "AbilityScoreRaces",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AbilityScores_AbilityScoreId",
                table: "Characters",
                column: "AbilityScoreId",
                principalTable: "AbilityScores",
                principalColumn: "AbilityScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassFeats_AbilityScores_AbilityScoreId",
                table: "ClassFeats",
                column: "AbilityScoreId",
                principalTable: "AbilityScores",
                principalColumn: "AbilityScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSavingThrows_Classes_ClassId",
                schema: "join",
                table: "ClassSavingThrows",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSavingThrows_SavingThrows_SavingThrowId",
                schema: "join",
                table: "ClassSavingThrows",
                column: "SavingThrowId",
                principalTable: "SavingThrows",
                principalColumn: "SavingThrowId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSkills_Classes_ClassId",
                schema: "join",
                table: "ClassSkills",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSkills_Skills_SkillId",
                schema: "join",
                table: "ClassSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_AbilityScores_AbilityScoreId",
                table: "Feats",
                column: "AbilityScoreId",
                principalTable: "AbilityScores",
                principalColumn: "AbilityScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Characters_CharacterId",
                table: "Feats",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AbilityScores_AbilityScoreId",
                table: "Items",
                column: "AbilityScoreId",
                principalTable: "AbilityScores",
                principalColumn: "AbilityScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_RaceLanguages_Languages_LanguageId",
                schema: "join",
                table: "RaceLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_RaceLanguages_Races_RaceId",
                schema: "join",
                table: "RaceLanguages",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_AbilityScores_AbilityScoreId",
                table: "Races",
                column: "AbilityScoreId",
                principalTable: "AbilityScores",
                principalColumn: "AbilityScoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AbilityScores_AbilityScoreId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassFeats_AbilityScores_AbilityScoreId",
                table: "ClassFeats");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSavingThrows_Classes_ClassId",
                schema: "join",
                table: "ClassSavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSavingThrows_SavingThrows_SavingThrowId",
                schema: "join",
                table: "ClassSavingThrows");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSkills_Classes_ClassId",
                schema: "join",
                table: "ClassSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSkills_Skills_SkillId",
                schema: "join",
                table: "ClassSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_AbilityScores_AbilityScoreId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Characters_CharacterId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_AbilityScores_AbilityScoreId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceLanguages_Languages_LanguageId",
                schema: "join",
                table: "RaceLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceLanguages_Races_RaceId",
                schema: "join",
                table: "RaceLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_AbilityScores_AbilityScoreId",
                table: "Races");

            migrationBuilder.DropTable(
                name: "AbilityScoreCharacters",
                schema: "join");

            migrationBuilder.DropTable(
                name: "AbilityScoreClassFeats",
                schema: "join");

            migrationBuilder.DropTable(
                name: "AbilityScoreFeats",
                schema: "join");

            migrationBuilder.DropTable(
                name: "AbilityScoreItems",
                schema: "join");

            migrationBuilder.DropTable(
                name: "AbilityScoreRaces",
                schema: "join");

            migrationBuilder.DropIndex(
                name: "IX_Races_AbilityScoreId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Items_AbilityScoreId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Feats_AbilityScoreId",
                table: "Feats");

            migrationBuilder.DropIndex(
                name: "IX_Feats_CharacterId",
                table: "Feats");

            migrationBuilder.DropIndex(
                name: "IX_ClassFeats_AbilityScoreId",
                table: "ClassFeats");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AbilityScoreId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AbilityScoreId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "AbilityScoreId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "AbilityScoreId",
                table: "Feats");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Feats");

            migrationBuilder.DropColumn(
                name: "AbilityScoreId",
                table: "ClassFeats");

            migrationBuilder.DropColumn(
                name: "AbilityScoreId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ClassFeatId",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "FeatId",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AbilityScores");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "AbilityScores");

            migrationBuilder.RenameTable(
                name: "RaceLanguages",
                schema: "join",
                newName: "RaceLanguages");

            migrationBuilder.RenameTable(
                name: "ClassSkills",
                schema: "join",
                newName: "ClassSkills");

            migrationBuilder.RenameTable(
                name: "ClassSavingThrows",
                schema: "join",
                newName: "ClassSavingThrows");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "AbilityScores",
                newName: "Wisdom");

            migrationBuilder.RenameColumn(
                name: "AbilityScoreId",
                table: "AbilityScores",
                newName: "AbilityScoresId");

            migrationBuilder.AlterColumn<Guid>(
                name: "CharacterId",
                table: "AbilityScores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "Charisma",
                table: "AbilityScores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constitution",
                table: "AbilityScores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dexterity",
                table: "AbilityScores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "AbilityScores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "AbilityScores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScores_CharacterId",
                table: "AbilityScores",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AbilityScores_Characters_CharacterId",
                table: "AbilityScores",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSavingThrows_Classes_ClassId",
                table: "ClassSavingThrows",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSavingThrows_SavingThrows_SavingThrowId",
                table: "ClassSavingThrows",
                column: "SavingThrowId",
                principalTable: "SavingThrows",
                principalColumn: "SavingThrowId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSkills_Classes_ClassId",
                table: "ClassSkills",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSkills_Skills_SkillId",
                table: "ClassSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceLanguages_Languages_LanguageId",
                table: "RaceLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceLanguages_Races_RaceId",
                table: "RaceLanguages",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
