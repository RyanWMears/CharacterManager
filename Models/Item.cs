using CharacterManager.Models.JoinModels.RaceJoins;
using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;

namespace CharacterManager.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public int Value { get; set; }
        public string Type { get; set; }
        public bool Magic { get; set; }
        public bool Attunement { get; set; }
        public string Rarity { get; set; }
        public string Source { get; set; }

        [NotMapped]
        [AllowNull]
        public virtual IList<AbilityScoreItem> AbilityScoreItems { get; set; }

        public Item() {
            ItemId = new Guid();
            Name = string.Empty;
            Description = string.Empty;
            Weight = 0.0;
            Value = 0;
            Type = string.Empty;
            Magic = false;
            Attunement = false;
            Rarity = string.Empty;
            Source = string.Empty;
        }

        public Item(string name, string description, double weight, int value, string type, bool magic, bool attunement, string rarity, string source)
        {
            ItemId = new Guid();
            Name = name;
            Description = description;
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
