using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FootballDB
{
    public class FootballContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FootballDB;Integrated Security=True;Encrypt=False")
                .LogTo(Console.WriteLine);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<User> Users { get; set; } 
        public DbSet<League> Leagues { get; set; }
        public DbSet <Team> Teams { get; set; }
        public DbSet <Player> Players { get; set; }
        public DbSet <Transfer> Transfers { get; set; }


    }
}
