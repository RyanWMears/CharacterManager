namespace CharacterManager.Models
{
    public class AbilityScores
    {
        private Guid AbilityScoresId { get; set; }
        private Guid PlayerId { get; set; }
        private int Strength { get; set; }
        private int Dexterity { get; set; }
        private int Constitution { get; set; }
        private int Intelligence { get; set; }
        private int Wisdom { get; set; }
        private int Charisma { get; set; }

        private int StrBonus { get; set; }
        private int DexBonus { get; set; }
        private int ConBonus { get; set; }
        private int IntBonus { get; set; }
        private int WisBonus { get; set; }
        private int ChaBonus { get; set; }

        public AbilityScores() { }
        public AbilityScores(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Strength        = strength;
            Dexterity       = dexterity;
            Constitution    = constitution;
            Intelligence    = intelligence;
            Wisdom          = wisdom;
            Charisma        = charisma;

            StrBonus        = (Strength - 10) / 2;
            DexBonus        = (Dexterity - 10) / 2;
            ConBonus        = (Constitution - 10) / 2;
            IntBonus        = (Intelligence - 10) / 2;
            WisBonus        = (Wisdom - 10) / 2;
            ChaBonus        = (Charisma - 10) / 2;
        }
    }
}