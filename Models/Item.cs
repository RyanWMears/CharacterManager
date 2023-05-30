using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;

namespace CharacterManager.Models
{
    public class Item
    {
        [Key]
        public Guid ItemId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public double Weight { get; set; } = 0.0;
        public int Value { get; set; } = 0;
        [AllowNull]
        [StringLength(100)]
        public string Type { get; set; }
        public bool Magic { get; set; } = false;
        public bool Attunement { get; set; } = false;
        [AllowNull]
        [StringLength(100)]
        public string Rarity { get; set; }
        [AllowNull]
        [StringLength(100)]
        public string Source { get; set; }

        public Item() {
            ItemId = new Guid();
            Name = "";
            Weight = 0.0;
            Value = 0;
            Type = "";
            Magic = false;
            Attunement = false;
            Rarity = "";
            Source = "";
        }

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
