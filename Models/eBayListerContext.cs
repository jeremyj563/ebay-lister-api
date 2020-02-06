using Microsoft.EntityFrameworkCore;

namespace eBayListerAPI.Models
{
    public class eBayListerContext : DbContext
    {
        public eBayListerContext(DbContextOptions<eBayListerContext> options)
            : base(options)
        {
        }

        public DbSet<Listing> Listings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Listing>().Property(l => l.Price).HasColumnType("smallmoney");
        }
    }
}