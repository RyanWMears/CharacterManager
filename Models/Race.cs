using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace CharacterManager.Models
{
    [Table("Races")]
    public class Race
    {
        [Key]
        public Guid RaceId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Ability { get; set; }
        [Required]
        [StringLength(100)]
        public string Size { get; set; }
        [Required]
        [StringLength(100)]
        public string Speed { get; set; }
        [Required]
        [StringLength(1000)]
        public string Language { get; set; }
        [AllowNull]
        [StringLength(4000)]
        [AllowHtml]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string Type { get; set; }
        [AllowNull]
        [StringLength(100)]
        public string Source { get; set; }

        public Race() { }
        public Race(string name, string ability, string size, string speed, string language, string description, string type, string source)
        {
            RaceId = new Guid();
            Name = name;
            Ability = ability;
            Size = size;
            Speed = speed;
            Language = language;
            Description = description;
            Type = type;
            Source = source;
        }
    }
}
