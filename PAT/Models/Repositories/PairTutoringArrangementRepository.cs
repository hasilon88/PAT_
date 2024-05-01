using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Pair tutoring arrangements.
/// </summary>
public class PairTutoringArrangementRepository : Repository<PairTutoringArrangement>, IPairTutoringArrangementRepository
{
    protected PairTutoringArrangementRepository(PatDbContext context) 
        : base(context)
    {
    }
}