
using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
             
        }

        public DbSet<Location> Locations { get; set; }
        
        
    }
}