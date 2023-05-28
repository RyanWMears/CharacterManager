using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;

namespace CharacterManager.Models
{
    public class Item
    {
        [Key]
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Value { get; set; }
        public string Type { get; set; }
        public bool Magic { get; set; }
        public bool Attunement { get; set; }
        public string Rarity { get; set; }
        public string Source { get; set; }

        public Item() { }

        public Item(string name, double weight, int value, string type, bool magic, bool attunement, string rarity, string source)
        {
            ItemId = new Guid();
            Name = name;
            Weight = weight;
            Value = value;
            Type = type;
            Magic = magic;
            Attunement = attunement;
            Rarity = rarity;
            Source = source;
        }
    }
}
