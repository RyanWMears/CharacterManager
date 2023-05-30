using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("AbilityScores")]
    public class AbilityScores
    {
        [Key]
        public Guid AbilityScoresId { get; set; }

        [ForeignKey("Character")]
        public Guid CharacterId { get; set; }
        [Required]
        public int Strength { get; set; }
        [Required]
        public int Dexterity { get; set; }
        [Required]
        public int Constitution { get; set; }
        [Required]
        public int Intelligence { get; set; }
        [Required]
        public int Wisdom { get; set; }
        [Required]
        public int Charisma { get; set; }

        public int StrBonus { get; set; }
        public int DexBonus { get; set; }
        public int ConBonus { get; set; }
        public int IntBonus { get; set; }
        public int WisBonus { get; set; }
        public int ChaBonus { get; set; }

        public AbilityScores() {
            AbilityScoresId = Guid.NewGuid();
            Strength = 10;
            Dexterity = 10;
            Constitution = 10;
            Intelligence = 10;
            Wisdom = 10;
            Charisma = 10;

            StrBonus = (Strength - 10) / 2;
            DexBonus = (Dexterity - 10) / 2;
            ConBonus = (Constitution - 10) / 2;
            IntBonus = (Intelligence - 10) / 2;
            WisBonus = (Wisdom - 10) / 2;
            ChaBonus = (Charisma - 10) / 2;
        }
        public AbilityScores(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            AbilityScoresId = Guid.NewGuid();   
            Strength        = strength;
            Dexterity       = dexterity;
            Constitution    = constitution;
            Intelligence    = intelligence;
            Wisdom          = wisdom;
            Charisma        = charisma;

            StrBonus        = (Strength - 10) / 2;
            DexBonus        = (Dexterity - 10) / 2;
            ConBonus        = (Constitution - 10) / 2;
            IntBonus        = (Intelligence - 10) / 2;
            WisBonus        = (Wisdom - 10) / 2;
            ChaBonus        = (Charisma - 10) / 2;
        }
    }
}