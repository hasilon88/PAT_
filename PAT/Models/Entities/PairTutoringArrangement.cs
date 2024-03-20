using System.ComponentModel.DataAnnotations;

namespace PAT.Models.Entities
{
    /// <summary>
    /// Represents a window when two students will meet.
    /// </summary>
    public class PairTutoringArrangement : BaseEntity
    {
        /// <summary>
        /// Gets or sets whether the arrangement is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the window for the meetups.
        /// </summary>
        [Required]
        public virtual Availability Availability { get; set; } = new Availability();

        /// <summary>
        /// Gets or sets the student pair.
        /// </summary>
        [Required]
        public StudentPairMatch StudentPairMatch { get; set; } = new StudentPairMatch();
    }
}
