using System.ComponentModel.DataAnnotations;
namespace MauiSqlite.Entities
{
    public class Teacher : User
    {
        /// <summary>
        /// Gets or sets the teacher's employee number.
        /// </summary>
        [Required] 
        public string EmployeeNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the User's program.
        /// </summary>
        [Required] 
        public virtual Program Program { get; set; } = new Program();
    }
}