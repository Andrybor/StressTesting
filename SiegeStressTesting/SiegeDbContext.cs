using Microsoft.EntityFrameworkCore;
using SiegeStressTesting.Controllers;

namespace SiegeStressTesting;

public class SiegeDbContext : DbContext
{
    public SiegeDbContext(DbContextOptions<SiegeDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<SaveModel> SaveModels { get; set; }
}