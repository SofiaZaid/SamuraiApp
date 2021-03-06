﻿using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using System;


namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<SamuraiBattle> SamuraiBattles {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = SamuraiRelatedData; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(s => new { s.BattleId, s.SamuraiId });
            //modelBuilder.Entity<Samurai>().Property(s => s.SecretIdentity).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
