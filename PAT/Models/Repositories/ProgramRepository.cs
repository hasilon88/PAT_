using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to programs.
/// </summary>
public class ProgramRepository : Repository<Entities.Program>, IProgramRepository
{
    protected ProgramRepository(PatDbContext context) 
        : base(context)
    {
    }
}