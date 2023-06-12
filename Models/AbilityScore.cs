using CharacterManager.Models.JoinModels.RaceJoins;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models
{
    [Table("AbilityScores")]
    public class AbilityScore
    {
        [Key]
        public Guid AbilityScoreId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        [AllowNull]
        public virtual IList<Character> Characters { get; set; }
        [AllowNull]
        public virtual IList<ClassFeat> ClassFeats { get; set; }
        [AllowNull]
        public virtual IList<Feat> Feats { get; set; }
        [AllowNull]
        public virtual IList<Item> Items { get; set; }
        [AllowNull]
        public virtual IList<Race> Races { get; set; }


        //Join Tables
        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreCharacter> ASC { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreClassFeat> AbilityScoreClassFeats { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreFeat> AbilityScoreFeats { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreItem> AbilityScoreItems { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreRace> AbilityScoreRaces { get; set; }

        public AbilityScore() {
            AbilityScoreId = Guid.NewGuid();
            Name = string.Empty;
            Value = 0;
        }
        public AbilityScore(string name, int value)
        {
            AbilityScoreId = Guid.NewGuid();
            Name = name;
            Value = value;
        }
    }
}