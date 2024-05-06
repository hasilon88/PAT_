using MauiSqlite;
using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly AppDbContext _dataContext;
        public AdminRepository(AppDbContext context) 
            : base(context)
        {
            this._dataContext = context;
        }
    }
}