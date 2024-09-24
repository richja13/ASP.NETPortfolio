using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UnityProjectsModel> UnityProjects { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
