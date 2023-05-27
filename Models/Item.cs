using Microsoft.AspNetCore.Http.Features;

namespace CharacterManager.Models
{
    public class Item
    {
        private Guid ItemId { get; set; }
        private string Name { get; set; }
        private double Weight { get; set; }
        private int Value { get; set; }
        private string Type { get; set; }
        private bool Magic { get; set; }
        private bool Attunement { get; set; }
        private string Rarity { get; set; }
        private string Source { get; set; }

        public Item() { }


    }
}
