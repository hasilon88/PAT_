using PAT.Models.Entities;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Users.
/// </summary>
public class UserRepository : Repository<User>, IUserRepository
{

    private readonly PatDbContext _dataContext;

    /// <summary>
    /// The constructor for the repository.
    /// </summary>
    /// <param name="context">The data-context to use.</param>
    public UserRepository(
        PatDbContext context) 
        : base(context)
    {
        this._dataContext = context;
    }
}