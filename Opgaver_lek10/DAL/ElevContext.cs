using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Opgaver_lek10.Model;

namespace Opgaver_lek10.DAL;

public class ElevContext : DbContext
{
    public ElevContext()
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Klasse>().HasData(new Klasse[] {new Klasse 
            { KlasseId = 1, KlasseName = "1A"} 
        });
        modelBuilder.Entity<Elev>().HasData(new Elev[] {new Elev 
            {ElevID = 1, Navn = "Vilje", CPR = "140189-1234", 
                Adresse = "Solsikkevej 67", klasseId = 1}
        });
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlServer("Data Source=LYNETMCQUEEN\\SQLEXPRESS;Initial Catalog=Skolesystem;Integrated Security=SSPI; TrustServerCertificate=true");
    }
    
    public DbSet<Elev> Elever { get; set; }
    public DbSet<Klasse> Klasser { get; set; }
    
    public DbSet<Lærer> Lærer { get; set; }
}
