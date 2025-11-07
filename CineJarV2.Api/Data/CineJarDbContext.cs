using Microsoft.EntityFrameworkCore;

namespace CineJarV2.Api.Data
{
    public class CineJarDbContext : DbContext
    {
        public CineJarDbContext(DbContextOptions<CineJarDbContext> options) : base(options)
        {
            // The ": base(options)" passes the options to the parent DbContext class
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}