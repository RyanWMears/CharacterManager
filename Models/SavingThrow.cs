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
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [NotMapped]
        [AllowNull]
        public List<Guid> ClassIds { get; set; }
        [AllowNull]
        public IList<ClassSavingThrow> ClassSavingThrows { get; set; }

        public SavingThrow() {
            SavingThrowId = Guid.NewGuid();
            Name = "";
        }

        public SavingThrow(string name)
        {
            SavingThrowId = Guid.NewGuid();
            Name = "";
        }
    }
}
