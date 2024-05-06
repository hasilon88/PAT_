using MauiSqlite;
using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories
{
    /// <summary>
    /// Provides data-access to Students.
    /// </summary>
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly AppDbContext _dataContext;
        public StudentRepository(AppDbContext context) : base(context)
        {
            this._dataContext = context;
        }
    }
}