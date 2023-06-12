using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models.JoinModels.ClassJoins
{
    [Table("ClassSkills", Schema = "join")]
    public class ClassSkill
    {
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        [ForeignKey("Skill")]
        public Guid SkillId { get; set; }
        public Class Class { get; set; }
        public Skill Skill { get; set; }
        public ClassSkill() { }
        public ClassSkill(Guid classId, Guid skillId)
        {
            ClassId = classId;
            SkillId = skillId;
        }
    }
}