using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace CharacterManager.Models
{
    [Table("Spells")]
    public class Spell
    {
        [Key]
        public Guid SpellId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public string School { get; set; }
        public bool Concentration { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public string Duration { get; set; }
        public string Components { get; set; }
        [AllowNull]
        public int SaveDC { get; set; }
        [AllowNull]
        [StringLength(100)]
        public string SpellLists { get; set; }
        [AllowNull]
        [StringLength(100)]
        public string Materials { get; set; }
        [AllowNull]
        [StringLength(4000)]
        public string Upcast { get; set; }
        [StringLength(100)]
        public string Source { get; set; }

        public Spell()
        {

        }

        public Spell(string name, int level, string description, string school, bool concentration, string castingTime, string range, string duration, string components, int saveDC, string spellLists, string materials, string upcast, string source)
        {
            SpellId = new Guid();
            Name = name;
            Level = level;
            Description = description;
            School = school;
            Concentration = concentration;
            CastingTime = castingTime;
            Range = range;
            Duration = duration;
            Components = components;
            SaveDC = saveDC;
            SpellLists = spellLists;
            Materials = materials;
            Upcast = upcast;
            Source = source;
        }
    }
}
