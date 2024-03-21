using Microsoft.EntityFrameworkCore;
using PAT.Models.Entities;

namespace PAT.Models.Repositories;

public class Repository<T> : IRepository<T>
        where T : BaseEntity
    {

        private readonly PatDbContext _context;
        private readonly DbSet<T> _entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The module database context.</param>
        protected Repository(PatDbContext context)
        {
            context.Database.EnsureCreated();
            this._context = context;
            this._entities = context.Set<T>();
        }

        /// <inheritdoc/>
        public async Task CreateAsync(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            this._entities.Add(entity);
            await this._context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task DeleteAsync(int id)
        {
            var entity = _entities.Single(e => e.Id == id);

            this._entities.Remove(entity);
            await this._context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public IQueryable<T> Get()
        {
            return this._entities;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this._entities.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<T> GetByIdAsync(int id, CancellationToken token = default)
        {
            return await _entities.SingleAsync(e => e.Id == id, token);
        }

        /// <inheritdoc/>
        public async Task UpdateAsync(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            await this._context.SaveChangesAsync();
        }
    }