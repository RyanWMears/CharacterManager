using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("Armor")]
    public class Armor : Item
    {
        public string AC { get; set; }
        public Armor() { }
        public Armor(string ac)
        {
            AC = ac;
        }
    }
}
