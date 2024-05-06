using Microsoft.EntityFrameworkCore;
using PAT.Models.Entities;

namespace MauiSqlite;

public class AppDbContext : DbContext
{

    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite();
    
    public DbSet<Message> Messages { get; set; }
    public DbSet<PairTutoringArrangement> PairTutorings { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Availability> Availabilities { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Program> Programs { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<StudentPairMatch> StudentPairMatches { get; set; }
    public DbSet<StudentCoursePerformance> StudentCoursePerformances { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentType> StudentType { get; set; }
}