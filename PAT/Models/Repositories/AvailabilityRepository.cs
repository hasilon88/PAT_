using PAT.Models.Entities;

namespace PAT.Models.Repositories
{
    internal class AvailabilityRepository : Repository<Availability>, IAvailabilityRepository
    {
        protected AvailabilityRepository(PatDbContext context) : base(context)
        {
        }
    }
}
