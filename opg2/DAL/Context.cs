using Microsoft.EntityFrameworkCore;

namespace opg2.DAL;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlServer("Data Source=LYNETMCQUEEN\\SQLEXPRESS;Initial Catalog=Calculations;User Id=sa;Password=1234; TrustServerCertificate=true");
    }
    
    public DbSet<Calculation> calculations { get; set; }
}