using CharacterManager.Models;
using CharacterManager.Models.JoinModels;
using CharacterManager.Models.JoinModels.ClassJoins;
using CharacterManager.Models.JoinModels.RaceJoins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace CharacterManager.DAL
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IWebHostEnvironment webHostEnvironment, IConfiguration configuration) : base(options)
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DRN913K;Initial Catalog=CharacterManager;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            #region AbilityScore
            modelBuilder.Entity<AbilityScore>().ToTable("AbilityScores");
            modelBuilder.Entity<AbilityScore>().Property(a => a.AbilityScoreId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<AbilityScore>().Property(a => a.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<AbilityScore>().Property(a => a.Value).HasDefaultValue(0).IsRequired(true);
            #endregion

            #region Armor
            modelBuilder.Entity<Armor>().ToTable("Armor");
            modelBuilder.Entity<Armor>().Property(a => a.AC).HasDefaultValue(10).IsRequired(true);
            #endregion

            #region Character
            modelBuilder.Entity<Character>().ToTable("Characters");
            modelBuilder.Entity<Character>().Property(c => c.CharacterId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Character>().Property(c => c.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Character>().Property(c => c.Level).HasDefaultValue(1).IsRequired(true);
            #endregion

            #region Class
            modelBuilder.Entity<Class>().ToTable("Classes");
            modelBuilder.Entity<Class>().Property(c => c.ClassId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Class>().Property(c => c.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Class>().Property(c => c.HitDie).HasDefaultValue(0).IsRequired(true);
            modelBuilder.Entity<Class>().Property(c => c.Description).HasMaxLength(4000).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Class>().Property(c => c.ClassLevel).HasDefaultValue(0).IsRequired(true);
            modelBuilder.Entity<Class>().Property(c => c.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);

            modelBuilder.Entity<SubClass>().ToTable("SubClasses");
            modelBuilder.Entity<SubClass>().Property(c => c.SubClassId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<SubClass>().Property(c => c.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<SubClass>().Property(c => c.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);

            modelBuilder.Entity<SubClass>()
            .HasOne<Class>(c => c.Class)
            .WithMany(s => s.SubClasses)
            .HasForeignKey(c => c.ClassId);

            modelBuilder.Entity<Class>()
            .HasMany<SubClass>(g => g.SubClasses)
            .WithOne(s => s.Class)
            .HasForeignKey(s => s.ClassId)
            .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Feat
            modelBuilder.Entity<Feat>().ToTable("Feats");
            modelBuilder.Entity<Feat>().Property(f => f.FeatId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Feat>().Property(f => f.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Feat>().Property(f => f.Description).HasMaxLength(4000).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Feat>().Property(f => f.Prerequisite).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Feat>().Property(f => f.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);

            modelBuilder.Entity<ClassFeat>().ToTable("ClassFeats");
            modelBuilder.Entity<ClassFeat>().Property(f => f.ClassFeatId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<ClassFeat>().Property(f => f.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<ClassFeat>().Property(f => f.Description).HasMaxLength(4000).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<ClassFeat>().Property(f => f.LevelRequirement).HasDefaultValue(1).IsRequired(true);
            modelBuilder.Entity<ClassFeat>().Property(f => f.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);

            
            modelBuilder.Entity<ClassFeat>()
            .HasOne<Class>(c => c.Class)
            .WithMany(s => s.ClassFeats)
            .HasForeignKey(c => c.ClassId);

            modelBuilder.Entity<Class>()
            .HasMany<ClassFeat>(g => g.ClassFeats)
            .WithOne(s => s.Class)
            .HasForeignKey(s => s.ClassId)
            .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region Game
            modelBuilder.Entity<Game>().ToTable("Games");
            modelBuilder.Entity<Game>().Property(g => g.GameId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Game>().Property(g => g.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);

            modelBuilder.Entity<Character>()
            .HasOne<Game>(c => c.Game)
            .WithMany(s => s.Characters)
            .HasForeignKey(c => c.GameId);

            modelBuilder.Entity<Game>()
            .HasMany<Character>(g => g.Characters)
            .WithOne(s => s.Game)
            .HasForeignKey(s => s.GameId)
            .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Item
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Item>().Property(i => i.ItemId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Description).HasMaxLength(4000).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Weight).HasDefaultValue(0.0).IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Value).HasDefaultValue(0).IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Type).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Magic).HasDefaultValue(false).IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Attunement).HasDefaultValue(false).IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Rarity).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Item>().Property(i => i.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            #endregion

            #region Language
            modelBuilder.Entity<Language>().ToTable("Languages");
            modelBuilder.Entity<Language>().Property(l => l.LanguageId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Language>().Property(l => l.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Language>().Property(l => l.Type).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Language>().Property(l => l.Script).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Language>().Property(l => l.TypicalSpeakers).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Language>().Property(l => l.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            #endregion

            #region Race
            modelBuilder.Entity<Race>().ToTable("Races");
            modelBuilder.Entity<Race>().Property(r => r.RaceId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Race>().Property(r => r.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Race>().Property(r => r.Size).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Race>().Property(r => r.Speed).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Race>().Property(r => r.Description).HasMaxLength(4000).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Race>().Property(r => r.Type).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Race>().Property(r => r.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            #endregion

            #region SavingThrow
            modelBuilder.Entity<SavingThrow>().ToTable("SavingThrows");
            modelBuilder.Entity<SavingThrow>().Property(s => s.SavingThrowId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<SavingThrow>().Property(s => s.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            #endregion

            #region Skill
            modelBuilder.Entity<Skill>().ToTable("Skills");
            modelBuilder.Entity<Skill>().Property(s => s.SkillId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Skill>().Property(s => s.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            #endregion

            #region Spell
            modelBuilder.Entity<Spell>().ToTable("Spells");
            modelBuilder.Entity<Spell>().Property(s => s.SpellId).HasDefaultValueSql("newid()").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Name).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Level).HasDefaultValue(0).IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Description).HasMaxLength(4000).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.School).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Concentration).HasDefaultValue(false).IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.CastingTime).HasMaxLength(100).HasDefaultValue("").IsRequired(true);            
            modelBuilder.Entity<Spell>().Property(s => s.Range).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Duration).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Components).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.SaveDC).HasDefaultValue(0).IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.SpellLists).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Materials).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Upcast).HasMaxLength(4000).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Spell>().Property(s => s.Source).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            #endregion

            #region Weapon
            modelBuilder.Entity<Weapon>().ToTable("Weapons");
            modelBuilder.Entity<Weapon>().Property(s => s.Range).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Weapon>().Property(s => s.MaxRange).HasMaxLength(100).HasDefaultValue("").IsRequired(true);
            modelBuilder.Entity<Weapon>().Property(s => s.NumberOfDie).HasDefaultValue(0).IsRequired(true);
            modelBuilder.Entity<Weapon>().Property(s => s.DieSize).HasDefaultValue(0).IsRequired(true);
            modelBuilder.Entity<Weapon>().Property(s => s.Bonus).HasDefaultValue(0).IsRequired(true);
            #endregion

            #region Template

            #endregion

            #region JoinTables
            #region AbilityScoreCharacter
            modelBuilder.Entity<AbilityScoreCharacter>().HasKey(a => new { a.AbilityScoreId, a.CharacterId });

            modelBuilder.Entity<AbilityScoreCharacter>()
                .HasOne<AbilityScore>(a => a.AbilityScore)
                .WithMany(x => x.ASC)
                .HasForeignKey(a => a.AbilityScoreId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AbilityScoreCharacter>()
                .HasOne<Character>(a => a.Character)
                .WithMany(x => x.ASC)
                .HasForeignKey(a => a.CharacterId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region AbilityScoreClassFeats
            modelBuilder.Entity<AbilityScoreClassFeat>().HasKey(a => new { a.AbilityScoreId, a.ClassFeatId });

            modelBuilder.Entity<AbilityScoreClassFeat>()
                .HasOne<AbilityScore>(a => a.AbilityScore)
                .WithMany(x => x.AbilityScoreClassFeats)
                .HasForeignKey(a => a.AbilityScoreId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AbilityScoreClassFeat>()
                .HasOne<ClassFeat>(a => a.ClassFeat)
                .WithMany(x => x.AbilityScoreClassFeats)
                .HasForeignKey(a => a.ClassFeatId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region AbilityScoreFeats
            modelBuilder.Entity<AbilityScoreFeat>().HasKey(a => new { a.AbilityScoreId, a.FeatId });

            modelBuilder.Entity<AbilityScoreFeat>()
                .HasOne<AbilityScore>(a => a.AbilityScore)
                .WithMany(x => x.AbilityScoreFeats)
                .HasForeignKey(a => a.AbilityScoreId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AbilityScoreFeat>()
                .HasOne<Feat>(a => a.Feat)
                .WithMany(x => x.AbilityScoreFeats)
                .HasForeignKey(a => a.FeatId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region AbilityScoreItems
            modelBuilder.Entity<AbilityScoreItem>().HasKey(a => new { a.AbilityScoreId, a.ItemId });

            modelBuilder.Entity<AbilityScoreItem>()
                .HasOne<AbilityScore>(a => a.AbilityScore)
                .WithMany(x => x.AbilityScoreItems)
                .HasForeignKey(a => a.AbilityScoreId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AbilityScoreItem>()
                .HasOne<Item>(a => a.Item)
                .WithMany(x => x.AbilityScoreItems)
                .HasForeignKey(a => a.ItemId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region AbilityScoreRaces
            modelBuilder.Entity<AbilityScoreRace>().HasKey(a => new { a.AbilityScoreId, a.RaceId });

            modelBuilder.Entity<AbilityScoreRace>()
                .HasOne<AbilityScore>(a => a.AbilityScore)
                .WithMany(x => x.AbilityScoreRaces)
                .HasForeignKey(a => a.AbilityScoreId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AbilityScoreRace>()
                .HasOne<Race>(a => a.Race)
                .WithMany(x => x.AbilityScoreRaces)
                .HasForeignKey(a => a.RaceId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region ClassSkill
            modelBuilder.Entity<ClassSkill>().HasKey(cs => new { cs.ClassId, cs.SkillId });

            modelBuilder.Entity<ClassSkill>()
                .HasOne<Class>(cs => cs.Class)
                .WithMany(x => x.ClassSkills)
                .HasForeignKey(cs => cs.ClassId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ClassSkill>()
                .HasOne<Skill>(cs => cs.Skill)
                .WithMany(x => x.ClassSkills)
                .HasForeignKey(cs => cs.SkillId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region ClassSavingThrow
            modelBuilder.Entity<ClassSavingThrow>().HasKey(cs => new { cs.ClassId, cs.SavingThrowId });

            modelBuilder.Entity<ClassSavingThrow>()
                .HasOne<Class>(cs => cs.Class)
                .WithMany(x => x.ClassSavingThrows)
                .HasForeignKey(cs => cs.ClassId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ClassSavingThrow>()
                .HasOne<SavingThrow>(cs => cs.SavingThrow)
                .WithMany(x => x.ClassSavingThrows)
                .HasForeignKey(cs => cs.SavingThrowId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region RaceLanguage
            modelBuilder.Entity<RaceLanguage>().HasKey(cs => new { cs.RaceId, cs.LanguageId });

            modelBuilder.Entity<RaceLanguage>()
                .HasOne<Race>(cs => cs.Race)
                .WithMany(x => x.RaceLanguages)
                .HasForeignKey(cs => cs.RaceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RaceLanguage>()
                .HasOne<Language>(cs => cs.Language)
                .WithMany(x => x.RaceLanguages)
                .HasForeignKey(cs => cs.LanguageId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
            #endregion
        }

        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<Armor> Armor { get; set; }
        public DbSet<Character> Characters { get; set; }        
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassFeat> ClassFeats { get; set; }
        public DbSet<ClassSavingThrow> ClassSavingThrows { get; set; }
        public DbSet<ClassSkill> ClassSkills { get; set; }
        public DbSet<ErrorViewModel> ErrorViewModels { get; set; }
        public DbSet<Feat> Feats { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceLanguage> RaceLanguages { get; set; }
        public DbSet<SavingThrow> SavingThrows { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
