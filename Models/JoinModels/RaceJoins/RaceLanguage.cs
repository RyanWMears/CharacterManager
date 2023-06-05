
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models.JoinModels.RaceJoins
{
    [Table("RaceLanguages")]
    public class RaceLanguage
    {
        [ForeignKey("Race")]
        public Guid RaceId { get; set; }
        [ForeignKey("Language")]
        public Guid LanguageId { get; set; }

        public Race Race { get; set; }
        public Language Language { get; set; }
        public RaceLanguage() { }
        public RaceLanguage(Guid raceId, Guid languageId)
        {
            RaceId = raceId;
            LanguageId = languageId;
        }
    }
}