using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiSqlite.Entities
{
    /// <summary>
    /// Represents the association between a user and a participating course to display their current performance.
    /// </summary>
    public class StudentCoursePerformance : BaseEntity
    {

        /// <summary>
        /// Gets or sets whether the student completed the course with a passing grade.
        /// </summary>
        public bool IsCourseFinished { get; set; } 

        /// <summary>
        /// Gets or sets the Current grade for that student and that course.
        /// </summary>
        public double CurrentGrade { get; set; }

        /// <summary>
        /// Gets or sets the Student.
        /// </summary>
        [Required]
        public virtual Student Student { get; set; } = new Student();

        /// <summary>
        /// Gets or sets the Course.
        /// </summary>
        [Required]
        public virtual Course Course { get; set; } = new Course();
    }
}