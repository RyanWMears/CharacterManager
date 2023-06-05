using CharacterManager.Models.JoinModels.ClassJoins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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
        public int HitDie { get; set; } = 1;
        [Required]
        [StringLength(4000)]
        public string Description { get; set; }
        [Required]
        public int ClassLevel { get; set; } = 0;
        [StringLength(100)]
        public string Source { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Guid> ArmorIds { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Guid> WeaponsIds { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Guid> ToolsIds { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Guid> SavingThrowIds { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Guid> SkillIds { get; set; }
        [AllowNull]
        public IList<ClassSkill> ClassSkills { get; set; }
        [AllowNull]
        public IList<ClassSavingThrow> ClassSavingThrows { get; set; }

        public Class()
        {
            ClassId = Guid.NewGuid();
            Name = "";
            HitDie = 1;
            Description = "";
            ClassLevel = 0;
            Source = "";
            ArmorIds = new List<Guid>();
            WeaponsIds = new List<Guid>();
            ToolsIds = new List<Guid>();
            SavingThrowIds = new List<Guid>();
            SkillIds = new List<Guid>();
        }
        public Class(string name, int hitDie, string description, int classLevel, string source)
        {
            ClassId = new Guid();
            Name = name;
            HitDie = hitDie;
            Description = description;
            ClassLevel = classLevel;
            Source = source;
        }
        public Class(
            string name, int hitDie, string description, int classLevel, string source, 
            List<Guid> armor, List<Guid> weapons, List<Guid> tools, List<Guid> savingThrows, List<Guid> skillIds)
        {
            ClassId = new Guid();
            Name = name;
            HitDie = hitDie;
            Description = description;
            ClassLevel = classLevel;
            Source = source;
            ArmorIds = armor;
            WeaponsIds = weapons;
            ToolsIds = tools;
            SavingThrowIds = savingThrows;
            SkillIds = skillIds;
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
        [StringLength(100)]
        public string Source { get; set; }

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
