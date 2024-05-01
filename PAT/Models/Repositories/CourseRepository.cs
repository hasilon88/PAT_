using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to courses.
/// </summary> 
public class CourseRepository : Repository<Course>, ICourseRepository
{
    protected CourseRepository(PatDbContext context) 
        : base(context)
    {
    }
}