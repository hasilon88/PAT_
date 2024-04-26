using PAT.Models.Entities;

namespace PAT.Models.Repositories
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        private readonly PatDbContext _dataContext;
    
        public TeacherRepository(PatDbContext context) : base(context)
        {
            this._dataContext = context;
        }
    }
}