using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models
{
    [Table("Weapons")]
    public class Weapon : Item
    {
        public string Range { get; set; }
        public string MaxRange { get; set; }
        public int NumberOfDie { get; set; }
        public int DieSize { get; set; }
        public int Bonus { get; set; }
        public Weapon() {
            Type = string.Empty;
            Range = string.Empty;
            MaxRange = string.Empty;
            NumberOfDie = 0;
            DieSize = 0;
            Bonus = 0;
        }
        public Weapon(string type, string range, string maxRange, int numberOfDie, int dieSize, int bonus)
        {
            Type = type;
            Range = range;
            MaxRange = maxRange;
            NumberOfDie = numberOfDie;
            DieSize = dieSize;
            Bonus = bonus;
        }
    }
}
