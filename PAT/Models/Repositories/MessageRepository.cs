using PAT.Models.Entities;
using PAT.Providers;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Messages.
/// </summary>
class MessageRepository : Repository<Message>, IMessageRepository
{

    private readonly PatDbContext dataContext;
    private readonly IDateTimeProvider dateTimeProvider;

    public MessageRepository(
        PatDbContext context, 
        IDateTimeProvider dateTimeProvider) 
        : base(context)
    {
        this.dataContext = context;
        this.dateTimeProvider = dateTimeProvider;
    }
}