namespace CharacterManager.Models
{
    public class Spells
    {
        public Guid SpellId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public string School { get; set; }
        public bool Concentration { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public string Duration { get; set; }
        public string Components { get; set; }
        public int SaveDC { get; set; }
        public string SpellLists { get; set; }
        public string Materials { get; set; }
        public string Upcast { get; set; }
        public string Source { get; set; }

        public Spells()
        {

        }

        public Spells(Guid spellId, string name, string level, string description, string school, bool concentration, string castingTime, string range, string duration, string components, int saveDC, string spellLists, string materials, string upcast, string source)
        {
            SpellId = spellId;
            Name = name;
            Level = level;
            Description = description;
            School = school;
            Concentration = concentration;
            CastingTime = castingTime;
            Range = range;
            Duration = duration;
            Components = components;
            SaveDC = saveDC;
            SpellLists = spellLists;
            Materials = materials;
            Upcast = upcast;
            Source = source;
        }
    }
}
