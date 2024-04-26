using PAT.Models.Entities;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Students.
/// </summary>
public class StudentRepository(PatDbContext context) : Repository<Student>(context), IStudentRepository
{
    private readonly PatDbContext _dataContext = context;
}
