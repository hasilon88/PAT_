namespace PAT.Models.Entities
{
    /// <summary>
    /// Ensuire entities have some common properties.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the entity id.
        /// </summary>
        public long Id { get; set; }
    }
}
