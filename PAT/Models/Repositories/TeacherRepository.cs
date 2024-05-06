using MauiSqlite;
using PAT.Models.Entities;

namespace PAT.Models.Repositories
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        private readonly AppDbContext _dataContext;
    
        public TeacherRepository(AppDbContext context) : base(context)
        {
            this._dataContext = context;
        }
    }
}