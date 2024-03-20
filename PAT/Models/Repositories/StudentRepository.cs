using PAT.Models.Entities;
using PAT.Providers;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Students.
/// </summary>
class StudentRepository : Repository<Student>, IStudentRepository
{

    private readonly PatDbContext dataContext;
    private readonly IDateTimeProvider dateTimeProvider;

    public StudentRepository(
        PatDbContext context, 
        IDateTimeProvider dateTimeProvider) 
        : base(context)
    {
        this.dataContext = context;
        this.dateTimeProvider = dateTimeProvider;
    }
}