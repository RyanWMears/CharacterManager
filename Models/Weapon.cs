using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models
{
    public class Weapon : Item
    {
        [StringLength(100)]
        public string Type { get; set; }
        [AllowNull]
        [StringLength(100)]
        public string Range { get; set; }
        [AllowNull]
        [StringLength(100)]
        public string MaxRange { get; set; }
        public int NumberOfDie { get; set; } = 0;
        public int DieSize { get; set; } = 0;
        public int Bonus { get; set; } = 0;
        public Weapon() { }
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
