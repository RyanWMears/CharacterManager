using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models
{
    [Table("Character")]
    public class Character
    {
        [Key]
        public Guid CharacterId { get; set; }

        [ForeignKey("Game")]
        public Guid GameId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int Level { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Skill> SkillProficiencies{ get; set; }
        [NotMapped]
        [AllowNull]
        public List<Item> Items { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Spell> SpellsKnown { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Spell> SpellsPrepared { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Item> Armor { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Item> Weapons { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Item> Tools { get; set; }
        [NotMapped]
        [AllowNull]
        public List<SavingThrow> SavingThrows { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Skill> Skills { get; set; }
        public int ProficiencyBonus
        {
            get
            {
                return (int)Math.Ceiling(this.Level * 0.25) + 1;
            }
        }

        public Character() {
            CharacterId = Guid.NewGuid();
            Name = "";
            Level = 1;
        }
        public Character(string name, int level)
        {
            CharacterId = Guid.NewGuid();
            Name = name;
            Level = level;
        }
    }
}