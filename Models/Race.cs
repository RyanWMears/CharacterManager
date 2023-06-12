using CharacterManager.Models.JoinModels.RaceJoins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace CharacterManager.Models
{
    [Table("Races")]
    public class Race
    {
        [Key]
        public Guid RaceId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Speed { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }


        [NotMapped]
        [AllowNull]
        public List<Guid> LanguageIds { get; set; }
        [AllowNull]
        public IList<RaceLanguage> RaceLanguages { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreRace> AbilityScoreRaces { get; set; }

        public Race() { 
            RaceId = Guid.NewGuid();
            Name = string.Empty;
            Size = string.Empty;
            Speed = string.Empty;
            Description = string.Empty;
            Type = string.Empty;
            Source = string.Empty;
        }
        public Race(string name, string size, string speed, string description, string type, string source)
        {
            RaceId = new Guid();
            Name = name;
            Size = size;
            Speed = speed;
            Description = description;
            Type = type;
            Source = source;
        }
    }
}
