using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Models;

namespace WeAreTheChampions.Context
{
    public class WACDbContext : DbContext
    {
        public WACDbContext() : base("name= WACDbContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<Match>()
               .HasRequired(c => c.Team1)
               .WithMany(c=>c.Team1Matches)
               .HasForeignKey(x => x.Team1Id)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                .HasRequired(c => c.Team2)
                .WithMany(c => c.Team2Matches)
                .HasForeignKey(x => x.Team2Id)
                .WillCascadeOnDelete(false);





            modelBuilder.Entity<Team>()
                .HasMany<Player>(p => p.Players)
                .WithOptional(p => p.Team)
                .HasForeignKey(p => p.TeamId)
                .WillCascadeOnDelete(false);
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
