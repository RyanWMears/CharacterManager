using CharacterManager.Models;
using CharacterManager.Models.JoinModels;
using CharacterManager.Models.JoinModels.ClassJoins;
using CharacterManager.Models.JoinModels.RaceJoins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

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

            modelBuilder.Entity<ClassSkill>().HasKey(cs => new { cs.ClassId, cs.SkillId });

            modelBuilder.Entity<ClassSkill>()
                .HasOne<Class>(cs => cs.Class)
                .WithMany(x => x.ClassSkills)
                .HasForeignKey(cs => cs.ClassId);

            modelBuilder.Entity<ClassSkill>()
                .HasOne<Skill>(cs => cs.Skill)
                .WithMany(x => x.ClassSkills)
                .HasForeignKey(cs => cs.SkillId);

            modelBuilder.Entity<ClassSavingThrow>().HasKey(cs => new { cs.ClassId, cs.SavingThrowId });

            modelBuilder.Entity<ClassSavingThrow>()
                .HasOne<Class>(cs => cs.Class)
                .WithMany(x => x.ClassSavingThrows)
                .HasForeignKey(cs => cs.ClassId);

            modelBuilder.Entity<ClassSavingThrow>()
                .HasOne<SavingThrow>(cs => cs.SavingThrow)
                .WithMany(x => x.ClassSavingThrows)
                .HasForeignKey(cs => cs.SavingThrowId);

            modelBuilder.Entity<RaceLanguage>().HasKey(cs => new { cs.RaceId, cs.LanguageId });

            modelBuilder.Entity<RaceLanguage>()
                .HasOne<Race>(cs => cs.Race)
                .WithMany(x => x.RaceLanguages)
                .HasForeignKey(cs => cs.RaceId);

            modelBuilder.Entity<RaceLanguage>()
                .HasOne<Language>(cs => cs.Language)
                .WithMany(x => x.RaceLanguages)
                .HasForeignKey(cs => cs.RaceId);
        }

        public DbSet<AbilityScores> AbilityScores { get; set; }
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
        public DbSet<Proficiency> Proficiencies { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceLanguage> RaceLanguages { get; set; }
        public DbSet<SavingThrow> SavingThrows { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
