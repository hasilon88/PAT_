using Microsoft.EntityFrameworkCore;
using PAT.Models.Entities;

namespace PAT.Models
{
    public class PatDbContext : DbContext
    {
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<PairTutoringArrangement> PairTutorings { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Availability> Availabilities { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<StudentPairMatch> StudentPairMatches { get; set; }
        public virtual DbSet<StudentCoursePerformance> StudentCoursePerformances { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string connectionDb = $"Filename={LocalDbService.GetPath("appData.db")}";
            System.IO.Directory.CreateDirectory("C:/PAT_DB");
            optionsBuilder.UseSqlite("Data Source=C:/PAT_DB/appData.db");
        }
    }
}
