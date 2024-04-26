using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAT.Models.Entities
{
    /// <summary>
    /// Represents a pair of matching students for a given session for a given course.
    /// </summary>
    public class StudentPairMatch : BaseEntity
    {
        /// <summary>
        /// Gets or sets whether the Student pair match exists or not.
        /// </summary>
        public bool IsDeleted { get; set; } 

        /// <summary>
        /// Gets or sets the course of the pair.
        /// </summary>
        [Required] 
        public virtual Course Course { get; set; } = new Course();

        /// <summary>
        /// Gets or sets the tutor-tutee's session.
        /// </summary>
        [Required]
        public virtual Session Session { get; set; } = new Session();

        /// <summary>
        /// Gets or sets the Tutee.
        /// </summary>
        [Required]
        public virtual Student Tutee { get; set; } = new Student();

        /// <summary>
        /// Gets or sets the Tutor.
        /// </summary>
        public virtual Student Tutor { get; set; } = new Student();
    }
}