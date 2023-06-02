
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("ClassLanguage")]
    public class ClassLanguage
    {
        [Key]
        public Guid ClassLanguageId { get; set; }
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        [ForeignKey("Language")]
        public Guid LanguageId { get; set; }
        public ClassLanguage() { }
        public ClassLanguage(Guid characterId, Guid classId, Guid languageId)
        {
            ClassLanguageId = new Guid();
            ClassId = classId;
            LanguageId = languageId;
        }
    }
}