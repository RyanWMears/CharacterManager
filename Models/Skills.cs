using System;

namespace CharacterManager.Models
{
    public class Skills
    {
        private Guid SkillsId { get; set; }
        private Guid PlayerId { get; set; }
        private bool Acrobatics { get; set; }
        private bool AnimalHandling { get; set; }
        private bool Arcana { get; set; }
        private bool Athletics { get; set; }
        private bool Deception { get; set; }
        private bool History { get; set; }
        private bool Insight { get; set; }
        private bool Intimidation { get; set; }
        private bool Investigation { get; set; }
        private bool Medicine { get; set; }
        private bool Nature { get; set; }
        private bool Perception { get; set; }
        private bool Performance { get; set; }
        private bool Persuasion { get; set; }
        private bool Religion { get; set; }
        private bool SleightOfHand { get; set; }
        private bool Stealth { get; set; }
        private bool Survival { get; set; }

        public Skills()
        {

        }

        public Skills(bool acrobatics, bool animalHandling, bool arcana, bool athletics, bool deception, bool history, bool insight, bool intimidation, bool investigation, bool medicine, bool nature, bool perception, bool performance, bool persuasion, bool religion, bool sleightOfHand, bool stealth, bool survival)
        {
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
