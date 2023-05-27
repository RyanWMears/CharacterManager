namespace CharacterManager.Models
{
    public class SavingThrows
    {
        private Guid SavingThrowsId { get; set; }
        private Guid PlayerId { get; set; }
        private bool StrSave { get; set; }
        private bool DexSave { get; set; }
        private bool ConSave { get; set; }
        private bool IntelSave { get; set; }
        private bool WisSave { get; set; }
        private bool ChaSave { get; set; }

        public SavingThrows() { }

        public SavingThrows(bool strSave, bool dexSave, bool conSave, bool intelSave, bool wisSave, bool chaSave)
        {
            StrSave = strSave;
            DexSave = dexSave;
            ConSave = conSave;
            IntelSave = intelSave;
            WisSave = wisSave;
            ChaSave = chaSave;
        }
    }
}
