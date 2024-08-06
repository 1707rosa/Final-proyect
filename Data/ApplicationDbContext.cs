using Microsoft.EntityFrameworkCore;
using GoalTrackingApp.Models;

namespace GoalTrackingApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Goal> Goals { get; set; } = null!;
    }
}
