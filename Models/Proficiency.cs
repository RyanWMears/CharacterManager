using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    public class Proficiency
    {
        [Key]
        public Guid ProficiencyId { get; set; }

        [ForeignKey("Character")]
        public Guid CharacterId { get; set; }
        public Skill Skills { get; set; }
        public SavingThrow SavingThrows { get; set; }

        public Proficiency() {
            ProficiencyId = Guid.Empty;
            SavingThrows = new SavingThrow();
            Skills = new Skill();
        }
        public Proficiency(SavingThrow savingThrows, Skill skills)
        {
            ProficiencyId = Guid.Empty;
            SavingThrows = savingThrows;
            Skills = skills;
        }        
    }
}
