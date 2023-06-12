
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models.JoinModels.RaceJoins
{
    [Table("RaceLanguages", Schema = "join")]
    public class RaceLanguage
    {
        [ForeignKey("Race")]
        public Guid RaceId { get; set; }
        [ForeignKey("Language")]
        public Guid LanguageId { get; set; }

        [AllowNull]
        public Race Race { get; set; }
        [AllowNull]
        public Language Language { get; set; }
        public RaceLanguage() { }
        public RaceLanguage(Guid raceId, Guid languageId)
        {
            RaceId = raceId;
            LanguageId = languageId;
        }
    }
}