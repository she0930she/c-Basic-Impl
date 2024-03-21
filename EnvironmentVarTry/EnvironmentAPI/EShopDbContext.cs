using Microsoft.EntityFrameworkCore;

namespace EnvironmentAPI;

public class EShopDbContext:DbContext
{
    public EShopDbContext (DbContextOptions<EShopDbContext> options):base(options)
    {
    }
    
    public DbSet<Region> Regions { get; set; }
}