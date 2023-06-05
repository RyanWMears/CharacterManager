
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models.JoinModels
{
    public class ClassProficiencyVO
    {
        [Key]
        public Guid ClassProficiencyId { get; set; }
        public List<Item> Armor { get; set; }
        public List<Item> Weapons { get; set; }
        public List<Item> Tools { get; set; }
        public List<SavingThrow> SavingThrows { get; set; }
        public List<Skill> Skills { get; set; }
        public ClassProficiencyVO() { }
    }
}