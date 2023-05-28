﻿using CharacterManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CharacterManager.DAL
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationDBContext(IConfiguration configuration) {
            _configuration = configuration;
        }

        public ApplicationDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("CharacterManagerDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<AbilityScores> AbilityScores { get; set; }
        public DbSet<Armor> Armor { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ErrorViewModel> ErrorViewModels { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Proficiency> Proficiencies { get; set; }
        public DbSet<SavingThrows> SavingThrows { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
