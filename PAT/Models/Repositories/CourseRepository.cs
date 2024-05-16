using MauiSqlite;
using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to courses.
/// </summary> 
public class CourseRepository : Repository<Course>, ICourseRepository
{
    private AppDbContext _context;
    
    protected CourseRepository(AppDbContext context) 
        : base(context)
    {
        _context = context;
    }
}