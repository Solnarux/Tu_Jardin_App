using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tu_Jardin_App.Shared.Models;

namespace Tu_Jardin_App.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achieve>().HasData(
            new Achieve { Id = 1, Semillero = true, Agricultor = true },
            new Achieve { Id = 2, Riego = true, Cosecha = true }
            );

            modelBuilder.Entity<Plant>().HasData(
            new Plant { Id = 1, Name = "Jesus", Type = "Salvia", Img = "/images/Aromáticas.png", Owner = "David Herrera", AchievementsId = 1, Seeddate = DateTime.Now },
            new Plant { Id = 2, Name = "Alberto", Type = "Cannabis Indica", Img = "/images/Cannabis.png", Owner = "David Herrera", AchievementsId = 2, Seeddate = DateTime.Now }
            );
        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<Achieve> Achieves { get; set; }


    }
}
