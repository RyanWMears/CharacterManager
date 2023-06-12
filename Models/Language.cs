using CharacterManager.Models.JoinModels.ClassJoins;
using CharacterManager.Models.JoinModels.RaceJoins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models
{
    [Table("Languages")]
    public class Language
    {
        [Key]
        public Guid LanguageId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Script { get; set; }
        public string TypicalSpeakers { get; set; }
        public string Source { get; set; }

        [AllowNull]
        [NotMapped]
        public List<Guid> RaceIds { get; set; }
        [AllowNull]
        public IList<RaceLanguage> RaceLanguages { get; set; }

        public Language()
        {
            LanguageId = new Guid();
            Name = string.Empty;
            Type = string.Empty;
            Script = string.Empty;
            TypicalSpeakers = string.Empty;
            Source = string.Empty;
        }
        public Language(Guid classId, string name, string type, string script, string typicalSpeakers, string source)
        {
            LanguageId = new Guid();
            Name = name;
            Type = type;
            Script = script;
            TypicalSpeakers = typicalSpeakers;
            Source = source;
        }
    }
}
