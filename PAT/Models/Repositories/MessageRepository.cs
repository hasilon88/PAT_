using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;
using PAT.Providers;

namespace PAT.Models.Repositories
{
    /// <summary>
    /// Provides data-access to Messages.
    /// </summary>
    public class MessageRepository : Repository<Message>, IMessageRepository
    {

        private readonly PatDbContext _dataContext;

        /// <summary>
        /// The constructor for the repository.
        /// </summary>
        /// <param name="context">The data-context to use.</param>
        public MessageRepository(
            PatDbContext context) 
            : base(context)
    {
        this._dataContext = context;
    }
    }
}