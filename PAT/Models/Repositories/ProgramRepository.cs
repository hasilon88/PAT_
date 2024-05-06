using MauiSqlite;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to programs.
/// </summary>
public class ProgramRepository : Repository<Entities.Program>, IProgramRepository
{
    private AppDbContext _dbContext;
    protected ProgramRepository(AppDbContext context) 
        : base(context)
    {
        _dbContext = context;
    }
}