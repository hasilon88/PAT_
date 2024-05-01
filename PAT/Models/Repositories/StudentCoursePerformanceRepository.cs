using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;


/// <summary>
/// Provides data access to Student Course Performances.
/// </summary>
public class StudentCoursePerformanceRepository : Repository<StudentCoursePerformance>, IStudentCoursePerformanceRepository
{
    protected StudentCoursePerformanceRepository(PatDbContext context) 
        : base(context)
    {
    }
}