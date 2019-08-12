using Microsoft.EntityFrameworkCore;

namespace CinemaTracker.Models
{
    public class CinemaTrackerContext : DbContext
    {
        // public virtual DbSet<Category> Categories { get; set; }
        // public DbSet<Item> Items { get; set; }
        // public DbSet<CategoryItem> CategoryItem { get; set; }

        public CinemaTrackerContext(DbContextOptions options) : base(options) { }
    }
}