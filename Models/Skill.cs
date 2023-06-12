using CharacterManager.Models.JoinModels.ClassJoins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;


namespace CharacterManager.Models
{
    [Table("Skills")]
    public class Skill
    {
        [Key]
        public Guid SkillId { get; set; }
        public string Name { get; set; }

        [AllowNull]
        [NotMapped]
        public IList<ClassSkill> ClassSkills { get; set; }

        public Skill() {
            SkillId = Guid.NewGuid();
            Name = "";
        }
        public Skill(string name, List<Guid> classIds)
        {
            SkillId = Guid.NewGuid();
            Name = name;
        }

        //public bool Acrobatics { get; set; } = false;
        //public bool AnimalHandling { get; set; } = false;
        //public bool Arcana { get; set; } = false;
        //public bool Athletics { get; set; } = false;
        //public bool Deception { get; set; } = false;
        //public bool History { get; set; } = false;
        //public bool Insight { get; set; } = false;
        //public bool Intimidation { get; set; } = false;
        //public bool Investigation { get; set; } = false;
        //public bool Medicine { get; set; } = false;
        //public bool Nature { get; set; } = false;
        //public bool Perception { get; set; } = false;
        //public bool Performance { get; set; } = false;
        //public bool Persuasion { get; set; } = false;
        //public bool Religion { get; set; } = false;
        //public bool SleightOfHand { get; set; } = false;
        //public bool Stealth { get; set; } = false;
        //public bool Survival { get; set; } = false;

        //public Skills()
        //{
        //    SkillsId = new Guid();
        //    Acrobatics = false;
        //    AnimalHandling = false;
        //    Arcana = false;
        //    Athletics = false;
        //    Deception = false;
        //    History = false;
        //    Insight = false;
        //    Intimidation = false;
        //    Investigation = false;
        //    Medicine = false;
        //    Nature = false;
        //    Perception = false;
        //    Performance = false;
        //    Persuasion = false;
        //    Religion = false;
        //    SleightOfHand = false;
        //    Stealth = false;
        //    Survival = false;
        //}

        //public Skills(bool acrobatics, bool animalHandling, bool arcana, bool athletics, bool deception, bool history, bool insight, bool intimidation, bool investigation, bool medicine, bool nature, bool perception, bool performance, bool persuasion, bool religion, bool sleightOfHand, bool stealth, bool survival)
        //{
        //    SkillsId = new Guid();
        //    Acrobatics = acrobatics;
        //    AnimalHandling = animalHandling;
        //    Arcana = arcana;
        //    Athletics = athletics;
        //    Deception = deception;
        //    History = history;
        //    Insight = insight;
        //    Intimidation = intimidation;
        //    Investigation = investigation;
        //    Medicine = medicine;
        //    Nature = nature;
        //    Perception = perception;
        //    Performance = performance;
        //    Persuasion = persuasion;
        //    Religion = religion;
        //    SleightOfHand = sleightOfHand;
        //    Stealth = stealth;
        //    Survival = survival;
        //}        
    }
}
