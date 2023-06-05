using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models.JoinModels.ClassJoins
{
    [Table("ClassSavingThrows")]
    public class ClassSavingThrow
    {
        [ForeignKey("Class")]
        public Guid ClassId { get; set; }
        [ForeignKey("SavingThrow")]
        public Guid SavingThrowId { get; set; }
        public Class Class { get; set; }
        public SavingThrow SavingThrow { get; set; }
        public ClassSavingThrow() { }
        public ClassSavingThrow(Guid classId, Guid savingThrowId)
        {
            ClassId = classId;
            SavingThrowId = savingThrowId;
        }
    }
}