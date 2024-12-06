using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;

public class StudentRepository : BaseRepository<Student, Guid>, IStudentRepository
{
    public StudentRepository(DatabaseContext context) : base(context) { }
}