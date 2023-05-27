using System;

namespace CharacterManager.Models
{
    public class Proficiency
    {
        private Guid ProficiencyId { get; set; }
        private Guid PlayerId { get; set; }
        private Skills Skills { get; set; }
        private SavingThrows SavingThrows { get; set; }

        public Proficiency() { }
        public Proficiency(SavingThrows savingThrows, Skills skills)
        {
            SavingThrows = savingThrows;
            Skills = skills;
        }        
    }
}
