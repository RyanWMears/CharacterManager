namespace CharacterManager.Models
{
    public class Player
    {
        private Guid PlayerId { get; set; }
        private Guid GameId { get; set; }
        private string Name { get; set; }
        private int Level { get; set; }
        private int ProficiencyBonus { get; set; }
        private AbilityScores AbilityScores { get; set; }
        private Proficiency Proficiency { get; set; }
        public Player() { }
        public Player(string name, int level, AbilityScores abilityScores, Proficiency proficiency)
        {
            Name = name;
            Level = level;
            ProficiencyBonus = (int)Math.Ceiling(level * 0.25) + 1;
            AbilityScores = abilityScores;
            Proficiency = proficiency;
        }
    }
}