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
        public string Name { get; set; }
        public int HitDie { get; set; }
        public string Description { get; set; }
        public int ClassLevel { get; set; }
        public string Source { get; set; }



        //[NotMapped]
        //public virtual List<Guid> ArmorIds { get; set; }
        //[NotMapped]
        //public virtual List<Guid> WeaponsIds { get; set; }
        //[NotMapped]
        //public virtual List<Guid> ToolsIds { get; set; }



        [AllowNull]
        [NotMapped]
        public virtual IList<Guid> SavingThrowIds { get; set; }
        [AllowNull]
        [NotMapped]
        public virtual IList<Guid> SkillIds { get; set; }
        [AllowNull]
        [NotMapped]
        public virtual IList<ClassFeat> ClassFeats { get; set; }
        [AllowNull]
        [NotMapped]
        public virtual IList<ClassSavingThrow> ClassSavingThrows { get; set; }
        [AllowNull]
        [NotMapped]
        public virtual IList<ClassSkill> ClassSkills { get; set; }
        [AllowNull]
        [NotMapped]
        public virtual IList<SubClass> SubClasses { get; set; }

        public Class()
        {
            ClassId = Guid.NewGuid();
            Name = string.Empty;
            HitDie = 1;
            Description = string.Empty;
            ClassLevel = 0;
            Source = string.Empty;
            //ArmorIds = new List<Guid>();
            //WeaponsIds = new List<Guid>();
            //ToolsIds = new List<Guid>();
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
            //ArmorIds = armor;
            //WeaponsIds = weapons;
            //ToolsIds = tools;
            SavingThrowIds = savingThrows;
            SkillIds = skillIds;
        }
    }

    [Table("SubClasses")]
    public class SubClass
    {
        [Key]
        public Guid SubClassId { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }

        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        [AllowNull]
        public virtual Class Class { get; set; }

        public SubClass()
        {
            Name = string.Empty;
            Source = string.Empty;
        }
        public SubClass(string name, string source)
        {
            ClassId = new Guid();
            Name = name;
            Source = source;
        }
    }
}
