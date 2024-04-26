using System.ComponentModel.DataAnnotations.Schema;

namespace PAT.Models.Entities
{
    /// <summary>
    /// An availability for a student.
    /// </summary>
    public class Availability : BaseEntity
    {
        /// <summary>
        /// Gets or sets whether the availability still exists.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets availability's day of the week.
        /// </summary>
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets availability's start.
        /// </summary>
        [Column(TypeName = "time")]
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets availability's end.
        /// </summary>
        [Column(TypeName = "time")]
        public TimeSpan EndTime { get; set; }
    }
}