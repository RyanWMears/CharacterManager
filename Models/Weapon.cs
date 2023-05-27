namespace CharacterManager.Models
{
    public class Weapon : Item
    {
        private string Type { get; set; }
        private int Range { get; set; }
        private int MaxRange { get; set; }
        private int NumberOfDie { get; set; }
        private int DieSize { get; set; }
        private int Bonus { get; set; }
    }
}
