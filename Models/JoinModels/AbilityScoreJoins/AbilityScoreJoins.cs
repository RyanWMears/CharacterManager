using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models.JoinModels.RaceJoins
{
    [Table("AbilityScoreCharacters", Schema="join")]
    public class AbilityScoreCharacter
    {
        [ForeignKey("AbilityScore")]
        public Guid AbilityScoreId { get; set; }
        [ForeignKey("Character")]
        public Guid CharacterId { get; set; }

        [AllowNull]
        public AbilityScore AbilityScore { get; set; }
        [AllowNull]
        public Character Character { get; set; }
        public AbilityScoreCharacter() { }
        public AbilityScoreCharacter(Guid abilityScoreId, Guid characterId)
        {
            AbilityScoreId = abilityScoreId;
            CharacterId = characterId;
        }
    }

    [Table("AbilityScoreClassFeats", Schema = "join")]
    public class AbilityScoreClassFeat
    {
        [ForeignKey("AbilityScore")]
        public Guid AbilityScoreId { get; set; }
        [ForeignKey("ClassFeat")]
        public Guid ClassFeatId { get; set; }

        [AllowNull]
        public AbilityScore AbilityScore { get; set; }
        [AllowNull]
        public ClassFeat ClassFeat { get; set; }
        public AbilityScoreClassFeat() { }
        public AbilityScoreClassFeat(Guid abilityScoreId, Guid classFeat)
        {
            AbilityScoreId = abilityScoreId;
            ClassFeatId = classFeat;
        }
    }

    [Table("AbilityScoreFeats", Schema = "join")]
    public class AbilityScoreFeat
    {
        [ForeignKey("AbilityScore")]
        public Guid AbilityScoreId { get; set; }
        [ForeignKey("Feat")]
        public Guid FeatId { get; set; }

        [AllowNull]
        public AbilityScore AbilityScore { get; set; }
        [AllowNull]
        public Feat Feat { get; set; }
        public AbilityScoreFeat() { }
        public AbilityScoreFeat(Guid abilityScoreId, Guid feat)
        {
            AbilityScoreId = abilityScoreId;
            FeatId = feat;
        }
    }

    [Table("AbilityScoreItems", Schema = "join")]
    public class AbilityScoreItem
    {
        [ForeignKey("AbilityScore")]
        public Guid AbilityScoreId { get; set; }
        [ForeignKey("Item")]
        public Guid ItemId { get; set; }

        [AllowNull]
        public AbilityScore AbilityScore { get; set; }
        [AllowNull]
        public Item Item { get; set; }
        public AbilityScoreItem() { }
        public AbilityScoreItem(Guid abilityScoreId, Guid item)
        {
            AbilityScoreId = abilityScoreId;
            ItemId = item;
        }
    }

    [Table("AbilityScoreRaces", Schema = "join")]
    public class AbilityScoreRace
    {
        [ForeignKey("AbilityScore")]
        public Guid AbilityScoreId { get; set; }
        [ForeignKey("Race")]
        public Guid RaceId { get; set; }

        [AllowNull]
        public AbilityScore AbilityScore { get; set; }
        [AllowNull]
        public Race Race { get; set; }
        public AbilityScoreRace() { }
        public AbilityScoreRace(Guid abilityScoreId, Guid raceId)
        {
            AbilityScoreId = abilityScoreId;
            RaceId = raceId;
        }
    }
}