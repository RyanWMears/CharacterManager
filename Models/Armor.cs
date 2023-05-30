using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("Armor")]
    public class Armor : Item
    {
        [Required]
        public int AC { get; set; } = 10;
        public Armor() { 
            AC = 10;
        }
        public Armor(int ac)
        {
            AC = ac;
        }
    }
}
