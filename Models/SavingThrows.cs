using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    public class SavingThrows
    {
        [Key]
        public Guid SavingThrowsId { get; set; }

        [ForeignKey("Proficiency")]
        public Guid ProficiencyId { get; set; }
        public bool StrSave { get; set; }
        public bool DexSave { get; set; }
        public bool ConSave { get; set; }
        public bool IntelSave { get; set; }
        public bool WisSave { get; set; }
        public bool ChaSave { get; set; }

        public SavingThrows() { }

        public SavingThrows(bool strSave, bool dexSave, bool conSave, bool intelSave, bool wisSave, bool chaSave)
        {
            SavingThrowsId = Guid.NewGuid();
            StrSave = strSave;
            DexSave = dexSave;
            ConSave = conSave;
            IntelSave = intelSave;
            WisSave = wisSave;
            ChaSave = chaSave;
        }
    }
}
