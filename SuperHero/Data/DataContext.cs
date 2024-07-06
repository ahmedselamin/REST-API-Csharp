namespace SuperHero.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Hero> Heroes { get; set; }
}
