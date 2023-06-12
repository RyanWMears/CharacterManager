using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("Armor")]
    public class Armor : Item
    {
        public int AC { get; set; }
        public string ArmorType { get; set; }
        public Armor() { 
            AC = 10;
            ArmorType = "";
        }
        public Armor(int ac, string armorType)
        {
            AC = ac;
            ArmorType = armorType;
        }
    }
}
