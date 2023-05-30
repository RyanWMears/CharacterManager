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
        public Skills Skills { get; set; }
        public SavingThrows SavingThrows { get; set; }

        public Proficiency() {
            ProficiencyId = Guid.Empty;
            SavingThrows = new SavingThrows();
            Skills = new Skills();
        }
        public Proficiency(SavingThrows savingThrows, Skills skills)
        {
            ProficiencyId = Guid.Empty;
            SavingThrows = savingThrows;
            Skills = skills;
        }        
    }
}
