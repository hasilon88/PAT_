using PAT.Models.Entities.Enums;

namespace PAT.Models.Entities
{
    /// <summary>
    /// Represents a session.
    /// </summary>
    public class Session : BaseEntity
    {
        /// <summary>
        /// Gets or sets the session's year.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the session's period.
        /// </summary>
        public SessionPeriodEnum SessionPeriod { get; set; }
    }
}