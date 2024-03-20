using Microsoft.EntityFrameworkCore;
using PAT.Models.Entities;

namespace PAT.Models.Repositories;

public class Repository<T> : IRepository<T>
        where T : BaseEntity
    {

        private readonly PatDbContext context;
        private readonly DbSet<T> entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The module database context.</param>
        /// <param name="dateTimeProvider">The datetimeprovider for the repository.</param>
        public Repository(PatDbContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }

        /// <inheritdoc/>
        public async Task CreateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            this.entities.Add(entity);
            await this.context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task DeleteAsync(int id)
        {
            T entity = entities.Single(e => e.Id == id);
            if (entity == null)
            {
                return;
            }

            this.entities.Remove(entity);
            await this.context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public IQueryable<T> Get()
        {
            return this.entities;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.entities.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<T> GetByIdAsync(int id, CancellationToken token = default)
        {
            return await entities.SingleAsync(e => e.Id == id, token);
        }

        /// <inheritdoc/>
        public async Task UpdateAsync(T entity)
        {
            if (entity == null) 
            {
                throw new ArgumentNullException("entity");
            }

            await this.context.SaveChangesAsync();
        }
    }