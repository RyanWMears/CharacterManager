using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("Classes")]
    public class Class
    {
        [Key]
        public Guid ClassId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(4000)]
        public string Description { get; set; }
        [Required]
        public int ClassLevel { get; set; } = 0;
        [Required]
        public int HitDie { get; set; } = 1;

        public Class()
        {
            Name = "";
            ClassLevel = 0;
            HitDie = 1;
            Description = "";
        }
        public Class(string name, int classLevel, int hitDie, string description)
        {
            ClassId = new Guid();
            Name = name;
            ClassLevel = classLevel;
            HitDie = hitDie;
            Description = description;
        }
    }

    [Table("SubClasses")]
    public class SubClass
    {
        [Key]
        public Guid SubClassId { get; set; }
        [Required]
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public SubClass()
        {
            Name = "";
        }
        public SubClass(string name)
        {
            ClassId = new Guid();
            Name = name;
        }
    }
}
