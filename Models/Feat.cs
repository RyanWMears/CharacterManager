using CharacterManager.Models.JoinModels.RaceJoins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace CharacterManager.Models
{
    [Table("Feats")]
    public class Feat
    {
        [Key]
        public Guid FeatId { get; set; }
        public string Name { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        [AllowNull]
        public string Prerequisite { get; set; }
        public string Source { get; set; }


        //Joins
        public Guid CharacterId { get; set; }
        [AllowNull]
        public virtual Character Character { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreFeat> AbilityScoreFeats { get; set; }

        public Feat() { 
            FeatId = Guid.NewGuid();
            Name = string.Empty;
            Description = string.Empty;
            Prerequisite = string.Empty;
            Source = string.Empty;
        }
        public Feat(string name, string description, string type, string prerequisite, string source)
        {
            FeatId = new Guid();
            Name = name;
            Description = description;
            Prerequisite = prerequisite;
            Source = source;
        }
    }

    [Table("ClassFeats")]
    public class ClassFeat
    {
        [Key]
        public Guid ClassFeatId { get; set; }
        public string Name { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public int LevelRequirement { get; set; }
        public string Source { get; set; }

        //Joins
        public Guid ClassId { get; set; }
        [AllowNull]
        public virtual Class Class { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreClassFeat> AbilityScoreClassFeats { get; set; }


        public ClassFeat() {
            ClassFeatId = Guid.NewGuid();
            Name = string.Empty;
            Description = string.Empty;
            LevelRequirement = 1;
            Source = string.Empty;
        }
        public ClassFeat(string name, string description, int level, string source)
        {
            ClassFeatId = new Guid();
            Name = name;
            Description = description;
            LevelRequirement = level;
            Source = source;
        }
    }
}
