using MauiSqlite;
using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

public class StudentPairMatchRepository : Repository<StudentPairMatch>, IStudentPairMatchRepository
{
    private AppDbContext _context;
    
    protected StudentPairMatchRepository(AppDbContext context) 
        : base(context)
    {
        _context = context;
    }
}