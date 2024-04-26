using PAT.Models.Entities;

namespace PAT.Models.Repositories.Interfaces
{
    /// <summary>
    /// Provides data-access to Messages.
    /// </summary>
    public interface IMessageRepository : IRepository<Message>
    {
    }
}