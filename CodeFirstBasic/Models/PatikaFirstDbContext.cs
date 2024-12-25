using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Models;

public class PatikaFirstDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=PatikaCodeFirstDb1");
    }

    public DbSet<Movie> Movies { get; set; }
    
    public DbSet<Game> Games { get; set; }
}