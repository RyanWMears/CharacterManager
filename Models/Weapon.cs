namespace CharacterManager.Models
{
    public class Weapon : Item
    {
        public string Type { get; set; }
        public int Range { get; set; }
        public int MaxRange { get; set; }
        public int NumberOfDie { get; set; }
        public int DieSize { get; set; }
        public int Bonus { get; set; }
    }
}
