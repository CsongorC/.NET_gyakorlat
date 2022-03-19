using API_example.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API_example.Data
{
    public class AppDbContext : DbContext
    {  
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses_Authors>()
                .HasOne(c => c.Course)
                .WithMany(a => a.Course_Authors)
                .HasForeignKey(ci => ci.CourseId);

            modelBuilder.Entity<Courses_Authors>()
                .HasOne(c => c.Author)
                .WithMany(a => a.Course_Authors)
                .HasForeignKey(ci => ci.AuthorId);

            modelBuilder.Entity<Courses>()
                .HasOne(a => a.Algorithm)
                .WithMany(c => c.Courses);

            modelBuilder.Entity<LearningSteps>()
                .HasOne(c => c.Course)
                .WithMany(a => a.LearningSteps);
        }

        public DbSet<Algorithms> Algorithms { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Courses_Authors> Courses_Authors { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<LearningSteps> LearningSteps { get; set; }
    }
}
