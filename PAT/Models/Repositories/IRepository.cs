namespace PAT.Models.Repositories;

/// <summary>
/// Provides generic data access features for entities.
/// </summary>
/// <typeparam name="T">The entity type.</typeparam>
public interface IRepository<T>
    where T : Entities.BaseEntity
{
    /// <summary>
    /// Gets all entities.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>
    /// Gets entitties as an IQueryable to allow furter filtering/sorting, etc.
    /// </summary>
    /// <returns>An IQueryable of the items.</returns>
    IQueryable<T> Get();

    /// <summary>
    /// Gets a single entity by id.
    /// </summary>
    /// <param name="id">The id of the entity.</param>
    /// <param name="token">A token that can be used to cancel the request early.</param>
    /// <returns></returns>
    Task<T> GetByIdAsync(int id, CancellationToken token = default);

    /// <summary>
    /// Creates an entity and saves it to the database.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task CreateAsync(T entity);

    /// <summary>
    /// Updates an entity and saves it to the database.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task UpdateAsync(T entity);

    /// <summary>
    /// Deletes an entity in the database.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(int id);
}