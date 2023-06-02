﻿// <auto-generated />
using System;
using CharacterManager.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CharacterManager.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230602011732_13")]
    partial class _13
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharacterManager.Models.AbilityScores", b =>
                {
                    b.Property<Guid>("AbilityScoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ChaBonus")
                        .HasColumnType("int");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("ConBonus")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("DexBonus")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("IntBonus")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("StrBonus")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("WisBonus")
                        .HasColumnType("int");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.HasKey("AbilityScoresId");

                    b.ToTable("AbilityScores");
                });

            modelBuilder.Entity("CharacterManager.Models.Character", b =>
                {
                    b.Property<Guid>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CharacterId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("CharacterManager.Models.CharacterClass", b =>
                {
                    b.Property<Guid>("CharacterClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CharacterClassId");

                    b.ToTable("CharacterClass");
                });

            modelBuilder.Entity("CharacterManager.Models.Class", b =>
                {
                    b.Property<Guid>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClassLevel")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int>("HitDie")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("CharacterManager.Models.ClassFeat", b =>
                {
                    b.Property<Guid>("ClassFeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ClassFeatId");

                    b.ToTable("ClassFeats");
                });

            modelBuilder.Entity("CharacterManager.Models.ClassLanguage", b =>
                {
                    b.Property<Guid>("ClassLanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassLanguageId");

                    b.ToTable("ClassLanguage");
                });

            modelBuilder.Entity("CharacterManager.Models.ErrorViewModel", b =>
                {
                    b.Property<string>("ErrorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ErrorId");

                    b.ToTable("ErrorViewModels");
                });

            modelBuilder.Entity("CharacterManager.Models.Feat", b =>
                {
                    b.Property<Guid>("FeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prerequisite")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FeatId");

                    b.ToTable("Feats");
                });

            modelBuilder.Entity("CharacterManager.Models.Game", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CharacterManager.Models.Item", b =>
                {
                    b.Property<Guid>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attunement")
                        .HasColumnType("bit");

                    b.Property<bool>("Magic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("CharacterManager.Models.Language", b =>
                {
                    b.Property<Guid>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Script")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TypicalSpeakers")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CharacterManager.Models.Proficiency", b =>
                {
                    b.Property<Guid>("ProficiencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProficiencyId");

                    b.ToTable("Proficiencies");
                });

            modelBuilder.Entity("CharacterManager.Models.Race", b =>
                {
                    b.Property<Guid>("RaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ability")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Speed")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RaceId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("CharacterManager.Models.SavingThrows", b =>
                {
                    b.Property<Guid>("SavingThrowsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ChaSave")
                        .HasColumnType("bit");

                    b.Property<bool>("ConSave")
                        .HasColumnType("bit");

                    b.Property<bool>("DexSave")
                        .HasColumnType("bit");

                    b.Property<bool>("IntelSave")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProficiencyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("StrSave")
                        .HasColumnType("bit");

                    b.Property<bool>("WisSave")
                        .HasColumnType("bit");

                    b.HasKey("SavingThrowsId");

                    b.HasIndex("ProficiencyId")
                        .IsUnique();

                    b.ToTable("SavingThrows");
                });

            modelBuilder.Entity("CharacterManager.Models.Skills", b =>
                {
                    b.Property<Guid>("SkillsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Acrobatics")
                        .HasColumnType("bit");

                    b.Property<bool>("AnimalHandling")
                        .HasColumnType("bit");

                    b.Property<bool>("Arcana")
                        .HasColumnType("bit");

                    b.Property<bool>("Athletics")
                        .HasColumnType("bit");

                    b.Property<bool>("Deception")
                        .HasColumnType("bit");

                    b.Property<bool>("History")
                        .HasColumnType("bit");

                    b.Property<bool>("Insight")
                        .HasColumnType("bit");

                    b.Property<bool>("Intimidation")
                        .HasColumnType("bit");

                    b.Property<bool>("Investigation")
                        .HasColumnType("bit");

                    b.Property<bool>("Medicine")
                        .HasColumnType("bit");

                    b.Property<bool>("Nature")
                        .HasColumnType("bit");

                    b.Property<bool>("Perception")
                        .HasColumnType("bit");

                    b.Property<bool>("Performance")
                        .HasColumnType("bit");

                    b.Property<bool>("Persuasion")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProficiencyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Religion")
                        .HasColumnType("bit");

                    b.Property<bool>("SleightOfHand")
                        .HasColumnType("bit");

                    b.Property<bool>("Stealth")
                        .HasColumnType("bit");

                    b.Property<bool>("Survival")
                        .HasColumnType("bit");

                    b.HasKey("SkillsId");

                    b.HasIndex("ProficiencyId")
                        .IsUnique();

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CharacterManager.Models.Spell", b =>
                {
                    b.Property<Guid>("SpellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CastingTime")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Components")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Concentration")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Materials")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SaveDC")
                        .HasColumnType("int");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SpellLists")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Upcast")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("SpellId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("CharacterManager.Models.Armor", b =>
                {
                    b.HasBaseType("CharacterManager.Models.Item");

                    b.Property<int>("AC")
                        .HasColumnType("int");

                    b.ToTable("Armor");
                });

            modelBuilder.Entity("CharacterManager.Models.Weapon", b =>
                {
                    b.HasBaseType("CharacterManager.Models.Item");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<int>("DieSize")
                        .HasColumnType("int");

                    b.Property<string>("MaxRange")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumberOfDie")
                        .HasColumnType("int");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("CharacterManager.Models.SavingThrows", b =>
                {
                    b.HasOne("CharacterManager.Models.Proficiency", null)
                        .WithOne("SavingThrows")
                        .HasForeignKey("CharacterManager.Models.SavingThrows", "ProficiencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterManager.Models.Skills", b =>
                {
                    b.HasOne("CharacterManager.Models.Proficiency", null)
                        .WithOne("Skills")
                        .HasForeignKey("CharacterManager.Models.Skills", "ProficiencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterManager.Models.Armor", b =>
                {
                    b.HasOne("CharacterManager.Models.Item", null)
                        .WithOne()
                        .HasForeignKey("CharacterManager.Models.Armor", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterManager.Models.Weapon", b =>
                {
                    b.HasOne("CharacterManager.Models.Item", null)
                        .WithOne()
                        .HasForeignKey("CharacterManager.Models.Weapon", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterManager.Models.Proficiency", b =>
                {
                    b.Navigation("SavingThrows")
                        .IsRequired();

                    b.Navigation("Skills")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
