using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<NetProjectsModel> NetProjects { get; set; }

        public DbSet<UnityProjectsModel> UnityProjects { get; set; }

        public DbSet<GraphicsModel> Graphics { get; set; }

        public DbSet<SkillModel> Skills { get; set; }

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

            modelBuilder.Entity<GraphicsModel>(entity =>
            {
                entity.ToTable("Graphics");
                entity.HasKey(p => p.ID).HasName("ID");

                entity.Property(p => p.ID).HasColumnName("ID").HasColumnType("int").ValueGeneratedNever();

                entity.Property(p => p.ImageURL).HasColumnName("ImageURL");

                entity.Property(p => p.GraphicType).HasColumnName("GraphicType");
            });

            modelBuilder.Entity<SkillModel>(entity =>
            {

                entity.ToTable("Skills");
                entity.HasKey(p => p.ID).HasName("ID");

                entity.Property(p => p.ID).HasColumnName("ID").HasColumnType("int").ValueGeneratedNever();

                entity.Property(p => p.ImageURL).HasColumnName("ImageURL");

                entity.Property(p => p.SkillName).HasColumnName("SkillName");

                entity.Property(p => p.SkillLevel).HasColumnName("SkillLevel");
            });

        }
    }
}
