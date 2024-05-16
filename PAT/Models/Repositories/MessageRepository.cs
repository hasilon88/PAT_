using MauiSqlite;
using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories
{
    /// <summary>
    /// Provides data-access to Messages.
    /// </summary>
    public class MessageRepository : Repository<Message>, IMessageRepository
    {

        private readonly AppDbContext _dataContext;

        /// <summary>
        /// The constructor for the repository.
        /// </summary>
        /// <param name="context">The data-context to use.</param>
        public MessageRepository(AppDbContext context) 
            : base(context)
        {
            this._dataContext = context;
        }
    }
}