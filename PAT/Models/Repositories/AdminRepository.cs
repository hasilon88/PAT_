using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly PatDbContext _dataContext;
        public AdminRepository(PatDbContext context) : base(context)
    {
        this._dataContext = context;
    }
    }
}