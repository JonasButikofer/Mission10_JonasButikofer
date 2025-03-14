using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
     public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }

        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Team { get; set; } 

    }
}