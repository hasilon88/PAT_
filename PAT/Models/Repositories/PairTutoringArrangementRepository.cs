using MauiSqlite;
using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Pair tutoring arrangements.
/// </summary>
public class PairTutoringArrangementRepository : Repository<PairTutoringArrangement>, IPairTutoringArrangementRepository
{
    private AppDbContext _dbContext;
    protected PairTutoringArrangementRepository(AppDbContext context) 
        : base(context)
    {
        _dbContext = context;
    }
}