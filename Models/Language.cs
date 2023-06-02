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
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        [AllowNull]
        public string Type { get; set; } = "None";
        [StringLength(100)]
        [AllowNull]
        public string Script { get; set; } = "None";
        [StringLength(100)]
        [AllowNull]
        public string TypicalSpeakers { get; set; } = "None";

        [StringLength(100)]
        public string Source { get; set; } = "None";
        public Language()
        {
            LanguageId = new Guid();
            Name = "None";
            Type = "None";
            Script = "None";
            TypicalSpeakers = "None";
            Source = "None";
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
