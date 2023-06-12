using CharacterManager.Models.JoinModels.ClassJoins;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models
{
    [Table("SavingThrows")]
    public class SavingThrow
    {
        [Key]
        public Guid SavingThrowId { get; set; }
        public string Name { get; set; }

        [AllowNull]
        [NotMapped]
        public IList<ClassSavingThrow> ClassSavingThrows { get; set; }

        public SavingThrow() {
            SavingThrowId = Guid.NewGuid();
            Name = "";
        }

        public SavingThrow(string name)
        {
            SavingThrowId = Guid.NewGuid();
            Name = name;
        }
    }
}
