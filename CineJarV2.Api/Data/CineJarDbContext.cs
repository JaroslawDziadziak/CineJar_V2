using Microsoft.EntityFrameworkCore;
using CineJarV2.Api.Models; 

namespace CineJarV2.Api.Data
{
    public class CineJarDbContext : DbContext
    {
        public CineJarDbContext(DbContextOptions<CineJarDbContext> options) : base(options)
        {
            // The ": base(options)" passes the options to the parent DbContext class
        }

        //DbSets represents database tables
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configutation the relationship between User and Booking
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.User) //Each booking has one user
                .WithMany(u => u.Bookings) //Each user has many bookings
                .HasForeignKey(b => b.UserId); //Foreign key is UserId
        }
    }
}