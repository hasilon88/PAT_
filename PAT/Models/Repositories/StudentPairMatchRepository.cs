using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

public class StudentPairMatchRepository : Repository<StudentPairMatch>, IStudentPairMatchRepository
{
    protected StudentPairMatchRepository(PatDbContext context) 
        : base(context)
    {
    }
}