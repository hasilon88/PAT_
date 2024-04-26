using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAT.Models.Entities
{
    /// <summary>
    /// Represents a single course.
    /// </summary>
    public class Course : BaseEntity
    {
        /// <summary>
        /// Gets or sets the course's Course code.
        /// </summary>
        [Required]
        public string CourseCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the course's credit amount.
        /// </summary>
        public double CourseCredits { get; set; }

        /// <summary>
        /// Gets or sets if the Course is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the course's name.
        /// </summary>
        [Required]
        public string CourseName { get; set; } = string.Empty;
    }
}