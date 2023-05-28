using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    public class Skills
    {
        [Key]
        public Guid SkillsId { get; set; }

        [ForeignKey("Proficiency")]
        public Guid ProficiencyId { get; set; }
        public bool Acrobatics { get; set; }
        public bool AnimalHandling { get; set; }
        public bool Arcana { get; set; }
        public bool Athletics { get; set; }
        public bool Deception { get; set; }
        public bool History { get; set; }
        public bool Insight { get; set; }
        public bool Intimidation { get; set; }
        public bool Investigation { get; set; }
        public bool Medicine { get; set; }
        public bool Nature { get; set; }
        public bool Perception { get; set; }
        public bool Performance { get; set; }
        public bool Persuasion { get; set; }
        public bool Religion { get; set; }
        public bool SleightOfHand { get; set; }
        public bool Stealth { get; set; }
        public bool Survival { get; set; }

        public Skills()
        {

        }

        public Skills(bool acrobatics, bool animalHandling, bool arcana, bool athletics, bool deception, bool history, bool insight, bool intimidation, bool investigation, bool medicine, bool nature, bool perception, bool performance, bool persuasion, bool religion, bool sleightOfHand, bool stealth, bool survival)
        {
            SkillsId = new Guid();
            Acrobatics = acrobatics;
            AnimalHandling = animalHandling;
            Arcana = arcana;
            Athletics = athletics;
            Deception = deception;
            History = history;
            Insight = insight;
            Intimidation = intimidation;
            Investigation = investigation;
            Medicine = medicine;
            Nature = nature;
            Perception = perception;
            Performance = performance;
            Persuasion = persuasion;
            Religion = religion;
            SleightOfHand = sleightOfHand;
            Stealth = stealth;
            Survival = survival;
        }        
    }
}
