using PAT.Models.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiSqlite.Entities
{
    /// <summary>
    /// Represents a Student.
    /// </summary>
    public class Student : User
    {
        /// <summary>
        /// Gets or sets the student's DA number.
        /// </summary>
        [Required]
        public string DANumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets Student's employee number. Sometimes, when a student is a tutor and they are paid, they get an employee number. 
        /// This field will be nullable and often be just an empty string as the only difference between a tutor and a tutee will be their role and an employee number. 
        /// Though this will be a little complicated as a student can have an employee number, be a tutor and a tutee at the same time.
        /// </summary>
        public string? EmployeeNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the student's R-Score.
        /// </summary>
        public double? RScore { get; set; }

        /// <summary>
        /// Gets or sets the students Global Average.
        /// </summary>
        public double GlobalAverage { get; set; }

        /// <summary>
        /// Gets or sets the students roles.
        /// </summary>
        public virtual IEnumerable<StudentType>? StudentRoleTypes { get; set; }

        /// <summary>
        /// Get or set the student's Tutor availabilities.
        /// </summary>
        [Required]
        public virtual IEnumerable<Availability> TutorAvailabilities { get; set; } = new List<Availability>();


        /// <summary>
        /// Get or set the student's tutee availabilities.
        /// </summary>
        [Required]
        public virtual IEnumerable<Availability> TuteeAvailabilities { get; set; } = new List<Availability>();
        
        /// <summary>
        /// Gets or set the student's program.
        /// </summary>
        public virtual Program Program { get; set; }
    }
}