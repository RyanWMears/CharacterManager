using CharacterManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterManager.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("CharacterManagerDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<AbilityScores> AbilityScoresDbSet { get; set; }
        public DbSet<ErrorViewModel> ErrorViewModels { get; set; }
        public DbSet<Proficiency> Proficiencies { get; set; }
        public DbSet<SavingThrows> SavingThrowsDbSet { get; set; }
        public DbSet<Skills> SkillsSet { get; set; }
    }
}
