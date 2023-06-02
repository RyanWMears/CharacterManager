using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;

namespace CharacterManager.Models
{
    [Table("Feats")]
    public class Feat
    {
        [Key]
        public Guid FeatId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(4000)]
        [AllowHtml]
        public string Description { get; set; }
        [AllowNull]
        [StringLength(100)]
        public string Prerequisite { get; set; }
        [StringLength(100)]
        public string Source { get; set; }

        public Feat() { }
        public Feat(string name, string description, string type, string prerequisite, string source)
        {
            FeatId = new Guid();
            Name = name;
            Description = description;
            Prerequisite = prerequisite;
            Source = source;
        }
    }

    [Table("ClassFeats")]
    public class ClassFeat
    {
        [Key]
        public Guid ClassFeatId { get; set; }
        [Required]
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(4000)]
        [AllowHtml]
        public string Description { get; set; }
        public int Level { get; set; }
        [StringLength(100)]
        public string Source { get; set; }

        public ClassFeat() { }
        public ClassFeat(string name, string description, int level, string source)
        {
            ClassFeatId = new Guid();
            Name = name;
            Description = description;
            Level = level;
            Source = source;
        }
    }
}
