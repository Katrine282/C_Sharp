using Microsoft.EntityFrameworkCore;
using DataAccess.Model;

namespace DataAccess.Context;

internal class StuderendeContext : DbContext
{
    public StuderendeContext()
    {
       Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Studerende>().HasData(
            new Studerende
            {
                ID = 1, Navn = "Janne Sommer", Alder = 20,
                Studiestart = new DateTime(2024, 8, 15),
                Studietype = DTO.Studietype.Master
            });
        modelBuilder.Entity<Hold>().HasData(
            new Hold { HoldId = 1, Navn = "Geografi"},
            new Hold { HoldId = 2, Navn = "Dansk"}
            );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlServer("Data Source=LYNETMCQUEEN\\SQLEXPRESS;Initial Catalog=Studiebanken;User Id=sa;Password=1234; TrustServerCertificate=true");
    }
    
    public DbSet<Studerende> Studerendes { get; set; }
    public DbSet<Hold> Holdene { get; set; }
}