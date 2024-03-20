using PAT.Models.Entities;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Messages.
/// </summary>
public interface IMessageRepository : IRepository<Message>
{
}