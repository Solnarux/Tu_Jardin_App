using Microsoft.EntityFrameworkCore;
using System;
using Tu_Jardin_App.Shared;
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
            new Plant { Id = 1, Name = "Jesus", Type = "Salvia", Img = "/images/Aromáticas.png", Owner = "David Herrera", Email = "estebanlopezb2010@gmail.com", AchievementsId = 1, Seeddate = DateTime.Now },
            new Plant { Id = 2, Name = "Alberto", Type = "Cannabis Indica", Img = "/images/Cannabis.png", Owner = "David Herrera", Email = "estebanlopezb2010@gmail.com", AchievementsId = 2, Seeddate = DateTime.Now }
            );

            modelBuilder.Entity<User>().HasData(
            new User { Id = 1, UserName = "Dave Herrera", Email = "test@gmail.com", Img = "/images/logros/agricultor.png" , Plants = 2, Points = 230},
            new User { Id = 2, UserName = "Solnarux", Email = "test2@gmail.com", Img = "/images/logros/guardabosques.png", Plants = 3, Points = 150 }
            );
        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<Achieve> Achieves { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
