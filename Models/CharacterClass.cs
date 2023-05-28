using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("CharacterClass")]
    public class CharacterClass
    {
        [Key]
        public Guid CharacterClassId { get; set; }
        [ForeignKey("Character")]
        public Guid CharacterId { get; set; }
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        public CharacterClass() { }
    }
}