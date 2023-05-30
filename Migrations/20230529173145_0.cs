using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterManager.Migrations
{
    /// <inheritdoc />
    public partial class _0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbilityScores",
                columns: table => new
                {
                    AbilityScoresId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    StrBonus = table.Column<int>(type: "int", nullable: false),
                    DexBonus = table.Column<int>(type: "int", nullable: false),
                    ConBonus = table.Column<int>(type: "int", nullable: false),
                    IntBonus = table.Column<int>(type: "int", nullable: false),
                    WisBonus = table.Column<int>(type: "int", nullable: false),
                    ChaBonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScores", x => x.AbilityScoresId);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClass",
                columns: table => new
                {
                    CharacterClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClass", x => x.CharacterClassId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClassLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "ErrorViewModels",
                columns: table => new
                {
                    ErrorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorViewModels", x => x.ErrorId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Magic = table.Column<bool>(type: "bit", nullable: false),
                    Attunement = table.Column<bool>(type: "bit", nullable: false),
                    Rarity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Proficiencies",
                columns: table => new
                {
                    ProficiencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencies", x => x.ProficiencyId);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    School = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Concentration = table.Column<bool>(type: "bit", nullable: false),
                    CastingTime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Range = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Components = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SaveDC = table.Column<int>(type: "int", nullable: true),
                    SpellLists = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Materials = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Upcast = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellId);
                });

            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Armor_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaxRange = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumberOfDie = table.Column<int>(type: "int", nullable: false),
                    DieSize = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Weapons_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrows",
                columns: table => new
                {
                    SavingThrowsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProficiencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StrSave = table.Column<bool>(type: "bit", nullable: false),
                    DexSave = table.Column<bool>(type: "bit", nullable: false),
                    ConSave = table.Column<bool>(type: "bit", nullable: false),
                    IntelSave = table.Column<bool>(type: "bit", nullable: false),
                    WisSave = table.Column<bool>(type: "bit", nullable: false),
                    ChaSave = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrows", x => x.SavingThrowsId);
                    table.ForeignKey(
                        name: "FK_SavingThrows_Proficiencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "ProficiencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProficiencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Acrobatics = table.Column<bool>(type: "bit", nullable: false),
                    AnimalHandling = table.Column<bool>(type: "bit", nullable: false),
                    Arcana = table.Column<bool>(type: "bit", nullable: false),
                    Athletics = table.Column<bool>(type: "bit", nullable: false),
                    Deception = table.Column<bool>(type: "bit", nullable: false),
                    History = table.Column<bool>(type: "bit", nullable: false),
                    Insight = table.Column<bool>(type: "bit", nullable: false),
                    Intimidation = table.Column<bool>(type: "bit", nullable: false),
                    Investigation = table.Column<bool>(type: "bit", nullable: false),
                    Medicine = table.Column<bool>(type: "bit", nullable: false),
                    Nature = table.Column<bool>(type: "bit", nullable: false),
                    Perception = table.Column<bool>(type: "bit", nullable: false),
                    Performance = table.Column<bool>(type: "bit", nullable: false),
                    Persuasion = table.Column<bool>(type: "bit", nullable: false),
                    Religion = table.Column<bool>(type: "bit", nullable: false),
                    SleightOfHand = table.Column<bool>(type: "bit", nullable: false),
                    Stealth = table.Column<bool>(type: "bit", nullable: false),
                    Survival = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillsId);
                    table.ForeignKey(
                        name: "FK_Skills_Proficiencies_ProficiencyId",
                        column: x => x.ProficiencyId,
                        principalTable: "Proficiencies",
                        principalColumn: "ProficiencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_ProficiencyId",
                table: "SavingThrows",
                column: "ProficiencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ProficiencyId",
                table: "Skills",
                column: "ProficiencyId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityScores");

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "CharacterClass");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "ErrorViewModels");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "SavingThrows");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Proficiencies");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
