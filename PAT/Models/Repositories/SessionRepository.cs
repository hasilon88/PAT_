using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Sessions.
/// </summary>
public class SessionRepository : Repository<Session>, ISessionRepository 
{
    protected SessionRepository(PatDbContext context) 
        : base(context)
    {
    }
}