using PAT.Models.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace PAT.Models.Entities
{
    /// <summary>
    /// Represents a program.
    /// </summary>
    public class Program : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Program's Code.
        /// </summary>
        [Required] 
        public string ProgramCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Program's type.
        /// </summary>
        public ProgramTypeEnum ProgramType { get; set; }

        /// <summary>
        /// Gets or sets if the Program is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the Program's Courses.
        /// </summary>
        [Required]
        public virtual IEnumerable<Course> Courses { get; set; } = Enumerable.Empty<Course>();
    }
}