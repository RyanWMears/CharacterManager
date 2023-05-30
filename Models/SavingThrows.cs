using System;
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
        public bool StrSave { get; set; } = false;
        public bool DexSave { get; set; } = false;
        public bool ConSave { get; set; } = false;
        public bool IntelSave { get; set; } = false;
        public bool WisSave { get; set; } = false;
        public bool ChaSave { get; set; } = false;

        public SavingThrows() {
            SavingThrowsId = Guid.NewGuid();
            StrSave = false;
            DexSave = false;
            ConSave = false;
            IntelSave = false;
            WisSave = false;
            ChaSave = false;
        }

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
