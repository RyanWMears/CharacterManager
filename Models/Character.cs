using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("Character")]
    public class Character
    {
        [Key]
        public Guid CharacterId { get; set; }

        [ForeignKey("Game")]
        public Guid GameId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        [NotMapped]
        public Proficiency Proficiency { get; set; }
        [NotMapped]
        public List<Item>? Items { get; set; }
        [NotMapped]
        public List<Spell>? SpellsKnown { get; set; }
        [NotMapped]
        public List<Spell>? SpellsPrepared { get; set; } 
        public int ProficiencyBonus
        {
            get
            {
                return (int)Math.Ceiling(this.Level * 0.25) + 1;
            }
        }

        public Character() { }
        public Character(string name, int level)
        {
            CharacterId = Guid.NewGuid();
            Name = name;
            Level = level;
        }
    }
}