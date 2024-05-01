using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Student Types.
/// </summary>
public class StudentTypeRepository : Repository<StudentType>, IStudentTypeRepository
{
    protected StudentTypeRepository(PatDbContext context) 
        : base(context) 
    {
    }
}