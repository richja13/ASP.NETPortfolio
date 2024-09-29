using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<NetProjectsModel> NetProjects { get; set; }

        public DbSet<UnityProjectsModel> UnityProjects { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<NetProjectsModel>(entity =>
            {

                entity.ToTable("NetProjects");
                entity.HasKey(p => p.ProjectID).HasName("ProjectID");

                entity.Property(p => p.ProjectID).HasColumnName("ProjectID").HasColumnType("int").ValueGeneratedNever();

                entity.Property(p => p.ProjectName).HasColumnName("ProjectName");

                entity.Property(p => p.ProjectDescription).HasColumnName("ProjectDescription");

                entity.Property(p => p.ImageURL).HasColumnName("ImageURL");

            });

        }
    }
}
